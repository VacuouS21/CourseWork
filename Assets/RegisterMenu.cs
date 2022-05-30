using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RegisterMenu : MonoBehaviour
{
   
    [SerializeField] private InputField input;
    private string myName;
    public void Start()
    {
       input .ActivateInputField();
    }
    // Start is called before the first frame update
    public void goToTheMainMenu()
    {
        if (input.text == "")
        {
            Debug.Log("Ошибка");
        }
        else
        {
            //input.text;

            Debug.Log("Успешно");
            myName = input.text;
            UserStorage user = new UserStorage(myName);
            GlobalRandomNumber.newAll(user.Name,user.Easy,user.Medium,user.Hard,user.BossReady,user.BossMax,user);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
        
    }
    public void test()
    {
        if (input.text == "")
        {
            Debug.Log("Ошибка");
        }
        else
        {
            myName = input.text;
           
        }
    }
}
