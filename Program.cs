using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "74 99999 9999",modelo: "Windows Phone 3", imei: "A1F42T748T88", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instragram");
nokia.InstalarAplicativo("Zapzap");
Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "74 88888 8888", modelo: "Iphone XS", imei: "DQ5FGG5WEF10", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Subway Surfers");
Console.WriteLine();

Console.ReadLine();