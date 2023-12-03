using System.Security;

namespace Dio.Async.Programming;

internal class Cozinha
{
    public void FazerComida()
    {
        FritarOvo();
        CozinharArroz();        
    }
  
    public async Task FazerComidaAsync()
    {
       await Task.WhenAll(FritarOvoAsync(),CozinharArrozAsync());  
    }

    public void CozinharArroz()
    {
        Console.WriteLine("Cozinhando o arroz");
        Thread.Sleep(10000);
        Console.WriteLine("Arroz cozido");
    }

    public void FritarOvo()
    {
        Console.WriteLine("Fritando O Ovo");
        Thread.Sleep(5000);
        Console.WriteLine("Ovo Frito");
    }

    public async Task CozinharArrozAsync()
    {
        await Console.Out.WriteLineAsync("Cozinhando o arroz");
        await Task.Delay(10000);
        await Console.Out.WriteLineAsync("Arroz cozido");
    }

    public async Task FritarOvoAsync()
    {
        await Console.Out.WriteLineAsync("Fritando O Ovo");
        await Task.Delay(5000);
        await Console.Out.WriteLineAsync("Ovo Frito");
    }    
}
