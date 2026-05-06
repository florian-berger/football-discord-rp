using DiscordRPC;
using DiscordRPC.Message;
using ModernWpf;
using ModernWpf.Controls;
using System.Windows;
using System.Windows.Media;
using ThemeManager = ModernWpf.ThemeManager;

namespace football_discord_rp.ViewModel
{
    /// <summary>
    ///     ViewModel for the main application window
    /// </summary>
    public class MainViewModel : BindableBase
    {
        #region Private variables

        private readonly Debouncer? _saveSettingsDebouncer;

        private DiscordRpcClient? _client;

        #endregion Private variables

        #region Properties

        /// <summary>
        ///     Gets or sets the league currently selected by the user.
        /// </summary>
        public League? SelectedLeague
        {
            get;
            set => SetProperty(ref field, value, ValueHasChanged);
        }

        /// <summary>
        ///     Gets or sets the club selected as the home team.
        /// </summary>
        public Club? SelectedHomeTeam
        {
            get;
            set => SetProperty(ref field, value, ValueHasChanged);
        } = null;

        /// <summary>
        ///     Gets or sets the club selected as the away team.
        /// </summary>
        public Club? SelectedAwayTeam
        {
            get;
            set => SetProperty(ref field, value, ValueHasChanged);
        } = null;

        /// <summary>
        ///     Gets or sets the custom detail associated with this instance.
        /// </summary>
        public string? CustomDetail
        {
            get;
            set => SetProperty(ref field, value, ValueHasChanged);
        }

        /// <summary>
        ///     Gets or sets the type of details that should be sent to Discord.
        /// </summary>
        public SelectedDetailType SelectedDetailType
        {
            get;
            set => SetProperty(ref field, value, ValueHasChanged);
        }

        /// <summary>
        ///     Represents the current state of the connection to Discord
        /// </summary>
        public bool IsConnected
        {
            get;
            set => SetProperty(ref field, value, ValueHasChanged);
        }

        /// <summary>
        ///     Information if a presence is set by the current application at Discord
        /// </summary>
        public bool HasPresence
        {
            get;
            set => SetProperty(ref field, value, ValueHasChanged);
        }

        /// <summary>
        ///     Connection state text displayed in the status bar
        /// </summary>
        public string ConnectionStateText
        {
            get;
            set => SetProperty(ref field, value);
        } = "Not connected";

        /// <summary>
        ///     Source of the Avatar of the connected user
        /// </summary>
        public ImageSource? ConnectedUserAvatarSource
        {
            get;
            set => SetProperty(ref field, value);
        } = null;

        /// <summary>
        ///     Information if the dark mode is active
        /// </summary>
        public bool IsDarkMode
        {
            get;
            set => SetProperty(ref field, value, OnThemeChanged);
        }

        public string? NewVersionDownloadLink
        {
            get;
            set => SetProperty(ref field, value);
        }

        #endregion Properties

        #region Constructor

        /// <summary>
        ///     Creates a new instance of the ViewModel and set the default options
        /// </summary>
        public MainViewModel()
        {
            SelectedLeague = !string.IsNullOrWhiteSpace(FootballDiscordRp.Settings.SelectedLeague)
                ? DataStore.Leagues.FirstOrDefault(l => l.Id.Equals(FootballDiscordRp.Settings.SelectedLeague))
                : DataStore.Leagues.FirstOrDefault();

            SelectedDetailType = FootballDiscordRp.Settings.DetailType;
            CustomDetail = FootballDiscordRp.Settings.CustomDetail;

            IsDarkMode = FootballDiscordRp.Settings.UseDarkMode;
            OnThemeChanged();

            _saveSettingsDebouncer = new Debouncer(TimeSpan.FromSeconds(1), SaveSettings);
        }

        #endregion Constructor

        #region Commands

        /// <summary>
        ///     Command executed when the page is loaded ("OnContentRendered" event)
        /// </summary>
        public DelegateCommand LoadedCommand => field ??= new DelegateCommand(Loaded);

        /// <summary>
        ///     Command to stop the client and exit the application
        /// </summary>
        public DelegateCommand ExitCommand => field ??= new DelegateCommand(Exit);

        /// <summary>
        ///     Command to set the presence based on the current settings
        /// </summary>
        public DelegateCommand SetPresenceCommand => field ??= new DelegateCommand(SetPresence, () => IsConnected && HasValidSettings());

        /// <summary>
        ///     Command to clear the presence
        /// </summary>
        public DelegateCommand ClearPresenceCommand => field ??= new DelegateCommand(ClearPresence, () => IsConnected && HasPresence);

        /// <summary>
        ///     Command to check for the availability of a new version
        /// </summary>
        public AsyncDelegateCommand CheckVersionUpdateCommand => field ??= new AsyncDelegateCommand(CheckForVersionUpdate);

        #endregion Commands

        #region Command methods

        private void Loaded()
        {
            if (_client != null)
            {
                return;
            }

            _ = CheckForVersionUpdate();

            _client = new DiscordRpcClient(FootballDiscordRp.DiscordApplicationId);
            _client.OnReady += DiscordClient_OnReady;
            _client.OnPresenceUpdate += DiscordClientClient_OnPresenceUpdate;

            _client.Initialize();

            CheckVersionUpdateCommand.Execute();
        }

        private void Exit()
        {
            Application.Current.Shutdown(0);
        }

