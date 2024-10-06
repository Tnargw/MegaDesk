using System;

namespace MegaDesk_Watson
{
    // DeskQuote.cs (Class): This class will define the attributes of a quote including
    // Desk, rush days, customer name, and quote date. This class will also hold the logic
    // in determining the desk quote total.
    internal class DeskQuote
    {
        // Property to hold the Desk instance
        public Desk _desk;
        public int RushDays { get; set; }
        public string Name { get; set; }
        public DateTime QuoteDate { get; set; }

        int surfaceArea = 0;
        int surfaceAreaPrice = 0;

        int deskPrice = 0;


        // Constructor that accepts a Desk instance
        public DeskQuote(Desk desk)
        {
            _desk = desk;
            QuoteDate = DateTime.Now; 
            CalculateTotal();
        }

        public int CalculateTotal()
        {
            surfaceArea= _desk.Width * _desk.Depth;


            // Calculate material price based on the desk material
            if (_desk.DeskMaterial == DesktopMaterial.Oak)
            {
                _desk.MaterialPrice = 200;
            }
            else if (_desk.DeskMaterial == DesktopMaterial.Laminate)
            {
                _desk.MaterialPrice = 100;
            }
            else if (_desk.DeskMaterial == DesktopMaterial.Pine)
            {
                _desk.MaterialPrice = 50;
            }
            else if (_desk.DeskMaterial == DesktopMaterial.Rosewood)
            {
                _desk.MaterialPrice = 300;
            }
            else if (_desk.DeskMaterial == DesktopMaterial.Veneer)
            {
                _desk.MaterialPrice = 125;
            }

            if (surfaceArea > 1000)
            {
                surfaceAreaPrice = surfaceArea - 1000;
            }
            else { surfaceAreaPrice = surfaceArea; }

            int drawerCost = CalculateDrawerCost();
            int rushOrderCost = CalculateRushOrderCost();

            return Desk.BASEPRICE + _desk.MaterialPrice + surfaceAreaPrice + drawerCost + rushOrderCost;

        }
        private int CalculateRushOrderCost()
        {
            int area = _desk.Width * _desk.Depth;

            if (RushDays == 3)
            {
                if (area < 1000) return 60;
                if (area <= 2000) return 70;
                return 80;
            }
            else if (RushDays == 5)
            {
                if (area < 1000) return 40;
                if (area <= 2000) return 50;
                return 60;
            }
            else if (RushDays == 7)
            {
                if (area < 1000) return 30;
                if (area <= 2000) return 35;
                return 40;
            }
            return 0; // No rush order cost if not applicable
        }

        private int CalculateDrawerCost()
        {
            return (_desk.DrawerCount * 50);
        }
    }
}
