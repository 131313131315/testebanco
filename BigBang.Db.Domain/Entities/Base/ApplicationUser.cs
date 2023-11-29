using Db.Domain.Entities.Base.UsuarioEmpresa;
using Db.Domain.Entities.Base.UsuarioModulo;
using Domain.Entities.Cadastros.PapelUsuario;
using Domain.Entities.Cadastros.Setor;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Cadastros.Base
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public bool UtilizaGarcon { get; set; }
        public bool UsuarioPark { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }
        public int SetorId { get; set; }
        public Setor Setor { get; set; }
        public bool Ativo { get; set; }
        public ICollection<UsuarioEmpresa> Empresas { get; set; }
        public ICollection<UsuarioModulos> Modulos { get; set; }
        public async Task<IdentityResult> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateAsync(this);
            return userIdentity;
        }
    }
}
