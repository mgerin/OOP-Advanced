namespace _03.Ferrari.Entities.Interfaces
{
    public interface ICar
    {
        string Model { get; set; }

        string Driver { get; set; }

        string UseBrakes();

        string UseGas();
    }
}
