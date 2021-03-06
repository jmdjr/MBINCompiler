﻿using System.Runtime.InteropServices;

namespace MBINCompiler.Models
{
    public class MBINHeader : NMSTemplate
    {
        public int Magic;
        public int Unknown4;
        public int Unknown8;
        public int UnknownC;
        public long Unknown10;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string TemplateName;

        public long Unknown58;

        public string GetXMLTemplateName()
        {
            if (!TemplateName.StartsWith("c") || TemplateName.Length < 2)
                return TemplateName;

            return TemplateName.Substring(1); // remove the "c" (compiled?) from the start of the template name
        }
    }
}
