using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hp : MonoBehaviour
{
    public float hp = 1;
    private float hp_cp = 0;
    public Image hpImage;

    // Start is called before the first frame update
    void Start()
    {
        hp_cp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    public void TakeDmg(float dmg)
    {
        hp_cp -= dmg;
        hpImage.fillAmount = hp_cp;
        Debug.Log($"{hp_cp} = 현재 체력");
        if (hp_cp <= 0)
        {
            Die();
            SceneManager.LoadScene("Over");
        }
    }

    public void Die()
    {
        Debug.Log("아 몰랑 주거버릴 거야!");
    }
}
