namespace DemoClass.Models
{
    public class Project
    {
        private string dateCreated;

        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public string DateCreated { get => dateCreated; set => dateCreated = value; }
    }
}
