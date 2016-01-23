using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo
{
    public abstract class VehicleVisitor
    {
        public VehicleVisitor()
        { }
        public abstract void VisitCar(Car c);
        public abstract void VisitBoat(Boat b);
        public abstract void VisitPlane(Plane p);      

    }

    public class VehicleStopVisitor : VehicleVisitor
    {

        public override void VisitCar(Car c)
        {
            c.Park();
        }

        public override void VisitBoat(Boat b)
        {
            b.PullIn();
        }

        public override void VisitPlane(Plane p)
        {
            p.LandOn();
        }
    }
}

