namespace BlogAPI;

public interface ICategoryRepo : IRepository<Category>
{
    Category? GetCategoryWithPosts(int id);
}
