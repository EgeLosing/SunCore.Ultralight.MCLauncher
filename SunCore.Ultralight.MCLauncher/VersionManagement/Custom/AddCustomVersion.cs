using CmlLib.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace SunCore.Ultralight.MCLauncher.VersionManagement.Custom
{
    public static class AddCustomVersion
    {
        public enum Method
        {
            Copy,
            Move
        }

        public static bool Add(string VersionJarAndJSONDirectory, Method method, string MCVersionsDirectory)
        {
            if (!Directory.Exists(VersionJarAndJSONDirectory))
                throw new VersionNotFoundException("Version not found.");
            if (!Directory.Exists(MCVersionsDirectory))
                MCVersionsDirectory = MinecraftPath.GetOSDefaultPath();
            if (!Directory.Exists(MCVersionsDirectory))
                throw new MinecraftDirectoryNotFoundException("Minecraft Directory not found.");

            switch (method)
            {
                case Method.Copy:
                    foreach (var file in Directory.GetFiles(VersionJarAndJSONDirectory))
                    {
                        File.Copy(file, Path.Combine(MCVersionsDirectory, Path.GetFileName(file)), true);
                    }
                    break;
                case Method.Move:
                    foreach (var file in Directory.GetFiles(VersionJarAndJSONDirectory))
                    {
                        File.Move(file, Path.Combine(MCVersionsDirectory, Path.GetFileName(file)));
                    }
                    break;
            }

            return true;
        }
    }

    public class MinecraftDirectoryNotFoundException : Exception
    {
        public MinecraftDirectoryNotFoundException()
        {

        }

        public MinecraftDirectoryNotFoundException(string message) : base(message)
        {

        }
    }

    public class VersionNotFoundException : Exception
    {
        public VersionNotFoundException()
        {

        }

        public VersionNotFoundException(string message) : base(message)
        {

        }
    }
}
