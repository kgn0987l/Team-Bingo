using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Invoke("ExitGame", 1);
        }
    }

    // Start is called before the first frame update
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // 어플리케이션 종료
#endif
    }
}
