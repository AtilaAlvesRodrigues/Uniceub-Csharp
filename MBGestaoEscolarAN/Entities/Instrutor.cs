﻿namespace MBGestaoEscolarAN.Entities
{
    public class Instrutor
    {
        public int InstrutorId { get; set; }
        public string Nome {  get; set; }
        public string Cpf {  get; set; }
        public string Email {  get; set; }
        public string Telefone {  get; set; }
        public string FormacaoAcademia {  get; set; }
        public string Especialidade { get; set; }
        public decimal ValorHoraAula {  get; set; }
        public int StatusInstrutor { get; set; }

    }
}
