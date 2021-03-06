﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcHUDTextData : NMSTemplate
    {
        public GcHUDComponent Data;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Text;

        public GcTextPreset Preset;
    }
}
