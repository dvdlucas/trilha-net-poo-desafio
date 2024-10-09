using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("123456789", "Tijolão", "ABC1234", 16);
nokia.Ligar();
nokia.InstalarAplicativo("ZapZap");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("987654321", "Iphone16", "DEF1234", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");