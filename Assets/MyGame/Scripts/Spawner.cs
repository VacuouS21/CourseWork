using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacleVariants;
    public float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    public float speed;
    public int minIntRand;
    public int maxIntRand;

    bool first = true;
    public Text textNumberRand;
    // Start is called before the first frame update

    private void Start()
    {
        
       /* int randFalseFirst1 = Random.Range(minIntRand, maxIntRand);
        int randFalseSecond1 = Random.Range(minIntRand, maxIntRand);
        int randFalseFirst2 = Random.Range(minIntRand, maxIntRand);
        int randFalseSecond2 = Random.Range(minIntRand, maxIntRand);
        GlobalRandomNumber.falseFirstObject = randFalseFirst1 * randFalseSecond1;
        GlobalRandomNumber.falseSecondObject = randFalseFirst2 * randFalseSecond2;

        GlobalRandomNumber.firstTrueNumber = Random.Range(minIntRand, maxIntRand);
        GlobalRandomNumber.secondTrueNumber = Random.Range(minIntRand, maxIntRand);
        GlobalRandomNumber.randomNumbersForText.Enqueue(GlobalRandomNumber.firstTrueNumber + " x " + GlobalRandomNumber.secondTrueNumber);
        textNumberRand.text = GlobalRandomNumber.randomNumbersForText.Dequeue()+"="+GlobalRandomNumber.firstTrueNumber*GlobalRandomNumber.secondTrueNumber;*/

        

    }

    // Update is called once per frame
    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {             
           int rand = Random.Range(0, obstacleVariants.Length);
            

            int firstTrueNumber = Random.Range(minIntRand, maxIntRand);
            int secondTrueNumber = Random.Range(minIntRand, maxIntRand);
            GlobalRandomNumber.firstTrueNumber = firstTrueNumber;
            GlobalRandomNumber.secondTrueNumber = secondTrueNumber;
            GlobalRandomNumber.randomNumbersForText.Enqueue(firstTrueNumber.ToString() + " x " + secondTrueNumber.ToString());
            if (first)
            {
                textNumberRand.text = GlobalRandomNumber.randomNumbersForText.Dequeue();
                first = false;
            }
            int randFalseFirst = Random.Range(minIntRand, maxIntRand * maxIntRand);
            int randFalseSecond = Random.Range(minIntRand, maxIntRand* maxIntRand);
            
            while (randFalseFirst == firstTrueNumber * secondTrueNumber) 
            {
                randFalseFirst = Random.Range(minIntRand, maxIntRand * maxIntRand);
            }
            while(randFalseSecond == firstTrueNumber * secondTrueNumber)
            {
                randFalseSecond = Random.Range(minIntRand, maxIntRand * maxIntRand);
            }
                GlobalRandomNumber.falseFirstObject = randFalseFirst;
            GlobalRandomNumber.falseSecondObject = randFalseSecond;

            Instantiate(obstacleVariants[rand], transform.position, Quaternion.identity);

            timeBtwSpawn = startTimeBtwSpawn;
            if( startTimeBtwSpawn> minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
            
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
       

    }
}
