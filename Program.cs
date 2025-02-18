using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero:"123456",modelo: "Modelo A",imei: "9999999",memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Smartphone iphone = new Iphone(numero: "654321",modelo:"Modelo B",imei:"8888888",memoria:256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
