using System;
using System.Collections.Generic;
using System.Text;

namespace _1_240322
{
    internal class Bicycle:Vehicle
    {
        public override void Drive(double km)
        {
            Millage = Millage + km;
        }

        public override string ShowInfo()
        {
            return base.ShowInfo();
        }
    }
}
