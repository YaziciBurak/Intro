// See https://aka.ms/new-console-template for more information
using Intro1.Business;
using Intro1.Entities;

Console.WriteLine("Hello, World!");

string message = "Kredi";
int term = 12;
double amount = 10000;

bool isAuthenticated = false;
Console.WriteLine(message);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton-->Sisteme Giriş Yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
//string[] loans2 = new string[6];
//loans2 = "Kredi 1" ;

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}




Console.WriteLine("Kod bitti");

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


