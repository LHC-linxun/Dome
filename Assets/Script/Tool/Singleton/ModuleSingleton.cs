using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleSingleton<T> where T:class,new()
{
    private static T _single;

    private static Action InitAction;

    public  static void AddInitAction(Action action)
    {
        InitAction = null;
        InitAction = action;
    }

    public static T Single
    {
        get 
        {
            if (_single == null)
            {
                T t = new T();
                if (t is MonoBehaviour)
                {
                    Debug.Log("Mono类请使用MonoSingleton类");
                    return null;
                }
                _single = t;
                InitAction();
                //这里添加Init()便可以
            }
            return _single;
        }
    }
}
