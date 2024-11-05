<Query Kind="Statements">
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

#region Array

// 1D Array
int[] array = new int[5];
array[0] = 1;
array[1] = 2;
array[2] = 3;
array[3] = 4;
array[4] = 5;

#endregion

#region List

// var list = new List<int>(20);
List<int> list = [1, 4, 2, 8, 5, 7];

//try better approaches
list.AddRange([9, 6, 3]);
list.FindIndex(x => x > 8);
list.TrueForAll(x => x > 0);         // All, Count > 0, IndexOf == -1
list.RemoveAll(x => x > 5 && x < 8); // Where + ToList
list.ConvertAll(x => x.ToString());  // Select + ToList
list.Reverse();                      // Reverse (LINQ) + ToList

list.Sort();
//list.IndexOf(5);
list.BinarySearch(5);

// fastest way to iterate through a list
foreach (var n in CollectionsMarshal.AsSpan(list))
{
    // do something...
}

#endregion