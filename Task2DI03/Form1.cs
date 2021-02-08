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
        }

        private void serchButt_Click(object sender, EventArgs e)
        {
            serchNew();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            serchNew();
        }

        public void serchNew()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 128);

            var productModel = DataAcces.GetProductModel(random);
            MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            pictureBox.Image = largePhoto;

            flowLayoutPanel.Controls.Clear();
            productModel.ProductSizes = DataAcces.GetProducts(random);

            foreach (Product product in productModel.ProductSizes)
            {
                Button sizeButton = new Button();
                sizeButton.Text = product.Size;
                sizeButton.Name = product.ProductId.ToString();
                flowLayoutPanel.Controls.Add(sizeButton);
            }

            listBoxInfo.Items.Clear();
            productModel.ProductSizes = DataAcces.GetInfo(random);

            listBoxInfo.Items.Add(productModel.fullInfo);
        }
    }
}
