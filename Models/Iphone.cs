namespace DesafioPOO.Models;

    // TODO: Herdar da classe "Smartphone"
    // DONE!
    public class Iphone : Smartphone 

    {
         public Iphone (string numero, string model, string imei, int memory) : base(numero, model, imei, memory)
         {

         }
    
    
        
    // TODO: Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine("Instalando");
    }
    
    }
