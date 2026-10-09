# Unity C# Scripts

A collection of small Unity scripts in C#, written for Unity and C# lessons. They cover the basics of game programming: player movement and animation, collisions and triggers, spawning and destroying objects, scene changes, timers and simple UI.

The scripts are intentionally short and readable. Each one does a single job and can be dropped onto a GameObject.

## Contents

| Folder | Script | What it does |
|--------|--------|--------------|
| `Player/` | `Player.cs` | Tracks health and collected coins, and launches a fireball prefab on left click |
| | `ThirdPersonMovement.cs` | Rigidbody-based movement with walk and run speed, and turning in place with A/D |
| | `CharacterAnim.cs` | Switches the Animator's walk and run states from the W and left shift keys |
| `Gameplay/` | `Missile.cs` | Flies forward, destroys enemies tagged `Enemy`, and removes itself after a few seconds |
| | `NPC.cs` | Starts with health based on its level and walks along the z axis |
| | `Coin.cs` | Gives the player a coin when touched, then disappears |
| | `Teleport.cs` | Moves the player to a target point when entering a trigger |
| | `Trampoline.cs` | Increases the player's jump strength inside a trigger and restores it on exit |
| | `Timer.cs` | Counts down and shows `m:ss` in a TextMeshPro text, then reloads the scene |
| | `SceneChange.cs` | Loads a scene by name when the player enters a trigger |
| `UI/` | `StartButton.cs` | Loads the game scene from a button |
| | `ExitButton.cs` | Quits the game from a button (stops play mode in the editor) |
| | `TemperatureUI.cs` | Shows a temperature value with one decimal place |
| `Basics/` | `HelloWorld.cs` | First script: prints a message in `Start()` |
| | `Crickets.cs` | Demonstrates `Update()` by printing on every frame |
| | `DestroyOnStart.cs` | Destroys its own GameObject when the game starts |
| | `CreatePrimitives.cs` | Builds a blocky character out of cubes |

## How to use

1. Copy the scripts you want into your Unity project's `Assets` folder.
2. Drag a script onto a GameObject, or attach it with **Add Component**.
3. Fill in the public fields in the Inspector (prefabs, text objects, target points).
4. Create the tags the scripts use: `Player` and `Enemy`.
5. For triggers (`Coin`, `Teleport`, `Trampoline`, `SceneChange`, `Missile`) enable **Is Trigger** on the collider. At least one of the two objects needs a Rigidbody.
6. For `SceneChange` and `StartButton`, add the scenes to **File > Build Settings**.

## Notes

- `Timer.cs` and `TemperatureUI.cs` use TextMeshPro, which comes with the standard Unity UI packages.
- `ThirdPersonMovement.cs` uses `Rigidbody.velocity`. In Unity 6 this property is called `linearVelocity`.
- `Trampoline.cs` expects a `Jump` component with a public `jumpStrength` field, and `TemperatureUI.cs` expects a `PlayerTemperature` component with a public `currentTemperature` field. Those two components are not part of this repository, so these two scripts will not compile until you add them.

## Author

Theopoula Eirini Daskalou, Computer Science, Aristotle University of Thessaloniki
[LinkedIn](https://www.linkedin.com/in/thei-daskalou-3567a8358) | [GitHub](https://github.com/tdaska824)
