using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Watson
{
    // Desk.cs (Class): This class will define the attributes of the desk object with
    // width, depth, number of drawers, and the surface material.
    public enum DesktopMaterial { Laminate, Oak, Rosewood, Veneer, Pine }

    internal class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerCount { get; set; }
        public int MaterialPrice { get; set; }


        public DesktopMaterial DeskMaterial { get; set; }


        public const int BASEPRICE = 200;

        // Desk constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;

        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;
    }
}
