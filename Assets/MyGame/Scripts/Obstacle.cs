using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public float myTime = 4;
    // public Text scoreDisplay;
    // Start is called before the first frame update
    void Start()
    {

        
        if (gameObject.CompareTag("TrueObstacle"))
        {
            gameObject.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>().text = GlobalRandomNumber.firstTrueNumber * GlobalRandomNumber.secondTrueNumber+"";
           
        }
        if (gameObject.CompareTag("Obstacle"))
        {
            gameObject.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>().text = GlobalRandomNumber.falseFirstObject.ToString();
        }
        if (gameObject.CompareTag("Obstacle2"))
        {
            gameObject.GetComponentInChildren<Canvas>().GetComponentInChildren<Text>().text = GlobalRandomNumber.falseSecondObject.ToString();
        }
        // this.GetComponent<Text>.text = "Hi";*/
    }



    // Update is called once per frame
    private void Update()
    {
        
        transform.Translate(Vector2.left * speed );
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") )
        {
            
            collision.GetComponent<PlayerController>().health -= damage;
            Destroy(gameObject);
        }
    }
}
