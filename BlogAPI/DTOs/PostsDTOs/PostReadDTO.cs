namespace BlogAPI;

public class PostReadDTO
{
    public required int Id { get; set; }
    public required string Title { get; set; } = "";
    public required string Content { get; set; } = "";
    public required DateTime Created { get; set; } = DateTime.Now;
}
