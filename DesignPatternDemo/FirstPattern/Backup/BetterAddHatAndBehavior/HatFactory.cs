using System;
using System.Collections.Generic;
using System.Text;

namespace BetterAddHatAndBehavior
{
    class HatFactory
    {
        public HatFactory()
        { }

        public static Hat GetNewHat(Behavior bh)
        {
            Hat h = null;

            switch (bh.BehaviorName)
            { 
                case "Swimming":
                    h = new SwimmingHat();
                    break;
                case "Play Tennis":
                    h = new TennisHat();
                    break;
            }

            return h;
        }
    }
}
