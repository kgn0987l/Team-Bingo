using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            Invoke("reloadScene", 1);
        }
    }

    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
