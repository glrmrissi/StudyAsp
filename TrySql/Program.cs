using Microsoft.EntityFrameworkCore;
using TrySql.Context;
using TrySql.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
                  options.UseNpgsql(connectionString));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});


var app = builder.Build();

#region Post Categoria
app.MapPost("/categorias", async (Categoria categoria, AppDbContext db) =>
{
    db.Categorias?.Add(categoria);
    await db.SaveChangesAsync();

    return Results.Created($"categorias/{categoria.CategoriaId}", categoria);
});

#endregion

#region Post Produto
app.MapPost("/produtos", async (Produtos produto, AppDbContext db) =>
{
    db.Produtos?.Add(produto);
    await db.SaveChangesAsync();

    return Results.Created($"produtos/{produto.ID}", produto);
});

#endregion

#region Get Categoria List
app.MapGet("/categorias", async (AppDbContext db) =>
{
    return await db.Categorias
    .Include(c => c.Produtos)
    .ToListAsync();
});

#endregion

#region Get Categoria

app.MapGet("/categorias/{id:int}", async (int id, AppDbContext db) =>
{
    return await db.Categorias.FindAsync(id)
      is Categoria categoria
                     ? Results.Ok(categoria)
                      : Results.NotFound();
});

#endregion 

#region Get Produtos 
app.MapGet("/produtos/{id:int}", async (int id, AppDbContext db) =>
{
    return await db.Produtos.FindAsync(id)
      is Produtos produto
                     ? Results.Ok(produto)
                      : Results.NotFound();
});
#endregion 

#region Put Categoria
app.MapPut("categorias/{id:int}", async (int id, Categoria categoria, AppDbContext db) =>
{
    if (categoria.CategoriaId != id)
    {
        return Results.BadRequest();
    }

    var categoriaDb = await db.Categorias.FindAsync(id);

    if (categoriaDb is null) return Results.NotFound();

    // categoriaDb.CategoriaId = categoria.CategoriaId;
    categoriaDb.CategoriaNome = categoria.CategoriaNome;
    categoriaDb.CategoriaDescricao = categoria.CategoriaDescricao;

    await db.SaveChangesAsync();
    return Results.Ok(categoriaDb);
});

#endregion

#region Put Produtos
app.MapPut("produtos/{id:int}", async (int id, Produtos produto, AppDbContext db) =>
{
    if (produto.ID != id)
    {
        return Results.BadRequest();
    }

    var produtoDb = await db.Produtos.FindAsync(id);

    if (produtoDb is null) return Results.NotFound();

    produtoDb.Nome = produto.Nome;
    produtoDb.Descricao = produto.Descricao;
    produtoDb.ImagemUrl = produto.ImagemUrl;
    produtoDb.Preco = produto.Preco;
    produtoDb.DataCompra = produto.DataCompra;
    produtoDb.Estoque = produto.Estoque;
    produtoDb.CategoriaId = produto.CategoriaId;

    await db.SaveChangesAsync();
    return Results.Ok(produtoDb);
});
#endregion

#region Delete Categorias
app.MapDelete("categorias/{id:int}", async (int id, AppDbContext db) =>
{
    var categoriaDb = await db.Categorias.FindAsync(id);
    if (categoriaDb is not null)
    {
        db.Categorias.Remove(categoriaDb);
        await db.SaveChangesAsync();
    }

    return Results.NoContent();

});
#endregion 

#region Delete Produtos
app.MapDelete("produtos/{id:int}", async (int id, AppDbContext db) =>
{
    var produtoDb = await db.Produtos.FindAsync(id);
    if (produtoDb is not null)
    {
        db.Produtos.Remove(produtoDb);
        await db.SaveChangesAsync();
    }

    return Results.NoContent();

});
#endregion
app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();

