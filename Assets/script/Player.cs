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
        p_Speed = 2.5f;
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

            // 조이스틱 입력 받기
            float moveHorizontal = Input.GetAxis("Horizontal"); // -1(왼쪽) ~ 1(오른쪽)
            float moveVertical = Input.GetAxis("Vertical");     // -1(아래) ~ 1(위)

            // 이동 처리
            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0) * p_Speed * Time.deltaTime;
            transform.position += movement;

            // 캐릭터 방향 플립
            if (moveHorizontal > 0) // 오른쪽 이동
            {
                transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
                b_filp_X = true;
            }
            else if (moveHorizontal < 0) // 왼쪽 이동
            {
                transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
                b_filp_X = false;
            }

            // 애니메이션 업데이트
            if (movement.magnitude > 0) // 이동 중
            {
                b_MoveStop = false;

                if (b_AnimeCheck)
                {
                    f_waitTime_cur += Time.deltaTime;
                    if (f_waitTime_cur > f_AniwaitTimeMv)
                    {
                        if (i_indexNum >= list_Spt.Count)
                        {
                            i_indexNum = 0;
                        }

                        f_waitTime_cur = 0;
                        sprt_rander.sprite = list_Spt[i_indexNum];
                        i_indexNum++;
                    }
                }
            }
            else // 정지 상태
            {
                b_MoveStop = true;
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
