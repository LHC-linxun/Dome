using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IState
{
    public Dictionary<FSMCore.condition, IState> ToState;
    public virtual void Update_Act() { }
    public virtual void FixedUpdate_Act() { }
    public virtual void Enter() { }
    public virtual void Exit() { }
    
    
}
