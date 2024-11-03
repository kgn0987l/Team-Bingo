using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour {
    public static Area Instance;
    public bool b_Area;

	// Use this for initialization
	void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   /* private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && b_Area)
        {
            print("BBBB");
            ClickBigger.Instance.b_cant = false;
        }
        else
        {
            ClickBigger.Instance.b_doll = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ClickBigger.Instance.b_cant = true;
        ClickBigger.Instance.b_doll = true;
    }*/
}
