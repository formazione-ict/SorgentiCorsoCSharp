using System;
namespace Corso_10.Enums
{
    #region enum

    public enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

    public enum Days2 { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };

    //byte, sbyte, short, ushort, int, uint, long o ulong.
    public enum Days3 : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };

    [Flags]
    public enum CarOptions
    {
        // The flag for SunRoof is 00000001.
        SunRoof = 0x01,
        // The flag for Spoiler is 00000010.
        Spoiler = 0x02,
        // The flag for FogLights is 00000100.
        FogLights = 0x04,
        // The flag for TintedWindows is 00001000.
        TintedWindows = 0x08,
    }

    #endregion
}
