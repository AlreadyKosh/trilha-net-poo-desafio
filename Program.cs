using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone celularIphone = new("139967070", "Iphone 15", "555020", 128);
Nokia celularNokia = new("139970008", "110 Preto", "343020", 64);

Console.WriteLine("IPHONE");
celularIphone.DadosCelular();
celularIphone.InstalarAplicativo("TikTok");
celularIphone.ReceberLigacao();
celularIphone.Ligar();
celularIphone.Numero = "1386739070";
celularIphone.DadosCelular();

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("NOKIA");
celularNokia.DadosCelular();
celularNokia.InstalarAplicativo("Youtube");
celularNokia.ReceberLigacao();
celularNokia.Ligar();
celularNokia.Numero = "139767070";
celularNokia.DadosCelular();



