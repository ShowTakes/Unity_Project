using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_R_Sword : MonoBehaviour
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
    public int Speed;

    public bool Collision_rank_R;
    public static int Combo_Counter = 0;
    public bool Collision_flag_R;

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
        if (this.Sword_R_Child.transform.tag == collision.gameObject.tag)
        {
            if (!Collision_flag_R)
            {
                Collision_rank_R = true;
                Collision_flag_R = true;
                Block_Num = Random.Range(0, Block.Length - 1);
                Instantiate(Block[Block_Num], SpawnMove.transform.position, Block[Block_Num].transform.rotation);

            }
        }
    }

    // 物体が通り抜け終えた時に呼ばれ
    public void OnCollisionExit(Collision collision)
    {
        if (this.Sword_R_Child.transform.tag == collision.gameObject.tag)
        {
            Collision_rank_R = false;
            Collision_flag_R = false;
            RankContoller.Collisiton_MoveRank_R = true;
            Destroy(collision.gameObject);
            SpeedController.Speed_Move = Speed;
            Combo_Counter++;
        }
    }
   
}
