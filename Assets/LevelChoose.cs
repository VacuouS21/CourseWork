using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour
{
    // Start is called before the first frame update
  public void Light()
    {
        SceneManager.LoadScene(2);
    }
    public void Medium()
    {
        SceneManager.LoadScene(4);
    }
    public void Hight()
    {
        SceneManager.LoadScene(5);
    }
    public void Boss()
    {
        SceneManager.LoadScene(6);
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
}
