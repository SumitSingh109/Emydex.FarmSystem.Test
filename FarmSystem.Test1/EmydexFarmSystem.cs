using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //TEST 1

        private Queue<object> queue = new Queue<object>();
        public void Enter(object animal)        
        
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            if(queue.Count < 4)
            {
                queue.Enqueue(animal);
            }
            Console.WriteLine(animal.GetType().Name + " has entered the Emydex farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            Cow cow = new Cow();
            Hen hen = new Hen();
            Horse horse = new Horse();
            Sheep sheep = new Sheep();
            cow.Talk();
            hen.Talk();
            horse.Talk();
            sheep.Talk();
            //Console.WriteLine("There are no animals in the farm");
        }

        //TEST 3
        public void MilkAnimals()
        {
            IMilkableAnimal interfaceObj = new Cow();
            interfaceObj.ProduceMilk();
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.ElementAt(0).GetType().Name + " has left the farm");
                queue.Dequeue();
            }

            queue.Clear();

            if(queue.Count != 0)
                Console.WriteLine("There are still animals in the farm, farm is not free");
        }

        public void FarmEmpty()
        {
            if (queue.Count == 0)
                Console.WriteLine("Emydex Farm is now empty");
        }
    }
}