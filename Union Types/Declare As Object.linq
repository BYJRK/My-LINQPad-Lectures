<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <RemoveNamespace>System.Linq.Expressions</RemoveNamespace>
  <RemoveNamespace>System.Text.RegularExpressions</RemoveNamespace>
  <RemoveNamespace>System.Transactions</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

object pet = new Dog
{
    Name = "Buddy",
    Age = 3
};

var message = pet switch
{
    Dog d => $"{d.Name}, {d.Age}",
    Bird b => $"{b.Name}, {(b.CanFly ? "can fly" : "cannot fly")}",
    Cat c => $"{c.Name}, {(c.IsIndoor ? "indoor" : "outdoor")}",
    _ => throw new InvalidOperationException("Unknown pet type")
};

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