using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] gameObjects;

    // Update is called once per frame
    void Update()
    {
       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("TrueObstacle") || collision.CompareTag("Obstacle") || collision.CompareTag("Obstacle2"))
        {
            Destroy(collision.gameObject);
        }

    }

}
