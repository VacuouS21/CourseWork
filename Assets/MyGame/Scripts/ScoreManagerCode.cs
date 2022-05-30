using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerCode : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoreDisplay;
    public Text scorePause;
    public int level;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        scoreDisplay.text = score.ToString();
        scorePause.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TrueObstacle"))
        {
            score++;
            switch (level)
            {
                case 1:
                    if (GlobalRandomNumber.firstLevel < score)
                    {
                        UserStorage user = GlobalRandomNumber.user;
                        GlobalRandomNumber.user.updateUser(score, user.Medium, user.Hard, user.BossReady, user.BossMax);
                        
                        GlobalRandomNumber.firstLevel = score;
                        
                    }
                    break;
                case 2:
                    if (GlobalRandomNumber.secondLevel < score)
                    {
                        UserStorage user = GlobalRandomNumber.user;
                        GlobalRandomNumber.user.updateUser(user.Easy, score, user.Hard, user.BossReady, user.BossMax);
                        GlobalRandomNumber.secondLevel = score;
                    }
                    break;
                case 3:
                    if (GlobalRandomNumber.thiirdLevel < score)
                    {
                        UserStorage user = GlobalRandomNumber.user;
                        GlobalRandomNumber.user.updateUser(user.Easy, user.Medium, score, user.BossReady, user.BossMax);
                        GlobalRandomNumber.thiirdLevel = score;
                    }
                    break;

            }
        }
       

    }
    }
