using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoadManger 
{
    private string ScriptableObjectPath = "ScriptableObject";
    private Dictionary<string, ScriptableObject> ScriptableObjectDic = new Dictionary<string, ScriptableObject>();
    public ScriptableObject Get_ScriptableObject(string name)
    {
        ScriptableObject Temp;
        ScriptableObjectDic.TryGetValue(name, out Temp);
        if (Temp == null)
        {
            Temp = Resources.Load<ScriptableObject>(ScriptableObjectPath + "/name");
            ScriptableObjectDic.Add(name , Temp);
        }
        return Temp;
    }
    
    private string PrefabPath = "Prefab";
    private Dictionary<string, GameObject> PrefabDic = new Dictionary<string, GameObject>();
    public GameObject Get_Prefab(string name)
    {
        GameObject Temp;
        PrefabDic.TryGetValue(name, out Temp);
        if (Temp == null)
        {
            Temp = Resources.Load<GameObject>(PrefabPath + "/name");
            PrefabDic.Add(name , Temp);
        }
        return GameObject.Instantiate(Temp);
    }
    
}
