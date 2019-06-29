using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandamMove : MonoBehaviour
{

    public GameObject[] Block = new GameObject[8];
    public GameObject[] MoveBranch = new GameObject[9];

    // ソードの当たり判定のオブジェクトの宣言※親
    GameObject Sword_L;
    GameObject Sword_R;

    // 子オブジェクト用に変数を宣言s
    Transform Sword_L_Child;
    Transform Sword_R_Child;

    public int[] MoveNum = new int[8];
    public int[] BlockNum = new int[8];

    public bool Rank;
    int Block_Num;
    public int temp;

    // 自分自身がどの空オブジェクトにいるか判断する
    public static bool MoveTopL;
    public static bool MoveTopR;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < MoveBranch.Length - 1; i++)
        {
            Block_Num = Random.Range(0, Block.Length);
            Instantiate(MoveBranch[i], MoveBranch[i].transform.position, MoveBranch[i].transform.rotation);
            Instantiate(Block[Block_Num], MoveBranch[i].transform.position, Block[Block_Num].transform.rotation);

        }

        //Instantiate(MoveBranch[8], MoveBranch[8].transform.position, MoveBranch[8].transform.rotation);

        this.Sword_L = GameObject.Find("Sword_L");
        this.Sword_R = GameObject.Find("Sword_R");
        this.Sword_L_Child = this.Sword_L.transform.Find("effect");
        this.Sword_R_Child = this.Sword_R.transform.Find("effect2");

    }

   

    // Update is called once per frame
    void Update()
    {

        // Tagで指定したブロックに衝突した場合、真偽値を返す。※ソードについてるscriptで判定
        // 真の場合、一番後ろに生成される。
        //MoveTopL = this.Sword_L_Child.GetComponent<Collision_L_Sword>().Collision_rank_L;
        //MoveTopR = this.Sword_R_Child.GetComponent<Collision_R_Sword>().Collision_rank_R;

        //if (MoveTopL)
       //{
          //  Block_Num = Random.Range(0, Block.Length - 1);
         //  Instantiate(Block[Block_Num], MoveBranch[8].transform.position, Block[Block_Num].transform.rotation);

        //if (MoveTopR)
        //{
        //    Block_Num = Random.Range(0, Block.Length - 1);
        //    Instantiate(Block[Block_Num], MoveBranch[8].transform.position, Block[Block_Num].transform.rotation);
        //}
        
    }

}
