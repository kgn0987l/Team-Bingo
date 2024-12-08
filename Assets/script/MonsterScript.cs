using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour {

    public int i_trigger = 0;
    public GameObject textFive;
    public List<Sprite> list_Spt = new List<Sprite>();
    SpriteRenderer sprt_rander;
    int i_indexNum;
    int i_indexNumTwo;
    public float f_AniwaitTime = 0.3f;
    float f_waitTime_cur = 0;
    public bool b_AnimeCheck = false;

    public float f_;
    public float f_max;

    float f_wait;


    public float f_moveX=150;
    public float f_moveY;


    bool b_start = false;

    public float f_delTIme = 3;

    public GameObject go_clock;

    // Use this for initialization
    void Start () {
        sprt_rander = GetComponent<SpriteRenderer>();
        BGMs.instance.PlaySound7();
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {

        if(!b_start)
        { return; }
        if (i_trigger == 4)
        {
           
                if (f_wait > 0.25f)
                {
                    transform.position += new Vector3(-1, f_moveY, 0) * Time.deltaTime;
                    if (transform.localScale.x > 0)
					transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
             
                    StartCoroutine(Dest());
               

                }
                else
                {
           
                
				transform.position += new Vector3(f_moveX, f_moveY, 0) * Time.deltaTime;
                f_wait += Time.deltaTime;
                }
            
        }

        if (i_trigger == 1)
        {
         
            if (Player.Instance.b_Safety)
            {
               // BGMs.instance.PlaySound7();
                if (f_wait > 4f)
                {
                    
                    transform.position += new Vector3(150, 0, 0) * Time.deltaTime;
                    if (transform.localScale.x > 0)
						transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                    StartCoroutine(Dest());
                }
                else
                {
                    f_wait += Time.deltaTime;
                }
            }

            if (b_AnimeCheck)
            {
                if (f_ < f_max)
                {
                    transform.position -= new Vector3(15, 0, 0) * Time.deltaTime;
                    f_ += Time.deltaTime;
                }


                f_waitTime_cur += Time.deltaTime;
                if (f_waitTime_cur > f_AniwaitTime)
                {
                    if (i_indexNum >= list_Spt.Count)
                    {
                        return;
                    }
                    //b_AnimeCheck = false;
                    f_waitTime_cur = 0;

                    sprt_rander.sprite = list_Spt[i_indexNum];
                    i_indexNum++;
                    //   Debug.Log(i_indexNum); b_AnimeCheck = true;

                }

            }
        } //1번 몬스터

        if (i_trigger == 2)
        {
           
       
            if (b_AnimeCheck)
            {
                if (f_ < f_max)
                {
                    transform.position -= new Vector3(0, 0.5f, 0) * Time.deltaTime;
                    f_ += Time.deltaTime;
                }


                f_waitTime_cur += Time.deltaTime;
                if (f_waitTime_cur > f_AniwaitTime)
                {
                    if (i_indexNum >= list_Spt.Count)
                    {
                        return;
                    }
                    //b_AnimeCheck = false;
                    f_waitTime_cur = 0;

                    sprt_rander.sprite = list_Spt[i_indexNum];
                    i_indexNum++;
                    //   Debug.Log(i_indexNum); b_AnimeCheck = true;
                    StartCoroutine(SeeOppo());
                }
            }

        }


        if (i_trigger == 3)
        {
       
            if (b_AnimeCheck)
            {
                if (f_ < f_max)
                {
                    transform.position -= new Vector3(0, 0.5f, 0) * Time.deltaTime;
                    f_ += Time.deltaTime;
                }


                f_waitTime_cur += Time.deltaTime;
                if (f_waitTime_cur > f_AniwaitTime)
                {
                    if (i_indexNum >= list_Spt.Count)
                    {
                        return;
                    }
                    //b_AnimeCheck = false;
                    f_waitTime_cur = 0;

                    sprt_rander.sprite = list_Spt[i_indexNum];
                    i_indexNum++;
                    //   Debug.Log(i_indexNum); b_AnimeCheck = true;
                    StartCoroutine(SeeOppo());
                }
            }

        }  
    }

    public void EVENT_MonsterAni()
    {
        if(i_trigger==1)
        {
       

        }
    }

    IEnumerator Dest()
    {


        yield return new WaitForSeconds(f_delTIme);


        Destroy(gameObject);
    }

    IEnumerator SeeOppo()
    {//두 번째 몬스터 고개 돌리기
        yield return new WaitForSeconds(1.5f);
        if (transform.localScale.x > 0)
			transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        yield return new WaitForSeconds(1.5f);
        if (i_trigger == 2)
        {
            go_clock.GetComponent<Rigidbody2D>().simulated = true;
            print("Cl");
            textFive.SetActive(true);
        }
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //	if (i_trigger == 4) 
        {
            if (Player.Instance.b_Safety == false) {
				Debug.Log ("FAlse!!!");
				Camera.Instance.Camera_GameOver ();
			}
		}
        if(collision.CompareTag("Portal"))
        {
            if(Player.Instance.b_Safety)
            {
                print("트루이니까 생존");
                collision.GetComponent<PortalScript>().b_portalAwake = true;
                print(collision.name+"Name::"); 
            }
            else
            {
                print("게임 오버!!!");
				Camera.Instance.Camera_GameOver ();
            }
        }
    }



    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        b_start = true;
    }
}
