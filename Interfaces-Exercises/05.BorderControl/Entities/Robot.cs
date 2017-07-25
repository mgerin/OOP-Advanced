namespace _05.BorderControl.Entities
{
    using _05.BorderControl.Interfaces;

    public class Robot : IRobot, ITrackable
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; set; }

        public string Id { get; set; }
    }
}
