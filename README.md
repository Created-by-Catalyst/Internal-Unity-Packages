# Internal Unity Packages

This repository serves as a catalog for Unity packages developed in-house at Created by Catalyst. These packages have been created with the intention of being reusable across multiple projects, improving efficiency and maintainability of our codebase.

## Packages

Here you will find a brief description of each package currently in this repository:

1. **[CustomTweens](https://github.com/Created-by-Catalyst/Internal-Unity-Packages/tree/CustomTweens):** The CustomTweens package provides a framework of abstract classes for creating customizable, reusable tweening behaviors in Unity, using the powerful DOTween library.
2. **[InputReader](https://github.com/Created-by-Catalyst/Internal-Unity-Packages/tree/InputReader):** The InputReader package provides a set of scripts, including the InputReader and InputEvent, to handle input events in Unity using the Unity Input System, allowing for easy integration and event-driven input handling.
3. **[UnityEventsExtension](https://github.com/Created-by-Catalyst/Internal-Unity-Packages/tree/UnityEventsExtension):** Extends the functionality of Unity's event system with some utility scripts.

> Note: Each package has its own README file inside its directory where you can find more detailed information.
>
## Getting Started

To use any of these packages, download the package you need and import it into your Unity project. Each package comes with its own set of instructions included in its directory.

## Requirements

To use any of the Created by Catalyst packages, you will need to generate a GitHub Public Access Token (PAT) and add it to Unity.

> Note: The following steps assume you have already created a Personal Access Token (PAT) in GitHub. If you have not, [see this doc](./PAT/README.md) on how to create a PAT.

1. Once you have your PAT, copy it to your clipboard.

2. In Unity, open the Package Manager by navigating to `Window -> Package Manager`.

3. Click on the '+' button located at the top-left corner of the Package Manager window, and select `Add package from git URL...`.

4. In the pop-up text field, enter the HTTPS URL of your private GitHub repository, replacing the `https://` protocol with `https://PAT@`. Do not include any spaces. The final URL should look something like this: `https://PAT@github.com/YourUsername/YourRepo.git`.

> Warning: Be careful not to share your PAT or expose it in public places, as it grants access to your private repositories. Treat it like a password.

1. Hit `Enter` or click `Add`. Unity should now start importing your private package.

Remember to replace `PAT` in the URL with your actual PAT.

## Contributing

Contributions to improve or extend these packages are always welcome. If you're a member of Created by Catalyst team and you've developed a new package that you believe should be shared, please follow these steps:

1. Document your package. Ensure that it includes a README with instructions on how to install and use the package.
2. Add your package to the appropriate directory in this repository.
3. Update this main README to include a brief description of your package in the Packages list.

For bug fixes, improvements, or new features to existing packages, please create a new branch, make your changes, and submit a pull request.

## License

These packages are proprietary software, only for use within Created by Catalyst projects unless otherwise agreed.

---
