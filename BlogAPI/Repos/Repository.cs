namespace BlogAPI;

public class Repository <T> : IRepository<T> where T : class
{
    private readonly BlogContext _context;

    public Repository(BlogContext context)
    {
        _context = context;
    }

    public IEnumerable<T> GetAll => _context.Set<T>().ToList();

    public T? GetById(int id) => _context.Set<T>().Find(id);

    public void Add(T entity) => _context.Set<T>().Add(entity);

    public void Update(T entity) => _context.Set<T>().Update(entity);

    public void Delete(T entity) => _context.Set<T>().Remove(entity);

    public int SaveChanges() => _context.SaveChanges();
}
