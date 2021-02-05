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
        public static ProdductModel GetProdductModel(int productModelID)
        {
            //string conectionString = "Data Source=spdiv2020.database.windows.net;Initial Catalog=Task1DB;User ID=spdiv;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (IDbConnection conec = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
            {
                string sql = $@"SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, 
	                         ProductPhoto.LargePhoto                             
                             FROM Production.ProductModel
                             JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID
                             JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID
                             JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID
                             WHERE Product.ProductModelID = {productModelID} ";

                var productModel = conec.Query<ProdductModel>(sql).FirstOrDefault();
                return productModel;
            }
        }

        //public static ProdductModel GetProdductModel(int productModelID)
        //{
        //    //string conectionString = "Data Source=spdiv2020.database.windows.net;Initial Catalog=Task1DB;User ID=spdiv;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //    using (IDbConnection conec = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2016")))
        //    {
        //        string sql = $@"SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, 
	       //                  ProductPhoto.LargePhoto                             
        //                     FROM Production.ProductModel
        //                     JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID
        //                     JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID
        //                     JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID
        //                     WHERE Product.ProductModelID = {productModelID} ";

        //        var productModel = conec.Query<ProdductModel>(sql).FirstOrDefault();
        //        return productModel;
        //    }
        //}
    }
}
