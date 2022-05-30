using System;
using System.Collections;
using System.Collections.Generic;

public abstract class Module<T> : ModuleSingleton <T> where T:class,new()
{
    private Dictionary<Type , object> FunctionDic;

    private bool IsInit = false;
    
    public Module()
    {
        FunctionDic = new Dictionary<Type, object>();
        AddInitAction(Register);
    }
    
    protected abstract void Register();
    protected void AddFunction<K>(K function) where K : class
    {
        FunctionDic.Add(typeof(K) ,function);
    }
    
    public K Get<K>() where K : class
    {
        object TObject;
        FunctionDic.TryGetValue(typeof(K) , out TObject);
        if (TObject != null)
        {
            return TObject as K;
        }
        else
        {
            return null;
        }
    }
}
