using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo
{
   public class Vehicle
    {
       public virtual void Go()
       { 
        
       }

       public virtual void Accept(VehicleVisitor v)
       { }
    }

    public class Car : Vehicle
    {
        public override void Go()
        {
            base.Go();
            //Æû³µÅÜ
        }

        public void Park()
        { }

        public override void Accept(VehicleVisitor v)
        {
            v.VisitCar(this);
        }
    }

 
    public class Boat : Vehicle
    {
        public override void Go()
        {
            base.Go();
        }

        public void PullIn()
        { }

        public override void Accept(VehicleVisitor v)
        {
            v.VisitBoat(this);

        }
    }

    public class Plane : Vehicle
    {
        public override void Go()
        {
            base.Go();
        }

        public void LandOn()
        { }

        public override void Accept(VehicleVisitor v)
        {
            v.VisitPlane(this);

        }
    }
}
