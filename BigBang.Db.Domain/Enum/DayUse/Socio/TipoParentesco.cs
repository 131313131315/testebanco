using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.DayUse.Socio
{
    public enum TipoParentesco
    {
        [Display(Name = "Filho (a)")]
        Filho = 1,
        [Display(Name = "Mãe")]
        Mae = 2,
        [Display(Name = "Pai")]
        Pai = 3,
        [Display(Name = "Cunhado (a)")]
        Cunhado = 4,
        [Display(Name = "Esposo (a)")]
        Esposo = 5,
        [Display(Name = "Enteado (a)")]
        Enteado = 6,
        [Display(Name = "Irmão")]
        Irmao = 7,
        [Display(Name = "Neto (a)")]
        Neto = 8,
        [Display(Name = "Sobrinho (a)")]
        Sobrinho = 9,
        [Display(Name = "Padrasto")]
        Padastro = 10,
        [Display(Name = "Madastra")]
        Madastra = 11,
        [Display(Name = "Namorado (a)")]
        Namorado = 12,
        [Display(Name = "Primo (a)")]
        Primo = 13,
        [Display(Name = "Sogro (a)")]
        Sogro = 14,
        [Display(Name = "Tio (a)")]
        Tio = 15,
        [Display(Name = "Avô - Avó ")]
        Avo = 16,
        [Display(Name = "Genro")]
        Genro = 17,
        [Display(Name = "Nora")]
        Nora = 18
    }
}
