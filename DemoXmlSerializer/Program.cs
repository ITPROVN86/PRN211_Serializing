using DemoXmlSerializer;
using System.Xml.Serialization;

Person p1 = new Person() { Name = "David", Age = 34 };
var xs = new XmlSerializer(typeof(Person));
//Serialize
using Stream s1 = File.Create("persion.xml");
xs.Serialize(s1, p1);
s1.Close();
//Deserialize
using Stream s2 = File.OpenRead("persion.xml");
var p2 = (Person)xs.Deserialize(s2);
Console.WriteLine("***Person Info***");
Console.WriteLine($"Name: {p2.Name}, Age: {p2.Age}");
Console.WriteLine("***persion.xml***");
string xmlData = File.ReadAllText("persion.xml");
Console.WriteLine(xmlData);
