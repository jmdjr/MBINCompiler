﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcTextPreset : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x50)]
        public byte[] Unknown0;

        public float Height;
        public float Unk54;
        public float Unk58;
        public float Unk5C;
        public Colour Colour;
    }
}
