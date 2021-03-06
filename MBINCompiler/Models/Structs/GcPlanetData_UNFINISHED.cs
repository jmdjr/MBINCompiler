﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcPlanetData_UNFINISHED : NMSTemplate
    {
        private string Name; // 0x80
        private int LifeSetting; // Dead / Low / Mid / Full

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x78)]
        public byte[] Hazard; // todo: GcPlanetHazardData
        
        public int ResourceLevel; // Low / High
        public int BuildingDensity; // todo: GcBuildingDensityLevels
    }
}
