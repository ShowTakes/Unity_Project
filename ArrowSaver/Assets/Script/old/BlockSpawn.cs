using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawn : MonoBehaviour
{

    public GameObject[] Block = new GameObject[8];

    public GameObject[] Movebranch = new GameObject[8];


    public GameObject Stage_Bottom;
    public GameObject Summon;

    // ソードの当たり判定のオブジェクトの宣言※親
    GameObject Sword_L;
    GameObject Sword_R;

    // 子オブジェクト用に変数を宣言s
    Transform Sword_L_Child;
    Transform Sword_R_Child;

    public bool Rank;
    int Block_Num;

    // Start is called before the first frame update
    void Start()
    {
        // 0以上、Block配列の要素数未満の乱数を取得
        Block_Num = Random.Range(0, Block.Length);
        Instantiate(Block[Block_Num], Movebranch[0].transform.position, Block[Block_Num].transform.rotation);

        Block_Num = Random.Range(0, Block.Length);
        Instantiate(Block[Block_Num], Movebranch[1].transform.position, Block[Block_Num].transform.rotation);

        Block_Num = Random.Range(0, Block.Length);
        Instantiate(Block[Block_Num], Movebranch[2].transform.position, Block[Block_Num].transform.rotation);

        Block_Num = Random.Range(0, Block.Length);
        Instantiate(Block[Block_Num], Movebranch[3].transform.position, Block[Block_Num].transform.rotation);

        Block_Num = Random.Range(0, Block.Length);
        Instantiate(Block[Block_Num], Movebranch[4].transform.position, Block[Block_Num].transform.rotation);

        Block_Num = Random.Range(0, Block.Length);
        Instantiate(Block[Block_Num], Movebranch[5].transform.position, Block[Block_Num].transform.rotation);

        Block_Num = Random.Range(0, Block.Length);
        Instantiate(Block[Block_Num], Movebranch[6].transform.position, Block[Block_Num].transform.rotation);

        Block_Num = Random.Range(0, Block.Length);
        Instantiate(Block[Block_Num], Movebranch[7].transform.position, Block[Block_Num].transform.rotation);


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
        if (this.Sword_L_Child.GetComponent<Collision_L_Sword>().Collision_rank_L)
        {
            Block_Num = Random.Range(0, Block.Length);
            Instantiate(Block[Block_Num], Stage_Bottom.transform.position, Block[Block_Num].transform.rotation);
        }
        else if (this.Sword_R_Child.GetComponent<Collision_R_Sword>().Collision_rank_R)
        {
            Block_Num = Random.Range(0, Block.Length);
            Instantiate(Block[Block_Num], Stage_Bottom.transform.position, Block[Block_Num].transform.rotation);
        }
    }

}
