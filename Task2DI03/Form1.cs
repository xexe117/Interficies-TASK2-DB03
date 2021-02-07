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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serchButt_Click(object sender, EventArgs e)
        {
            var productModel = DataAcces.GetProductModel(int.Parse(findTextBox.Text));
            MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            pictureBox1.Image = largePhoto;

            foreach (Product product in productModel.ProductSizes)
            {
                Button sizeButton = new Button();
                sizeButton.Text = product.ProductId + "/" + product.Size;
                sizeButton.Name = product.ProductId.ToString();
                flowLayoutPanel1.Controls.Add(sizeButton);
            }
        }
    }
}
