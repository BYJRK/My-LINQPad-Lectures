<Query Kind="Statements">
  <Namespace>System.Runtime.CompilerServices</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <RemoveNamespace>System.Linq.Expressions</RemoveNamespace>
  <RemoveNamespace>System.Text.RegularExpressions</RemoveNamespace>
  <RemoveNamespace>System.Transactions</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
  <RuntimeVersion>11.0</RuntimeVersion>
</Query>

var value = GetValue();

return;

IntOrBool GetValue() => 42;

//union IntOrBool(int, bool);

[Union]
readonly struct IntOrBool
{
    private readonly int _value;
    private readonly bool _isBool;

    public IntOrBool(int value)
    {
        _value = value;
        _isBool = false;
    }

    public IntOrBool(bool value)
    {
        _value = 0;
        _isBool = true;
    }

    public object Value => _isBool ? (object)(_value == 1) : _value;

    // Non-boxing    
    public bool HasValue => true;

    public bool TryGetValue(out int value)
    {
        value = _value;
        return !_isBool;
    }

    public bool TryGetValue(out bool value)
    {
        value = _value != 0;
        return _isBool;
    }    
}