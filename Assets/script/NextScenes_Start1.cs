using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScenes_Start1 : MonoBehaviour
{
    public void SwitchSceneOnClick()
    {
        // ���� ���� ���� �ε����� ��ȯ�մϴ�.
        SceneManager.LoadScene("Start1");
    }

}