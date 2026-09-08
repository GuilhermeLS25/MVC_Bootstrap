using System.ComponentModel.DataAnnotations;

namespace MVC_Bootstrap;



public class Cerimonia
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O campo Noiva é obrigatório!")] //Propriedade de validação para o campo Noiva
    public string? Noiva { get; set; }

    [Required(ErrorMessage = "O campo Noivo é obrigatório!")] //Propriedade de validação para o campo Noivo
    public string? Noivo { get; set; }

    [Required(ErrorMessage = "O campo Data é obrigatório!")] //Propriedade de validação para o campo Data
    [DataType(DataType.Date)] //define o tipo de dado como Data
    public DateTime Data { get; set; }

    [Required(ErrorMessage = "o campo Local é Obrigatori!")]
    public string? Local { get; set; }
    public int QuantidadeConvidados { get; set; }
}
