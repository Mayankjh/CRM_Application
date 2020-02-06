using System;
using System.Collections.Generic;

namespace CRM_PROJECT
{
    class Program
    {
        static void Main(string[] args)
        {

            List<customer> cust_list = new List<customer>
            {
                new customer{cust_id =1, cust_name="harshlala",cust_add="Vijay PG",cust_password="12345",cust_email="harsh@gmail.com",cust_phone=1231232},
                new customer{cust_id =2, cust_name="sharma",cust_add="Vijay PG",cust_password="12345",cust_email="sharma@gmail.com",cust_phone=1231232 }
            };
            Order_Item order_obj = new Order_Item();
            List<product> pro_list = new List<product>
        {
            new product{ product_id = 1212112,prod_name="Nike Black Sports",product_price=3232.32,prod_stock=43,prod_category="shoes" },
            new product{ product_id = 12,prod_name="20L bags",product_price=32632.32,prod_stock=46,prod_category="Bag" },
            new product{ product_id = 122,prod_name="rweer",product_price=322.32,prod_stock=463,prod_category="Phone" },
            new product{ product_id = 1212,prod_name="weewew",product_price=32372.32,prod_stock=434,prod_category="maz" },
            new product{ product_id = 121211,prod_name="wqqqqqqqqq",product_price=32232.32,prod_stock=3,prod_category="cloth" },
            new product{ product_id = 1212221,prod_name="weeeeeeeeeeeeeee",product_price=3232.32,prod_stock=33,prod_category="electronics" },
            new product{ product_id = 121214,prod_name="qwwqqqww",product_price=32322.32,prod_stock=323,prod_category="goods" }

    };

            //pro_list.Add(new product { product_id = 1451, prod_name = "Adidas", product_price = 32.32, prod_stock = 3, prod_category = "Sneakers" });

            Console.Write("Enter Mail Id: ");
            string mail = Console.ReadLine();
            
            foreach(customer cust in cust_list)
            {
                if (cust.cust_email == mail)
                {
                    Console.Write("Enter Password: ");
                    string pass = Console.ReadLine();
                    if (pass == cust.cust_password)
                    {
                        Console.WriteLine(" Welcome {1} Your Customer id is {0}, Your current address is {2}\n\n", cust.cust_id, cust.cust_name, cust.cust_add);

                     foreach( product prod in pro_list)
                        {
                            Console.WriteLine("Product Id {0},  Product Name {1},  Product Price{2}, Current Stock{3}, Product Category{4}\n", prod.product_id, prod.prod_name, prod.product_price, prod.prod_stock, prod.prod_category);
                        }

                        Console.WriteLine("Enter Product ID to Buy");
                        int pid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Quantity");
                        int qty = Convert.ToInt32(Console.ReadLine());
                        foreach (product prodnn in pro_list)
                        {
                            if (pid == prodnn.product_id && qty<=prodnn.prod_stock) {
                                Console.WriteLine("Your Product Details \n Product Id: {0},  Product Name: {1},  Product Price: {2}, Product Category: {4}, Quantity: {5}\n", prodnn.product_id, prodnn.prod_name, prodnn.product_price, prodnn.prod_stock, prodnn.prod_category,qty);
                                Console.WriteLine("Press Anykey to Buy the Product");
                                Console.ReadLine();
                                Console.WriteLine("Product Id {0},  Product Name {1},  Product Price: {2}, Current Stock: {3}, Product Category: {4},Quantity: {5},\n Total Bill Amt {6}", prodnn.product_id, prodnn.prod_name, prodnn.product_price, prodnn.prod_stock, prodnn.prod_category, qty,qty*prodnn.product_price);
                                Console.WriteLine("Will be Delivered to address {0}", cust.cust_add);
                            }
                            
                        }


                    }
                    else
                    {
                        Console.WriteLine("Wrong Password");
                        break;
                    }

                }
                
                
            }
            
            Console.ReadLine();
        }
    }
}
