using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisin_R : MonoBehaviour
{
    public GameObject particle;
    GameObject obj;

    // ソードの当たり判定のオブジェクトの宣言※親
    GameObject Sword_L;
    GameObject Sword_R;

    // 子オブジェクト用に変数を宣言
    // ソードの当たり判定のオブジェクトの宣言※子
    // 子のオブジェクトを取得する場合、GameObject型ではなく、Transform型を使う
    Transform Sword_L_Child;
    Transform Sword_R_Child;

    // コンボ加算させるメソッドを呼び出す為のオブジェクトの宣言
    public GameObject UI_Director;

    // Start is called before the first frame update
    void Start()
    {
        // UI_Directorのオブジェクトを代入
        UI_Director = GameObject.Find("UI_Director");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        // Sword_LとSword_Rとeffectのオブジェクトを取得
        this.Sword_R = GameObject.Find("Sword_R");
        this.Sword_R_Child = this.Sword_R.transform.Find("effect2");

        if (this.Sword_R_Child.tag == transform.tag)
        {
            // パーティクルの生成
            obj = Instantiate(particle, UI_Director.transform.position, transform.rotation) as GameObject;
            Destroy(obj, 0.2f);

        }
    }
}
