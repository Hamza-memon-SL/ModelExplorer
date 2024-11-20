namespace GenAiPoc.Contracts.Models
{
    public class FileDetails
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FullPath { get; set; }
        public string? Status { get; set; }
        public string? Summary { get; set; }
        public string? Extension { get; set; }
        public string? Size { get; set; }
        public DateTime CreateDate { get; set; }
        public int ProjectId { get; set; }
        public Projects Project { get; set; }
    }
}
