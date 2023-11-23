<Query Kind="Statements" />

interface IFoo
{
    string GetValue()
    {
        return GetNumber().ToString();
    }

    // private 方法几乎只用于其他 public 方法的默认实现
    private int GetNumber() => 42;
    
    string GetMessage()
    {
        return $"Flag: {GetBool()}, Byte: {GetByte()}";
    }

    // protected 方法与 private 的用法基本相同，但是允许子类提供定制
    protected bool GetBool();
    protected virtual byte GetByte() => 65;
}

class Foo : IFoo
{
    bool IFoo.GetBool()
    {
        return false;
    }
}