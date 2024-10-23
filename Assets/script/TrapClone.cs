using UnityEngine;

public class TrapClone: MonoBehaviour
{
    public GameObject trapPrefab; // 복제할 트랩 프리팹
    public float speed = 35f; // 트랩 이동 속도
    private GameObject currentTrap; // 현재 생성된 트랩

    void Start()
    {
        // 첫 번째 트랩 생성
        SpawnTrap();
    }

    void Update()
    {
        // 추가적인 조건이 필요하다면 여기서 확인
    }

    void SpawnTrap()
    {
        if (currentTrap == null) // 현재 트랩이 없으면 생성
        {
            currentTrap = Instantiate(trapPrefab, transform.position, Quaternion.identity);
            currentTrap.GetComponent<Movetrap>().speed = speed; // 속도 설정
        }
    }
}

