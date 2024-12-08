using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour {

    public GameObject textTwo;
    public float f_ = 1.5f;
	// Use this for initialization
	void Start () {
        StartCoroutine(SelfDestroyCall());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SelfDestroyCall()
    {
        yield return new WaitForSeconds(f_);
        if(textTwo!=null)
        {
            textTwo.SetActive(true);
        }
        gameObject.SetActive(false);
    }
}
