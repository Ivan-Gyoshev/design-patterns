namespace Builder
{
    public class Car
    {
        public Car()
        {
            Parts = new List<object>();
        }

        public List<object> Parts { get; set; }

        public string PartsReport
        {
            get
            {
                return string.Join(", ", Parts.Select(x => x.ToString()));
            }
        }

        public void AttachPart(string part)
        {
            Parts.Add(part);
        }
    }
}
