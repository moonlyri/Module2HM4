using System;
using static Module2HM4.Aviary1;
using static Module2HM4.Aviary2;

namespace Module2HM4
{
    public class AnimalsService
    {
        private IDataStorage _storage;
        public AnimalsService(IDataStorage storage)
        {
            _storage = storage;
        }
        public int Count(AviaryAnimals[] Animals)
        {
            return 4;
        }
        public int Count1(AviaryDangerAnimals[] Animals1)
        {
            return 4;
        }
    }
}

