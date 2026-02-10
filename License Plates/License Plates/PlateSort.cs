using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace License_Plates
{
    /// <remarks>
    /// Author: Catherine Gizzi
    /// Date Created: January 14th 2026
    /// Bugs: None known at this time.
    /// </remarks>
    /// <summary>
    /// This class is to take 2 vehicles and compare/sort them by license plate characters alphanumerically, numbers first then letters. 
    /// </summary>
    internal class PlateComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            string a = x.Plate;
            string b = y.Plate;

            int len = Math.Min(a.Length, b.Length);

            for (int i = 0; i < len; i++)
            {
                char ca = a[i];
                char cb = b[i];

                bool aDigit = char.IsDigit(ca);
                bool bDigit = char.IsDigit(cb);

                // Digit vs Letter → digit first
                if (aDigit && !bDigit) return -1;
                if (!aDigit && bDigit) return 1;

                // Both digits → compare numerically
                if (aDigit && bDigit)
                {
                    int diff = ca.CompareTo(cb);
                    if (diff != 0) return diff;
                }

                // Both letters → alphabetical compare
                if (!aDigit && !bDigit)
                {
                    int diff = char.ToUpper(ca).CompareTo(char.ToUpper(cb));
                    if (diff != 0) return diff;
                }
            }

            // All characters equal so far → shorter plate first
            return a.Length.CompareTo(b.Length);
        }
    }
}
