namespace LogSeqSerilog.Models;


public class Produto
{
    public Guid ID { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public DateTime DataDeFabricacao { get; set; }
    public TimeSpan TempoDeGarantia { get; set; }
    public Cores Cor { get; set; }
    public string Categoria { get; set; }
    public int EstoqueDisponivel { get; set; }
    public bool EmEstoque { get; set; }
    public int Nivel { get; set; }
    public string URLDaImagem { get; set; }
}
[Flags]
public enum Cores
{
    None = 0,
    Vermelho = 1 << 0,
    Verde = 1 << 1,
    Azul = 1 << 2,
    Amarelo = 1 << 3,
    Laranja = 1 << 4,
    Roxo = 1 << 5,
    Marrom = 1 << 6,
    Preto = 1 << 7,
    Branco = 1 << 8,
    Cinza = 1 << 9,

}


