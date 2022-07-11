namespace MinimalApi.Dtos;

public class BookDto
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageNumbers { get; set; }
    public DateTime? ReleaseDate { get; set; }
}