using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear_Time : MonoBehaviour
{
    // float Time;                 // 経過タイム
    float Score;                   // 総スコア
    // GameObject Time_result;
    GameObject Combo_result;
    GameObject Score_result;

    // Start is called before the first frame update
    void Start()
    {
        // this.Time_result = GameObject.Find("Time_Result");
        this.Combo_result = GameObject.Find("Combo_Result");
        this.Score_result = GameObject.Find("Score_Result");
        // UI_ScriptのSecond,Comboの値を参照
    }

    // Update is called once per frame
    void Update()
    {
        Score = UI_Script.Combo * 1.1f; // 総スコアの計算
        // this.Time_result.GetComponent<Text>().text = "TIME: " + Time.ToString("F2");
        this.Combo_result.GetComponent<Text>().text = "COMBO: " + UI_Script.Combo.ToString("D3");
        this.Score_result.GetComponent<Text>().text = "SCORE: " + Score.ToString("F2");
    }
}
