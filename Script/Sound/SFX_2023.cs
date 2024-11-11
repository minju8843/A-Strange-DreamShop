using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFX_2023 : MonoBehaviour
{
    public Slider back_SFX_Volume;
    public AudioSource sfx1;//버튼소리
    public AudioSource sfx2;//때리는 소리
    public AudioSource sfx3;// 벨 소리
    public AudioSource sfx4;// 발자국 소리
    public AudioSource sfx5;// 문 여는 소리
    public AudioSource sfx6;// 사인 소리

    public Only_Line QuestObject;

    /*public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;*/

    public Text SFX_Sound;
    public float back_SFX_Vol = 0.5001f;//원래 private였는데 수정함

    //public float B_Sound = 1.0f;

    void OnDisable()
    {





        /*back_SFX_Volume.value = back_SFX_Vol;
        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);


        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("스타트에 위치한 효과음(DisableGetFloat) 크기는" + back_SFX_Vol + "다.");*/

        //float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
        //back_SFX_Vol = SFX_Sd;
        //Debug.Log(SFX_Sd + "가 저장한 효과음 크기");

        back_SFX_Volume.value = back_SFX_Vol;

        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);

        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("스타트에 위치한 효과음(DisableGetFloat) 크기는" + back_SFX_Vol + "다.");



    }

    void OnEnable()
    {
        /*back_SFX_Volume.value = back_SFX_Vol;
        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);


        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("스타트에 위치한 효과음(EnableGetFloat) 크기는" + back_SFX_Vol + "다.");*/

        //float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
        //back_SFX_Vol = SFX_Sd;
        //Debug.Log(SFX_Sd + "가 저장한 효과음 크기");

        back_SFX_Volume.value = back_SFX_Vol;

        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);

        
        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("스타트에 위치한 효과음(EnableGetFloat) 크기는" + back_SFX_Vol+ "다.");


    }


    void Start()
    {

        /*back_SFX_Volume.value = back_SFX_Vol;
        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);
        
   
        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("스타트에 위치한 효과음(GetFloat) 크기는" + back_SFX_Vol + "다.");*/

        //float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
        //back_SFX_Vol = SFX_Sd;
        //Debug.Log(SFX_Sd + "가 저장한 효과음 크기");

        back_SFX_Volume.value = back_SFX_Vol;
        
        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);

        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("스타트에 위치한 효과음(Start) 크기는" + back_SFX_Vol + "다.");

        /*back_SFX_Volume.value = back_SFX_Vol;
        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);


        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("스타트에 위치한 효과음(GetFloat) 크기는" + back_SFX_Vol + "다.");*/



    }

    void Update()
    {
        SoundSlider();
        

    }

    public void SoundSlider()//슬라이더 기능이 될 함수
    {
        //float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
        //back_SFX_Vol = SFX_Sd;
        //Debug.Log(SFX_Sd + "가 저장한 효과음 크기");
        //back_SFX_Volume.value = back_SFX_Vol;

        back_SFX_Vol = back_SFX_Volume.value;


        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;
        //back_SFX_Vol = back_SFX_Volume.value;


        PlayerPrefs.SetFloat("back_SFX_Vol", back_SFX_Vol);
        SFX_Sound.text = back_SFX_Vol.ToString();

        PlayerPrefs.Save();
        Debug.Log("효과음 크기는(SetFloat)" + back_SFX_Vol + "다.");


    }

    public void SFX_Line_Button()
    {
        sfx1.Play();


        /*QuestObject.SFX_Index = 0;

        QuestObject.SFX_Object[0].gameObject.SetActive(true);
        QuestObject.SFX_Object[1].gameObject.SetActive(false);
        QuestObject.SFX_Object[2].gameObject.SetActive(false);
        QuestObject.SFX_Object[3].gameObject.SetActive(false);
        QuestObject.SFX_Object[4].gameObject.SetActive(false);
        QuestObject.SFX_Object[5].gameObject.SetActive(false);*/
    }
}
