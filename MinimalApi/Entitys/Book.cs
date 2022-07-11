using MinimalApi.Dtos;

namespace MinimalApi.Entitys;

public class Book
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageNumbers { get; set; }
    public DateTime? ReleaseDate { get; set; }

    public Book()
    {
        Id = Guid.NewGuid();
    }
}