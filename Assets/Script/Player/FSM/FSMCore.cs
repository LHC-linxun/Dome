using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FSMCore
{
    public delegate bool condition(Controller Controller);

    private List<IState> IStateList;
    private IState CurrentState;
    private Controller controller;
    private bool IsPause = true;

    public FSMCore(Controller controller)
    {
        IStateList = new List<IState>();
        this.controller = controller;
    }

    private void Reason()
    {
        foreach (condition Key in CurrentState.ToState.Keys)
        {
            if (Key(controller))
            {
                CurrentState.Enter();
                CurrentState = CurrentState.ToState[Key];
                CurrentState.Exit();
            }
        }
    }

    public void Update()
    {
        if(IsPause) return;
        
        Reason();
        CurrentState.Update_Act();
    }


    public void FixedUpdate()
    {
        CurrentState.FixedUpdate_Act();
    }

    public void ResetState()
    {
        CurrentState.Enter();
        if (IStateList.Count > 0)
        {
            CurrentState = IStateList[0];
        }
        CurrentState.Exit();
    }

    public void ForceChangeState(IState state)
    {
        CurrentState.Enter();
        CurrentState = state;
        CurrentState.Exit();
    }

    public void PauseState()
    {
        IsPause = true;
    }

    public void StartState()
    {
        IsPause = false;
    }

    public IState GetCurrentState()
    {
        return CurrentState;
    }


}
