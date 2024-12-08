using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSafety : MonoBehaviour {
	public static PlayerSafety Instance;

	public bool b_safety;

	// Use this for initialization
	void Start () {
		Instance=this;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    private void OnTriggerEnter2D(Collider2D collision)
    {

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
		
        if (collision.CompareTag("Player"))
        {
            if (Player.Instance.b_Down)
            {
                Player.Instance.b_Safety = true;
            }
            else
            {
                Player.Instance.b_Safety = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { 
                Player.Instance.b_Safety = false;
        }
    }
}
