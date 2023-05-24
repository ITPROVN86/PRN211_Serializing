using DemoJsonSerializer02;
using System.Text.Json;
string json = @"{
""FullName"":""Mark"",
""Email"":""Mark@gmail.com"",
""Salary"":1000,
}";
var option = new JsonSerializerOptions
{
    WriteIndented = true,
    ReadCommentHandling = JsonCommentHandling.Skip,
    AllowTrailingCommas = true
};
var emp = JsonSerializer.Deserialize<Employee>(json,option);
Console.WriteLine($"Name: {emp.Name}, Email: {emp.Email}, Salary: {emp.Salary}");