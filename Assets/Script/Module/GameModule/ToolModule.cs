using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolModule : Module<ToolModule>
{
    protected override void Register()
    {
        AddFunction(new ResourceLoadManger());
    }


}
