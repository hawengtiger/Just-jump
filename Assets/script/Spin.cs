using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{ 
    public float speed = 0.2f;
    public float spin;
    public float movespeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        spin = speed * Time.deltaTime;
        transform.Rotate(0, 0, -speed);
    }
}
