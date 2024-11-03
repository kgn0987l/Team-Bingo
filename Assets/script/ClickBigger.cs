using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBigger : MonoBehaviour {
    public static ClickBigger Instance;

    public int i_num; // 1번

    public Transform tr_;
    public Transform tr;

    public GameObject doll;
    public GameObject key;

    public GameObject knife;

    public GameObject background; // 쇼파방 백그라운드
    public GameObject keyspr;

   public bool b_click = false;


   /* public bool b_cant;
    public bool b_doll;*/
    int i_itemGet = 0;

    #region 
    [Header("Text")]
    public GameObject text1;
    #endregion


    // Use this for initialization
    void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void SetInit()
    {
        transform.position = tr.position;
        transform.localScale = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
        GetComponent<SpriteRenderer>().sortingOrder = 3;
        b_click = false;
        background.SetActive(true);
    }
    private void OnMouseUpAsButton()
    {
       /* if(b_cant)
        {
            return;
        }*/
        if (i_num == 0)
        {
            if (!b_click)
            {
                transform.position = tr_.transform.position;
                transform.localScale = new Vector2(transform.localScale.x * 2, transform.localScale.y * 2);
                print(GetComponent<SpriteRenderer>().sortingOrder);
                GetComponent<SpriteRenderer>().sortingOrder = 7;
                keyspr.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 8;
                background.SetActive(false);
                b_click = true;
                i_num = 10;
            }
            else if (b_click)
            {
                transform.position = tr.position;
                transform.localScale = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
                

              //  b_click = false;
            }
        }

       /* if(b_doll)
        {
            return;
        }*/
        if(b_click&&i_itemGet>=1&&i_num==1)
        {
            BGMs.instance.PlaySound6();
            text1.SetActive(true);
			background.SetActive(false);
                key.SetActive(true);
                Player.Instance.b_haveKey = true;
                gameObject.SetActive(false);
			background.SetActive(true);
        }

        if(i_num==1&&Player.Instance.b_haveKnive)
        {
            if (!b_click)
            {
				background.SetActive(false);
                transform.position = tr_.transform.position;
                transform.localScale = new Vector2(transform.localScale.x * 2, transform.localScale.y * 2);
                b_click = true;
            }else if(b_click)
            {
                doll.SetActive(false);
                knife.SetActive(false);
                i_itemGet++;

            }


        }


    }
}
