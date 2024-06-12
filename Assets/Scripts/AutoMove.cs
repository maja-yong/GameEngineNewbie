using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 10.0f; // 이동 속도 설정

    void Update()
    {
        // 현재 위치를 가져와서 z축 방향으로 이동
        Vector3 currentPosition = transform.position;
        currentPosition.z += speed * Time.deltaTime;

        // 새로운 위치를 적용
        transform.position = currentPosition;

    }
}

