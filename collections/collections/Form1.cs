using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace collections
{
    public partial class Form1 : Form
    {
        string s = "Today, weather is very good";
        int x = 5, y = 8;
        DateTime t = DateTime.Now;
        Car car = new Car() { id = 1, brand = "Renault", modelYear = 2020};
        Book book = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler için C# ile Programlar", author = "Anıl" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArr_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            list.Add(s);
            list.Add(x);
            list.Add(t);
            list.Add(car);
            list.Add(book);

            txtResult.Text += "Count of items in list: " + list.Count + "/n";
            txtResult.Text += "------------------------------------/n";
            foreach (var item in list)
            {
                txtResult.Text += item + "/n";
            }
            txtResult.Text += "------------------------------------/n";
            list[1] = y;
            list.RemoveAt(0);
            list.RemoveAt(car);

            txtResult.Text = "After Modifications, Count  of ıtems in list: " + list.Count + "/n";
            txtResult.Text += "------------------------------------/n";
            foreach (var item in list)
            {
                txtResult.Text += item + "/n";
            }
            txtResult.Text += "------------------------------------/n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
