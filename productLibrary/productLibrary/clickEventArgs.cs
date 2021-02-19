using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productLibrary
{
    public class clickEventArgs:EventArgs
    {
        private string _id;
        public clickEventArgs (Product product)
        {
            _id = product.ProductId.ToString();
        }

        public string ID
        {
            get { return _id;  }
        }
    }
}
