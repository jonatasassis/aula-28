using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.StateMachine
{

    public class StateBase
    {
        public virtual void onStateEnter(object o = null)
        {
            Debug.Log("onStateEnter");
            Player.canMove = true;
            Player.canJump = true;
        }
        public virtual void onStateStay(object o = null)
        {
            Debug.Log("onStateStay");
            
        }
        public virtual void onStateExit(object o = null)
        {
            Debug.Log("onStateExit");
            Player.canMove = false;
            Player.canJump = false;
        }
    }


}
