using System;
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
            GenericClass<int> t= new GenericClass<int>(12, 13);
            Console.WriteLine(t.Sum());

            GenericClass<float> q = new GenericClass<float>((float)1.25, (float)2.40);
            Console.WriteLine(q.Sum());
        }

        private void collectionsTestButton_Click(object sender, EventArgs e)
        {
            Collections t = new Collections();
            t.f();
        }
    }
}
