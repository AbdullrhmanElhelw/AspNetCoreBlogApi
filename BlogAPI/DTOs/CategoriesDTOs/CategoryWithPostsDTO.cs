namespace BlogAPI;

public class CategoryWithPostsDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public IEnumerable<PostReadDTO> Posts { get; set; } = new List<PostReadDTO>(); 
}
