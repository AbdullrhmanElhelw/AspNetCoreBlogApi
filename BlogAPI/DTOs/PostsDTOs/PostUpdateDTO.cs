namespace BlogAPI.DTOs.PostsDTOs
{
    public class PostUpdateDTO
    {
        public required string Title { get; set; } = "";
        public required string Content { get; set; } = "";
        public required int CategoryId { get; set; }
    }
}
