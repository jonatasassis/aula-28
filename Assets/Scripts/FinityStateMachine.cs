using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Script.StateMachine;

public class FinityStateMachine : MonoBehaviour
{
   public enum ExampleEnum
    { 
        state1,state2,state3
        
    }

    public StateMachine<ExampleEnum> stateMachine;

    private void Start()
    {
        stateMachine = new StateMachine<ExampleEnum>();
        stateMachine.Init();
        stateMachine.RegisterStates(ExampleEnum.state1,new StateBase());
        stateMachine.RegisterStates(ExampleEnum.state2, new StateBase());
        stateMachine.RegisterStates(ExampleEnum.state3, new StateBase());

    }
}
