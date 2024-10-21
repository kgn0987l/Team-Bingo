using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    /* private BoxCollider2D boxColl;
     public LayerMask layermask;*/

    public GameManager scr_Game_MNG;
    public Transform t_moveOne;

    public bool b_filp_X;

    public float p_Speed;

    public List<Sprite> list_Spt = new List<Sprite>();
    public List<Sprite> list_Stop = new List<Sprite>();

    SpriteRenderer sprt_rander;
    int i_indexNum;

    public float f_AniwaitTime = 0.3f;
    float f_waitTime_cur = 0;
    bool b_AnimeCheck = false;
    public bool b_MoveStop = true;
    private void Awake()
    {
        scr_Game_MNG.b_StartCheck = true;
        Debug.Log(scr_Game_MNG.b_StartCheck);
        b_filp_X = false;
        p_Speed = 2f;
    }
    // Use this for initialization

    void Start()
    {

        //  DontDestroyOnLoad(this.gameObject);
        //  boxColl = GetComponent<BoxCollider2D>();
        sprt_rander = GetComponent<SpriteRenderer>();
        scr_Game_MNG.b_StartCheck = true;
        b_AnimeCheck = true;

    }

    // Update is called once per frame
    void Update()
    {


        if (scr_Game_MNG.b_StartCheck)
        {
            if(Input.GetKey(KeyCode.D))
            { }
            else if(Input.GetKey(KeyCode.A))
            { }
                else if(Input.GetKey(KeyCode.S))
            { }else if(Input.GetKey(KeyCode.W))
            {

            }
            else
            {
                b_MoveStop = true;
            }


            if (b_MoveStop)
            {
                if (b_AnimeCheck)
                {

                    f_waitTime_cur += Time.deltaTime;
                    if (f_waitTime_cur > f_AniwaitTime)
                    {
                        b_AnimeCheck = false;
                        f_waitTime_cur = 0;

                        sprt_rander.sprite = list_Stop[i_indexNum];
                        i_indexNum++;
                        Debug.Log(i_indexNum); b_AnimeCheck = true;
                        if (i_indexNum >= list_Spt.Count)
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
                    /*RaycastHit2D hit;

                    Vector2 start = transform.position;
                    Vector2 end=start+new Vector2()*/

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
        if (collision.CompareTag("Portal"))
        {
            PortalScript.Instance.PortalState();
        }
    }

    //
}

