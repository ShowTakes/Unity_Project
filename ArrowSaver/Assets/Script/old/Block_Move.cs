/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Move : MonoBehaviour
{

    public GameObject[] MoveBranch = new GameObject[8];
    public GameObject Stage_Bottom;
    public GameObject Ramdam;
    public bool[] Pos = new bool[9];
    public float Speed = 1000f;
    public bool MoveL;
    public bool MoveR;

    public bool CntPos1;
    public bool CntPos2;
    public bool CntPos3;
    public bool CntPos4;
    public bool CntPos5;
    public bool CntPos6;
    public bool CntPos7;
    public bool Toppo_L_Pos;


    // Start is called before the first frame update
    void Start()
    {
       this.Ramdam = GameObject.Find("Ramdam");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveL = this.Ramdam.GetComponent<RandamMove>().MoveTopL;
        MoveR = this.Ramdam.GetComponent<RandamMove>().MoveTopR;

        CntPos1 = this.Ramdam.GetComponent<RandamMove>().CntPos1;
        CntPos2 = this.Ramdam.GetComponent<RandamMove>().CntPos2;
        CntPos3 = this.Ramdam.GetComponent<RandamMove>().CntPos3;
        CntPos4 = this.Ramdam.GetComponent<RandamMove>().CntPos4;
        CntPos5 = this.Ramdam.GetComponent<RandamMove>().CntPos5;
        CntPos6 = this.Ramdam.GetComponent<RandamMove>().CntPos6;
        CntPos7 = this.Ramdam.GetComponent<RandamMove>().CntPos7;
        Toppo_L_Pos = this.Ramdam.GetComponent<RandamMove>().Toppo_L_Pos;

        if (MoveL || MoveR)
        {
            if (CntPos1)
            {
                transform.position = Vector3.MoveTowards(transform.position, MoveBranch[0].transform.position, Speed * Time.deltaTime);
            
                if (MoveBranch[0].transform.position.z == transform.position.z)
                {
                    CntPos1 = false;
                }
            }

            if (CntPos2)
            {
                transform.position = Vector3.MoveTowards(transform.position, MoveBranch[1].transform.position, Speed * Time.deltaTime);
            
                if (MoveBranch[1].transform.position.z == transform.position.z)
                {
                    CntPos2 = false;
                }
            }

            if (CntPos3)
            {
                transform.position = Vector3.MoveTowards(transform.position, MoveBranch[2].transform.position, Speed * Time.deltaTime);
            
                if (MoveBranch[3].transform.position.z == transform.position.z)
                {
                    CntPos3 = false;
                }
            }

            if (CntPos4)
            {
                transform.position = Vector3.MoveTowards(transform.position, MoveBranch[3].transform.position, Speed * Time.deltaTime);
            
                if (MoveBranch[3].transform.position.z == transform.position.z)
                {
                    CntPos4 = false;
                }
            }


            if (CntPos5)
            {
                transform.position = Vector3.MoveTowards(transform.position, MoveBranch[4].transform.position, Speed * Time.deltaTime);
            
                if (MoveBranch[4].transform.position.z == transform.position.z)
                {
                    CntPos5 = false;
                }

            }

            if (CntPos6)
            {
                transform.position = Vector3.MoveTowards(transform.position, MoveBranch[5].transform.position, Speed * Time.deltaTime);
            
                if (MoveBranch[5].transform.position.z == transform.position.z)
                {
                    CntPos6 = false;
                }

            }

            if (CntPos7)
            {
                transform.position = Vector3.MoveTowards(transform.position, MoveBranch[6].transform.position, Speed * Time.deltaTime);
            
                if (MoveBranch[6].transform.position.z == transform.position.z)
                {
                    CntPos7 = false;
                }
            }

            if (Toppo_L_Pos)
            {
                transform.position = Vector3.MoveTowards(transform.position, MoveBranch[7].transform.position, Speed * Time.deltaTime);
            
                if (MoveBranch[7].transform.position.z == transform.position.z)
                {
                    Toppo_L_Pos = false;
                }
            }
        }
    }
}

*/