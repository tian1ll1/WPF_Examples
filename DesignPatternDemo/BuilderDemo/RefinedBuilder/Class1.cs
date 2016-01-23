//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace RefinedBuilder
//{

//    using System;
//    using System.Collections;

//    // "Director" 

//    class Director
//    {
//        // Methods
//        public void Construct(Builder builder)
//        {
//            builder.BuildPartA();
//            builder.BuildPartB();
//        }
//    }

//    // "Builder" 

//    abstract class Builder
//    {
//        // Methods
//        abstract public void BuildPartA();
//        abstract public void BuildPartB();
//        abstract public Product GetResult();
//    }

//    // "ConcreteBuilder1" 

//    class ConcreteBuilder1 : Builder
//    {
//        // Fields
//        private Product product;

//        // Methods
//        override public void BuildPartA()
//        {
//            product = new Product();
//            product.Add("PartA");
//        }

//        override public void BuildPartB()
//        {
//            product.Add("PartB");
//        }

//        override public Product GetResult()
//        {
//            return product;
//        }
//    }
//    // "ConcreteBuilder2" 

//    class ConcreteBuilder2 : Builder
//    {
//        // Fields
//        private Product product;

//        // Methods
//        override public void BuildPartA()
//        {
//            product = new Product();
//            product.Add("PartX");
//        }

//        override public void BuildPartB()
//        {
//            product.Add("PartY");
//        }

//        override public Product GetResult()
//        {
//            return product;
//        }
//    }

//    // "Product" 

//    class Product
//    {
//        // Fields
//        ArrayList parts = new ArrayList();

//        // Methods
//        public void Add(string part)
//        {
//            parts.Add(part);
//        }

//        public void Show()
//        {
//            Console.WriteLine("\nProduct Parts -------");
//            foreach (string part in parts)
//                Console.WriteLine(part);
//        }
//    }

//    /// <summary>
//    ///   Client test
//    /// </summary>
//    public class Client
//    {
//        public static void Main(string[] args)
//        {
//            // Create director and builders
//            Director director = new Director();

//            Builder b1 = new ConcreteBuilder1();
//            Builder b2 = new ConcreteBuilder2();

//            // Construct two products
//            director.Construct(b1);
//            Product p1 = b1.GetResult();
//            p1.Show();

//            director.Construct(b2);
//            Product p2 = b2.GetResult();
//            p2.Show();
//        }
//    }


//}
