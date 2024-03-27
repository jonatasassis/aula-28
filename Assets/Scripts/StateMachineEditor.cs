using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FinityStateMachine))]
public class StateMachineEditor : Editor
{
    public bool showFoldOut;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        FinityStateMachine fsm = (FinityStateMachine)target;

        EditorGUILayout.Space(30);
        EditorGUILayout.LabelField("StateMachine");

        if (fsm.stateMachine == null)
        {
            return;
        }

        if (fsm.stateMachine.estadoAtual != null)
        {
            EditorGUILayout.LabelField("Current State: ",fsm.stateMachine.estadoAtual.ToString());
        }

        showFoldOut = EditorGUILayout.Foldout(showFoldOut, "Avaliable states");
        if (showFoldOut)
        {
            if (fsm.stateMachine.dictionaryStates!=null)
            {
                var keys = fsm.stateMachine.dictionaryStates.Keys.ToArray();
                var values = fsm.stateMachine.dictionaryStates.Values.ToArray();

                for (int i = 0; i < keys.Length; i++)
                {
                    EditorGUILayout.LabelField(string.Format("{0}::{1}", keys[i], values[i]));
                }
            }
        }
    }
    
   
  
}
