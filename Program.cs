using DesafioPOO.Models;

Iphone cel1 = new Iphone("16991345301", "iphone 11", "543151413", 64);
Nokia cel2 = new Nokia("17991345301", "Nokia tijolo", "543245426", 8);

cel1.Ligar();
cel2.ReceberLigacao();

cel1.InstalarAplicativo("WhatsApp");
cel2.InstalarAplicativo("WhatsApp");

// TODO: Realizar os testes com as classes Nokia e Iphone