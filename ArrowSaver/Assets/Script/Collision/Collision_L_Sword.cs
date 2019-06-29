using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_L_Sword : MonoBehaviour
{

    // ソードの当たり判定のオブジェクトの宣言※親
    GameObject Sword_L;
    GameObject Sword_R;

    // 子オブジェクト用に変数を宣言
    Transform Sword_L_Child;
    Transform Sword_R_Child;

    public GameObject SpawnMove;
    public GameObject[] Block = new GameObject[8];
    public int Block_Num;
    public int Speed = 1;

    public bool Collision_rank_L;
    public static int Combo_Counter = 0;
    public bool Collision_flag;

    // Start is called before the first frame update
    void Start()
    {
        this.Sword_L = GameObject.Find("Sword_L");
        this.Sword_R = GameObject.Find("Sword_R");
        this.Sword_L_Child = this.Sword_L.transform.Find("effect");
        this.Sword_R_Child = this.Sword_R.transform.Find("effect2");

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // 物体がすり抜けた時
    public void OnCollisionEnter(Collision collision)
    {
        if (this.Sword_L_Child.transform.tag == collision.gameObject.tag)
        {
            if (!Collision_flag)
            {
                Collision_rank_L = true;
                Collision_flag = true;
                Block_Num = Random.Range(0, Block.Length - 1);
                Instantiate(Block[Block_Num], SpawnMove.transform.position, Block[Block_Num].transform.rotation);

            }
        }
    }

    // 物体が通り抜け終えた時に呼ばれ
    public void OnCollisionExit(Collision collision)
    {
        // BlockとSword_Lの子オブジェクトのタグと一致している時
        // effectのタグと衝突したBlockのタグと同じ時
        if (this.Sword_L_Child.transform.tag == collision.gameObject.tag)
        {
            Collision_rank_L = false;
            Collision_flag = false;
            RankContoller.Collisiton_MoveRank_L = true;
            Destroy(collision.gameObject);
            SpeedController.Speed_Move = Speed;
            Combo_Counter++;
        }
    }
   
}
