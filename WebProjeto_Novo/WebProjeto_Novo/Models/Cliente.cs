using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebProjeto_Novo.Models
{
    public class Cliente
    {
        public int Cod_Cli { get; set; }

        [Display(Name = "Nome de Usuário")]
        [Required(ErrorMessage = "Digite o Nome do usuário e tente novamente")]
        [StringLength(50, MinimumLength = 3)]
        public String Nome_Cli { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Preencha o campo telefone e tente novamente")]
        
        public int Tell_Cli { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Preencha o campo email e tente novamente")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public String Email_cli { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Preencha o campo cpf e tente novamente")]
        [StringLength(11)]
        public string CPF_Cli { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Preencha o campo data de nascimento e tente novamente")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data_de_Nascimento { get; set; }



    }
}
