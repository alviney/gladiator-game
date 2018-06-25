using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

[CustomEditor(typeof(Backgrounds))]
// [CanEditMultipleObjects]	
public class BackgroundEditor : Editor {
	SerializedProperty background;
	Backgrounds backgrounds;

 	void OnEnable()
    {
        background = serializedObject.FindProperty("Stories");
    }

	public override void OnInspectorGUI() {

		serializedObject.Update();
        EditorGUILayout.PropertyField(background, true);
        
        Backgrounds myScript = (Backgrounds)target;

        if(GUILayout.Button("Add Story"))
        {
            myScript.AddStory();
        }



		serializedObject.ApplyModifiedProperties();
	}
}
