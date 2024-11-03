using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour {

    public static PortalScript Instance;

    public GameObject key; //포탈나인 10번째넘버의 열쇠


    public int i_portalNum;

    public int i_keyOn = 0;

    public Transform t_transformOne;
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
   
    public bool b_NeedKey = false;

    public bool b_portalAwake = true;

    public GameObject col15;

    public GameObject keyNine;

    #region 
    [Header("Text")]
    public GameObject text_1;
    #endregion

    // Use this for initialization
    void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PortalState()
    {


        if (!b_portalAwake)
            return;

        if (i_portalNum ==1 )
        {

                Debug.Log("!!22");
                Camera.Instance.Camera_MoveSetOne();
            Camera.Instance.go_keyOneSpr.SetActive(false);

        }
        else if(i_portalNum==2)
        {
            Camera.Instance.Camera_MoveSetTwo();
        }
        else if (i_portalNum == 3 && b_portalAwake)
        {
            
        if(!b_portalAwake)
            return;
            Camera.Instance.Camera_MoveSetThree();
        }
        else if (i_portalNum == 4)
        {
            Camera.Instance.Camera_MoveSetFore();
        }else if (i_portalNum == 5)
        {
            if (!b_portalAwake)
                return;
            Camera.Instance.Camera_MoveSetFive();
    
        }else if (i_portalNum == 6)
        {
            if (!b_portalAwake)
                return;
            Camera.Instance.Camera_MoveSetSix();
            key.SetActive(false);
        }
        else if (i_portalNum == 7)
        {
            Camera.Instance.Camera_MoveSetSeven();
        }
        else if (i_portalNum == 8)
        {
            Camera.Instance.Camera_MoveSetEight();
        }
        else if (i_portalNum == 9)
        {
            if (!b_portalAwake)
                return;
            Camera.Instance.Camera_MoveSetNine();
        }
        else if (i_portalNum == 10)
        {
            if (!b_portalAwake)
                return;
            Camera.Instance.Camera_MoveSetTen();
            key.SetActive(false);
        }
        else if (i_portalNum == 11)
        {
            Camera.Instance.Camera_MoveSetEleven();
        }
        else if (i_portalNum == 12)
        {
            Camera.Instance.Camera_MoveSetTwoelve();
        }
        else if (i_portalNum == 13)
        {
            if (!b_portalAwake)
                return;
            Camera.Instance.Camera_MoveSet_13();
        }
        else if (i_portalNum == 14)
        {
            Camera.Instance.Camera_MoveSet_14();
        }
        else if (i_portalNum == 15)
        {
            Camera.Instance.Camera_MoveSet_15();
        }
      
        /* if (i_portalNum == 3 && b_NeedKey == true)
         {
             Camera.Instance.Camera_MoveSetThree();
         }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


    
        if (collision.CompareTag("Player"))
        {
            if (i_portalNum == 1)
            {
            if (!b_portalAwake)
                        return;

                    collision.transform.position = t_transformOne.transform.position;

                Camera.Instance.Camera_MoveSetOne();
                Camera.Instance.go_keyOneSpr.SetActive(false);
                b_portalAwake = true;




        
                
            }
            else if(i_portalNum==2)
            {
                collision.transform.position = t_transformTwo.transform.position;
            }
            else if (i_portalNum == 3 && b_portalAwake)
            {
                collision.transform.position = t_transformThree.transform.position;
            }
            else if (i_portalNum == 4)
            {
                if (!b_portalAwake)
                { return; }
                collision.transform.position = t_transformFore.transform.position;
            }
            else if (i_portalNum == 5)
            {
                collision.transform.position = t_transformFive.transform.position;
            }
            else if (i_portalNum == 6)
            {
                if (!b_portalAwake)
                    return;
                collision.transform.position = t_transformSix.transform.position;
            }
            else if (i_portalNum == 7)
            {
                collision.transform.position = t_transformSeven.transform.position;
            }
            else if (i_portalNum == 8)
            {
                collision.transform.position = t_transformEight.transform.position;
            }
            else if (i_portalNum == 9)
            {
                if (!b_portalAwake)
                    return;
                collision.transform.position = t_transformNine.transform.position;
                Camera.Instance.Camera_MoveSetNine();
                keyNine.SetActive(false);


            }
            else if (i_portalNum == 10)
            {
                if (!b_portalAwake)
                    return;

                collision.transform.position = t_transformTen.transform.position;
                key.SetActive(false);
            }
            else if (i_portalNum == 11)
            {
                collision.transform.position = t_transformEleven.transform.position;
            }
            else if (i_portalNum == 12)
            {
                collision.transform.position = t_transformTwoelve.transform.position;
            }
            else if (i_portalNum == 13)
            {
                if(Player.Instance.b_haveNeedle)
                {
                    Player.Instance.b_haveNeedle = false;
                    b_portalAwake = true;
                }
                if (!b_portalAwake)
                    return;


                    collision.transform.position = t_transform_13.transform.position;
                Camera.Instance.Camera_MoveSet_13();


            }
            else if (i_portalNum == 14)
            {
                collision.transform.position = t_transform_14.transform.position;
                Camera.Instance.Camera_MoveSet_14();
			}            
			else if (i_portalNum == 15)
			{
				if (Player.Instance.b_lastKey) {
					LastEvent.Instance.Call ();
                    text_1.SetActive(true);
                    col15.GetComponent<ScriptCall>().b_last = true;
				}
				if (!b_portalAwake)
					return;
                
				//collision.transform.position = t_transform_15.transform.position;
				Camera.Instance.Camera_MoveSet_15();
			}
        }

    }



}
