using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchswp : MonoBehaviour
{
    public Vector2 startPos;

    public int Touchfeel = 100;

    // IPhone7用のアスペクト比 1334×750
    public Vector2 SceneAspectRatio;

    // Swordの親オブジェクトを取得する為の宣言
     GameObject Sword_L;
     GameObject Sword_R;

    // Swordの子オブジェクトeffectを取得する為の宣言
    Transform effect_L;
    Transform effect_R;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

        // Swordのオブジェクトを取得
        this.Sword_L = GameObject.Find("Sword_L");
        this.Sword_R = GameObject.Find("Sword_R");

        // Swordの子オブジェクトeffectを取得
        this.effect_L = Sword_L.transform.Find("effect");
        this.effect_R = Sword_R.transform.Find("effect2");

    }

    void Update()
    {

        anim.SetBool("L_Right_bool", false);
        anim.SetBool("L_Left_bool", false);
        anim.SetBool("L_Up_bool", false);
        anim.SetBool("L_Down_bool", false);
        anim.SetBool("R_Right_bool", false);
        anim.SetBool("R_Left_bool", false);
        anim.SetBool("R_Up_bool", false);
        anim.SetBool("R_Down_bool", false);

        // タッチ数が1回の時
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            this.SceneAspectRatio = new Vector2(1334, 750);

            // タッチの状態の分岐 touch.phase
            switch (touch.phase) {

                // 画面に指が振れた時
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                // 画面上で指が動いた時
                case TouchPhase.Moved:
                    // 左画面
                    if(startPos.x < SceneAspectRatio.x / 2) {

                        if (touch.deltaPosition.x > Touchfeel)
                        {
                            this.effect_L.tag = "Blue_R";

                            anim.SetFloat("Speed", 5.0f);
                            anim.SetBool("L_Right_bool", true);
                            
                        }
                        else if (touch.deltaPosition.x < -Touchfeel)
                        {
                            this.effect_L.tag = "Blue_L";

                            anim.SetFloat("Speed", 5.0f);
                            anim.SetBool("L_Left_bool", true);

                        }
                        else if (touch.deltaPosition.y > Touchfeel)
                        {
                            this.effect_L.tag = "Blue_Up";

                            anim.SetFloat("Speed", 5.0f);
                            anim.SetBool("L_Up_bool", true);

                        }
                        else if (touch.deltaPosition.y < -Touchfeel)
                        {
                            this.effect_L.tag = "Blue_Down";

                            anim.SetFloat("Speed", 5.0f);
                            anim.SetBool("L_Down_bool", true);

                        }

                    }// 右画面
                    else if(startPos.x > SceneAspectRatio.x / 2)
                    {
                        if (touch.deltaPosition.x > Touchfeel)
                        {
                            this.effect_R.tag = "Red_R";

                            anim.SetFloat("Speed", 5.0f);
                            anim.SetBool("R_Right_bool", true);
                        }
                        else if (touch.deltaPosition.x < -Touchfeel)
                        {
                            this.effect_R.tag = "Red_L";

                            anim.SetFloat("Speed", 5.0f);
                            anim.SetBool("R_Left_bool", true);
                        }
                        else if (touch.deltaPosition.y > Touchfeel)
                        {
                            this.effect_R.tag = "Red_Up";

                            anim.SetFloat("Speed", 5.0f);
                            anim.SetBool("R_Up_bool", true);
                        }
                        else if (touch.deltaPosition.y < -Touchfeel)
                        {
                            this.effect_R.tag = "Red_Down";

                            anim.SetFloat("Speed", 5.0f);
                            anim.SetBool("R_Down_bool", true);
                        }
                    }
                    break;

                // 画面から指が離れた時
                case TouchPhase.Ended:
                    break;

                default:
                    break;
            }

        }
        else if(Input.touchCount == 5)
        {
            Touch touch = Input.GetTouch(0);
            this.SceneAspectRatio = new Vector2(1334, 750);

            // タッチの状態の分岐 touch.phase
            switch (touch.phase)
            {

                // 画面に指が振れた時
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                // 画面上で指が動いた時
                case TouchPhase.Moved:
                    // 左画面
                    if (startPos.x < SceneAspectRatio.x / 2)
                    {
                        if (touch.deltaPosition.x > 0)
                        {
                           anim.SetBool("L_Right_bool", true);
                        }
                        else if (touch.deltaPosition.x < 0)
                        {
                           anim.SetBool("L_Left_bool", true);
                        }
                        else if (touch.deltaPosition.y > 30)
                        {
                           anim.SetBool("L_Up_bool", true);
                        }
                        else if (touch.deltaPosition.y < -30)
                        {
                           anim.SetBool("L_Down_bool", true);
                        }
                    }

                    // 右画面
                    if (startPos.x > SceneAspectRatio.x / 2)
                    {
                        if (touch.deltaPosition.x > 0)
                        {
                           anim.SetBool("R_Right_bool", true);
                        }
                        else if (touch.deltaPosition.x < 0)
                        {
                           anim.SetBool("R_Left_bool", true);
                        }
                        else if (touch.deltaPosition.y > 30)
                        {
                           anim.SetBool("R_Up_bool", true);
                        }
                        else if (touch.deltaPosition.y < -30)
                        {
                           anim.SetBool("R_Down_bool", true);
                        }
                    }
                    break;

                // 画面から指が離れた時
                case TouchPhase.Ended:
                    break;
                
                default:
                    break;
            }
        }
    }
}
