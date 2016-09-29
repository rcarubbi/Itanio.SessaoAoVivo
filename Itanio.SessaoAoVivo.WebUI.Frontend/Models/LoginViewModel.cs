using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.WebUI.Frontend.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Uf { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [UIHint("Senha")]
        public string Senha { get; set; }

        public bool LembrarMe { get; set; }

        internal static Usuario ToEntity(LoginViewModel viewModel)
        {
            return new Usuario
            {
                Nome = viewModel.Nome,
                DataCriacao = DateTime.Now,
                Ativo = true,
                Cidade = viewModel.Cidade,
                Email = viewModel.Email,
                Senha = viewModel.Senha,
                UF = viewModel.Uf,
                Nick = viewModel.Email.Replace('@', '_').Replace('.', '_')
            };
        }

    
    }
}
