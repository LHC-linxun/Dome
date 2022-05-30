using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDataModule : Module<BaseDataModule>
{
    protected override void Register()
    {
        AddFunction(new BaseData_Animation());
        AddFunction(ToolModule.Single.Get<ResourceLoadManger>().Get_ScriptableObject("BaseData_Player"));
    }
}
