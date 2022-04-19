using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animals, IMilkableAnimal
    {
        
        public override string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public override int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = value;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk(string str)
        {
            Console.WriteLine("Cow produced milk");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }
    }
}