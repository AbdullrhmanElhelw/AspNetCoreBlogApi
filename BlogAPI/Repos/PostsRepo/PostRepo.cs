namespace BlogAPI;

public class PostRepo : Repository<Post>, IPostRepo
{
    public PostRepo(BlogContext context) : base(context)
    {
    }
}

