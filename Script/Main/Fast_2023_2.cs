using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fast_2023_2 : MonoBehaviour
{
    public Slider back_Speed;
    public Text Fast;
    public float Speed = 0.0f;

    void Start()
    {
        Time.timeScale = 0.0f;

        Speed = Time.timeScale;
        Speed = PlayerPrefs.GetFloat("Speed_1", 0.0f);
        back_Speed.value = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        SoundSlider();
    }

    public void SoundSlider()//슬라이더 기능이 될 함수
    {

        //stop1.S_Speed = back_Speed.value;//새로 추가한 거
        //stop2.S_Speed = back_Speed.value;//새로 추가한 거
        //stop3.S_Speed = back_Speed.value;//새로 추가한 거
        //stop4.S_Speed = back_Speed.value;//새로 추가한 거
        //stop5.S_Speed = back_Speed.value;//새로 추가한 거
        //stop6.S_Speed = back_Speed.value;//새로 추가한 거
        //stop7.S_Speed = back_Speed.value;//새로 추가한 거

        Speed = back_Speed.value;
        PlayerPrefs.SetFloat("Speed_1", Speed);
        Fast.text = Speed.ToString();
        PlayerPrefs.Save();


    }
}
