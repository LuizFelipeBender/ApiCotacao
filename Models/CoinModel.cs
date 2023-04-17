using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCotacao.Models
{
    [Table("Coins")]
    public class CoinModel
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        public string? code { get; set; }
        [Required]

        public string? codein { get; set; }
        [Required]

        public string? name { get; set; }

        [Required]
        public string? high { get; set; }

        [Required]
        public string? low { get; set; }
        [Required]
        public string? varBid { get; set; }
        [Required]
        public string? pctChange { get; set; }
        [Required]
        public string? bid { get; set; }
        [Required]
        public string? ask { get; set; }
        [Required]
        public string? timestamp { get; set; }
        [Required]
        public string? create_date { get; set; }

    }
}