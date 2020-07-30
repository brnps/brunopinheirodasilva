using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class PatrimonioDTO
    {       
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é de preenchimento Obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O MarcaId é de preenchimento Obrigatório.")]
        public int MarcaId { get; set; }
        public string Descricao { get; set; }
        public int NumeroTombo { get; set; }

    }
}