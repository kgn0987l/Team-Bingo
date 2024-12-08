using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScripts : MonoBehaviour {
    public static ItemScripts Instance;
	// Use this for initialization
	void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ItemSet(int i_)
    {
        if(i_==1)
        {   
            Destroy(gameObject);
            Debug.Log("CC");
        }else if(i_==2)
        {
            Destroy(gameObject);
            Debug.Log("DD");
        }
    }

}
