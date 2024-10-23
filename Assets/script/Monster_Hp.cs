using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster_Hp : MonoBehaviour
{
    public Hp hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = GetComponent<Hp>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Monster") || other.gameObject.CompareTag("Trap"))
        {
            float dmg = 1.2f;
            Debug.Log("ddddd");
            hp.TakeDmg(dmg);
        }
        if(other.gameObject.CompareTag("water"))
        {
            float dmg = 1.2f;
            Debug.Log("water_die");
            hp.TakeDmg(dmg);
        }
        if (other.gameObject.CompareTag("snowman"))
        {
            SceneManager.LoadScene("Snowman");
        }
    }
}
