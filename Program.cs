using SitesmaSmartPhone.Models;

try
{
    Smartphone smartphone;
    Iphone apple = new Iphone();
    Nokia nokia = new Nokia();


    System.Console.WriteLine("Qual seu Smartphone?");
    string Modelo = Console.ReadLine();
    System.Console.WriteLine("Qual seu numero?");
    string Number = Console.ReadLine();
    System.Console.WriteLine("Qual seu Imei?");
    string Imei = Console.ReadLine();
    System.Console.WriteLine("Qual sua Memoria?");
    int Memoria = int.Parse(Console.ReadLine());


    if(Modelo == "Iphone" || Modelo == "iphone"){
        apple = new Iphone(Modelo, Number, Imei, Memoria);
        System.Console.WriteLine(apple.ToString());
    }else{
        nokia = new Nokia(Modelo, Number, Imei, Memoria);
        System.Console.WriteLine(nokia.ToString());
    }

    System.Console.WriteLine("Voce quer fazer uma ligacao? (s/n)");
    char resp = char.Parse(Console.ReadLine());

    if(Modelo == "Iphone" || Modelo == "iphone" && resp == 's' || resp == 'S'){
        apple.Ligar();
    }else if(Modelo == "Nokia" || Modelo == "nokia" && resp == 's' || resp == 'S'){
        nokia.Ligar();
    }else{
        apple.ReceberLigacao();
    }
  



}catch(Exception x){
    System.Console.WriteLine("Erro na excessao!");
    System.Console.WriteLine(x.Message);
}