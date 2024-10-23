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
        while (true) // ���� ����
        {
            // ������ ������� ����
            sprite.color = Color.yellow;

            // 1�� ���
            yield return new WaitForSeconds(1f);

            // ������ �Ͼ����� ����
            sprite.color = Color.white;

            // 1�� ���
            yield return new WaitForSeconds(1f);
        }
    }
}
