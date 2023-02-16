using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade(9f);
employee.AddGrade("20");
employee.AddGrade(2);
employee.AddGrade(21d);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();

Console.WriteLine("Statystyki wygenerowane przez pętle forech");
Console.WriteLine($"Average: {statistics.Average:N1}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("Statystyki wygenerowane przez pętle for");
Console.WriteLine($"Average: {statistics1.Average:N1}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine("Statystyki wygenerowane przez pętle Do While");
Console.WriteLine($"Average: {statistics2.Average:N1}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("Statystyki wygenerowane przez pętle While");
Console.WriteLine($"Average: {statistics3.Average:N1}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

