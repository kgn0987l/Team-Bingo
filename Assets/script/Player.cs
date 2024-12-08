using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    /* private BoxCollider2D boxColl;
     public LayerMask layermask;*/

    public GameManager scr_Game_MNG;
    public Transform t_moveOne;

    public bool b_filp_X;

    public float p_Speed;

    public List<Sprite> list_Spt = new List<Sprite>();
    public List<Sprite> list_Stop = new List<Sprite>();
    public List<Sprite> list_Down = new List<Sprite>();

    SpriteRenderer sprt_rander;
    int i_indexNum;
    int i_indexNumTwo;
    public float f_AniwaitTime = 0.3f;
    public float f_AniwaitTimeMv = 0.03f;
    float f_waitTime_cur = 0;
    public bool b_AnimeCheck = false;
    public bool b_MoveStop = true;


    public bool b_Down = false;
    public bool b_Safety = false;


    public bool b_haveKey = false;
    public bool b_haveNeedle = false;
    public bool b_haveKnive = false;
	public bool b_lastKey = false;



    private void Awake()
    {
        Instance = this;
        scr_Game_MNG.b_StartCheck = true;
        Debug.Log(scr_Game_MNG.b_StartCheck);
        b_filp_X = false;
        p_Speed = 1.5f;
    }
    // Use this for initialization

    void Start()
    {
        //Time.timeScale = 2;

        //  DontDestroyOnLoad(this.gameObject);
        //  boxColl = GetComponent<BoxCollider2D>();
        sprt_rander = GetComponent<SpriteRenderer>();
        scr_Game_MNG.b_StartCheck = true;
        b_AnimeCheck = true;



    }

    // Update is called once per frame
    void Update()
    {

       // print(b_haveKey + "DADA");

        if (scr_Game_MNG.b_StartCheck)
        {
            if(Input.GetKey(KeyCode.D))
            {

            }
            else if(Input.GetKey(KeyCode.A))
            {

            }
            else if(Input.GetKey(KeyCode.S))
            {

            }
            else if(Input.GetKey(KeyCode.W))
            {

            }
            else
            {
                b_MoveStop = true;
            }

            if(Input.GetKey(KeyCode.R))
            {
                sprt_rander.sprite = list_Down[0];
                b_Down = true;
                if (b_Down)
                { return; }
            }
            else
            {
                b_Down = false;
            }


            if (b_MoveStop)
            {
                if (b_AnimeCheck)
                {
                    if(i_indexNum >= list_Stop.Count)
                    {
                        i_indexNum = 0;
                    }
                    f_waitTime_cur += Time.deltaTime;
                    if (f_waitTime_cur > f_AniwaitTime)
                    {
                       // b_AnimeCheck = false;
                        f_waitTime_cur = 0;

                        sprt_rander.sprite = list_Stop[i_indexNum];
                        i_indexNum++;
                        //Debug.Log(i_indexNum); b_AnimeCheck = true;
                        if (i_indexNum >= list_Stop.Count)
                        {
                            i_indexNum = 0;
                        }
                    }
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                b_MoveStop = false;
                b_filp_X = true;
                transform.position += new Vector3(p_Speed, 0, 0) * p_Speed * Time.deltaTime;
                if (transform.localScale.x > 0)
                    transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
                if (b_AnimeCheck)
                {
                    f_waitTime_cur += Time.deltaTime;
                    if (f_waitTime_cur > f_AniwaitTimeMv)
                    {
                        if (i_indexNum >= list_Spt.Count)
                        {
                            i_indexNum = 0;
                        }
                        //b_AnimeCheck = false;
                        f_waitTime_cur = 0;

                        sprt_rander.sprite = list_Spt[i_indexNum];
                        i_indexNum++;
                     //   Debug.Log(i_indexNum); b_AnimeCheck = true;

                    }

                }
            }
            else
            {
            
            }



            if (Input.GetKey(KeyCode.A))
            {
                b_filp_X = false;
                b_MoveStop = false;
                transform.position -= new Vector3(p_Speed, 0, 0) * p_Speed * Time.deltaTime;
                if (transform.localScale.x < 0)
                    transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
                if (b_AnimeCheck)
                {
                    f_waitTime_cur += Time.deltaTime;
                    if (f_waitTime_cur > f_AniwaitTimeMv)
                    {
                        if (i_indexNum >= list_Spt.Count)
                        {
                            i_indexNum = 0;
                        }
                        //b_AnimeCheck = false;
                        f_waitTime_cur = 0;

                        sprt_rander.sprite = list_Spt[i_indexNum];
                        i_indexNum++;
                        // Debug.Log(i_indexNum);
                        b_AnimeCheck = true;
                      
                    }

                }
            }
            else
            {
          
            }

            if (Input.GetKey(KeyCode.S))
            {
                b_filp_X = false;
                b_MoveStop = false;
                transform.position -= new Vector3(0, p_Speed, 0) * p_Speed * Time.deltaTime;
                if (transform.localScale.y < 0)
                    transform.localScale = new Vector3(transform.localScale.x, 1, transform.localScale.z);
                if (b_AnimeCheck)
                {
                    f_waitTime_cur += Time.deltaTime;
                    if (f_waitTime_cur > f_AniwaitTimeMv)
                    {
                        if (i_indexNum >= list_Spt.Count)
                        {
                            i_indexNum = 0;
                        }
                        //b_AnimeCheck = false;
                        f_waitTime_cur = 0;

                        sprt_rander.sprite = list_Spt[i_indexNum];
                        i_indexNum++;
                        //Debug.Log(i_indexNum);
                        b_AnimeCheck = true;
                     
                    }

                }
            }
            else
            {
            
            }

            if (Input.GetKey(KeyCode.W))
            {
                b_filp_X = false;
                b_MoveStop = false;
                transform.position += new Vector3(0, p_Speed, 0) * p_Speed * Time.deltaTime;
                if (transform.localScale.y < 0)
                    transform.localScale = new Vector3(transform.localScale.x, 1, transform.localScale.z);
                if (b_AnimeCheck)
                {
                    f_waitTime_cur += Time.deltaTime;
                    if (f_waitTime_cur > f_AniwaitTimeMv)
                    {
                        if (i_indexNum >= list_Spt.Count)
                        {
                            i_indexNum = 0;
                        }
                        //b_AnimeCheck = false;
                        f_waitTime_cur = 0;

                        sprt_rander.sprite = list_Spt[i_indexNum];
                        i_indexNum++;
                        //Debug.Log(i_indexNum);
                        b_AnimeCheck = true;
                       
                    }
                }
            }
            else
            {
               
            }

        }
        /* if (b_AnimeCheck)
         {
             f_waitTime_cur += Time.deltaTime;
             if (f_waitTime_cur > f_AniwaitTime)
             {
                 b_AnimeCheck = false;
                 f_waitTime_cur = 0;

                 sprt_rander.sprite = list_Spt[i_indexNum];
                 i_indexNum++;
                 Debug.Log(i_indexNum); b_AnimeCheck = true;
                 if (i_indexNum >= list_Spt.Count)
                 {
                     i_indexNum = 0;
                 }
             }
             else
             {
                 return;
             }
         }*/
    }//update
    private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("SafetyZone")) {

			b_Safety = true;
		} else {
		}


		if (collision.CompareTag ("Portal")) {
			if (collision.GetComponent<PortalScript> ().b_portalAwake) {
				collision.GetComponent<PortalScript> ().PortalState ();
			} else if (!collision.GetComponent<PortalScript> ().b_portalAwake) {
				if (b_haveKey) {
					if (collision.GetComponent<PortalScript> ().i_portalNum <= 12) {
						collision.GetComponent<PortalScript> ().b_portalAwake = true;
						b_haveKey = false;
					}

				}
			}
            
		}

	}
		
		void OnTriggerExit2D(Collider2D collision)
		{
		if (collision.CompareTag ("SafetyZone")) {
			b_Safety = false;
		} else {
		}

		}

    }
