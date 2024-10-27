using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class InputCheck : MonoBehaviour
{
    public InputField inputField;   // InputField를 참조할 변수
    public Text resultText;         // 결과 메시지를 표시할 Text
    public Text timeText;
    public string targetValue = "horang2.H";  // 확인할 값
    private int time = 5;

    void Start()
    {
        // InputField의 onEndEdit 이벤트 연결
        if (inputField != null)
        {
            inputField.onEndEdit.AddListener(CheckInputValue);
        }
    }

    // 입력값 확인 메서드
    void CheckInputValue(string userInput)
    {
        if (resultText != null)
        {
            // 입력 값과 targetValue 비교
            if (userInput == targetValue)
            {
                resultText.text = "Success \n Jump left at lvl 1";  // 성공 메시지
                resultText.color = Color.green;
                inputField.interactable = false;
                StartCoroutine(StartCountdown());
            }
            else
            {
                resultText.text = "Failure \n   Try again";  // 실패 메시지
                resultText.color = Color.red;
                inputField.interactable = false; //더이상 입력하지 못하게
                StartCoroutine(StartCountdown());

            }
        }
    }
    IEnumerator StartCountdown()
    {
        while (time > 0)
        {
            timeText.text = "남은 시간: " + time + "초";  // 남은 시간 표시
            yield return new WaitForSeconds(1f);               // 1초 대기
            time--;                                            // 1씩 감소
        }
        SceneManager.LoadScene("Start");
        // 카운트다운이 끝나면 씬 전환
    }
}
