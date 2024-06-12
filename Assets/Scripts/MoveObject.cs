using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 10.0f;
    public float minX = -2.3f;
    public float maxX = 2.3f;

    void Update()
    {
        //���� �Է� �� ����
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //������ġ �ޱ�
        Vector3 currentPosition = transform.position;
        //���ο� ��ġ ���
        currentPosition.x += move;
        //x��ǥ�� �ּҰ��� �ִ밪 ���̷� ����
        currentPosition.x=Mathf.Clamp(currentPosition.x, minX, maxX);
        //������Ʈ ��ġ ������Ʈ
        transform.position = currentPosition;
    }
}
