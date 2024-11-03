using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMs : MonoBehaviour {

	/*public AudioClip soundExplosion1;
	public AudioClip soundExplosion2;
	public AudioClip soundExplosion3;
	public AudioClip soundExplosion4;
	public AudioClip soundExplosion5;
	public AudioClip soundExplosion6;
    public AudioClip soundExplosion7;
    public AudioClip soundExplosion8;
    public AudioClip soundExplosion9;*/

    public AudioSource garbage;
    public AudioSource picture;
    public AudioSource boxopen;
    public AudioSource ball;
    public AudioSource clock;
    public AudioSource doll;
    public AudioSource monster;

    public static BGMs instance;


	void Awake(){
		if (BGMs.instance == null) 
		{
			BGMs.instance = this;
		}
	}

	// Use this for initialization
	void Start () {
     //  myAudio = this.gameObject.GetComponent<AudioSource> ();

        

    }

	public void PlaySound1(){
        print("CCA");
        garbage.Play();
        //myAudio.PlayOneShot(soundExplosion1);

    }
    public void PlaySound2()
    {
        picture.Play();
    }
    public void PlaySound3()
    {
        boxopen.Play();
    }
    public void PlaySound4()
    {
        ball.Play();
    }
    public void PlaySound5()
    {
        clock.Play(); 
    }
    public void PlaySound6()
    {
        doll.Play();
    }
    public void PlaySound7()
    {
        monster.Play();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
