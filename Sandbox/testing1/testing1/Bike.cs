using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace testing1
{
    internal class Bike
    {
        
        public string brand;
        public int size;
        public int wheels;
        public static int bikeCount = 0;
        private string model;
        
        public Bike(string aBrand, int aSize, int aWheels, string aModel) {
            brand = aBrand;
            size = aSize;
            wheels = aWheels;
            model = aModel;
            bikeCount++;
        }

        public string Model {
            get { return model; }
            set {
                if (value == "Activa 5G")
                {
                    model = value;
                }
                else {
                    model = "Unknown Model";
                }
            }
        }

        public int getBikeCount() {
            return bikeCount;
        }

    }
}
