using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int mapWidth;
    public int mapHeight;
    public float noiseScale;

    public bool autoUpdate;

    public int octaves;
    public float persistence;
    public float lacunarity;
    public int seed;
    public Vector2 offset;

    public void GenerateTerrain()
    {
        float[,] noiseMap = Terrain.GenerateNoiseMap(mapWidth, mapHeight, noiseScale, octaves, persistence, lacunarity, seed, offset);
        // Here you can use the noiseMap to create your terrain, for example by applying it to a mesh or a texture.
        MapDisplay mapDisplay = FindAnyObjectByType<MapDisplay>();
        mapDisplay.DrawNoiseMap(noiseMap);
    }

    void OnValidate()
    {
        if (mapWidth < 1)
        {
            mapWidth = 1;
        }
        if (mapHeight < 1)
        {
            mapHeight = 1;
        }
        if (octaves < 0)
        {
            octaves = 0;
        }
        if (lacunarity < 1)
        {
            lacunarity = 1;
        }
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
