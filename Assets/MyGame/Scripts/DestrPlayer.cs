using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestrPlayer : MonoBehaviour
{
    public Text rahdomText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //rahdomText.text = GlobalRandomNumber.randomNumbersForText.Dequeue();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("TrueObstacle") || collision.CompareTag("Obstacle") || collision.CompareTag("Obstacle2"))
        {
            if (GlobalRandomNumber.randomNumbersForText.Count==0) rahdomText.text = "NULL";
            else rahdomText.text = GlobalRandomNumber.randomNumbersForText.Dequeue();
        }

    }
}
