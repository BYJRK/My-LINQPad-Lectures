<Query Kind="Statements">
  <RuntimeVersion>8.0</RuntimeVersion>
</Query>

#region Shuffle

var array = Enumerable.Range(1, 20).ToArray();

// Random 现在自带了一个 Shuffle 洗牌算法
Random.Shared.Shuffle(array);

array.Dump();

#endregion

#region Lambda Expression with Default Parameter Values

// 现在声明 Lambda 表达式可以添加默认参数值了
var func = (int x = 10) => Console.WriteLine(x);

func();
func(20);

#endregion