using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    public GameObject Start_bnt;

    public GameObject go_Player;
    public GameObject go_obj;

    public bool b_StartCheck;
    // Use this for initialization

    void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseUpAsButton()
    {
        Debug.Log("AA");
        go_obj.SetActive(true);
        gameObject.SetActive(false);


    }
    public void GameStart()
    {
        b_StartCheck = true;
        Debug.Log(b_StartCheck);
        Start_bnt.gameObject.SetActive(false);
        SceneManager.LoadScene("basement");
    }
}
