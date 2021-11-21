namespace Series
{
    public class Serie:EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}

        private bool Excluido {get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = Descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string ret = "";
            ret += "Genero: " + this.Genero + "\n";
            ret += "Titulo: " + this.Titulo + "\n";
            ret += "Descricao: " + this.Descricao + "\n";
            ret += "Ano: " + this.Ano + "\n";
            ret += "Excluido: " + this.Excluido;

            return ret;
        }

        public string getTitulo()
        {
            return this.Titulo;
        }
        public int getId()
        {
            return this.Id;
        }
        public bool getExcluido(){
            return this.Excluido;
        }
        public void Excluir(){
            this.Excluido = true;
        }
    }
}