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

    public void SoundSlider()//�����̴� ����� �� �Լ�
    {

        //stop1.S_Speed = back_Speed.value;//���� �߰��� ��
        //stop2.S_Speed = back_Speed.value;//���� �߰��� ��
        //stop3.S_Speed = back_Speed.value;//���� �߰��� ��
        //stop4.S_Speed = back_Speed.value;//���� �߰��� ��
        //stop5.S_Speed = back_Speed.value;//���� �߰��� ��
        //stop6.S_Speed = back_Speed.value;//���� �߰��� ��
        //stop7.S_Speed = back_Speed.value;//���� �߰��� ��

        Speed = back_Speed.value;
        PlayerPrefs.SetFloat("Speed_1", Speed);
        Fast.text = Speed.ToString();
        PlayerPrefs.Save();


    }
}
