using System;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Net;
using System.Threading.Tasks;

namespace SunCore.Ultralight.MCLauncher
{
    public static class MCLauncher
    {
        private static void Load()
        {
            ServicePointManager.DefaultConnectionLimit = 12000;
        }

        public static async Task Launch(string version)
        {
            Load();
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 1024,

                ScreenWidth = 854,
                ScreenHeight = 480,
                Session = new OfflineAuthentication().Get("Player"),
                GameLauncherName = "Ultralight",
                FullScreen = false
            };
            var process = await launcher.CreateProcessAsync(version, launchOption, true);

            process.Start();
        }

        public static async Task Launch(string version, string user)
        {
            Load();
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

        public static async Task Launch(string version, MSession session)
        {
            Load();
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

        public static async Task Launch(string version, string user, int MemoryMB)
        {
            Load();
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

        public static async Task Launch(string version, MSession session, int MemoryMB)
        {
            Load();
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

        public static async Task Launch(string version, string user, int MemoryMB, MinecraftPath path)
        {
            Load();
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

        public static async Task Launch(string version, MSession session, int MemoryMB, MinecraftPath path)
        {
            Load();
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

        public static async Task Launch(string version, string user, int MemoryMB, MinecraftPath path, bool FullScreen)
        {
            Load();
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

        public static async Task Launch(string version, MSession session, int MemoryMB, MinecraftPath path, bool FullScreen)
        {
            Load();
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

        public static async Task Launch(string version, string user, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName)
        {
            Load();
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

        public static async Task Launch(string version, MSession session, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName)
        {
            Load();
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

        public static async Task Launch(string version, string user, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName, int ScreenWidth, int ScreenHeight)
        {
            Load();
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

        public static async Task Launch(string version, MSession session, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName, int ScreenWidth, int ScreenHeight)
        {
            Load();
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

        public static async Task Launch(string version, string user, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName, int ScreenWidth, int ScreenHeight, string ServerIp, int ServerPort)
        {
            Load();
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

        public static async Task Launch(string version, MSession session, int MemoryMB, MinecraftPath path, bool FullScreen, string GameLauncherName, int ScreenWidth, int ScreenHeight, string ServerIp, int ServerPort)
        {
            Load();
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