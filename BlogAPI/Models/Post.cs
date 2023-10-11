﻿namespace BlogAPI;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime? Updated { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; } = null!;
}
