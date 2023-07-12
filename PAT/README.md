# Personal Access Tokens (PATs) in GitHub

A Personal Access Token (PAT) is required to access a private repository because it provides a secure way of validating your identity without needing to input your username and password directly. This is especially important when you're interacting with GitHub via third-party tools or services like Unity.

When you generate a PAT, GitHub uses it to authenticate your requests and determine your access level. This means you can interact with your repositories (like pulling Unity packages from your private repository) securely.

## How to Generate a PAT

1. Sign into your GitHub account.
2. Click on your profile photo in the upper right-hand corner and select `Settings`.
3. On the left sidebar, click on `Developer settings`.
4. Click on `Personal access tokens` which will take you to the token page.
5. Click on `Generate new token`.
6. You will be asked to provide a note (name) for the token, select the scopes (permissions) you want this token to have, and optionally set it to expire at a certain date.
   - If this token is to pull packages from a repository, you'll at least need the `repo` scope.
7. After that, click on `Generate token` at the bottom of the page.
8. You will be redirected to a page showing the token. Copy it and save it somewhere safe (you won't be able to see it again).

Remember, your Personal Access Token is similar to a password. Treat it as sensitive information and do not expose it publicly.
