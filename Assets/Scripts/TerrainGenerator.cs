using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int mapWidth;
    public int mapHeight;
    public float noiseScale;

    public bool autoUpdate;

    public void GenerateTerrain()
    {
        float[,] noiseMap = Terrain.GenerateNoiseMap(mapWidth, mapHeight, noiseScale);
        // Here you can use the noiseMap to create your terrain, for example by applying it to a mesh or a texture.
        MapDisplay mapDisplay = FindAnyObjectByType<MapDisplay>();
        mapDisplay.DrawNoiseMap(noiseMap);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
