using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo
{
    public  abstract class Bird
    {
        public abstract Egg LayEgg();

    }
    public class Chicken : Bird
    {

        public override Egg LayEgg()
        {
            return new ChickenEgg();
        }
    }

    public class Goose : Bird
    {
        public override Egg LayEgg()
        {
            return new GooseEgg();
        }
    }

    public class Duck : Bird
    {

        public override Egg LayEgg()
        {
            return new DuckEgg();
        }
    }
}
