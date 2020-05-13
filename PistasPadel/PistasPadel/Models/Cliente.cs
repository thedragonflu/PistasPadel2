using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PistasPadel.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="*Introduce un usuario")]
        public String Usuario { get; set; }

        [Required(ErrorMessage = "*Introduce una contraseña")]
        public String Contraseña { get; set; }

        
    }
}
