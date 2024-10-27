using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class InputCheck : MonoBehaviour
{
    public InputField inputField;   // InputField�� ������ ����
    public Text resultText;         // ��� �޽����� ǥ���� Text
    public Text timeText;
    public string targetValue = "horang2.H";  // Ȯ���� ��
    private int time = 5;

    void Start()
    {
        // InputField�� onEndEdit �̺�Ʈ ����
        if (inputField != null)
        {
            inputField.onEndEdit.AddListener(CheckInputValue);
        }
    }

    // �Է°� Ȯ�� �޼���
    void CheckInputValue(string userInput)
    {
        if (resultText != null)
        {
            // �Է� ���� targetValue ��
            if (userInput == targetValue)
            {
                resultText.text = "Success \n Jump left at lvl 1";  // ���� �޽���
                resultText.color = Color.green;
                inputField.interactable = false;
                StartCoroutine(StartCountdown());
            }
            else
            {
                resultText.text = "Failure \n   Try again";  // ���� �޽���
                resultText.color = Color.red;
                inputField.interactable = false; //���̻� �Է����� ���ϰ�
                StartCoroutine(StartCountdown());

            }
        }
    }
    IEnumerator StartCountdown()
    {
        while (time > 0)
        {
            timeText.text = "���� �ð�: " + time + "��";  // ���� �ð� ǥ��
            yield return new WaitForSeconds(1f);               // 1�� ���
            time--;                                            // 1�� ����
        }
        SceneManager.LoadScene("Start");
        // ī��Ʈ�ٿ��� ������ �� ��ȯ
    }
}
