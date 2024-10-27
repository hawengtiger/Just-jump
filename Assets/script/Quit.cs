using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public Text timeText;
    private int time = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown()); // 5�� �� ����
    }
    IEnumerator StartCountdown()
    {
        while (time > 0)
        {
            timeText.text = "���� �ð�: " + time + "��";  // ���� �ð� ǥ��
            yield return new WaitForSeconds(1f);               // 1�� ���
            time--;                                            // 1�� ����
        }

        // ī��Ʈ�ٿ��� ��;
        yield return QuitAfterDelay();
    }
    private IEnumerator QuitAfterDelay()
    {
        yield return null; // �ٷ� �������� �ʵ���

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // �����Ϳ��� ����
    #else
               Application.Quit(); // ����� ���ӿ��� ����
    #endif
    }
}
