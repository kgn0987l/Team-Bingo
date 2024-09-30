using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public static Camera Instance;

    public Transform t_transform;
    public Transform t_transformTwo;

    // Use this for initialization
    void Start()
    {
        Instance = this;
        Debug.Log("AAAA" + transform.position);
    }

    public void Camera_MoveSetOne()
    {
        Debug.Log("!!");
        transform.position = new Vector3(t_transform.transform.position.x, t_transform.transform.position.y, transform.position.z);
    }

    public void Camera_MoveSetTwo()
    {
        transform.position = new Vector3(t_transformTwo.transform.position.x, t_transformTwo.transform.position.y, transform.position.z);
    }


}
