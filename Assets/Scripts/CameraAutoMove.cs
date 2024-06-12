using UnityEngine;

public class CameraAutoMove : MonoBehaviour
{
    public float speed = 10.0f; // �̵� �ӵ� ����

    void Update()
    {
        // ���� ī�޶��� ��ġ�� �����ͼ� z�� �������� �̵�
        Vector3 currentPosition = transform.position;
        currentPosition.z += speed * Time.deltaTime;

        // ���ο� ī�޶� ��ġ�� ����
        transform.position = currentPosition;
    }
}

