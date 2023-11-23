<Query Kind="Statements">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

var demo = new Demo();
// 但是会发现，对于类的实例，无法直接调用 Foo 方法
//demo.Foo();
// 正确的方法是，对接口对象调用这一方法
((IFoo)demo).Foo();

#region 思考

// 设想一下，如果类 Demo 实现了两个接口 IFoo1 与 IFoo2
// 两个接口都拥有 Foo 方法，且都提供了默认实现
// 那么如果调用类的 Foo 方法，会调用哪个？

// 所以接口的拥有默认实现的方法要求必须在接口对象上调用

#endregion

interface IFoo
{
    void Foo() => Console.WriteLine($"This is the default impl of {nameof(Foo)} method");
}

class Demo : IFoo
{
    // 实现接口的类不需要实现接口中拥有默认实现的方法
}