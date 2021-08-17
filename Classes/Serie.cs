namespace AppCadastro
{
    public class Serie : EntityBase {

        //Atributos
        public Serie(Genero genero, string titulo, int ano) 
        {
            this.Genero = genero;
                this.Titulo = titulo;
                this.Ano = ano;
               
        }
                private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descrição { get; set; }

        private int Ano { get; set; }

        //Metodos
        public Serie(int Id, Genero genero, string titulo, string descrição, int ano) {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descrição = descrição;
            this.Ano = ano;

        }

        public override string ToString(){
            string retornar = "";
            retornar += "Genero" + this.Genero;
            retornar += "Titulo" + this.Titulo;
            retornar += "Descrição" + this.Descrição;
            retornar += "Ano de inicio" + this.Ano;
            return retornar;
            
        }

        public string RetornaTitulo(){
            return this.Titulo;
        }

        public int RetornaId(){
            return this.Id;
        }


    }

  
}