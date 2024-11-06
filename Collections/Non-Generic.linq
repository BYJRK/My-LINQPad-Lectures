<Query Kind="Statements" />

#region ArrayList

var list = new ArrayList();
list.Add("Item 1");
list.Add("Item 2");
list.Add("Item 3");
//ArrayList list2 = ["item 1", 2, true, null];

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

// Creating a Hashtable
var hashtable = new Hashtable();

// Adding items
hashtable.Add("Key1", "Value1");
hashtable.Add("Key2", 2);
hashtable.Add("Key3", true);
hashtable.Add(42, "42");

// Accessing values
var value1 = hashtable["Key1"];
Console.WriteLine(value1);

// Checking keys/values
var hasKey4 = hashtable.ContainsKey("Key4");
var hasValue = hashtable.ContainsValue("Value1");

// Removing an item
hashtable.Remove("Key2");

// Checking size
Console.WriteLine($"Hashtable count: {hashtable.Count}");

// Iteration
foreach (DictionaryEntry entry in hashtable)
    Console.WriteLine($"{entry.Key}: {entry.Value}");

// Clearing the Hashtable
hashtable.Clear();

// Thread-safe synchronized version
var syncHashtable = Hashtable.Synchronized(hashtable);

// Important notes:
// 1. Hashtable is not type-safe
// 2. Keys and values can be of different types
// 3. Not recommended for modern C# - use Dictionary<,> (or ConcurrentDictionary<,>) instead

#endregion
