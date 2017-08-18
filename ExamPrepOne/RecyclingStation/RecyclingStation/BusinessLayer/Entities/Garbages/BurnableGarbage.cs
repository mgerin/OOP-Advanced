namespace RecyclingStation.BusinessLayer.Entities.Garbages
{
    public class BurnableGarbage : Garbage
    {
        public BurnableGarbage(string name, double volumePerKg, double weight)
            : base(name, volumePerKg, weight)
        {
        }
    }
}
