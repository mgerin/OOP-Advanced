namespace _03.Ferrari.Entities
{
    using System.Text;

    public class Ferrari : Interfaces.ICar
    {
        public Ferrari(string model, string driver)
        {
            this.Model = model;
            this.Driver = driver;
        }

        public string Model { get; set; }

        public string Driver { get; set; }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public string UseGas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}/{this.UseBrakes()}/{this.UseGas()}/{this.Driver}");

            return sb.ToString();
        }
    }
}
