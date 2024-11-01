<Query Kind="Statements" />

#region ArrayList

var list = new ArrayList();
list.Add("Item 1");
list.Add("Item 2");
list.Add("Item 3");

// Iteration
foreach (var item in list)
    Console.WriteLine(item);

// Use LINQ
var item1 = list.Cast<string>().FirstOrDefault(x => x.Contains("1"));
Console.WriteLine(item1);

var item2 = list.OfType<string>().FirstOrDefault(x => x.Contains("2"));
Console.WriteLine(item2);

#endregion

#region Hashtable

var hashtable = new Hashtable();

// Common usages
hashtable.Add("Key1", "Value1");
hashtable.Add("Key2", 2);
hashtable.Add("Key3", true);
hashtable.Add(42, "42");

var value1 = hashtable["Key1"];
Console.WriteLine(value1);

var value4 = hashtable[42];
Console.WriteLine(value4);

var hasKey4 = hashtable.ContainsKey("Key4");
Console.WriteLine(hasKey4);

// Iteration
foreach (DictionaryEntry entry in hashtable)
    Console.WriteLine($"{entry.Key}: {entry.Value}");

#endregion
