﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            GenericClass t = new GenericClass(12, 13);
            Console.WriteLine(t.Sum());
        }
    }
}
