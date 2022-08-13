using System;
using CmlLib.Core.Auth;

namespace SunCore.Ultralight.MCLauncher
{
    public class OfflineAuthentication
    {
        public OfflineAuthentication(string Username)
        {
            Set(Username);
        }

        public MSession session;

        private void Set(String username)
        {
            session = MSession.GetOfflineSession(username);
        }
    }
}