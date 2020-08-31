using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //カメラを入れる
    private GameObject camera;
    //カメラとコインの距離
    private float difference;

    // Use this for initialization
    void Start()
    {
        this.camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        this.difference = camera.transform.position.z - this.transform.position.z;

        if (this.transform.position.z < this.camera.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}