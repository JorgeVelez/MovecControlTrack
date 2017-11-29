using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;

[CustomEditor(typeof(MovecControl)), CanEditMultipleObjects]
class MovecControlEditor : Editor
{
    SerializedProperty _mode;

    void OnEnable()
    {
        _mode = serializedObject.FindProperty("template.mode");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(_mode);

        serializedObject.ApplyModifiedProperties();
    }
}
