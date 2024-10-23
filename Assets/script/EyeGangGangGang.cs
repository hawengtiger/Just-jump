using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeGangGangGang : MonoBehaviour
{
    SpriteRenderer sprite;

    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true) // 무한 루프
        {
            // 색깔을 노랑으로 변경
            sprite.color = Color.yellow;

            // 1초 대기
            yield return new WaitForSeconds(1f);

            // 색깔을 하양으로 변경
            sprite.color = Color.white;

            // 1초 대기
            yield return new WaitForSeconds(1f);
        }
    }
}
