# Google Sign-In WinForms App

This is a simple Windows Forms application built in C# that demonstrates how to integrate **Google OAuth 2.0 Sign-In** in a desktop environment. Once the user signs in with their Google account, the app fetches and displays:

- ✅ Full Name
- ✅ Google Account ID
- ✅ Profile Picture

This app uses the official Google APIs Client Library for .NET.

## Prerequisites

- Visual Studio 2019 or later
- .NET Framework (version your project targets)
- A Google Cloud project with OAuth 2.0 credentials
- Enabled "People API" in Google Cloud Console

## Setup

1. Go to [Google Cloud Console](https://console.cloud.google.com/)
2. Create a new project or select an existing one
3. Enable the **People API**
4. Configure the OAuth consent screen (you can keep it internal for testing)
5. Create OAuth 2.0 Client ID credentials (choose Desktop app)
6. Download the `client_secret.json` file
7. Place `client_secret.json` in your project directory (do **not** commit this file)

## Usage

1. Open the solution (`.sln`) file in Visual Studio
2. Build and run the application
3. Sign in with your Google account when prompted
4. Your account name, ID, and profile picture will be displayed in the app window

## Security Notice

The `client_secret.json` file contains sensitive credentials. **Do not commit this file to public repositories**.

Add it to `.gitignore` to keep it private.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
