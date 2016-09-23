using System;
using System.Runtime.InteropServices;

namespace rah.lib.core
{
    public static class Utility
    {
        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        private static int GLockWindowUpdate = 0;

        public static void LockWindowUpdate()
        {
            if (GLockWindowUpdate == 0)
                LockWindowUpdate(WDMMain.GetInstance().MainFormHandle());
            GLockWindowUpdate++;
        }

        public static void UnLockWindowUpdate()
        {
            GLockWindowUpdate--;

            if (GLockWindowUpdate == 0)
                LockWindowUpdate(IntPtr.Zero);

            if (GLockWindowUpdate < 0)
                GLockWindowUpdate = 0;
        }
    }
}
