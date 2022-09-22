using System;
namespace Module2HM4
{
    public class MemoryDataStorage : IDataStorage
    {
        private SafariPark[] parks;

        void IDataStorage.Create(SafariPark park)
        {
            throw new NotImplementedException();
        }
}

