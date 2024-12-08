using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGetScript : MonoBehaviour {

    public GameObject knife;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseUpAsButton()
    {
        knife.SetActive(true);
        Player.Instance.b_haveKnive = true;
        gameObject.SetActive(false);
    }
}
