using Contador.Contracts;

namespace Contador.Domain.TiposPagamento.Adaptadores
{
    public class TipoPagamentoAdapter : ITipoPagamentoAdapter
    {
        public TipoPagamentoDto ToDto(TipoPagamento entity)
        {
            return new TipoPagamentoDto
            {
                Id = entity.Id,
                Descricao = entity.Descricao,
                Usuario = entity.Usuario
            };
        }

        public TipoPagamento ToEntity(TipoPagamentoDto dto)
        {
            return new TipoPagamento
            {
                Id = dto.Id,
                Descricao = dto.Descricao,
                Usuario = dto.Usuario
            };
        }
    }
}
