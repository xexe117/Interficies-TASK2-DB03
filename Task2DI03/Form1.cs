using productLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2DI03
{
    //Se añadir lo de dll, pero no se como usarlo aqui
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menu1.ClickSizze += getInfo;
        }

        public void getInfo(object sender, clickEventArgs e)
        {
            textBox1.Text = e.ID;
        }
    }
}
