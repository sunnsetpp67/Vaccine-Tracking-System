using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aşı_Takip_02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            static void Main(string[] args)
            {


                Depo depo = new Depo();



                Console.Write("Depo adı: ");
                depo.Ad = Console.ReadLine();

                Console.Write("Depo adresi: ");
                depo.Adres = Console.ReadLine();

                Console.Write("Depo kapasitesi: ");
                depo.Kapasite = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Depo bilgileri:");
                Console.WriteLine("Ad: " + depo.Ad);
                Console.WriteLine("Adres: " + depo.Adres);
                Console.WriteLine("Kapasite: " + depo.Kapasite);


                Console.ReadLine();
            }
        }


        class Depo
        {
            public string Ad { get; set; }
            public string Adres { get; set; }
            public int Kapasite { get; set; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GERİ_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            {
                this.Hide();  
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
