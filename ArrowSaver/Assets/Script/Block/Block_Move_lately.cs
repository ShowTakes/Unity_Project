using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Move_lately : MonoBehaviour
{
    GameObject[] MoveBench = new GameObject[9];
    public GameObject Ramdam;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {

        this.Ramdam = GameObject.Find("Ramdam");
        MoveBench = this.Ramdam.GetComponent<RandamMove>().MoveBranch;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (RankContoller.Collisiton_MoveRank_L || RankContoller.Collisiton_MoveRank_R)
        {

            this.distance = Vector3.Distance(transform.position, MoveBench[0].transform.position);

            // 全Blockを空オブジェクト0に移動させる。
            transform.position = Vector3.MoveTowards(transform.position, MoveBench[0].transform.position, SpeedController.Speed_Move);

            if(distance　== 0)
            {
                SpeedController.Speed_Move = 0;
            }

        }


    }
}
