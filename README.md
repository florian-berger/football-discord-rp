# football-discord-rp
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](LICENSE)
[![Issues](https://img.shields.io/github/issues/florian-berger/football-discord-rp?logo=github&style=for-the-badge)](https://github.com/florian-berger/football-discord-rp/issues)
[![Discord](https://img.shields.io/discord/302523634075828226?label=Discord&logo=discord&style=for-the-badge)](https://ultgmng.de/discord)

This tools allows you to show your friends in Discord, which football (or in American English: soccer) match you are watching. It uses [Discord RPC C#](https://github.com/Lachee/discord-rpc-csharp) for setting the Rich Presence.

## Contribution
To contribute to the development of this project, take a look at the [Contribution guidelines for this project](CONTRIBUTING.md).

## Download and installation
![GitHub Release](https://img.shields.io/github/v/release/florian-berger/football-discord-rp?style=for-the-badge&logo=github&label=Latest%20Release)

All versions are published via GitHub Releases. Just download the MSI installer and execute it.

## Usage
When starting the program, it automatically tries to connect to your Discord client. If the connection succeeded, it is displayed in the status bar, together with the avatar and the username of your Discord account. A rich presence is **not** set automatically.

You just have to select a football league define the details you want to show to your friends. Clicking the "Set presence" button sends the information to Discord. As soon as you hit the "Clear presence" button or end the program, the presence is cleared again.