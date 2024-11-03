using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCall : MonoBehaviour {

    public bool b_steped=true;
    public GameObject text;
    public int i_num;

    public bool b_last = true;

    public float f_;
	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (b_last)
        {
            if (i_num == 1)
            {
                if (collision.gameObject.CompareTag("Player"))
                {
                    if (b_steped)
                    {
                        b_steped = false;
                        text.SetActive(true);

                    }
                }
            }
            else if (i_num == 0)
            {
                if (b_steped)
                {
                    b_steped = false;
                    text.SetActive(true);

                }
            }
            else
            {

            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (b_last)
        {
            if (i_num == 1)
            {
                if (collision.gameObject.CompareTag("Player"))
                {
                    if (b_steped)
                    {
                        b_steped = false;
                        text.SetActive(true);

                    }
                }
            }
            else if (i_num == 0)
            {

                if (b_steped)
                {
                    b_steped = false;
                    text.SetActive(true);

                }

            }
            else
            {
                StartCoroutine(TextWait());

            }
        }
    }

    IEnumerator TextWait()
    {
        if (i_num == 3)
        {
            yield return new WaitForSeconds(3.5f);
            text.SetActive(true);
        }
        else
        {
            yield return new WaitForSeconds(f_);
            text.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
