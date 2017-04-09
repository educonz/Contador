using Base.Core.EntityFramework;

namespace Contador.Domain
{
    public class Contexto : ContextoBase
    {
        public Contexto() : base("contador-prod")
        {
        }
    }
}
