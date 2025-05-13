namespace MBGestaoEscolarAN.Entities
{
    public class Curso
    {
        private int cursoID;
        private string nome;
        private string codigo;
        private string descricao;
        private int cargaHoraria;
        private string modalidade;
        private string trilha;
        private int pontosCap;
        private string statusCurso;
        private int coordenadorID;

        public int CursoID { get => cursoID; set => cursoID = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        public string Modalidade { get => modalidade; set => modalidade = value; }
        public string Trilha { get => trilha; set => trilha = value; }
        public int PontosCap { get => pontosCap; set => pontosCap = value; }
        public string StatusCurso { get => statusCurso; set => statusCurso = value; }
        public int CoordenadorID { get => coordenadorID; set => coordenadorID = value; }
    }
}
