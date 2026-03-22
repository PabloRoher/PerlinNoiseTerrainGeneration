using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TerrainGenerator))]
public class MapEditor : Editor
{
    public override void OnInspectorGUI()
    {
        TerrainGenerator mapGen = (TerrainGenerator)target;

        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.GenerateTerrain();
            }
        }

        if (GUILayout.Button("Generate"))
        {
            mapGen.GenerateTerrain();
        }
    }
}
