namespace GenAiPoc.Contracts.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? GitHubURL { get; set; }
        public string? Status { get; set; }
        public string? Summary { get; set; }
        public DateTime CreateDate{ get; set; }
        public ICollection<FileDetails> Files { get; set; }
    }
}
