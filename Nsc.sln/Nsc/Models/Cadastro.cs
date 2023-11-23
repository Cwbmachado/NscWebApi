using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nsc.Models;
[Table("Cadastros")]

public class Cadastro
{
    [Key]
    public int CadastroId { get; set; }
    
    [Required]
    [StringLength(80)]
    public int ReservaId { get; set; }
    
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }
   
    [Required]
    [StringLength(300)]
    public DateTime DataCadastro { get; set; }

    public DateTime DataNascimento { get; set; }
    
    [Required]
    [StringLength(80)]
    public int IdRG { get; set; }
    
    [Required]
    [StringLength(80)]
    public int IdCPF { get; set; }
    
    [Required]
    [StringLength(80)]
    public string? Endereco{ get; set; }
    
    [Required]
    [StringLength(300)]
    public string? Cidade { get; set; }  
    
    [Required]
    [StringLength(200)]
    public string? Estado { get; set; }
    
    [Required]
    [StringLength(100)]
    public string? Pais{ get; set; }
    
    [Required]
    [StringLength(80)]
    public string? EstadoCivil { get; set; }
   
    [Required]
    [StringLength(100)]
    public string? Profissao { get; set; }
  

}

