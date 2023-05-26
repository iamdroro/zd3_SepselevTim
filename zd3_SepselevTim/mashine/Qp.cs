using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mashine
{
    class Qp:Car
    {
        private List<string> car = new List<string>();
        private int P;
        private ListBox listBox;
        public Qp(ListBox listBox) => this.listBox = listBox;
        public int p
        {
            get
            {
                return P;
            }
            set
            {
                if (value > 0)
                {
                    P = value;
                    scn = true;

                }
                else
                {
                    MessageBox.Show("Значение не должно быть отрицательным", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
        }
        public void Remove(string marka)
        {
            
            int con1 = car.Count;
            car.RemoveAll(car => car.Contains($"Марка:{marka}"));
            int con2 = car.Count;
            if (con2 < con1)
            {
                MessageBox.Show($"Марка {marka} удален");
            }
            else
            {
                MessageBox.Show("Авто не найдено");
            }
        }
        public double Qpreset()
        {
            return Rashod() *1.15*p;
        }
        public void Add()
        {
            car.Add($"Марка:{marka},Пробег:{mile}, Расход: {fuel},, P={p}. Q={Rashod()}, Qp={Qpreset()}");
        }

        public void GetAllList()
        {
            foreach (var ar in car)
            {
                listBox.Items.Add(ar);
            }
        }
    }
}
