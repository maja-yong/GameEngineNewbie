using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 10.0f; // �̵� �ӵ� ����

    void Update()
    {
        // ���� ��ġ�� �����ͼ� z�� �������� �̵�
        Vector3 currentPosition = transform.position;
        currentPosition.z += speed * Time.deltaTime;

        // ���ο� ��ġ�� ����
        transform.position = currentPosition;

    }
}

