namespace BlogAPI;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepo _categoryRepo;

    public CategoryService(ICategoryRepo categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }

    public void CreateCategory(CategoryCreateDTO category)
    {
       if(category is not null)
        {
            _categoryRepo.Add(new Category
            {
                Name = category.Name
            });
            _categoryRepo.SaveChanges();    
        }
    }

    public void DeleteCategory(int id)
    {
       var categoryToDelete = _categoryRepo.GetById(id);
        if(!(categoryToDelete is null))
        {
            _categoryRepo.Delete(categoryToDelete);
            _categoryRepo.SaveChanges();
        }
    }

    public IEnumerable<CategoryReadDTO> GetAllCategories() =>
        _categoryRepo.GetAll.Select(
            c => new CategoryReadDTO
            {
                Id = c.Id,
                Name = c.Name
            }
            ).ToList();

    public CategoryReadDTO? GetCategoryById(int id) =>
        _categoryRepo.GetById(id) is Category category ? new CategoryReadDTO
            {
                Id = category.Id,
                Name = category.Name
            } : null;

    public CategoryWithPostsDTO? GetCategoryWithPosts(int id)
        =>
        _categoryRepo.GetById(id) is Category category ?
        new CategoryWithPostsDTO
        {
            Id = category.Id,
            Name = category.Name,
            Posts =
            category.Posts.Select(
                    p => new PostReadDTO
                    {
                        Id = p.Id,
                        Title = p.Title,
                        Content = p.Content,
                        Created = p.Created
                    }
                )
        }: null;
    

    public void UpdateCategory(int id, CategoryUpdateDTO category)
    {
        var categoryToUpdate = _categoryRepo.GetById(id);
        if(!(categoryToUpdate is  null))
        {
            categoryToUpdate.Name = category.Name;
            _categoryRepo.Update(categoryToUpdate);
            _categoryRepo.SaveChanges();
        }
    }

  }

