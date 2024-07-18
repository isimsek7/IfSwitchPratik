
Console.WriteLine("Ruya manavinda fiyatlar cok uygun!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL ");
Console.WriteLine("Cilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diger butun meyveler = 4 TL");

Console.Write("Hangi meyveyi satin almak istersin?  (Elma/ Armut /Cilek/ Muz/ Diger):");
string secim = Console.ReadLine();
string yeniSecim = secim.ToLower();

if (yeniSecim == "muz")
{
    Console.WriteLine("3 TL");
}
else if (yeniSecim == "elma")
{
    Console.WriteLine("2 TL");                     //If kullanimi, her satirda kucuk harflerle yeniden atadigimiz yeniSecim alanini yazmamizi 
}
else if (yeniSecim == "cilek")                     // gerektiriyor ve yine her satirda yeniden acmak zorunda kaldigimiz else if ve bodyden
{
    Console.WriteLine("2 TL");                     // olusuyor. Ayni zamanda tek bir islem yapiyoruz ve tek alan kullaniyoruz, if burada hem 
}
else if (yeniSecim == "armut")                     // gereksizce var oluyor hem de bu program icin fark olusturmayacak olsa da, islem satirlarini
{
    Console.WriteLine("3 TL");                     // prensip olarak her seferinde tek tek kontrol ediyor ve bu da bize, hissedilmese de
}                                                  // performans kaybi yasatiyor.       
else
{
    Console.WriteLine("4 TL");
}
Console.WriteLine("==========================================================================");

//Burada ayni uygulamayi switch ile kodluyoruz.

Console.WriteLine("Ruya manavinda fiyatlar cok uygun!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL ");
Console.WriteLine("Cilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diger butun meyveler = 4 TL");

Console.Write("Hangi meyveyi satin almak istersin?  (Elma/ Armut /Cilek/ Muz/ Diger):");
string secim2 = Console.ReadLine();
string yeniSecim2 = secim2.ToLower();

switch (yeniSecim2)
{
    case "elma":
        Console.WriteLine("2 TL");                         // Ote yandan, switch bizden alani tanitirken bir kere aliyor ve tekrarini istemiyor
        break;
    case "armut":                                          // ayni zamanda daha okunabilir ve sade bir kod olustururken, calisirken satir satir 
        Console.WriteLine("3 TL");
        break;                                             // gezip dogrulama yapip, diger satira gecip devam etmek yerine, program bir kere
    case "cilek":
        Console.WriteLine("2 TL");                         // calistiginda, dogru olan parcasi uzerinden islem yapiyor. Ben bu uygulama icin
        break;
    case "muz":                                            // switchi kullanim ve gorsel olarak daha rahat ve guzel buldum.
        Console.WriteLine("3 TL");
        break;
    default:
        Console.WriteLine("4 TL");
        break;
            
       
}
 

