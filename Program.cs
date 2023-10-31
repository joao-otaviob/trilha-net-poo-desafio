using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("::::::::Iniciando Testes com o modelo Nokia::::::");
Nokia nokia = new("12345", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhastApp");


Console.WriteLine(" ");

Console.WriteLine("::::::::Iniciando Testes com o modelo Iphone::::::");
Iphone iphone = new("67890", "Modelo 13 PRo", "22222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
