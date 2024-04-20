using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone15 = new Iphone(numero: "+5544958547895", modelo: "Iphone15", imei: "4587", memoria: 128);
iphone15.Ligar();
iphone15.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia8 = new Nokia(numero: "+5588996633221", modelo: "Nokia8", imei: "5697", memoria: 64);
nokia8.ReceberLigacao();
nokia8.InstalarAplicativo("Chrome");
