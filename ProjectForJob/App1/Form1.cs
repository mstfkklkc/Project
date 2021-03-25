using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI;

namespace App1
{
    public partial class Form1 : Form
    {
        private LogBLL logbll;
        public Form1()
        {
            logbll = new LogBLL();
            InitializeComponent();
            northwindC.SelectedIndex = 1;

        }
        

      

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Get methodunun çalıştırıldığı buton
        private async void show_Click(object sender, EventArgs e)
        {
            
            var gelenId = textBox1.Text;
            string combo = northwindC.SelectedItem.ToString();
            var json = logbll.Get(combo,gelenId);
            richTextBox2.Text = await json;

        }

        //Delete methodunun çalıştırıldığı buton
        private async void sil_Click(object sender, EventArgs e)
        {
            
            string silinecekTablo = silinecek.SelectedItem.ToString();
            var silinecekID = silinecekId.Text;
            var json2 = logbll.Delete(silinecekTablo, silinecekID);
            deleteText.Text = await json2;
            
        }

        //post metodunun çalıştırıldığı buton
        private async void post_Click(object sender, EventArgs e)
        {            
            var json3 = logbll.Post("shippers", "companyname", "55555555");
            richTextBox1.Text = await json3;
        }

        //Log kayıtlarının veritabanından getirilmesini sağlayan buton
        private void getLog_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logbll.GetAllItems();
        }
    }
}
