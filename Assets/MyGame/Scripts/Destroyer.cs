using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Variants");
        for (int i = 0; i < gameObjects.Length; ++i)
        { 
                Destroy(gameObjects[i]);
        }
    }
}
