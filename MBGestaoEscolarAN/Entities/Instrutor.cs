namespace MBGestaoEscolarAN.Entities
{
    public class Instrutor:Pessoa
    {
        public int InstrutorId { get; set; }
        public string FormacaoAcademia {  get; set; }
        public string Especialidade { get; set; }
        public decimal ValorHoraAula {  get; set; }
        public int StatusInstrutor { get; set; }

    }
}
