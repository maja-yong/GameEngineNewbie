using UnityEngine;

public class CameraAutoMove : MonoBehaviour
{
    public float speed = 10.0f; // 이동 속도 설정

    void Update()
    {
        // 현재 카메라의 위치를 가져와서 z축 방향으로 이동
        Vector3 currentPosition = transform.position;
        currentPosition.z += speed * Time.deltaTime;

        // 새로운 카메라 위치를 적용
        transform.position = currentPosition;
    }
}

