using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public static Camera Instance;

    public Transform t_transform;
    public Transform t_transformTwo;
    public Transform t_transformThree;
    public Transform t_transformFore;
    public Transform t_transformFive;
    public Transform t_transformSix;
    public Transform t_transformSeven;
    public Transform t_transformEight;
    public Transform t_transformNine;
    public Transform t_transformTen;
    public Transform t_transformEleven;
    public Transform t_transformTwoelve;
    public Transform t_transform_13;
    public Transform t_transform_14;
    public Transform t_transform_15;
    public Transform t_Diedform;

	public GameObject go_ui;


    public GameObject go_keyOneSpr;

    // Use this for initialization
    void Start()
    {
        Instance = this;
        Debug.Log("AAAA" + transform.position);
    }

    public void Camera_MoveSetOne()
    {
        Debug.Log("!!");
        transform.position = new Vector3(t_transform.transform.position.x,-0.55f, transform.position.z);
    }

    public void Camera_MoveSetTwo()
    {
        print("adad");

        transform.position = new Vector3(t_transformTwo.transform.position.x, -0.55f, transform.position.z);
    }

    public void Camera_MoveSetThree()
    {
        transform.position = new Vector3(t_transformThree.transform.position.x, -0.55f, transform.position.z);
    }

    public void Camera_MoveSetFore()
    {
        transform.position = new Vector3(t_transformFore.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSetFive()
    {
        transform.position = new Vector3(t_transformFive.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSetSix()
    {
        transform.position = new Vector3(t_transformSix.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSetSeven()
    {
        transform.position = new Vector3(t_transformSeven.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSetEight()
    {
        transform.position = new Vector3(t_transformEight.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSetNine()
    {
        transform.position = new Vector3(t_transformNine.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSetTen()
    {
        transform.position = new Vector3(t_transformTen.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSetEleven()
    {
        transform.position = new Vector3(t_transformEleven.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSetTwoelve()
    {
        transform.position = new Vector3(t_transformTwoelve.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSet_13()
    {
        transform.position = new Vector3(t_transform_13.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSet_14()
    {
        transform.position = new Vector3(t_transform_14.transform.position.x, -0.55f, transform.position.z);
    }
    public void Camera_MoveSet_15()
    {
        transform.position = new Vector3(t_transform_15.transform.position.x, -0.55f, transform.position.z);
    }


	public void Camera_GameOver(){

		transform.position = new Vector3(t_Diedform.transform.position.x, -0.55f, transform.position.z);
		go_ui.SetActive (false);
	}

}
