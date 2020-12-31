using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EnumerationReflection
{
    public static class Callsigns
    {
        public const string BAW = "Speedbird";
        public const string DLH = "Lutfhansa";
        public const string KLM = "KLM";
        public const string VIR = "Virgin";
        public const string VIK = "SwedJet";
        public const string EZY = "Easy";
        public const string EZS = "TopSwiss";
        public const string EJU = "Alpine";
        public const string QFA = "Quantas";
        public const string ACA = "AirCanada";

        private static List<string> _items;

        public static IEnumerable<string> All
        {
            get
            {
                if (_items == null)
                {
                    Type t = typeof(Callsigns);

                    _items = t.GetFields(BindingFlags.Public | BindingFlags.Static)
                              .Select(f => f.GetValue(null) as string)
                              .OrderBy(s => s)
                              .ToList();
                }

                return _items;
            }
        }
    }
}
