using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Repos.CategoryRepo
{
    public class CategoryRepo : Repository<Category>, ICategoryRepo
    {
        private readonly BlogContext context;

        public CategoryRepo(BlogContext context) : base(context)
        {
            this.context = context;
        }

        public Category? GetCategoryWithPosts(int id) => context.Categories.Include(c => c.Posts).FirstOrDefault(c => c.Id == id);
    }
    
}
