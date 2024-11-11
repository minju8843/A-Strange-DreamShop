using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Inside : MonoBehaviour
{
    public GameObject First_Circle_Inside_TimeLine;
    //빛나는 동그라미 눌렀을 때 나오는 거

    public GameObject Second_Circle_Inside_TimeLine;
    //빛나는 동그라미 눌렀을 때 나오는 거

    public Animator First_Circle_anim;
    //빛나는 동그라미 눌렀을 때 나오는 애니메이션
    //흐릿한 화면이 나타나고 없어지는 거

    public Animator Second_Circle_anim;
    //빛나는 동그라미 눌렀을 때 나오는 애니메이션
    //흐릿한 화면이 나타나고 없어지는 거

    public Animator Square_anim;
    //타임라인 눌렀을 때 나오는 거
    //안에 2개의 챕터 세분화 있는 공간의 애니메이션



    public GameObject Square_TimeLine;
    //타임라인 불러오는 거
    //안에 2개의 챕터의 세분화 있음

    public GameObject CheckPoint_No1;
    //첫 번째 네모 선택시 예, 아니오

    public GameObject CheckPoint_No2;
    //두 번째 네모 선택시 예, 아니오



    void Start()
    {
        First_Circle_anim.SetBool("Button_P", false);

        Second_Circle_anim.SetBool("Button_P", false);

        Square_anim.SetBool("Button_P", false);

    }

    public void First_TimeLine()
    {
        First_Circle_Inside_TimeLine.SetActive(true);
        First_Circle_anim.SetBool("Button_P", true);

    }

    public void Second_TimeLine()
    {
        Second_Circle_Inside_TimeLine.SetActive(true);
        Second_Circle_anim.SetBool("Button_P", true);

    }

    public void First_Back_To_TimeLine()
    {

        First_Circle_anim.SetBool("Button_P", false);
    }

    public void Second_Back_To_TimeLine()
    {

        Second_Circle_anim.SetBool("Button_P", false);
    }

    public void Press_Square_TimeLine()
    {//타임라인 누르면  나오는 거
        Square_TimeLine.SetActive(true);
        Square_anim.SetBool("Button_P", true);
        
        

    }

    public void Back_To_SquareTimeLine()
    {//타임라인으로 돌아감

        Square_anim.SetBool("Button_P", false);
    }

    public void First_CheckPoint_No()//체크포인트-아니오
    {
        CheckPoint_No1.SetActive(false);
    }

    public void Second_CheckPoint_No()//체크포인트-아니오
    {
        CheckPoint_No2.SetActive(false);
    }

    public void Select_First_Square()//체크포인트에서 1번째 네모 상자 눌렀을 때
    {
        CheckPoint_No1.SetActive(true);
    }

    public void Select_Second_Square()//체크포인트에서 2번째 네모 상자 눌렀을 때
    {
        CheckPoint_No2.SetActive(true);
    }


}
