using DesafioPOO.Models;

Console.WriteLine("Iphone test");
Smartphone iphone = new Iphone(numero:"1234567", model: "model 10", imei: "34457789", memory: 128);
iphone.InstalarAplicativo("WhatsApp");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Nokia test");
Smartphone nokia = new Nokia(numero: "1234567", model: "nk 10", imei: "345475", memory: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();

// TODO: Realizar os testes com as classes Nokia e Iphone