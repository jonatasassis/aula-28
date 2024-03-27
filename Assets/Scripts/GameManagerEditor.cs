using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameManager))]

public class GameManagerEditor : Editor
{
    public bool showFoldOut;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GameManager gameManagerFSM  = (GameManager)target;

        EditorGUILayout.Space(30);
        EditorGUILayout.LabelField("StateMachine");

        if (gameManagerFSM.playerStateMachine == null)
        {
            return;
        }

        if (gameManagerFSM.playerStateMachine.estadoAtual != null)
        {
            EditorGUILayout.LabelField("Current State: ", gameManagerFSM.playerStateMachine.estadoAtual.ToString());
        }

        showFoldOut = EditorGUILayout.Foldout(showFoldOut, "Avaliable states");
        if (showFoldOut)
        {
            if (gameManagerFSM.playerStateMachine.dictionaryStates != null)
            {
                var keys = gameManagerFSM.playerStateMachine.dictionaryStates.Keys.ToArray();
                var values = gameManagerFSM.playerStateMachine.dictionaryStates.Values.ToArray();

                for (int i = 0; i < keys.Length; i++)
                {
                    EditorGUILayout.LabelField(string.Format("{0}::{1}", keys[i], values[i]));
                }
            }
        }
    }

}
