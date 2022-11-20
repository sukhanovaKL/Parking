using System.Windows;

namespace Parking
{
    class Functions
    {
        public bool Racschet(int cost, int money)
        {
            if (money > cost)
                return true;
            else
                return false;
        }
    }
}
