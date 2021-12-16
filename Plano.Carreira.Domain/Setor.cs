namespace Plano.Carreira.Domain
{
    public class Setor
    {
        public int Id { get; set; }
        public int DepartamentoId { get; set; }
        public string Nome { get; set; }

        public Departamento Departamento { get; set; }

        public Setor()
        {

        }
    }
}
