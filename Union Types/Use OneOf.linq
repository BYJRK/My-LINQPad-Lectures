<Query Kind="Statements">
  <NuGetReference>OneOf</NuGetReference>
  <Namespace>OneOf</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <RemoveNamespace>System.Linq.Expressions</RemoveNamespace>
  <RemoveNamespace>System.Text.RegularExpressions</RemoveNamespace>
  <RemoveNamespace>System.Transactions</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

using Pet = OneOf.OneOf<Dog, Cat, Bird>;

Pet pet = new Dog
{
    Name = "Buddy",
    Age = 3
};

var message = pet
    .Match(
        d => $"{d.Name}, {d.Age}",
        c => $"{c.Name}, {(c.IsIndoor ? "indoor" : "outdoor")}",
        b => $"{b.Name}, {(b.CanFly ? "can fly" : "cannot fly")}"
    );
    
Console.WriteLine(message);

class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Bird
{
    public string Name { get; set; }
    public bool CanFly { get; set; }
}

class Cat
{
    public string Name { get; set; }
    public bool IsIndoor { get; set; }
}