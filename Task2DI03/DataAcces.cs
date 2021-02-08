using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2DI03
{
    class DataAcces
    {
        public static ProductModel GetProductModel(int productModelID)
        {
            using (IDbConnection conec = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string sql = $@"SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, 
	                         ProductPhoto.LargePhoto, Product.ListPrice                             
                             FROM Production.ProductModel
                             JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID
                             JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID
                             JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID
                             WHERE Product.ProductModelID = {productModelID} 
                             ORDER BY Product.ListPrice";

                var productModel = conec.Query<ProductModel>(sql).FirstOrDefault();
                return productModel;
            }
        }

        public static List<Product> GetProducts(int productModelID)
        {
            using (IDbConnection conec = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string sql = $@"SELECT ProductID, Size FROM Production.Product
	                            WHERE Product.ProductModelID = { productModelID }
	                            ORDER BY Size;";

                var products = conec.Query<Product>(sql).ToList();
                return products;
            }
        }

        public static List<Product> GetInfo(int productModelID)
        {
            using (IDbConnection conec = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string sql = $@"SELECT ProductID, Name, ListPrice FROM Production.Product
	                            WHERE Product.ProductModelID = { productModelID }
	                            ORDER BY Size;";

                var products = conec.Query<Product>(sql).ToList();
                return products;
            }
        }
    }
}
