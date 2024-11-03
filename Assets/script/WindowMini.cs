using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowMini : MonoBehaviour {


	public GameObject portal;
	public GameObject b_key;
	public bool b_check;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		b_check = Player.Instance.b_haveNeedle;
	}

	private void  OnTriggerStay2D(Collider2D collision)
    {

		if (Player.Instance.b_haveNeedle) 
		{
			Player.Instance.b_haveNeedle = false;
			portal.SetActive (true);
			b_key.SetActive (false);
			portal.GetComponent<PortalScript> ().b_portalAwake = true;
			//gameObject.SetActive (false);

		}

	}



}
