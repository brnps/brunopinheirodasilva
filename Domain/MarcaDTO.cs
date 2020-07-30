using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Domain
{
    public class MarcaDTO
    {
        [Required(ErrorMessage = "O MarcaId é de preenchimento Obrigatório.")]
        public int MarcaId { get; set; }
        [Required(ErrorMessage = "O Nome é de preenchimento Obrigatório.")]
        public string Nome { get; set; }              

    }
}

    