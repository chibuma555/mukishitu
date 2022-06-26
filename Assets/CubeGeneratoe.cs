using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGeneratoe : MonoBehaviour
{
    public  GameObject anycube;
    public List<GameObject> ListValue = new List<GameObject>();

    void Start()
    {
        MakePrefab();
    }

    void MakePrefab()
    { 
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Instantiate(anycube, new Vector3(i * 12.0f, 0.5f, j * 12.0f), Quaternion.identity);
                ListValue.Add(anycube);
            }
        }
    }

    void Update()
    {
      
    }
}
