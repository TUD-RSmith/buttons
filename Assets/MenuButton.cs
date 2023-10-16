using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public string URL = "https://github.com/TUD-RSmith/Lecture_Demo/tree/main/Button_Demo";
    public void GoToScene1()
    {
        SceneManager.LoadScene("scene1");
    }

    public void GoToScene2()
    {
        SceneManager.LoadScene("scene2");
    }

    public void loadUrl()
    {
        Application.OpenURL(URL);
    }
}