        private void SetPresence()
        {
            _client?.SetPresence(GetRichPresenceForCurrentConfig());
        }

        private void ClearPresence()
        {
            _client?.ClearPresence();
        }

        private async Task CheckForVersionUpdate()
        {
            var currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (currentVersion == null)
            {
                return;
            }

            try
            {
                var newestVersion = await VersionHelper.CheckForUpdate(currentVersion);
                if (newestVersion != null)
                {
                    await Application.Current.Dispatcher.Invoke(async () =>
                    {
                        NewVersionDownloadLink = newestVersion.Value.ReleaseLink;
                        var versionString = newestVersion.Value.Version.ToShortString();

                        var dlg = new ContentDialog
                        {
                            Title = "Update available",
                            Content = $"A new version ({versionString}) is available. Do you want do download it now?",
                            PrimaryButtonText = "Yes",
                            SecondaryButtonText = "No",
                            DefaultButton = ContentDialogButton.Primary
                        };
                        var result = await dlg.ShowAsync();
                        if (result == ContentDialogResult.Primary)
                        {
                            StaticCommands.OpenUriCommand.Execute(NewVersionDownloadLink);
                        }
                    }).ConfigureAwait(false);
                }
            }
            catch (Exception)
            {
                // Version check failed - do nothing
            }
        }

        #endregion Command methods

        #region Private methods

        private void DiscordClient_OnReady(object sender, ReadyMessage args)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                var avatarUrl = args.User.GetAvatarURL(User.AvatarFormat.PNG);
                var avatarSrc = WebImageHelper.GetImageSourceFromPath(avatarUrl);

                ConnectionStateText = $"Connected (@{args.User.DisplayName})";
                ConnectedUserAvatarSource = avatarSrc;

                IsConnected = true;
            });
        }

        private void DiscordClientClient_OnPresenceUpdate(object sender, PresenceMessage args)
        {
            // Only react to PresenceUpdate events, when:
            //  - the updated was caused by our app, OR
            //  - the ApplicationID is empty (means the presence was cleared)
            if (args.Type != MessageType.PresenceUpdate || (args.ApplicationID != FootballDiscordRp.DiscordApplicationId && args.ApplicationID != string.Empty))
            {
                return;
            }

            HasPresence = args.Presence != null;
        }

        private RichPresence? GetRichPresenceForCurrentConfig()
        {
            // If no league is selected, we can't create a presence
            if (SelectedLeague == null)
            {
                return null;
            }

            // Create the RichPresence object based on the current settings
            var rp = new RichPresence
            {
                // TODO:
                // Custom name is already in Discord-RPC-CSharp available,
                // see https://github.com/Lachee/discord-rpc-csharp/pull/281
                // But the package is not yet published to NuGet. As soon as
                // it is, set the name to the league name, the StatusDisplay
                // to name and remove setting the state
                // Name = SelectedLeague.Name,
                Type = ActivityType.Watching,
                StatusDisplay = StatusDisplayType.State,
                State = SelectedLeague.Name
            };

            if (!string.IsNullOrWhiteSpace(SelectedLeague.ImageKey))
            {
                rp.WithAssets(new Assets
                {
                    LargeImageKey = SelectedLeague.ImageKey,
                    LargeImageText = SelectedLeague.Name
                });
            }

            switch (SelectedDetailType)
            {
                case SelectedDetailType.DetailTypeNone:
                    break;
                case SelectedDetailType.DetailTypeCustom:
                    rp.Details = CustomDetail ?? string.Empty;
                    break;
                case SelectedDetailType.DetailTypeConference:
                    rp.Details = "Conference";
                    break;
                case SelectedDetailType.DetailTypeMatchup:
                    rp.Details = $"{SelectedHomeTeam?.ShortName} vs. {SelectedAwayTeam?.ShortName}";
                    break;
            }

            rp.WithButtons(new Button
            {
                Label = "Also watching?",
                Url = FootballDiscordRp.RepositoryUrl
            });

            HasPresence = true;
            return rp;
        }

        private bool HasValidSettings()
        {
            if (SelectedLeague == null)
            {
                return false;
            }

            if (SelectedDetailType == SelectedDetailType.DetailTypeCustom && string.IsNullOrWhiteSpace(CustomDetail))
            {
                return false;
            }

            if (SelectedDetailType == SelectedDetailType.DetailTypeMatchup && (SelectedHomeTeam == null || SelectedAwayTeam == null))
            {
                return false;
            }

            return true;
        }

        private void ValueHasChanged()
        {
            SetPresenceCommand.RaiseCanExecuteChanged();
            ClearPresenceCommand.RaiseCanExecuteChanged();

            // Invoke the debouncer to save the new settings after the defined interval
            _saveSettingsDebouncer?.Invoke();
        }

        private void OnThemeChanged()
        {
            var theme = IsDarkMode ? ApplicationTheme.Dark : ApplicationTheme.Light;
            ThemeManager.Current.ApplicationTheme = theme;

            ValueHasChanged();
        }

        private void SaveSettings()
        {
            FootballDiscordRp.Settings.SelectedLeague = SelectedLeague?.Id;
            FootballDiscordRp.Settings.DetailType = SelectedDetailType;
            FootballDiscordRp.Settings.CustomDetail = CustomDetail;
            FootballDiscordRp.Settings.UseDarkMode = IsDarkMode;
            FootballDiscordRp.Settings.Save();
        }

        #endregion Private methods
    }
}
