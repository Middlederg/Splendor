using System.Collections.Generic;
using System.Linq;

namespace Splendor.Core.Model
{
    public interface IAccion
    {
        IEnumerable<string> RecursosCogidos();
    }

    public class CogerGemas : IAccion
    {
        private readonly IEnumerable<Gema> gemas;

        public CogerGemas(IEnumerable<Gema> gemas)
        {
            this.gemas = gemas;
        }

        public IEnumerable<string> RecursosCogidos() => gemas.Select(x => nameof(x));
    }

    public class ComprarDesarrollo : IAccion
    {
        private readonly Desarrollo desarrollo;
        private readonly Noble noble;

        public ComprarDesarrollo(Desarrollo desarrollo, Noble noble)
        {
            this.desarrollo = desarrollo;
            this.noble = noble;
        }

        public IEnumerable<string> RecursosCogidos()
        {
            yield return desarrollo.Ruta;
            if (noble != null)
                yield return noble.Ruta;
        }
    }

    public class ReservarDesarrollo : IAccion
    {
        private readonly Desarrollo desarrollo;
        private readonly bool conPiezaOro;

        public ReservarDesarrollo(Desarrollo desarrollo, bool conPiezaOro)
        {
            this.desarrollo = desarrollo;
            this.conPiezaOro = conPiezaOro;
        }

        public IEnumerable<string> RecursosCogidos()
        {
            yield return desarrollo.Ruta;
            if (conPiezaOro)
                yield return Gema.Oro.ToString();
        }
    }

}
