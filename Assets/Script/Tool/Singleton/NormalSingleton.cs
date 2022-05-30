using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.PlayerLoop;

//使用方法
//public class ChangeInputTouch : NormalSingleton<ChangeInputTouch>
//{

public class NormalSingleton<T> where T:class,new()
{
    private static T _single;
    
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
                //这里添加Init()便可以
            }
            return _single;
        }
    }
	
}
