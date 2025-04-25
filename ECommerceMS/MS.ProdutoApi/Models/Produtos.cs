namespace MS.ProdutoApi.Models;
public class Produtos
{
    public int Id { get; set; }
    public string?  Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public long Estoque { get; set; }
    public string? ImagemUrl { get; set; }

    public Categoria? Categoria { get; set; }
    public int CategoriaId { get; set; }
}
