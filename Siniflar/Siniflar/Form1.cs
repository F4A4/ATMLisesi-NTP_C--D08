using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Matematik.MatMetot1();//Static metot 
            //Sınıf türetme/örnekleme
            Matematik mtmSinifi = new Matematik();
            mtmSinifi.MatMetot2();//Static olmayan metot

            //-------------------------------------------

            Edebiyat.EdebMetot1();//Static metot
            //Sınıf türetme/örnekleme
            Edebiyat edbSinifi = new Edebiyat();
            edbSinifi.EdebMetot2();//Static olmayan metot

            //--------------------------------------------
            
        }
    }
}
