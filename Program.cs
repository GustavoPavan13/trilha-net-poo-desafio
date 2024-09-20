using DesafioPOO.Models;

Smartphone Nokia = new Nokia ( numero: "0000000", modelo: "1", imei: "37812631287", memoria: 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Smartphone Apple = new Iphone ( numero: "11111111", modelo: "2", imei: "56235712", memoria: 256);
Apple.ReceberLigacao();
Apple.InstalarAplicativo("Instagram");


