using BlogAPI.DTOs.PostsDTOs;

namespace BlogAPI;

public interface IPostService
{
    IEnumerable<PostReadDTO>? GetAllPosts { get; }

    PostReadDTO? GetPostById(int id);

    void CreatePost(PostCreateDTO post);

    void UpdatePost(int id, PostUpdateDTO post);
    void DeletePost(int id);    


}
