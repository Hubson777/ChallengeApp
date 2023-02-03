string name = "Ewa";
bool female = true;
int age = 33;

if(age < 30 && female == true)
{
    Console.WriteLine("kobieta, poniżej lat 30");
}
else if (name == "Ewa" && age == 33) 
{
    Console.WriteLine("Ewa, lat 33");
} 
else if (age < 18 && female == false) { Console.WriteLine("niepełnoletni mężczyzna");
}