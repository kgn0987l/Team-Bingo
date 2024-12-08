using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour {

    public GameObject mon;
	// Use this for initialization
	void Start () {
        StartCoroutine(Call());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    
   IEnumerator Call()
    {
        yield return new WaitForSeconds(2.5f);
        mon.SetActive(true);
    }
}
