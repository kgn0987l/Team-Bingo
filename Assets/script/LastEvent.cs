using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastEvent : MonoBehaviour {
	public static LastEvent Instance;

	public GameObject monsters;
	public GameObject portal15;

	public GameObject go_key;
	public GameObject off_door;
	// Use this for initialization
	void Start () {
		Instance = this;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Call(){
		StartCoroutine (LastEvent_ ());
	}

	IEnumerator LastEvent_()
	{print ("aAAA");

		Player.Instance.b_lastKey = false;
		go_key.SetActive (false);
		yield return new WaitForSeconds(7f);
		monsters.SetActive(true);
		yield return new WaitForSeconds(1.5f);
		off_door.SetActive (false);
		Destroy (off_door);
		portal15.GetComponent<PortalScript>().b_portalAwake=true;

		//gameObject.SetActive (false);
	}
}
