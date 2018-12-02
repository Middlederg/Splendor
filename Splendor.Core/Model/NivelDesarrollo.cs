using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Splendor.Core.Model
{
    public enum NivelDesarrollo
    {
        [Display(Name = "Nivel 1")]
        Nivel1 = 1,

        [Display(Name = "Nivel 2")]
        Nivel2 = 2,

        [Display(Name = "Nivel 3")]
        Nivel3 = 3
    }
}
