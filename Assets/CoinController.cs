using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class CoinController : MonoBehaviour
    {
    //カメラを入れる
    private GameObject camera;
    //カメラとコインの距離
      private float difference;




    // Use this for initialization
    void Start()
        {
            //回転を開始する角度を設定
            this.transform.Rotate(0, Random.Range(0, 360), 0);

            this.camera = GameObject.Find("Main Camera");
       　　 
    }

        // Update is called once per frame
        void Update()
        {

        //カメラとコインの位置（z座標）の差を求める　これがカメラの座標
        this.difference = camera.transform.position.z - this.transform.position.z;
        //回転
        this.transform.Rotate(0, 3, 0);
        if (this.transform.position.z < this.camera.transform.position.z)
        {
            Destroy(gameObject);
        }
    }

    }