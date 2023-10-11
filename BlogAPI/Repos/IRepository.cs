﻿namespace BlogAPI;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll { get; }
    T? GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    int SaveChanges();

}
