using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Dev._2023.Models
{
    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Diesel,
        Gnv
    }

    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem!")]
        [Display(Name = "Quilometragem")]
        public int Quilometragem { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo de combustível!")]
        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o veículo!")]
        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }
}