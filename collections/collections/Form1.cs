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
        Car car = new Car() { id = 1, brand = "Renault", modelYear = 2020 };
        Book book = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler İçin C# ile Programlamaya Giriş", author = "Aybar Karaçay" };


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

         
            list.Add(s);
            list.Add(x);
            list.Add(t);
            list.Add(car);
            list.Add(book);

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach(var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            list[1] = y;
            list.RemoveAt(0);
            list.Remove(car);

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SortedList list = new SortedList();

            list.Add("message", s);
            list.Add("number", x);
            list.Add("datetime", t);
            list.Add("car", car);
            list.Add("book", book);

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (DictionaryEntry item in list)
            {
                txtResult.Text += item.Key + " -> " + item.Value + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            list["number"] = y;
            list.RemoveAt(0);
            list.Remove("car");

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (DictionaryEntry item in list)
            {
                txtResult.Text += item.Key + " -> " + item.Value + "\n";
            }
            txtResult.Text += "---------------------------------\n";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hashtable list = new Hashtable();

            list.Add("message", s);
            list.Add("number", x);
            list.Add("datetime", t);
            list.Add("car", car);
            list.Add("book", book);

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (DictionaryEntry item in list)
            {
                txtResult.Text += item.Key + " -> " + item.Value + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            list["number"] = y;
            //list.RemoveAt(0); //ERROR: RemoveAt is not defined in Hashtable
            list.Remove("car");

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (DictionaryEntry item in list)
            {
                txtResult.Text += item.Key + " -> " + item.Value + "\n";
            }
            txtResult.Text += "---------------------------------\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Queue list = new Queue();

            list.Enqueue(s);
            list.Enqueue(x);
            list.Enqueue(t);
            list.Enqueue(car);
            list.Enqueue(book);

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            //list[1] = y; //ERROR: You cannot do that
            var deletedItem = list.Dequeue();
            

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";
            txtResult.Text += "Removed Element: " + deletedItem + "\n";
            txtResult.Text += "First place in the queue: "+ list.Peek() + "\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stack list = new Stack();

            list.Push(s);
            list.Push(x);
            list.Push(t);
            list.Push(car);
            list.Push(book);

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            //list[1] = y; //ERROR: You cannot do that
            var deletedItem = list.Pop();


            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";
            txtResult.Text += "Removed Element: " + deletedItem + "\n";
            txtResult.Text += "First place in the stack: " + list.Peek() + "\n";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SortedList<string, Book> list = new SortedList<string, Book>();

            Book book1 = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler İçin C# ile Programlamaya Giriş", author = "Aybar Karaçay" };
            Book book2 = new Book() { ISBN = "89750236211", title = "Az bilenler İçin C# ile Programlamaya Giriş", author = "Zahid Gürbüz" };
            Book book3 = new Book() { ISBN = "50236211", title = "İyiler İçin C# ile Programlamaya Giriş", author = "Mustafa Gürbüz" };
            Book book3modified = new Book() { ISBN = "50236211", title = "İyi bilenler İçin C# ile Programlamaya Giriş", author = "Mustafa Gürbüz" };
            Book book4 = new Book() { ISBN = "236211", title = "Herşeyi Bilenler İçin C# ile Programlamaya Giriş", author = "Mustafa Zahid" };

            list.Add(book1.ISBN, book1);
            list.Add(book2.ISBN, book2);
            list.Add(book3.ISBN, book3);
            list.Add(book4.ISBN, book4);

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item.Key + " -> " + item.Value + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            list["50236211"] = book3modified;
            list.RemoveAt(0);
            list.Remove("9789750236211");

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item.Key + " -> " + item.Value + "\n";
            }
            txtResult.Text += "---------------------------------\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dictionary<string, Book> list = new Dictionary<string, Book>();

            Book book1 = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler İçin C# ile Programlamaya Giriş", author = "Aybar Karaçay" };
            Book book2 = new Book() { ISBN = "89750236211", title = "Az bilenler İçin C# ile Programlamaya Giriş", author = "Zahid Gürbüz" };
            Book book3 = new Book() { ISBN = "50236211", title = "İyiler İçin C# ile Programlamaya Giriş", author = "Mustafa Gürbüz" };
            Book book3modified = new Book() { ISBN = "50236211", title = "İyi bilenler İçin C# ile Programlamaya Giriş", author = "Mustafa Gürbüz" };
            Book book4 = new Book() { ISBN = "236211", title = "Herşeyi Bilenler İçin C# ile Programlamaya Giriş", author = "Mustafa Zahid" };

            list.Add(book1.ISBN, book1);
            list.Add(book2.ISBN, book2);
            list.Add(book3.ISBN, book3);
            list.Add(book4.ISBN, book4);

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item.Key + " -> " + item.Value + "\n";
            }
            txtResult.Text += "---------------------------------\n";


            if (list.ContainsKey(book4.ISBN))
                list[book4.ISBN] = book;
            else
                list.Add(book4.ISBN, book);

            list["502"] = book3modified;
            //list.RemoveAt(0); //ERROR
            list.Remove(book4.ISBN);

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item.Key + " -> " + item.Value + "\n";
            }
            txtResult.Text += "---------------------------------\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Queue<Car> list = new Queue<Car>();

            //list.Enqueue(s); // ERROR: string is not permitted. i requires a Car object. 
            list.Enqueue(new Car() { id = 1, brand = "Renault", modelYear = 2020 });
            list.Enqueue(new Car() { id = 2, brand = "Citroen", modelYear = 2009 });
            list.Enqueue(new Car() { id = 3, brand = "Nissan", modelYear = 2023 });
            list.Enqueue(new Car() { id = 4, brand = "BMW", modelYear = 2023 });

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            //list[1] = new Car() { id = 5, brand = "Volkswagen", modelYear = 2019 }; //ERROR: index is not defined
            var deletedItem = list.Dequeue();

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            txtResult.Text += "Deleted item: "+ deletedItem + "\n";
            txtResult.Text += "First place: "+ list.Peek() + "\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stack<Car> list = new Stack<Car>();

            //list.Push(s); // ERROR: string is not permitted. i requires a Car object. 
            list.Push(new Car() { id = 1, brand = "Renault", modelYear = 2020 });
            list.Push(new Car() { id = 2, brand = "Citroen", modelYear = 2009 });
            list.Push(new Car() { id = 3, brand = "Nissan", modelYear = 2023 });
            list.Push(new Car() { id = 4, brand = "BMW", modelYear = 2023 });

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            //list[1] = new Car() { id = 5, brand = "Volkswagen", modelYear = 2019 }; //ERROR: index is not defined
            var deletedItem = list.Pop();

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            txtResult.Text += "Deleted item: " + deletedItem + "\n";
            txtResult.Text += "First place: " + list.Peek() + "\n";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FiveCell list = new FiveCell();

            list.Add((uint)x);
            list.Add((uint)y);

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            for(int i= 0; i< list.Count; i++)
            {
                var item = list[i];
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            list[0] = y;
           

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FiveCell<Car> list = new FiveCell<Car>();

            list.Add(new Car() { id = 1, brand = "Renault", modelYear = 2020 });
            list.Add(new Car() { id = 2, brand = "Citroen", modelYear = 2009 });
            list.Add(new Car() { id = 3, brand = "Nissan", modelYear = 2023 });
            list.Add(new Car() { id = 4, brand = "BMW", modelYear = 2023 });

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            list[2] = car;


            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<Car> list = new List<Car>();

            //list.Add(s); // ERROR: string is not permitted. i requires a Car object. 
            list.Add(new Car() { id = 1, brand = "Renault", modelYear = 2020 });
            list.Add(new Car() { id = 2, brand = "Citroen", modelYear = 2009 });
            list.Add(new Car() { id = 3, brand = "Nissan", modelYear = 2023 });
            list.Add(new Car() { id = 4, brand = "BMW", modelYear = 2023 });

            txtResult.Text = "Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";

            list[1] = new Car() { id = 5, brand = "Volkswagen", modelYear = 2019 };
            list.RemoveAt(2);
            list.Remove(car);  //car object is not involved in the list. so it cannot be removed.

            txtResult.Text += "After Modifications, Count of Items in list: " + list.Count + "\n";
            txtResult.Text += "---------------------------------\n";
            foreach (var item in list)
            {
                txtResult.Text += item + "\n";
            }
            txtResult.Text += "---------------------------------\n";
        }

    }

}
