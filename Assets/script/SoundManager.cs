using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

    public List<AudioSource> list_BGM;

    BGM last_bgm = BGM.Intro;
	

    public void PlayBGM(BGM _bgm)
    {
        if (list_BGM[(int)last_bgm].isPlaying)
            list_BGM[(int)last_bgm].Stop();

        last_bgm = _bgm;

        list_BGM[(int)_bgm].Play();
    }
   /* public void Event_Change()
    {
        list_BGM[(int)last_bgm].
    }*/

}
