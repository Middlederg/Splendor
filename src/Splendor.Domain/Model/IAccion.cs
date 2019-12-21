using System.Collections.Generic;
using System.Linq;

namespace Splendor.Domain
{
    public interface IAccion
    {
        IEnumerable<string> RecursosCogidos();
    }

    public class CogerGemas : IAccion
    {
        private readonly IEnumerable<Gem> gemas;

        public CogerGemas(IEnumerable<Gem> gemas)
        {
            this.gemas = gemas;
        }

        public IEnumerable<string> RecursosCogidos() => gemas.Select(x => nameof(x));
    }

    public class ComprarDesarrollo : IAccion
    {
        private readonly Development desarrollo;
        private readonly Noble noble;

        public ComprarDesarrollo(Development desarrollo, Noble noble)
        {
            this.desarrollo = desarrollo;
            this.noble = noble;
        }

        public IEnumerable<string> RecursosCogidos()
        {
            yield return desarrollo.Path;
            if (noble != null)
                yield return noble.Path;
        }
    }

    public class ReservarDesarrollo : IAccion
    {
        private readonly Development desarrollo;
        private readonly bool conPiezaOro;

        public ReservarDesarrollo(Development desarrollo, bool conPiezaOro)
        {
            this.desarrollo = desarrollo;
            this.conPiezaOro = conPiezaOro;
        }

        public IEnumerable<string> RecursosCogidos()
        {
            yield return desarrollo.Path;
            if (conPiezaOro)
                yield return Gems.Gold.ToString();
        }
    }

}
