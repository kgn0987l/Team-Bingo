using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iteminteraction : MonoBehaviour {

    public static Iteminteraction Instance;

    public float f_;
    public GameObject go_keyOne;
    public GameObject go_needle;
    public GameObject go_needleC;
    public int i_Number; // 3번이면 액자, 4번이면 시계, 5번임 바늘

    public GameObject go_picture;


    public GameObject go_ballSpr;


    public GameObject go_monsterOne;

    public GameObject body;
    public GameObject key;
    public GameObject keyBody;
    public GameObject knife;


    public GameObject go_check;


    #region 
    [Header("Text")]
    public GameObject textOne;
    public GameObject textTwo;
    public GameObject textThree;
    public GameObject textFore;
    public GameObject textFive;
    public GameObject textSix;
    #endregion


    BoxCollider2D bx2d;
    public bool check = false;
    bool b_click=false;
	// Use this for initialization
	void Start () {
        Instance = this;
        bx2d = GetComponent<BoxCollider2D>();

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            if (i_Number == 1)
            {
                BGMs.instance.PlaySound1();
                if (i_Number == 2)
                {
                    bx2d.isTrigger = true;
                }
                gameObject.SetActive(false);
            }
        }


        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            if (i_Number == 10)
            {
                if (i_Number == 11)
                {
                    bx2d.isTrigger = true;
                }
                gameObject.SetActive(false);
            }
        }
   


    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (Input.GetKey(KeyCode.F))
    //    {
    //         if (i_Number == 3)
    //        {
    //            print("DDD");
    //            go_picture.GetComponent<Rigidbody2D>().simulated = true;
    //
    //            StartCoroutine(MonsterOneSpawn()); // 2.5초뒤 몬스터 소환하는 코루틴함수 호출
    //
    //        }
    //    }
    //}

    private void OnMouseUpAsButton()
    {
        if (i_Number == 7)
        {
            if (go_check.GetComponent<ClickBigger>().i_num == 10)
            {
               go_check.GetComponent<ClickBigger>().SetInit();
                go_monsterOne.SetActive(true);
                go_keyOne.SetActive(true);
                Player.Instance.b_haveKey = true;
                textOne.SetActive(true);
                gameObject.SetActive(false);
                
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if(Input.GetKey(KeyCode.Joystick1Button1))
        {
            if (collision.gameObject.CompareTag("Player"))
            {

                if (i_Number == 2)
                {
                    if (bx2d != null)
                    { bx2d.isTrigger = true; }
                    go_keyOne.SetActive(true);
                    Player.Instance.b_haveKey = true;
                    gameObject.SetActive(false);
                }
                else if (i_Number == 3)
                {
                    
                    BGMs.instance.PlaySound2();
                    print("DDD");
                    textOne.SetActive(true);
                    StartCoroutine(WaitCall());
                    
                   // 2.5초뒤 몬스터 소환하는 코루틴함수 호출

                }
                else if (i_Number == 4)
                {
                    BGMs.instance.PlaySound5();
                    print("DDD");
                    textFive.SetActive(true);
                    go_picture.GetComponent<Rigidbody2D>().simulated = true;
                    StartCoroutine(MonsterOneSpawn());
                    StartCoroutine(NeedleActive());

                }
                else if (i_Number == 5)
                {

                    go_needle.SetActive(true);
                    Player.Instance.b_haveNeedle = true;
                    gameObject.SetActive(false);
                    Debug.Log("DASDASDASDAS");
                }
                else if (i_Number == 6)
                {

                    BGMs.instance.PlaySound4();
                    textFore.SetActive(true);
                    StartCoroutine(MonsterOneSpawn());
                    if (!b_click)
                    {
                        b_click = true;
                        StartCoroutine(NeedleActive());
                    }
                    go_ballSpr.SetActive(false);
                    // gameObject.SetActive(false);
                }
                
                else if (i_Number == 8)
                {
                    BGMs.instance.PlaySound3();
                    body.SetActive(true);
                    gameObject.SetActive(false);
                }
                else if (i_Number == 9)
                {
                    textThree.SetActive(true);
                    key.SetActive(true);
                    Player.Instance.b_haveKey = true;
                    keyBody.SetActive(false);

                }
                else if (i_Number == 10)
                {
                    gameObject.SetActive(false);
                }
                else if (i_Number == 11)
                {
                    if (bx2d != null)
                        { bx2d.isTrigger = true; }
                    textFive.SetActive(true);
                    go_keyOne.SetActive(true);
                    Player.Instance.b_lastKey = true;
                   // textSix.SetActive(true);
                    gameObject.SetActive(false);
                }
                else if (i_Number == 12)
                {
                    knife.SetActive(true);
                    Player.Instance.b_haveKnive = true;
                    textTwo.SetActive(true);
                    gameObject.SetActive(false);
                }
            }
        }

    }
    /*
    private void OnMouseUpAsButton()
    {

        if (i_Number == 1)
        {
            gameObject.SetActive(false);

        }
        else if (i_Number == 2)
        {
            go_keyOne.SetActive(true);
            Player.Instance.b_haveKey = true;
            gameObject.SetActive(false);
        }
        else if (i_Number == 3)
        {
            print("DDD");
            go_picture.GetComponent<Rigidbody2D>().simulated = true;

            StartCoroutine(MonsterOneSpawn()); // 2.5초뒤 몬스터 소환하는 코루틴함수 호출

        }
        else if (i_Number == 4)
        {
            print("DDD");
            go_picture.GetComponent<Rigidbody2D>().simulated = true;
            StartCoroutine(MonsterOneSpawn());
            StartCoroutine(NeedleActive());
        }
        else if (i_Number == 5)
        {

            go_needle.SetActive(true);
            Player.Instance.b_haveNeedle = true;
            gameObject.SetActive(false);
            Debug.Log("DASDASDASDAS");
        }
        else if (i_Number == 6)
        {


            StartCoroutine(MonsterOneSpawn());
			if (!b_click) 
			{
				b_click = true;
				StartCoroutine (NeedleActive ());
			}
            go_ballSpr.SetActive(false);
            // gameObject.SetActive(false);
        }
        else if (i_Number == 7)
        {
            if (go_check.GetComponent<ClickBigger>().i_num == 10)
            {


                go_check.GetComponent<ClickBigger>().SetInit();


                go_monsterOne.SetActive(true);
                go_keyOne.SetActive(true);
                Player.Instance.b_haveKey = true;
                gameObject.SetActive(false);
            }
        }
        else if (i_Number == 8)
        {

            body.SetActive(true);
            gameObject.SetActive(false);
        }
        else if (i_Number == 9)
        {
            key.SetActive(true);
            Player.Instance.b_haveKey = true;
            keyBody.SetActive(false);

        }
        else if (i_Number == 10)
        {
            gameObject.SetActive(false);
        }
        else if (i_Number == 11)
        {
            go_keyOne.SetActive(true);
            Player.Instance.b_lastKey = true;
            gameObject.SetActive(false);
        }
    }
    */
    public void MonsterCall()
    {
        StartCoroutine(MonsterOneSpawn());
    }

    IEnumerator WaitCall()
    {
        yield return new WaitForSeconds(f_);
        go_picture.GetComponent<Rigidbody2D>().simulated = true;

        StartCoroutine(MonsterOneSpawn()); // 2.5초뒤 몬스터 소환하는 코루틴함수 호출

    }
    IEnumerator NeedleActive()
    {
        yield return new WaitForSeconds(5.5f); // 이게 있어야 됨. 이 시간만큼 기다림.
        go_needleC.SetActive(true);
    }

    IEnumerator MonsterOneSpawn() // 코루틴함수.
    {
        print("ggjjh00");
        yield return new WaitForSeconds(4f); // 이게 있어야 됨. 이 시간만큼 기다림.
        
            go_monsterOne.SetActive(true);
            check = true;
        
        
    }

}
