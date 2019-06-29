using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Script : MonoBehaviour
{
    GameObject TimerText;
    GameObject ComboText;
    public float Second; // Clear_Time.csで値を使い為static宣言
    int Combo_L;    // Clear_Time.csで値を使い為static宣言
    int Combo_R;
    public static int Combo;

    // Start is called before the first frame update
    void Start()
    {
        Second = 30; // タイム初期化
        // SceneからTimerという名前のGameObjectを探す
        this.TimerText = GameObject.Find("Second");
        this.ComboText = GameObject.Find("Combo");
    }

    // Update is called once per frame
    void Update()
    {
        Second -= Time.deltaTime;
        Combo_L = Collision_L_Sword.Combo_Counter;
        Combo_R = Collision_R_Sword.Combo_Counter;
        Combo   = Combo_L + Combo_R;

        // Secondの数値をToStringで文字列に変換。引数により表示領域を指定。
        this.TimerText.GetComponent<Text>().text = Second.ToString("F2");
        this.ComboText.GetComponent<Text>().text = Combo.ToString("D3");

        if(Second < 0)
        {
            SceneManager.LoadScene("GameClear");
        }
    }
}

// ToStringは数値を文字列に変換するメソッド。引数に数値を表示する時の書式を指定する事ができる。
// 整数型　D(桁数)：整数の場合に使用する。指定した引数に満たない場合は、左側にゼロが挿入される。(456).ToString("F5") → 00456
// 固定小数点型　F(桁数)：小数を表示する場合の小数点以下の桁数を指定する。(12.3456).ToString("F3") → 12.345 

// 追記
// GameObjectをシーン切り替え後も残しておきたい場合は、
// Unityではシーンを切り替えるとGameObject等は全部破棄される
// Object.DontDestroyOnLoadを使用。
// 引数に指定したGameObjectは破棄されなくなり、Scene切替時にそのまま引き継がれます。
// 値をシーン切り替え後も引き継ぎたい場合、
// static付の変数は、アプリ終了時まで破棄されません。