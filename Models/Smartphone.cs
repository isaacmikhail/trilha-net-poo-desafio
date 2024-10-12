namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        // DONE!
        private string Model {get;set;}
        private string IMEI{get;set;}
        private int Memory{get; set;}

        public Smartphone(string numero, string model, string imei, int memory)
        {
            Numero = numero;
            Model=model;
            IMEI=imei;
            Memory=memory;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}