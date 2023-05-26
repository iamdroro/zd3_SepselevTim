using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mashine
{
    public class Car
    {
        private bool scan = true;
        private string Marka;
        private int Mileage;
        private double Fuel_consumption_for_1km;

        public bool scn
        {
            get
            {
                return scan;
            }
            set
            {
                scan = value;
            }
        }
        public Car(int mileage, double for1km, string marka)
        {
            mileage = Mileage;
            for1km = Fuel_consumption_for_1km;
            Marka = marka;
        }
        public Car()
        { 
        }
        public double Rashod()
        {
            return Mileage/Fuel_consumption_for_1km;
        }
        public int mile
        {
            get
            {
                return Mileage;
            }
            set 
            {
                if (value > 0)
                {
                    Mileage = value;
                    scan = true;
                }
                else
                {
                    scan = false;
                    MessageBox.Show("Пробег не может быть отрицательным");
                }
            }
            
        }
        public string marka
        {
            get
            {
                return Marka;
            }
            set
            {
                if (value != "")
                {
                    Marka = value;
                    scan = true;
                }
                else
                {
                    scan = false;
                    MessageBox.Show("Значение бренда нужно заполнить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public double fuel
        {
            get
            {
                return Fuel_consumption_for_1km;
            }
            set
            {
                if (value > 0)
                {
                    Fuel_consumption_for_1km = value;
                    scan = true;
                }
                else
                {
                    scan = false;
                    MessageBox.Show("Расход не может быть отрицательным");
                }
            }

        }
    }
}
