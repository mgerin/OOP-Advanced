namespace RecyclingStation.BusinessLayer.Entities.Garbages
{
    public class StorableGarbage : Garbage
    {
        public StorableGarbage(string name, double volumePerKg, double weight)
            : base(name, volumePerKg, weight)
        {
        }
    }
}
