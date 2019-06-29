using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_UI : MonoBehaviour
{
    GameObject Pause;
    public bool flag;

    void Start()
    {
        Pause = GameObject.Find("Pause");
        flag = false;
        // Pause.SetActive(flag);
    }
    
    void Update()
    {
        if (!flag)
        {
            Pause.SetActive(flag);
        }
    }

    public void Pause_Button()
    {
        flag = true;
        Pause.SetActive(flag);
        Time.timeScale = 0f;
    }

    public void Title_Botton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameStart");
    }

    public void ReStart_Botton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }

    public void Back_Botton()
    {
        Time.timeScale = 1f;
        Pause = GameObject.Find("Pause");
        // Pause.SetActive(false);
        flag = false;
    }


}
