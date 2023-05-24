using DemoXmlSerializer02;
using System.Xml.Serialization;

string fileName = "people.xml";
//create an object graph
var people = new List<Person> {
    new Person(30000M){FirstName="Alice", LastName="Smith",DateOfBirth=new DateTime(1972,3,16)},
    new Person(20000M){FirstName="Charlie", LastName="Cox",DateOfBirth=new DateTime(1984,5,4),Children = new HashSet<Person> {
        new Person(0M){FirstName="Sally", LastName="Cox",DateOfBirth=new DateTime(2003,7,12)} } }
    };
//Create object that will format a List of Persons as XML
var xs = new XmlSerializer(typeof(List<Person>));
//Create a file to write to
using FileStream stream = File.Create(fileName);
//serialize the object graph to the stream
xs.Serialize(stream, people);
Console.WriteLine("Written {0} bytes of XML to {1}", new FileInfo(fileName).Length, fileName);
stream.Close();
Console.WriteLine(new string('*', 30));
//Display the serialized object graph
Console.WriteLine(File.ReadAllText(fileName));
Console.WriteLine(new string('*', 30));
//Deserializing with XML
using FileStream xmlLoad = File.Open(fileName, FileMode.Open);
//Deserializing and cast the object graph into a List of Person
var loadedPeople = (List<Person>)xs.Deserialize(xmlLoad);
foreach (var item in loadedPeople)
{
    Console.WriteLine($"{item.LastName} has {item.Children?.Count??0} children.");
}
xmlLoad.Close();