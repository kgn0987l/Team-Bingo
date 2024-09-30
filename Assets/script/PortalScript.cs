using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour {
    public static PortalScript Instance;
    public int i_portalNum;

    public Transform t_transformOne;
    public Transform t_transformTwo;
    // Use this for initialization
    void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PortalState()
    {
        
        if(i_portalNum ==1)
        {
            Debug.Log("!!22");
            Camera.Instance.Camera_MoveSetOne();
            
        }else if(i_portalNum==2)
        {
            Camera.Instance.Camera_MoveSetTwo();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if (i_portalNum == 1)
            { collision.transform.position = t_transformOne.transform.position; }
            else if(i_portalNum==2)
            {
                collision.transform.position = t_transformTwo.transform.position;
            }

        }

    }



}
