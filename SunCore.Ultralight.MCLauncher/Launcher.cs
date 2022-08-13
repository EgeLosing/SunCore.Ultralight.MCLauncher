using System;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Net;

namespace SunCore.Ultralight.MCLauncher
{
    public class Launcher
    {
        public Launcher()
        {
            ServicePointManager.DefaultConnectionLimit = 12000;
        }

        OfflineAuthentication auth = new OfflineAuthentication("Player");

        public async void Launch(string version)
        {
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 1024,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = auth.session,
                GameLauncherName = "Ultralight",
                FullScreen = false
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, string user)
        {
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 1024,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = MSession.GetOfflineSession(user),
                GameLauncherName = "Ultralight",
                FullScreen = false
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, MSession session)
        {
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 1024,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = session,
                GameLauncherName = "Ultralight",
                FullScreen = false
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, string user, int MemoryMB)
        {
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = MSession.GetOfflineSession(user),
                GameLauncherName = "Ultralight",
                FullScreen = false
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, MSession session, int MemoryMB)
        {
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = session,
                GameLauncherName = "Ultralight",
                FullScreen = false
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, string user, int MemoryMB, MinecraftPath path)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = MSession.GetOfflineSession(user),
                GameLauncherName = "Ultralight",
                FullScreen = false
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, MSession session, int MemoryMB, MinecraftPath path)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = session,
                GameLauncherName = "Ultralight",
                FullScreen = false
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, string user, int MemoryMB, MinecraftPath path, bool FullScreen)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = MSession.GetOfflineSession(user),
                GameLauncherName = "Ultralight",
                FullScreen = FullScreen
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, MSession session, int MemoryMB, MinecraftPath path, bool FullScreen)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = session,
                GameLauncherName = "Ultralight",
                FullScreen = FullScreen
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, string user, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = MSession.GetOfflineSession(user),
                GameLauncherName = GameLauncherName,
                FullScreen = FullScreen
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, MSession session, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = session,
                GameLauncherName = GameLauncherName,
                FullScreen = FullScreen
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, string user, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName, int ScreenWidth, int ScreenHeight)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = ScreenWidth,
                ScreenHeight = ScreenHeight,
                Session = MSession.GetOfflineSession(user),
                GameLauncherName = GameLauncherName,
                FullScreen = FullScreen,
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, MSession session, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName, int ScreenWidth, int ScreenHeight)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,

                ScreenWidth = ScreenWidth,
                ScreenHeight = ScreenHeight,
                Session = session,
                GameLauncherName = GameLauncherName,
                FullScreen = FullScreen,
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, string user, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName, int ScreenWidth, int ScreenHeight, string ServerIp, int ServerPort)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,
                ScreenWidth = ScreenWidth,
                ScreenHeight = ScreenHeight,
                Session = MSession.GetOfflineSession(user),
                GameLauncherName = GameLauncherName,
                FullScreen = FullScreen,
                ServerIp = ServerIp,
                ServerPort = ServerPort
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public async void Launch(string version, MSession session, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName, int ScreenWidth, int ScreenHeight, string ServerIp, int ServerPort)
        {
            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = MemoryMB,
                ScreenWidth = ScreenWidth,
                ScreenHeight = ScreenHeight,
                Session = session,
                GameLauncherName = GameLauncherName,
                FullScreen = FullScreen,
                ServerIp = ServerIp,
                ServerPort = ServerPort
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }
    }
}