# GEMINI.md - Project Overview

This is a Unity project, likely intended to be a Tic-Tac-Toe game based on the root directory name. It utilizes the Unity game engine and C# for scripting.

## Project Structure and Technologies

*   **Engine:** Unity (version 6000.0.60f1, inferred from `ProjectSettings/ProjectVersion.txt`)
*   **Scripting Language:** C# (as seen in `Assets/Scripts/HelloWorld.cs`)
*   **Key Files/Directories:**
    *   `Assets/`: Contains all game assets, scenes, and scripts.
    *   `Packages/manifest.json`: Lists project dependencies and Unity packages.
    *   `ProjectSettings/`: Contains various Unity project configuration files.
    *   `README.md`: Basic project title.

## Building and Running

This project is built and run using the Unity Editor.

1.  **Open in Unity Editor:** Launch the Unity Editor and open this project directory. The editor version `6000.0.60f1` (or a compatible newer version) is recommended.
2.  **Scene Navigation:** Navigate to `Assets/Scenes/SampleScene.unity` to view the primary scene.
3.  **Run:** Use the Unity Editor's play mode to run the game.
4.  **Build:** To create a standalone application, use `File > Build Settings...` in the Unity Editor and follow the instructions for your target platform.

## Development Conventions

*   **Scripting:** All game logic and component behaviors are implemented in C# scripts, typically located in the `Assets/Scripts/` directory.
*   **Asset Management:** Assets (models, textures, audio, etc.) should be organized within the `Assets/` directory following standard Unity practices.
*   **Input System:** The project appears to use Unity's new Input System, indicated by `Assets/InputSystem_Actions.inputactions`.
