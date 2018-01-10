using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    //Playerジャンプ制御
    private Rigidbody2D rd2d;
    //ジャンプ一回だけの処理flg
    private bool Jump;




    // Use this for initialization
    void Start () {

        rd2d = GetComponent<Rigidbody2D>();
        Jump = false;

    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.LeftArrow))
        {  //←が押されたら左へ(-=)
            transform.position -= new Vector3(3.0f, 0.0f, 0.0f) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { //→が押されたら右へ(+=)
            transform.position += new Vector3(3.0f, 0.0f, 0.0f) * Time.deltaTime;
        }
        //ジャンプキーが押されたらジャンプflgがfalseならジャンプする
        if (Input.GetKeyDown("space") && Jump == false)
        {
            this.rd2d.velocity = Vector2.up * 7.0f;
            //連続ジャンプさせないようにtrue
            Jump = true;
        }


    }



    void OnCollisionEnter2D(Collision2D col)
    {

        //地面に着いたらflgをfalseにして飛べるようにする
        if (col.gameObject.tag == "Ground")
        {
            Jump = false;
        }

    }




}
