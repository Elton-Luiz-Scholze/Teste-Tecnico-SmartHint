using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Teste_Tecnico_SmartHint.Models
{
    public class Customers
    {

        public Customers() 
        {
            Created_at = DateTime.Now;
        }

        [Display(Name = "Código")]
        [Column("Id")]
        public Guid Id { get; set; }

        [Display(Name = "Nome completo ou Razão Social do Cliente")]
        [Column("Name")]
        [StringLength(150)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }

        [Display(Name = "E-mail do Cliente")]
        [Column("Email")]
        [EmailAddress(ErrorMessage = "Deve informar um email válido")]
        [StringLength(150)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Email { get; set; }

        [Display(Name = "Telefone do Cliente")]
        [Column("Telephone")]
        [StringLength(14)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [RegularExpression(@"^\(\d{2}\)\d{5}-\d{4}$", ErrorMessage = "O telefone inserido não é válido. Use o formato (##)#####-####.")]
        public string Telephone { get; set; }

        [Display(Name = "Data de criação")]
        [Column("Created_at")]
        [DataType(DataType.Date)]
        public DateTime Created_at { get; set; }

        [Display(Name = "Selecione o tipo de Pessoa")]
        [Column("Type")]
        [Required(ErrorMessage = "Deve selecionar uma opção")]
        public KindOfPersonEnum Type { get; set; }

        [Display(Name = "Insira o CPF ou o CNPJ do Cliente")]
        [Column("CPF/CNPJ")]
        [StringLength(18)]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$|^\d{2}\.\d{3}\.\d{3}\/\d{4}-\d{2}$", ErrorMessage = "O CPF/CNPJ inserido não é válido.")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string CPF_CNPJ { get; set; }

        [Display(Name = "Inscrição Estadual do Cliente, selecionar Isento caso assim for.")]
        [Column("StateRegistration")]
        [StringLength(15, ErrorMessage = "A Inscrição Estadual do cliente deve ter no máximo 12 caracteres.")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{3}$", ErrorMessage = "A Inscrição Estadual não é válida. Use o formato ###.###.###-###")]
        public string StateRegistration { get; set; }

        [Display(Name = "Isento")]
        [Column("Is_Free")]
        public bool Is_free { get; set; }

        [Display(Name = "Selecione o gênero do Cliente")]
        [Column("Gender")]
        public GenderEnum? Gender { get; set; }

        [Display(Name = "Data de nascimento do Cliente")]
        [Column("Birthdate")]
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }

        [Display(Name = "Bloqueio o acesso do Cliente na sua Loja")]
        [Column("Is_blocked")]
        public bool Is_blocked { get; set; }

        [Display(Name = "Cadastre a senha de acesso do seu Cliente")]
        [Column("Password")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 8 e 15 caracteres.")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Password { get; set; }

        [Display(Name = "Confirmação de Senha")]
        [Column("Password Confirm")]
        [Compare("Password", ErrorMessage = "As senhas não conferem.")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string PasswordConfirm { get; set; }

        public enum KindOfPersonEnum
        {
            Fisica,
            Juridica
        }

        public enum GenderEnum
        {
            Feminino,
            Masculino,
            Outro
        }
    }
}