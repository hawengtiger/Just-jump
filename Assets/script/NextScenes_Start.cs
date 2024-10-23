using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScenes_Start : MonoBehaviour
{
    public void SwitchSceneOnClick()
    {
        // 다음 씬의 빌드 인덱스로 전환합니다.
        SceneManager.LoadScene("Start");
    }

}