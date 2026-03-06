using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(MeshCombiner))]
public class TerrainEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        GUILayoutOption[] glo = {GUILayout.Width(100), GUILayout.Height(34)};
        if (GUILayout.Button("Combine Child Meshes", glo))
        {
            MeshCombiner mc = target as MeshCombiner;
            mc.Combine();
        }
    }
}