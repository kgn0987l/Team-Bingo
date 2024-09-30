using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    static public CameraManager Instance;

    public GameObject target;
    public float MoveSpeed;
    private Vector3 TargetPosition;

    public BoxCollider2D bound;

    private Vector3 minBound;
    private Vector3 maxBound;

    private float halfwidth;
    private float halfheight;

    private Camera _Camera;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
    }
    // Use this for initialization
    void Start () {
        //DontDestroyOnLoad(this.gameObject);
        _Camera = GetComponent<Camera>();

        CameraMove();
        //minBound=bound.
    }
	
	// Update is called once per frame
	//void Update () {
	//if(target.gameObject != null)
   //     {
  //          TargetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

  //          this.transform.position = Vector3.Lerp(this.transform.position, TargetPosition, MoveSpeed * Time.deltaTime);
   //     }
//	}


    void CameraMove()
    {
        transform.position = new Vector3(12.7f, transform.position.y, transform.position.z);
    }
}
