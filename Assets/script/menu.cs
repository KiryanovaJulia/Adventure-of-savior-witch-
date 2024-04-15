using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    /*public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }*/
    public void ExitGame()
    {
        Debug.Log("Игра закрыта");
        Application.Quit();
    }
}
