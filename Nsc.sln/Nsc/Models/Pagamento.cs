using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nsc.Models;
[Table("Pagamentos")]
public class Pagamento
{

    [Key]
    public int PagamentoId { get; set; }

    [Required]
    [StringLength(80)]
    public int CadastroId { get; set; }

    [Required]
    [StringLength(80)]
    public int ReservaId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }
    public DateTime DataReservaId { get; set; }
    public DateTime DataEscolhidaId { get; set; }

    [Required]
    [StringLength(80)]
    public int ValorId { get; set; }

    [Required]
    [StringLength(80)]
    public int ValorPagoId { get; set; }

    [Required]
    [StringLength(80)]
    public int ValorRestanteId { get; set; }


}
