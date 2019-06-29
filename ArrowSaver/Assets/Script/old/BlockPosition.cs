using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPosition : MonoBehaviour
{ 
    // 空オブジェクトを格納する為の宣言
    public GameObject[] MoveBranch = new GameObject[9];

    // Block_Bule,Redを配列に格納
    public GameObject[,] Block_Blue_Red = new GameObject[2,4];

    // 自分自身がどの空オブジェクトにいるか判断する
    public bool Toppe_F_Pos;

    public bool MoveTop;
    public bool CntPos1;
    public bool CntPos2;
    public bool CntPos3;
    public bool CntPos4;
    public bool CntPos5;
    public bool CntPos6;
    public bool CntPos7;
    public bool Toppo_L_Pos;

    bool Block__Blue_Up;
    bool Block__Blue_Down;
    bool Block__Blue_L;
    bool Block__Blue_R;

    bool Block__Red_Up;
    bool Block__Red_Down;
    bool Block__Red_L;
    bool Block__Red_R;

    // rotationを扱う場合、Quaternionを使う。Quaternion(x,y,z,w)
    Quaternion Sync;
    float Speed = 100f;

    // ソードの当たり判定のオブジェクトの宣言※親
    GameObject Sword_L;
    GameObject Sword_R;

    // 子オブジェクト用に変数を宣言
    // ソードの当たり判定のオブジェクトの宣言※子
    // 子のオブジェクトを取得する場合、GameObject型ではなく、Transform型を使う
    Transform Sword_L_Child;
    Transform Sword_R_Child;

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        // ソードの当たり判定を取得 ※親じゃなく子にCollisionがついている。
        this.Sword_L = GameObject.Find("Sword_L");
        this.Sword_R = GameObject.Find("Sword_R");
        this.Sword_L_Child = this.Sword_L.transform.Find("effect");
        this.Sword_R_Child = this.Sword_L.transform.Find("effect2");
    }

    // Update is called once per frame
    void Update()
    {
        // 指標オブジェクトを空オブジェクトとしてGameObject型で代入
        GameObject[] MoveBranch = { GameObject.Find("Bench1"),
                                    GameObject.Find("Bench2"),
                                    GameObject.Find("Bench3"),
                                    GameObject.Find("Bench4"),
                                    GameObject.Find("Bench5"),
                                    GameObject.Find("Bench6"),
                                    GameObject.Find("Bench7"),
                                    GameObject.Find("Toppo_L"),
                                    GameObject.Find("Stage_Bottom")
                                  };

        // Block_BlueとRedの空オブジェクトをGameObject型に代入
        // 2次元配列で格納している。
        GameObject[,] Block_Blue_Red = {
            {
                GameObject.Find("Blue_Up(Clone)"),
                GameObject.Find("Blue_Down(Clone)"),
                GameObject.Find("Blue_Left(Clone)"),
                GameObject.Find("Blue_Right(Clone)")
            },
            {
                GameObject.Find("Red_Up(Clone)"),
                GameObject.Find("Red_Down(Clone)"),
                GameObject.Find("Red_Left(Clone)"),
                GameObject.Find("Red_Right(Clone)")}
        };

        int[] mvb = new int[8];
        bool[] Cnt = new bool[8];
        int[] Seek_Blue_Red = new int[8];
        int[] Seek_Arrow = new int[8];
        int i;
        int j;

        for (i = 0; i < Block_Blue_Red.GetLength(0); i++)
        {
            for (j = 0; j < Block_Blue_Red.GetLength(1); j++)
            {
                if (MoveBranch[1].transform.position.z == Block_Blue_Red[i, j].transform.position.z)
                {
                    CntPos1 = true;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                    count++;
                }
                else if (MoveBranch[2].transform.position.z == Block_Blue_Red[i, j].transform.position.z)
                {
                    CntPos2 = true;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                    count++;
                }
                else if (MoveBranch[3].transform.position.z == Block_Blue_Red[i, j].transform.position.z)
                {
                    CntPos3 = true;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                    count++;
                }
                else if (MoveBranch[4].transform.position.z == Block_Blue_Red[i, j].transform.position.z)
                {
                    CntPos4 = true;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                    count++;
                }
                else if (MoveBranch[5].transform.position.z == Block_Blue_Red[i, j].transform.position.z)
                {
                    CntPos5 = true;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                    count++;
                }
                else if (MoveBranch[6].transform.position.z == Block_Blue_Red[i, j].transform.position.z)
                {
                    CntPos6 = true;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                    count++;

                }
                else if (MoveBranch[7].transform.position.z == Block_Blue_Red[i, j].transform.position.z)
                {
                    CntPos7 = true;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                    count++;
                }
                else if (MoveBranch[8].transform.position.z == Block_Blue_Red[i, j].transform.position.z)
                {
                    Toppo_L_Pos = true;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                    count++;
                }
                else if (MoveBranch[0].transform.position.z == Block_Blue_Red[i, j].transform.position.z)
                {
                    MoveTop = true;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                }
                else if (MoveBranch[0].transform.position.z != Block_Blue_Red[i, j].transform.position.z)
                {
                    MoveTop = false;
                    Cnt[count] = true;
                    Seek_Blue_Red[count] = i;
                    Seek_Arrow[count] = j;
                    mvb[count] = count;
                    count++;
                }
            }

            if (i == Block_Blue_Red.GetLongLength(0) - 1)
            {
                count = 0;
                if (!Toppe_F_Pos)
                {
                    for (int x = 0; x < Seek_Blue_Red.Length; x++)
                    {
                        Spawn_move(Block_Blue_Red, MoveBranch, Seek_Blue_Red[x], Seek_Arrow[x], mvb[x], Cnt[x]);

                    }
                }
            }
        }
    }

    public void Spawn_move(GameObject[,] Block_Red_Blue, GameObject[] MoveBranch, int i, int j, int Movedec , bool MoveOn)
    {
        if(MoveOn)
        {
            Block_Red_Blue[i, j].transform.position = Vector3.MoveTowards(Block_Red_Blue[i, j].transform.position, MoveBranch[Movedec].transform.position, Speed * Time.deltaTime);

            if(Block_Red_Blue[i,j].transform.position.z == MoveBranch[Movedec].transform.position.z)
            {
                MoveOn = false;
            }
        }
    }

    public void Spawn(GameObject[,] Block_Red_Blue, int i, int j, bool MoveOn)
    {
        if (Block_Blue_Red[i, j].transform.position.z == transform.position.z)
        {
            MoveOn = true;
        }
        else
        {
            MoveOn = false;
        }
    }

}


