using DesafioPOO.Models;



Console.WriteLine("SMARTPHONE NOKIA:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "5432111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("SMARTPHONE IPHONE");
Smartphone iphone = new Iphone(numero : "400235", modelo: "Modelo 2", imei: "6631341", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TELEGRAM");
