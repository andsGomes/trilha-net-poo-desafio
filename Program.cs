using System.Diagnostics.CodeAnalysis;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Samrtphone Nokia");
Smartphone nokia = new Nokia(numero: "(11) 9761472-66", modelo: "Nokia 5200 Xpressmusic", imei: "11-000000X0003", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("");

await Chamada(async () => { nokia.ReceberLigacao(); await Task.CompletedTask; }, 3000);


Console.WriteLine("");
 await Task.Delay(5000);

Console.WriteLine("Samrtphone Iphone");
Smartphone iphone = new Iphone(numero: "(11) 9761472-66", modelo: "Iphone 15", imei: "11-000000X0003", memoria: 64);

iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
Console.WriteLine("");

await Chamada(async () => { iphone.ReceberLigacao(); await Task.CompletedTask; }, 3000);



static async Task Chamada(Func<Task> metodo, int time)
{
    await Task.Delay(time);
    await metodo();
}