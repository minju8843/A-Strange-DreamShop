using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFX_2023 : MonoBehaviour
{
    public Slider back_SFX_Volume;
    public AudioSource sfx1;//��ư�Ҹ�
    public AudioSource sfx2;//������ �Ҹ�
    public AudioSource sfx3;// �� �Ҹ�
    public AudioSource sfx4;// ���ڱ� �Ҹ�
    public AudioSource sfx5;// �� ���� �Ҹ�
    public AudioSource sfx6;// ���� �Ҹ�

    public Only_Line QuestObject;

    /*public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;*/

    public Text SFX_Sound;
    public float back_SFX_Vol = 0.5001f;//���� private���µ� ������

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

        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(DisableGetFloat) ũ���" + back_SFX_Vol + "��.");*/

        //float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
        //back_SFX_Vol = SFX_Sd;
        //Debug.Log(SFX_Sd + "�� ������ ȿ���� ũ��");

        back_SFX_Volume.value = back_SFX_Vol;

        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);

        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(DisableGetFloat) ũ���" + back_SFX_Vol + "��.");



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

        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(EnableGetFloat) ũ���" + back_SFX_Vol + "��.");*/

        //float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
        //back_SFX_Vol = SFX_Sd;
        //Debug.Log(SFX_Sd + "�� ������ ȿ���� ũ��");

        back_SFX_Volume.value = back_SFX_Vol;

        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);

        
        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(EnableGetFloat) ũ���" + back_SFX_Vol+ "��.");


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

        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(GetFloat) ũ���" + back_SFX_Vol + "��.");*/

        //float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
        //back_SFX_Vol = SFX_Sd;
        //Debug.Log(SFX_Sd + "�� ������ ȿ���� ũ��");

        back_SFX_Volume.value = back_SFX_Vol;
        
        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);

        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(Start) ũ���" + back_SFX_Vol + "��.");

        /*back_SFX_Volume.value = back_SFX_Vol;
        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);


        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(GetFloat) ũ���" + back_SFX_Vol + "��.");*/



    }

    void Update()
    {
        SoundSlider();
        

    }

    public void SoundSlider()//�����̴� ����� �� �Լ�
    {
        //float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
        //back_SFX_Vol = SFX_Sd;
        //Debug.Log(SFX_Sd + "�� ������ ȿ���� ũ��");
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
        Debug.Log("ȿ���� ũ���(SetFloat)" + back_SFX_Vol + "��.");


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
