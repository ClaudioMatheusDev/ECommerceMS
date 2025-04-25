namespace MS.ProdutoApi.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public ICollection<Produtos>? Produtos { get; set; }
}
