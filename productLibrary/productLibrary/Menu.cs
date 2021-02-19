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

namespace productLibrary
{
    public partial class Menu : UserControl
    {
        Product product = new Product();

        public Menu()
        {
            InitializeComponent();
            ToolTip tp = new ToolTip();
            tp.SetToolTip(pictureBox, "Click to display another product");
        }

        public EventHandler<clickEventArgs> ClickSizze;

        public virtual void OnClickSizze(clickEventArgs e)
        {
            ClickSizze?.Invoke(this, e);
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

                sizeButton.Click += sizeButtom_Click;
            }

            listBoxInfo.Items.Clear();
            productModel.ProductSizes = DataAcces.GetInfo(random);

            listBoxInfo.Items.Add(productModel.fullInfo);
        }

        public void sizeButtom_Click(object sender, EventArgs e)
        {
            product.ProductId = Int32.Parse(((Button)sender).Name);
            clickEventArgs args = new clickEventArgs(product);
            OnClickSizze(args);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            serchNew();
        }

        private void serchButt_Click_1(object sender, EventArgs e)
        {
            serchNew();
        }
    }
}
