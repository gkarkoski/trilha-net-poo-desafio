using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "97548-1356", modelo: "Nokia 3310", imei: "EAC-143-ER5-TT7", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("PlayStore");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "97548-1356", modelo: "Iphone 12", imei: "JKG-095-HGW-897-ZC2", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("AppStore");