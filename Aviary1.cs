using System;
using static Module2HM4.Aviary1;

namespace Module2HM4
{
    public class Aviary1 : SafariPark
    {
        public enum AviaryAnimals
        {
            Zebra,
            Elephant,
            Giraffe,
            Antelope
        }
        private AviaryAnimals[] animals;
        public AviaryAnimals[] Animals
        {
            get { return animals; }
            set
            {
                foreach (int i in Enum.GetValues(typeof(AviaryAnimals))) ;
                //Console.WriteLine(Animals);
            }

            {
                Array.Sort(Animals);
                return Animals;
            }
        }
       
    }
}

