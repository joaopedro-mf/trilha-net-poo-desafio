using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var celularNokia = new Nokia("9912-5003","Nokia", "123123123", 64 );

var celularIphone = new Iphone("9912-5003", "Iphone 13", "123123123", 64);

celularNokia.ReceberLigacao();

celularIphone.InstalarAplicativo("teste");