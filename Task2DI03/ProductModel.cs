﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2DI03
{
    public class ProductModel
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public double ListPrice { get; set; }
        public byte[] LargePhoto { get; set; }
        public List<Product> ProductSizes { get; set; }
        public string fullInfo
        {
            get
            {
                return $"{ ProductModelID }: { Name } | { ListPrice }";
            }
        }

    }
}
