namespace _05.BorderControl.Entities
{
    using _05.BorderControl.Interfaces;

    public class Citizen : ICitizen, ITrackable
    {
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }
    }
}
