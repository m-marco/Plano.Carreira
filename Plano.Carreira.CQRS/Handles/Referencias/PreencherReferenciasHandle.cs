using MediatR;
using Microsoft.EntityFrameworkCore;
using Plano.Carreira.Domain;
using Plano.Carreira.Infra;

namespace Plano.Carreira.CQRS.Handles.Referencias
{
    public class PreencherReferenciaRequest : IRequest<PreencherReferenciaResponse>
    {

    }

    public class PreencherReferenciasHandle : IRequestHandler<PreencherReferenciaRequest, PreencherReferenciaResponse>
    {
        private readonly Context _context;

        public PreencherReferenciasHandle(Context context)
        {
            _context = context;
        }

        public async Task<PreencherReferenciaResponse> Handle(PreencherReferenciaRequest request, CancellationToken cancellationToken)
        {
            var referenciasExistentes = await _context.Referencias.ToListAsync();

            decimal valorInicial = 1707.14m;

            var alfabeto = new List<string> {
                "A", "B", "C", "D", "E", "F", "G", "H", "I","J","K","L","M","N",
                "O","P", "Q","R","S","T","U","V","W","X","Y","Z"
            };

            string referenciaFinal = "X7";
            int numeroReferenciaMinimo = 1;
            int numeroReferenciaMaximo = 7;

            for (int i = numeroReferenciaMinimo; i <= numeroReferenciaMaximo; i++)
            {
                foreach (var letra in alfabeto)
                {
                    string codigoReferencia = $"{letra}{i}";

                    if (codigoReferencia == referenciaFinal)
                    {
                        break;
                    }

                    if (!referenciasExistentes.Any(x => x.Codigo == codigoReferencia))
                    {
                        Referencia novaReferencia = new Referencia
                        {
                            Codigo = codigoReferencia,
                            Valor = valorInicial
                        };

                        await _context.Referencias.AddAsync(novaReferencia);
                    }

                    valorInicial *= 1.014m;
                }
            }

            await _context.SaveChangesAsync();

            return new PreencherReferenciaResponse();
        }
    }

    public class PreencherReferenciaResponse
    {
        public string Msg { get => "Referencias Cadastradas com Sucesso!"; }
    }
}
