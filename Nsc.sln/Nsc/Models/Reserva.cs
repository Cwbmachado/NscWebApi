using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nsc.Models;
[Table("Reservas")]
public class Reserva
{     
    public Reserva()
    {
        Cadastros = new Collection<Cadastro>();
    }

    [Key]
    public int ReservaId { get; set; }

    public DateTime DataReservaId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    public DateTime DataEscolhidaId { get; set; }

    [Required]
    [StringLength(80)]
    public int QtdePessoas { get; set; }

    [Required]
    [StringLength(80)]
    public int ValorId { get; set; }

    public ICollection<Cadastro>? Cadastros { get; set; }
}
