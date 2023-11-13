using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KapsamCalısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //MessageBox(....);a değişkeni dış kapsamdan erişilemiyor...
        int b = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 3;
            MessageBox.Show(a.ToString());//Kendi kapsamı içinde erişebilir
            MessageBox.Show(b.ToString());//b değişkeni dış kapsamda
            //Tanımladığı için içeridekine her kapsamdan erişilebiliyor..
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox(....);a değişkeni dış kapsamdan erişilemiyor...
            int a = 15;//O yüzden yeni bir a tanımlanabilir..
            b = 15;//erişilemiyor
            
        } 
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //b=9;bu dış kapsama erişmeye çalışır..
            //içeride aynısı tanımlandığı için hata verir.
            int b = 0;//burada tanımlanan b değişkeni dış kapsamdaki 
            //b değişkenini siler yerine bu kullanılır.
            b = 9;//bu iç kapsamda kullanılan b yi kullanır.


        }
    }
}
