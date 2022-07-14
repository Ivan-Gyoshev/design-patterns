namespace Prototype
{
    public class Robot
    {
        public Robot(string model, string color, DateTimeOffset creationDate, IdInfo serialNumber)
        {
            Model = model;
            Color = color;
            CreationDate = creationDate;
            SerialNumber = serialNumber;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public DateTimeOffset CreationDate { get; set; }

        public IdInfo SerialNumber { get; set; }

        public Robot ShallowCopy()
        {
            return (Robot)MemberwiseClone();
        }

        public Robot CompleteCopy()
        {
            Robot clone = (Robot)MemberwiseClone();
            clone.SerialNumber = new IdInfo(SerialNumber.IdNumber);
            clone.Model = Model;
            clone.Color = Color;
            clone.CreationDate = DateTimeOffset.UtcNow;

            return clone;
        }
    }
}
