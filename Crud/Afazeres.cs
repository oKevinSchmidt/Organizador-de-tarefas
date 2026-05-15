namespace Crud
{
    public class Afazeres
    {
        public string Tarefa {  get; set; }

        public Afazeres(string Tarefa)
        {
            this.Tarefa = Tarefa;
           
        }

        public override string ToString()
        {
            return Tarefa;

        }

    }
}
