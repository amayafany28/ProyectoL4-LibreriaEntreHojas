using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntreHojas.BL
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Direccion { get; set; }
        public bool Telefono { get; set; }
    }
    
        [Required(ErrorMessage = "Ingrese Datos del Cliente")]  //Esto nos indica que no puede estar nulo, que es un campo obligatorio.

        


    
}         

    
   

