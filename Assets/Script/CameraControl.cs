using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject Player;


    void Start()
    {
        

    }


   
    // Update is called once per frame
    void Update()
    {
        //セットしたPlayerのx座標を基に同じ分量動く(y,zは初期のPlayerの位置)
        transform.position = new Vector3(Player.transform.position.x, 0, -1);


        //Stage外にカメラが追従しないように
        //右端
        if (transform.position.x > 0)
        {
            transform.position = new Vector3(0, 0, -1);
        }
        //左端
        if (transform.position.x < -50)
        {
            transform.position = new Vector3(-50, 0, -1);
        }


    }


}
