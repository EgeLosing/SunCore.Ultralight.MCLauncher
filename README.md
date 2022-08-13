<img src="https://sunrisenw.s3.amazonaws.com/Images/512x512.png" width=80px height=80px></img> 
# SunCore

SunCore is a library for Minecraft Launchers that uses CmlLib.Core and removes hard-code work. You can use a single method to Launch game.

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)


## Features

- No more hard-coding to Launch Minecraft.
- Offline Authentication
- Microsoft Authentication coming soon.
    
## Contributing

Contributions are always welcome!

See `Contributing.md` for ways to get started.

Please adhere to this project's `code of conduct`.


## Usage/Examples

Launching Minecraft:
```csharp
using SunCore.Ultralight.MCLauncher;

Launcher.Launch("1.18.2", "Player", 1024, new MinecraftPath(), false, "GameLauncherName", 1280, 720, "play.sunrisenw.com", 25565);

```

The code example above launches:

- Version 1.18.2
- With username "Player"
- With 1024 MB (1 GB) RAM
- On default Minecraft Path
- Windowed
- With resolution: 1280x720
- To connect server play.sunrisenw.com:25565.
