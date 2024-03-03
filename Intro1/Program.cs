// See https://aka.ms/new-console-template for more information
using Test1.Business;
using Test1.DataAccess.Concrates;
using Test1.Entities;

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

CourseManager courseManager = new(new DapperCourseDal());

List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


IndividualCustomer customer1 = new IndividualCustomer();

customer1.Id = 1;
customer1.NationalIdentity = "12345678";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();

customer2.Id = 2;
customer2.NationalIdentity = "58494815";
customer2.FirstName = "Özgür";
customer2.LastName = "atılgan";
customer2.CustomerNumber = "405961";

CoorporateCustomer customer3 = new CoorporateCustomer();

customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "65447";
customer3.TaxNumber = "55917851951";

CoorporateCustomer customer4 = new CoorporateCustomer();

customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "985151";
customer4.TaxNumber = "234581681";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

