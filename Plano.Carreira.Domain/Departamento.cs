namespace Plano.Carreira.Domain
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Setor> Setores { get; set; }

        public Departamento()
        {
            Setores = new List<Setor>();
        }
    }
}