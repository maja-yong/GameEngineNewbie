using System.Threading;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public GameObject gameOverCanvas; // ĵ������ �����ϱ� ���� ����
    public GameObject gameClearCanvas;
    void Start()
    {
        // ���� ���� �� ĵ������ ��Ȱ��ȭ
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(false);
        }
        else
        {
            Debug.LogError("GameOverCanvas�� �������� �ʾҽ��ϴ�.");
        }

        if (gameClearCanvas != null)
        {
            gameClearCanvas.SetActive(false);
        }
        else
        {
            Debug.LogError("GameClearCanvas�� �������� �ʾҽ��ϴ�.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �浹�� ������Ʈ�� �±װ� Enemy���� Ȯ��
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // �浹�� ������Ʈ�� �±װ� Enemy�� ��� �浹 �̺�Ʈ ó��
            Debug.Log("Player�� Enemy�� �浹�߽��ϴ�: " + collision.gameObject.name);

            // ���� ���� ó��
            GameOver();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Player�� Finish�� �浹�߽��ϴ�: " + collision.gameObject.name);

            // ���� ���� ó��
            GameClear();
        }
    }

    void GameOver()
    {
        // ���� ���� ĵ������ Ȱ��ȭ
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }
        else
        {
            Debug.LogError("GameOverCanvas�� �������� �ʾҽ��ϴ�.");
        }
        Time.timeScale = 0f;
    }

    void GameClear()
    {
        // ���� ���� ĵ������ Ȱ��ȭ
        if (gameClearCanvas != null)
        {
            gameClearCanvas.SetActive(true);
        }
        else
        {
            Debug.LogError("GameClearCanvas�� �������� �ʾҽ��ϴ�.");
        }
        Time.timeScale = 0f;
    }
}

