using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Singleton;
using Script.StateMachine;

public class GameManager : Singleton<GameManager>
{
    public enum PlayerStates
    {
        IdleState,
        WalkState,
        JumpState
    }

    public StateMachine<PlayerStates> playerStateMachine;

    private void Start()
    {
        InitGameManager();
    }

    public void InitGameManager()
    {
        playerStateMachine= new StateMachine<PlayerStates>();
        playerStateMachine.Init();
        playerStateMachine.RegisterStates(PlayerStates.IdleState,new StateBase());
        playerStateMachine.RegisterStates(PlayerStates.WalkState, new StateBase());
        playerStateMachine.RegisterStates(PlayerStates.JumpState, new StateBase());

        playerStateMachine.SwitchState(PlayerStates.IdleState);
    }
   

    

}
