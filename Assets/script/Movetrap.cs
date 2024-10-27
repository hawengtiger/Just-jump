using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetrap : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    public GameObject[] target;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {
        foreach (GameObject t in target)
        {
            t.transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}
