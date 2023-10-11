using BlogAPI.DTOs.PostsDTOs;
using System.Diagnostics;

namespace BlogAPI;

public class PostService : IPostService
{
    private readonly IPostRepo _repo;

    public PostService(IPostRepo repo)
    {
        _repo = repo;
    }


    public IEnumerable<PostReadDTO>? GetAllPosts =>

        _repo.GetAll.Select(
                p => new PostReadDTO
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                    Created = p.Created
                }
            );


    public void CreatePost(PostCreateDTO post)
    {
       if(post is not null)
        {
            _repo.Add(new Post
            {
                Title = post.Title,
                Content = post.Content,
                Created = DateTime.Now,
                CategoryId = post.CategoryId
            });
            _repo.SaveChanges();
        }
    }

    public void DeletePost(int id)
    {
        var postToDelete = _repo.GetById(id);
        if(postToDelete is not null)
        {
            _repo.Delete(postToDelete);
        }
        _repo.SaveChanges();
    }

    public PostReadDTO? GetPostById(int id) =>
        _repo.GetById(id) is Post post?
        new PostReadDTO
        {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                Created = post.Created
        } : null;

    public void UpdatePost(int id, PostUpdateDTO post)
    {
        var postToUpdate = _repo.GetById(id);
        if(postToUpdate is not null)
        {
            postToUpdate.Title = post.Title;
            postToUpdate.Content = post.Content;
            postToUpdate.Created = DateTime.Now;
            postToUpdate.CategoryId = post.CategoryId;
            _repo.Update(postToUpdate);
            _repo.SaveChanges();
        }
    }
}
