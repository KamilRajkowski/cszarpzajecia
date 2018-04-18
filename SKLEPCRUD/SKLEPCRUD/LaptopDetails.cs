using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKLEPCRUD
{
    public partial class LaptopDetails : Form
    {

        Laptop laptop;
        SKLEPEntities db;

        public LaptopDetails(Laptop laptop, SKLEPEntities db)
        {
            this.db = db;
            this.laptop = laptop;
            InitializeComponent();
        }

        private void LaptopDetails_Load(object sender, EventArgs e)
        {
            this.TextBoxModel.Text = laptop.model.ToString();
            this.TextBoxProcesor.Text = laptop.procesor.ToString();
            this.TextBoxRam.Text = laptop.ram.ToString();
            this.TextBoxEkran.Text = laptop.ekran.ToString();
            this.TextBoxCena.Text = laptop.cena.ToString();
            this.TextBoxHdd.Text = laptop.hdd.ToString();
        }

        private void SaveLaptopDetails_Click(object sender, EventArgs e)
        {
            laptop.procesor = int.Parse(this.TextBoxProcesor.Text);
            laptop.ram = int.Parse(this.TextBoxRam.Text);
            laptop.ekran = int.Parse(this.TextBoxEkran.Text);
            laptop.cena = decimal.Parse(this.TextBoxCena.Text);
            laptop.hdd = int.Parse(this.TextBoxHdd.Text);
            db.SaveChanges();
        }
    }
}
