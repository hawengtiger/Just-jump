using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetrap : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    public GameObject[] target;

    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {
        foreach (GameObject target in target)
        {
            target.transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("destroy"))
        {
            Destroy(gameObject);
        }
    }
}
