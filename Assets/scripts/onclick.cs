using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onclick : MonoBehaviour
{
   
 public void onclickPlay()
    {
        SceneManager.LoadScene("Level");
    }

    public void OnclickQuit()
    {
        Application.Quit();
    }
}
