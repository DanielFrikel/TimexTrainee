using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing1
{
    internal class Car
    {
        public string brand;
        public string color;
        public int yearModel;
        public static int carCount = 0;
        private string nationality;

        public Car(string aBrand, string aColor, int aYearModel, string aNationality)
        {
            brand = aBrand;
            color = aColor;
            yearModel = aYearModel;
            nationality = aNationality;
            carCount++;
        }

        public int getCarCount() {            
            return carCount;
        }

        public string Nationality {
            get{ return nationality; }
            set{
                if (value == "mx")
                {
                    nationality = value;
                }
                else {
                    nationality = "Chocolate Car";
                }
            }
        }

    }
}
