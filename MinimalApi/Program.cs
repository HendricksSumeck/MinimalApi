using Microsoft.EntityFrameworkCore;
using MinimalApi.Data;
using MinimalApi.Dtos;
using MinimalApi.Entitys;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDataContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/v1/books", (AppDataContext context) =>
{
    var books = context.Books;
    return Results.Ok(books);
}).Produces<Book>();

app.MapPost("/v1/books", (AppDataContext context, BookDto bookDto) =>
{
    var book = new Book
    {
        Name = bookDto.Name,
        Author = bookDto.Author, 
        PageNumbers = bookDto.PageNumbers,
        ReleaseDate = bookDto.ReleaseDate
    };
    
    context.Books.Add(book);
    context.SaveChanges();

    return Results.Ok(book);
});

app.MapPut("/v1/books{id}",async (AppDataContext context, Guid id, BookDto bookDto) =>
{
    var book = await context.Books.FirstOrDefaultAsync(e => e.Id.Equals(id));

    if (book is null)
    {
        return Results.NotFound("Book don't existis");
    }
    
    book.Name = bookDto.Name;
    book.Author = bookDto.Author;
    book.PageNumbers = bookDto.PageNumbers;
    book.ReleaseDate = bookDto.ReleaseDate;
        
    context.Books.Update(book);
    context.SaveChanges();
    
    return Results.Ok(book);
});

app.MapDelete("/v1/books{id}",async (AppDataContext context, Guid id) =>
{
    var book = await context.Books.FirstOrDefaultAsync(e => e.Id.Equals(id));

    if (book is null)
    {
        return Results.NotFound("Book don't existis");
    }
    
    context.Books.Remove(book);
    context.SaveChanges();
    
    return Results.Ok("Deleted book");
});

app.Run();