using System.Threading;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public GameObject gameOverCanvas; // 캔버스를 참조하기 위한 변수
    public GameObject gameClearCanvas;
    void Start()
    {
        // 게임 시작 시 캔버스를 비활성화
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(false);
        }
        else
        {
            Debug.LogError("GameOverCanvas가 설정되지 않았습니다.");
        }

        if (gameClearCanvas != null)
        {
            gameClearCanvas.SetActive(false);
        }
        else
        {
            Debug.LogError("GameClearCanvas가 설정되지 않았습니다.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 충돌한 오브젝트의 태그가 Enemy인지 확인
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // 충돌한 오브젝트의 태그가 Enemy인 경우 충돌 이벤트 처리
            Debug.Log("Player가 Enemy와 충돌했습니다: " + collision.gameObject.name);

            // 게임 오버 처리
            GameOver();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Player가 Finish와 충돌했습니다: " + collision.gameObject.name);

            // 게임 오버 처리
            GameClear();
        }
    }

    void GameOver()
    {
        // 게임 오버 캔버스를 활성화
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }
        else
        {
            Debug.LogError("GameOverCanvas가 설정되지 않았습니다.");
        }
        Time.timeScale = 0f;
    }

    void GameClear()
    {
        // 게임 오버 캔버스를 활성화
        if (gameClearCanvas != null)
        {
            gameClearCanvas.SetActive(true);
        }
        else
        {
            Debug.LogError("GameClearCanvas가 설정되지 않았습니다.");
        }
        Time.timeScale = 0f;
    }
}

