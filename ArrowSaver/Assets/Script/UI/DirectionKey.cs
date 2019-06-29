using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionKey : MonoBehaviour
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
        // 剣を振る速度
        anim.SetFloat("Speed", 5.0f);
    }

    // 左画面(L_Sword)
    // L_right
    public void L_right_Button()
    {
        this.effect_L.tag = "Blue_R";
        anim.SetTrigger("L_right_trriger");
    }
                        
    // L_left
    public void L_left_Button()
    {
        this.effect_L.tag = "Blue_L";
        anim.SetTrigger("L_left_trriger");
    }

    // L_up
    public void L_up_Button()
    {
        this.effect_L.tag = "Blue_Up";
        anim.SetTrigger("L_up_trriger");
    }

    // L_down
    public void L_down_Button()
    {
        this.effect_L.tag = "Blue_Down";
        anim.SetTrigger("L_down_trriger");
    }


    // 右画面(R_Sword)
    // R_right
    public void R_right_Button()
    {
        this.effect_R.tag = "Red_R";
        anim.SetTrigger("R_right_trriger");
    }

    // R_left
    public void R_left_Button()
    {
        this.effect_R.tag = "Red_L";
        anim.SetTrigger("R_left_trriger");
    }

    // R_up
    public void R_up_Button()
    {
        this.effect_R.tag = "Red_Up";
        anim.SetTrigger("R_up_trriger");
    }
                        
    // R_down                        
    public void R_down_Button()
    {
        this.effect_R.tag = "Red_Down";
        anim.SetTrigger("R_down_trriger");
    }
}


