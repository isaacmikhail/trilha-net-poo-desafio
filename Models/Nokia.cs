namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {// TODO: Sobrescrever o método "InstalarAplicativo"
       
       public Nokia (string numero, string model, string imei, int memory) : base(numero, model, imei, memory)
         {

         }
       
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando");
        }
    }
}