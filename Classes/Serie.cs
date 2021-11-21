namespace Series
{
    public class Serie:EntidadeBase
    {
        public Genero Genero {get; protected set;}
        public string Titulo {get; protected set;}
        public string Descricao {get; protected set;}
        public int Ano {get; protected set;}
        public bool Excluido {get; protected set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
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

        public void Excluir(){
            this.Excluido = true;
        }
    }
}