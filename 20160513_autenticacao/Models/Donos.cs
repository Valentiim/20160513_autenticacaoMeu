using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicaVeterinaria.Models
{
    public class Donos {
        public Donos()
        {
            ListaDeAnimais = new HashSet<Animais>();
        }


        [Key]
        public int DonoID { get; set; }

        [Required]
        public string Nome { set; get; }

        [Required]
        public string NIF { get; set; }

        //*****************************************************************
        // criarum atributo para ligar este atributo à BD de autenticação
        //*****************************************************************
        public string Username { get; set; } //corresponde ao LOGIN


        // especificar que um DONO tem muitos ANIMAIS
        public ICollection<Animais> ListaDeAnimais { get; set; }
    }
}