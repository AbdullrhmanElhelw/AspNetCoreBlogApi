namespace BlogAPI;

public interface ICategoryService
{
    IEnumerable<CategoryReadDTO> GetAllCategories();

    CategoryWithPostsDTO? GetCategoryWithPosts(int id);

    CategoryReadDTO? GetCategoryById(int id);

    void CreateCategory(CategoryCreateDTO category);

    void UpdateCategory(int id, CategoryUpdateDTO category);

    void DeleteCategory(int id);

}
