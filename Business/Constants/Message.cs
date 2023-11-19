using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Message
    {
        //Success Messages
        public static string ProductAdded = "Product Successfully Added";
        public static string ProductDeleted = "Product Successfully Deleted";
        public static string ProductUpdated = "Product Successfully Updated";
        public static string ProductNameInvalid = "Product Name Invalid";
        public static string ProductGetAllListed = "Product Data Listed";
        public static string ProductGetByCategoryIdListed = "Product Data Listed By CategoryID ";
        public static string ProductGetByPrice = "Product Data Listed By Price";
        public static string ProductGetById = "Product Data Listed By Id";
        public static string ProductDetail = "Product Data Listed By Details";

        //Error Messages
        public static string MaintenanceTime = "Maintenance Time";
    }
}
