﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Высота");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Height())); // Метод нахождения высоты
            if (a == b && b == c && c == b) { listView1.Items[7].SubItems.Add("Равносторонний"); } // Типы треугольников
            else if (b == c) { listView1.Items[7].SubItems.Add("Равнобедренный"); }
            else { listView1.Items[7].SubItems.Add("Разносторонний"); }
            if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Не существует"); }
            else if (triangle.Height() == 0) { listView1.Items[6].SubItems.Add("Не существует"); }
            else if ((a + b) < c && (b + c) < a && (a + c) < b) { listView1.Items[6].SubItems.Add("Не существует"); }
            else listView1.Items[6].SubItems.Add("Существует");

        }
    }
}
