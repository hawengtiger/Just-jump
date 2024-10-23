using UnityEngine;

public class TrapClone: MonoBehaviour
{
    public GameObject trapPrefab; // ������ Ʈ�� ������
    public float speed = 35f; // Ʈ�� �̵� �ӵ�
    private GameObject currentTrap; // ���� ������ Ʈ��

    void Start()
    {
        // ù ��° Ʈ�� ����
        SpawnTrap();
    }

    void Update()
    {
        // �߰����� ������ �ʿ��ϴٸ� ���⼭ Ȯ��
    }

    void SpawnTrap()
    {
        if (currentTrap == null) // ���� Ʈ���� ������ ����
        {
            currentTrap = Instantiate(trapPrefab, transform.position, Quaternion.identity);
            currentTrap.GetComponent<Movetrap>().speed = speed; // �ӵ� ����
        }
    }
}

