using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_L : MonoBehaviour
{
    public GameObject particle;
    GameObject obj;

    // ソードの当たり判定のオブジェクトの宣言※親
    GameObject Sword_L;

    // 子オブジェクト用に変数を宣言
    // ソードの当たり判定のオブジェクトの宣言※子
    // 子のオブジェクトを取得する場合、GameObject型ではなく、Transform型を使う
    Transform Sword_L_Child;


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
        this.Sword_L = GameObject.Find("Sword_L");
        this.Sword_L_Child = this.Sword_L.transform.Find("effect");

        // TagがSword_Lで触れた時
        if (this.Sword_L_Child.tag == transform.tag)
        {
            // パーティクルの生成
            obj = Instantiate(particle, UI_Director.transform.position, transform.rotation) as GameObject;
            Destroy(obj, 0.2f);
        }
    }
}

// Particlはプレハブであり、PrefabにDestroyすることはできないから
// 変数に入れて、インスタンスさせてからDestroyする。

