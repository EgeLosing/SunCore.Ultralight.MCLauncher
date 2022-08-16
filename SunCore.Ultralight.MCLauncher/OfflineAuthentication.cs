using System;
using CmlLib.Core.Auth;

namespace SunCore.Ultralight.MCLauncher
{
    public class OfflineAuthentication
    {
        public MSession Get(string Username)
        {
            return MSession.GetOfflineSession(Username);
        }
    }
}
