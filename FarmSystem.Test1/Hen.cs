using System;

namespace FarmSystem.Test1
{
    public class Hen : Animals
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
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public override void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}