using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 10.0f;
    public float minX = -2.3f;
    public float maxX = 2.3f;

    void Update()
    {
        //수평 입력 값 감지
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //현재위치 받기
        Vector3 currentPosition = transform.position;
        //새로운 위치 계산
        currentPosition.x += move;
        //x좌표를 최소값과 최대값 사이로 제한
        currentPosition.x=Mathf.Clamp(currentPosition.x, minX, maxX);
        //오브젝트 위치 업데이트
        transform.position = currentPosition;
    }
}
