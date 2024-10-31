



//Girilen sayının tek-çift kontrolü
/*
int a;
a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("a çift sayıdır.");
}
else if (a % 2 == 1)
{
    Console.WriteLine("a tek sayıdır");
}

Console.ReadKey();
*/





// 1 - 10 arası girilen sayıyı harflerle ekrana yazma
/*
int sayi;
Console.WriteLine("1 il 10 arası sayı giriniz: ");
sayi = int.Parse(Console.ReadLine());

switch(sayi)
{
    case 1:
        Console.WriteLine("BİR");
        break;  

    case 2:
        Console.WriteLine("İKİ");
        break;
    case 3:
        Console.WriteLine("ÜÇ");
        break;
    case 4:
        Console.WriteLine("DÖRT");
        break;
    case 5:
        Console.WriteLine("BEŞ");
        break;
    case 6:
        Console.WriteLine("ALTI");
        break;
    case 7:
        Console.WriteLine("YEDİ");
        break;
    case 8:
        Console.WriteLine("SEKİZ");
        break;
    case 9:
        Console.WriteLine("DOKUZ");
        break;
    case 10:
        Console.WriteLine("ON");
        break;
    default: Console.WriteLine("1 ile 10 arasında sayı giriniz!"); break;

}
*/


//Kullanıcı bilgilerine bağlı olarak giriş başarılı - başarısız durumu oluşturma
/*

Console.WriteLine("Kullanıcı Adı: ");
string kullanıcı_ad = Console.ReadLine();
Console.WriteLine("Şifre: ");
string şifre = Console.ReadLine();

if (kullanıcı_ad == "Admin" && şifre == "Admin_32453@")
{
    Console.WriteLine("Giriş başarılı. ");
}
else
{
    Console.WriteLine("Giriş başarısız.");
}
Console.ReadKey();
*/


//Sıcaklık durumlarına göre ekran normal,sıcak çok sıcak , kavurucu sıcak yazma durumları
/*
int sıcaklık;
Console.WriteLine("Hava sıcaklığını giriniz: ");
sıcaklık = int.Parse(Console.ReadLine());

if (10 < sıcaklık && sıcaklık < 20)
{
    Console.WriteLine("NORMAL.");
}
else if (20 < sıcaklık && sıcaklık < 30)
{
    Console.WriteLine("SICAK.");
}
else if (30 < sıcaklık && sıcaklık < 40)
{
    Console.WriteLine("ÇOK SICAK.");
}
else
{
    Console.WriteLine("KAVURUCU SICAKLIK.");
}
Console.ReadKey();
*/


































































































