<Query Kind="Statements">
  <Namespace>System.Runtime.InteropServices</Namespace>
</Query>

#region Array

// 1D Array
int[] array1 = new int[5];
array1[0] = 1;
array1[1] = 2;
array1[2] = 3;
array1[3] = 4;
array1[4] = 5;

int[] array2 = [6, 7, 8];
int[] concatArray = [.. array1, .. array2, 9, 10];
var emptyArray = Array.Empty<int>();

// Array Static Methods
Array.Sort(array2); // Order(By) + ToArray
Array.BinarySearch(concatArray, 6);
Array.Reverse(concatArray);
Array.Copy(array1, array2, 3);
Array.Exists(array1, x => x == 6);
Array.ForEach(array1, (x) => Console.WriteLine(x));
var charArray = (char[])Array.CreateInstance(typeof(char), 30);

// Resize
int[] resizeArray = [1, 2, 3];
Array.Resize(ref resizeArray, 5);
resizeArray[3] = 4;
resizeArray[4] = 5;
Console.WriteLine(resizeArray);

// 2D Array & Jagged Array
var twoDArray = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//int[,] twoDArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[][] jaggedArray = [[1, 2, 3], [4, 5], [6, 7, 8], [9]];

// Matrix
//using MathNet.Numerics.LinearAlgebra;
// Matrix<double> mat = Matrix<double>.Build ...

#endregion

#region List

// var list = new List<int>(20);
List<int> list = [1, 4, 2, 8, 5, 7];
list.TrimExcess();

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