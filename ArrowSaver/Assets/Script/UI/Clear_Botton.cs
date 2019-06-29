using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Clear_Botton : MonoBehaviour
{
    public void ReStart_Botton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void TitleBack_Botton()
    {
        SceneManager.LoadScene("GameStart");
    }
}
