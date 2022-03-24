using System;
using System.Collections.Generic;
using System.Text;

namespace _1_240322
{
    internal class Car:Vehicle
    {

        private int _fuelCapasity;
        public int FuelCapasity
        {
            get
            {
                return
                    _fuelCapasity;
            }
            set
            {
                if (value > 0)
                    _fuelCapasity = value;
            }
        }
        private double _currentFuel;
        public double CurrentFuel
        {
            get
            {
                return _currentFuel;
            }
            set
            {
                if (value > 0)
                    _currentFuel = value;
            }
        }
        private int _fuelFor1km;
        public int FuelFor1km
        {
            get
            {
                return _fuelFor1km;
            }
            set
            {
                if (value > 0)
                    _fuelFor1km = value;
            }
        }





        public override void Drive(double km)
        {
            double UsedFuelKm = (km * _fuelFor1km) / 100;


            if (CurrentFuel > UsedFuelKm)
            {
                Millage = Millage + km;
                CurrentFuel = CurrentFuel - UsedFuelKm;
                Console.WriteLine($"yuruyus- {this.Millage}km \nyanacaq miqdari: {this.CurrentFuel} litr");
            }


            else
            {
                Console.WriteLine($"lazim olacaq yanacaq miqdari: {UsedFuelKm}litr");
            }
        }




        public override string ShowInfo()
        {
            return base.ShowInfo() + $"Full yanacaq miqdari: {FuelCapasity} litr";
        }

    }
}
