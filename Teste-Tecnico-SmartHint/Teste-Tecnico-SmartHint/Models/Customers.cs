using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste_Tecnico_SmartHint.Models
{
    public class Customers
    {
        public Customers()
        {
            Is_free = false;
            Is_blocked = false;
        }

        [Display(Name = "Código")]
        [Column("Id")]
        public Guid Id { get; set; }

        [Display(Name = "Nome completo ou Razão Social do Cliente")]
        [Column("Name")]
        public string Name { get; set; }

        [Display(Name = "E-mail do Cliente")]
        [Column("Email")]
        public string Email { get; set; }

        [Display(Name = "Telefone do Cliente")]
        [Column("Telephone")]
        public string Telephone { get; set; }

        public DateTime Created_at { get; set; }

        [Display(Name = "Selecione o tipo de Pessoa")]
        [Column("Type")]
        public string Type { get; set; }

        [Display(Name = "Insira o CPF ou o CNPJ do Cliente")]
        [Column("CPF/CNPJ")]
        public string CPF_CNPJ { get; set; }

        [Display(Name = "Inscrição Estadual do Cliente, selecionar Isento caso assim for.")]
        [Column("StateRegistration")]
        public string StateRegistration { get; set; }

        public bool Is_free { get; set; }

        [Display(Name = "Selecione o gênero do Cliente")]
        [Column("Gender")]
        public string Gender { get; set; }

        [Display(Name = "Data de nascimento do Cliente")]
        [Column("Birthdate")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Bloqueio o acesso do Cliente na sua Loja")]
        [Column("Is_blocked")]
        public bool Is_blocked { get; set; }

        [Display(Name = "Cadastre a senha de acesso do seu Cliente")]
        [Column("Password")]
        public string Password { get; set; }
    }
}