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
        StartCoroutine(StartCountdown()); // 5초 후 종료
    }
    IEnumerator StartCountdown()
    {
        while (time > 0)
        {
            timeText.text = "남은 시간: " + time + "초";  // 남은 시간 표시
            yield return new WaitForSeconds(1f);               // 1초 대기
            time--;                                            // 1씩 감소
        }

        // 카운트다운이 끝;
        yield return QuitAfterDelay();
    }
    private IEnumerator QuitAfterDelay()
    {
        yield return null; // 바로 종료하지 않도록

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // 에디터에서 종료
    #else
               Application.Quit(); // 빌드된 게임에서 종료
    #endif
    }
}
