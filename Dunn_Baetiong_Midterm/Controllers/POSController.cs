using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dunn_Baetiong_Midterm.Models;

namespace Dunn_Baetiong_Midterm.Controllers
{
    public class POSController : ApiController
    {
        static List<product> collections = new List<product>();

        public POSController()//ENLIST ALL PRODUCTS
        {
            if (collections.Count < 1)
            {
                product GPU1 = new product();//LIST OF GPU CATEGORY
                GPU1.ProductID = 20801;
                GPU1.ProductCode = 0;
                GPU1.ProductName = "Nvidia GeForce RTX 2080 Ti";
                GPU1.Description = "The NVIDIA® GeForce® RTX 2080 Ti graphics card is built for gaming realism and performance. Its powerful NVIDIA Turing™ GPU architecture, breakthrough technologies, and 11 GB of next-gen, ultra-fast GDDR6 memory make it an ultimate gaming GPU";
                GPU1.CategoryID = 1;
                GPU1.Color = "Green";
                GPU1.Size = 22;
                GPU1.Price = 30000;
                collections.Add(GPU1);

                product GPU2 = new product();
                GPU2.ProductID = 20800;
                GPU2.ProductCode = 1;
                GPU2.ProductName = "Nvidia GeForce RTX 2080";
                GPU2.Description = "The GeForce RTX 2080 is built on the 12 nm process, and based on the TU104 graphics processor, in its TU104-400A-A1 variant, the card supports DirectX 12 Ultimate. This ensures that all modern games will run on GeForce RTX 2080";
                GPU2.CategoryID = 2;
                GPU2.Color = "Blue";
                GPU2.Size = 20;
                GPU2.Price = 24000;
                collections.Add(GPU2);


                product GPU3= new product();
                GPU3.ProductID = 20799;
                GPU3.ProductCode = 2;
                GPU3.ProductName = "Nvidia GeForce RTX 2080 super";
                GPU3.Description = "The GeForce RTX 2080 SUPER is built on the 12 nm process, and based on the TU104 graphics processor, in its TU104-450-A1 variant, the card supports DirectX 12 Ultimate";
                GPU3.CategoryID = 3;
                GPU3.Color = "Blue";
                GPU3.Size = 16;
                GPU3.Price = 27500;
                collections.Add(GPU3);

                product CPU1= new product();//Lists of products for CPU CATEGORY
                CPU1.ProductID = 56001;
                CPU1.ProductCode = 3;
                CPU1.ProductName = "Ryzen 5 5600x";
                CPU1.Description = "The Ryzen 5 5600X is a six-core shredder that smooths over the last of the few flaws we saw from Zen 2 and the Ryzen 5 3600X";
                CPU1.CategoryID = 4;
                CPU1.Color = "Blue";
                CPU1.Size = 16;
                CPU1.Price = 17500;
                collections.Add(CPU1);

                product CPU2 = new product();
                CPU2.ProductID = 36001;
                CPU2.ProductCode = 4;
                CPU2.ProductName = "Ryzen 5 3600x";
                CPU2.Description = "AMD Ryzen 5 3600X. 6 Cores - 3800 MHz - 95 watts";
                CPU2.CategoryID = 5;
                CPU2.Color = "Blue";
                CPU2.Size = 16;
                CPU2.Price = 13500;
                collections.Add(CPU2);

                product CPU3 = new product();
                CPU3.ProductID = 32003;
                CPU3.ProductCode = 5;
                CPU3.ProductName = "Ryzen 3 3200g";
                CPU3.Description = "AMD Ryzen™ 3 3200G with Radeon™ Vega 8 Graphics delivers responsiveness and performance required from a much pricier PC";
                CPU3.CategoryID = 6;
                CPU3.Color = "Blue";
                CPU3.Size = 16;
                CPU3.Price = 10000;
                collections.Add(CPU3);

            }
        }


        //GET,POST,PUT,DELETE

            public List<product> Get()//Shows List of all Products
        {
            return collections;
        }
       
        public product Get(int index)//Shows specific product base on given index
        {
            return collections[index];
        }

        public product Post(int ProductID, int ProductCode, string ProductName, string Description, int CategoryID, string Color, int Size, int Price)//Adds product to list
        {
            product P = new product();
            P.ProductID = ProductID;  
            P.ProductCode = ProductCode;  
            P.ProductName = ProductName;
            P.Description = Description;
            P.CategoryID = CategoryID;
            P.Color = Color;
            P.Size = Size;
            P.Price = Price;
            collections.Add(P);
            return P;

        }
        public product Put(int index, int ProductID, int ProductCode, string ProductName, string Description, int CategoryID, string Color, int Size, int Price)//Updates info of specific product to list
        {
            var P = collections[index];
            P.ProductID = ProductID;
            P.ProductCode = ProductCode;
            P.ProductName = ProductName;
            P.Description = Description;
            P.CategoryID = CategoryID;
            P.Color = Color;
            P.Size = Size;
            P.Price = Price;
            collections.Add(P);
            return P;
        }
        
        public string Delete(int index)//Delete Product in List
        {
            collections.RemoveAt(index);
            return "Successfully Deleted";
        }

        }
    }

