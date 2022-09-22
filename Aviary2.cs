using System;
using static Module2HM4.Aviary2;

namespace Module2HM4
{
    public class Aviary2 : SafariPark
    {
        public enum AviaryDangerAnimals
        {
            Lion,
            Tiger,
            Puma,
            Panther
        }
        private AviaryDangerAnimals[] animals1;
        public AviaryDangerAnimals[] Animals1
        {
            get { return animals1; }
            set
            {
                foreach (int i in Enum.GetValues(typeof(AviaryDangerAnimals))) ;
                //Console.WriteLine(Animals1);
            }

            {
                Array.Sort(Animals1);
                return Animals1;
            }
        }
    }
}

