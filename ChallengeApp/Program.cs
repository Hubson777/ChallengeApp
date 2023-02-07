/// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek oraz punkty w postaci liczb całkowitych
/// 
/// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakesu od 1 do 10
/// 
/// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen a następnie wyświetli jego dane oraz wynik
/// 

using ChallengeApp;

Employee employee1 = new Employee("Adam", "Szkic", 65, 0);
Employee employee2 = new Employee("Monika", "Kartka", 28, 0);
Employee employee3 = new Employee("Zuzia", "Ołówek", 30, 0);

employee1.Addpoint(5);
employee1.Addpoint(2);
employee1.Addpoint(1);
employee1.Addpoint(7);
employee1.Addpoint(8);

employee2.Addpoint(2);
employee2.Addpoint(5);
employee2.Addpoint(9);
employee2.Addpoint(5);
employee2.Addpoint(5);

employee3.Addpoint(11);
employee3.Addpoint(1);
employee3.Addpoint(1);
employee3.Addpoint(4);
employee3.Addpoint(7);

var result1 = employee1.Sum;
var result2 = employee2.Sum;
var result3 = employee3.Sum;
var emplData1 = employee1.emplData;
var emplData2 = employee2.emplData;
var emplData3 = employee3.emplData;

List<string> employess = new List<string> { emplData1, emplData2, emplData3 };
List<int> wyniki = new List<int> { result1, result2, result3 };
int maxPoints = wyniki.Max();
List<string> winner = new List<string>();

foreach (var res in wyniki.Select((value, i) => new { i, value }))
{
    var value = res.value;
    var index = res.i;
    Console.WriteLine( value + " <--- " + employess[index] );
    if(value == maxPoints)
    {
        winner.Add(employess[index]);
    }
}
Console.WriteLine("Zwycięzca to: " + String.Join(", ", winner) + " Zdobyte punkt: " + maxPoints);