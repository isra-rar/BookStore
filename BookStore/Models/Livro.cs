using LivrariaProject.Models;


public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public Autor Autor { get; set; }

    public decimal Preco { get; set; }

    public string ISBN { get; set; }
    public IdiomasEnum Idioma { get; set; }
    public int NumeroPaginas { get; set; }
    public int Edicao { get; set; }

    public string AnoEdicao { get; set; }

    public Marca Marca { get; set; }
}
