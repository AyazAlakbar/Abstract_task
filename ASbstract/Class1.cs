using System;
using System.Collections.Generic;
using System.Text;

namespace ASbstract
{
    abstract class Transportation
    {
        public abstract void Air();


        
    }
     class Plane : Transportation
    {
        public override void Air()
        {
            Console.WriteLine("fly");
        }

        
    }




}
