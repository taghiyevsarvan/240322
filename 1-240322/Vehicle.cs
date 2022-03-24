using System;
using System.Collections.Generic;
using System.Text;

namespace _1_240322
{
        internal abstract class Vehicle
        {

            public string Color;
            public string Brand;
            private double _millage;
            public double Millage
            {
                get
                {
                    return _millage;
                }
                set
                {
                    if (value > 0)
                        _millage = value;
                }
            }
            public virtual string ShowInfo()
            {
                return $"marka- {this.Brand} reng- {this.Color} yuruyus: {this._millage}";
            }
            public abstract void Drive(double km);
        }
 }

