using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animals
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
            Console.WriteLine("Sheep says baa!");
        }
        
        public override void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}