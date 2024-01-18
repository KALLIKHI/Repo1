//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Jan8
//{
//    internal class Productrepository
//    {
        
//            public Product1[] product;

//            public Productrepository(Product1[] product)
//            {
//                this.product = product;
//                public void DisplayAllProducts() 
//            {
//                Console.WriteLine($"_____ALL PRODUCT DETAILS : _______");
//                foreach (Product1 p in product)
//                {
//                    Console.WriteLine($" PID: {p.pid} , PNAME: {p.pName} , PROD PRICE {p.price} , PROD CATEGORY : {p.category}");
//                }
//                Console.WriteLine("");

//            }
//            public void DisplayProductsByCategory(string category) //display all products of the category
//            {
//                Console.WriteLine($"_____SEARCHING THE PRODUCT BY CATEGORY : _______");
//                foreach (Product1 pd in product)
//                {
//                    if (pd.category.Equals(category))
//                        Console.WriteLine($"PID: {pd.pid} , PNAME: {pd.pName} , PROD PRICE {pd.price} , PROD CATEGORY : {pd.category}");
//                }
//                Console.WriteLine("");
//            }
//            public void DisplayProductByPrice(float price)  //display all products > then the Price
//            {
//                Console.WriteLine(" ");
//                Console.WriteLine($"_____SEARCHING THE PRODUCT BY PRICE : _______");
//                foreach (Product1 pt in product)
//                {
//                    if ((product.price) > (price))
//                        Console.WriteLine($"PID: {pt.pid} , PNAME: {pt.pName} , PROD PRICE {pt.price} , PROD CATEGORY : {pt.category}");
//                }

//            }
//        }
//    }
//}
//        }
    
//}
