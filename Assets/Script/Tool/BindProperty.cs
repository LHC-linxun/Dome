using System;

public class BindProperty<T>
{
    private T _value;

    public Action _action;

    public T Value
    {
        get { return _value; }
        set
        {
            if (!_value.Equals(value))
            {
                _action();
            }
            _value = value;
        }
    }

}
