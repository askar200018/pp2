using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Task1
{ [Serializable]
    public class Shop
    {
        public string shopName;
        public string shopType;
        public List<Product> products;
        public Shop() { }
        public Shop(string shopName , string shopType, List<Product> products)
        {
            this.shopName = shopName;
            this.shopType = shopType;
            this.products = products;
        }
        //public override string ToString()
        //{
        //    string s = "IT IS AN " + shopType;
        //    return "Welcome to " + shopName + s + products;
        //}
    }
    [Serializable]
    public class Product
    {
        public string Name;
        public int Price;
        public Product() { }
        public Product(string Name , int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        //public override string ToString()
        //{
        //    return "Name : " + Name + " PRICE " + Price;
        //}
    }


    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Product1", 100);
            Product product2 = new Product("Product2", 200);
            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            Shop shop = new Shop("SHOPPY", "SHOPNAME", products);
            //FileStream fs1 = new FileStream("complex2.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //XmlSerializer xs = new XmlSerializer(typeof(Shop));
            //xs.Serialize(fs1, shop);
            //fs1.Close();
            //FileStream fs = new FileStream("complex2.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //XmlSerializer xs2 = new XmlSerializer(typeof(Shop));
            //Shop comnum = xs2.Deserialize(fs) as Shop;
            //fs.Close();

            //XmlSerializer xml = new XmlSerializer(typeof(Shop));
            //using (FileStream fs = new FileStream("shop4.xml", FileMode.OpenOrCreate ))
            //{
            //    xml.Serialize(fs, shop);
            //}
            using (FileStream fs = new FileStream("shop2.xml", FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Shop));
                Shop newShop = xs.Deserialize(fs) as Shop;
                Console.WriteLine("DESERIALIZE");
            }

            XmlSerializer formatter = new XmlSerializer(typeof(Shop));
            //using (FileStream fs = new FileStream("shop5.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, shop);
            //}
            //using (FileStream fs = new FileStream("shop2.xml", FileMode.Open))
            //{
            //    Shop shop2 = (Shop)formatter.Deserialize(fs);
            //    Console.WriteLine("Deserialize");
            //}

        }
        //public static void Ser(Shop shop)
        //{
        //    FileStream fs1 = new FileStream("shop.xml", FileMode.Truncate, FileAccess.ReadWrite);
        //    XmlSerializer xs = new XmlSerializer(typeof(Shop));
        //    xs.Serialize(fs1, shop);
        //    fs1.Close();
        //}
        //public static void F2()
        //{
        //    FileStream fs = new FileStream("shop.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //    XmlSerializer xs = new XmlSerializer(typeof(Shop));
        //    Shop shop = xs.Deserialize(fs) as Shop;
        //    fs.Close();
        //    Console.WriteLine("DONE");
        //}
    }
}
