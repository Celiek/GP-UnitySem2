using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * kolory:
 * #b90101 - czerwony
 * #09d50b	- zielony
 * 
 */

public class LevelGenerator : MonoBehaviour
{
    public Texture2D map;
    public ColorToPrefab[] colorMappings;
    public float offset = 5f;
  
     void GenerateTile(int x ,int z)
    {
        Color pixelColor = map.GetPixel(x, z);

       foreach (ColorToPrefab colorMapping in colorMappings)
        {
            if (colorMapping.color.Equals(pixelColor))
            {
                Vector3 position = new Vector3(x, 0, z) * offset;
                Instantiate(colorMapping.prefab,
                    position, Quaternion.identity , transform);
            }
        }

    }

    public void GenerateLabirynth()
    {
        for(int x = 0; x < map.width; x++)
        {
            for(int z = 0; z < map.height; z++)
            {
                GenerateTile(x, z);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
