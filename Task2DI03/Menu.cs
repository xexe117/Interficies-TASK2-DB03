using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task2DI03
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            ToolTip tp = new ToolTip();
            tp.SetToolTip(pictureBox, "Click to display another product");
        }

        public void serchNew()
        {
            bool door = false;
            var productModel = new ProductModel();
            int random = 0;
            while (door == false)
            {
                Random rnd = new Random();
                random = rnd.Next(1, 128);

                productModel = DataAcces.GetProductModel(random);
                if (productModel != null)
                {
                    MemoryStream ms = new MemoryStream(productModel.LargePhoto);
                    Image largePhoto = Image.FromStream(ms);
                    pictureBox.Image = largePhoto;
                    door = true;
                }
            }

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

        private void pictureBox_Click(object sender, EventArgs e)
        {
            serchNew();
        }

        private void serchButt_Click(object sender, EventArgs e)
        {
            serchNew();
        }
    }
}
