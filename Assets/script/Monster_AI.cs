using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_AI : MonoBehaviour
{
    public float speed = 0f;
    public float move_dis = 5f;
    public bool move_dir = true;
    private Vector2 startPosition;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = move_dir? speed : -speed;
        rb.velocity = new Vector2(moveSpeed,rb.velocity.y);
        float dis = Vector2.Distance(startPosition,transform.position);
        
        if(dis >= move_dis)
        {
            move_dir = !move_dir;
            startPosition = transform.position;

        }
    }
}
