using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Inside : MonoBehaviour
{
    public GameObject First_Circle_Inside_TimeLine;
    //������ ���׶�� ������ �� ������ ��

    public GameObject Second_Circle_Inside_TimeLine;
    //������ ���׶�� ������ �� ������ ��

    public Animator First_Circle_anim;
    //������ ���׶�� ������ �� ������ �ִϸ��̼�
    //�帴�� ȭ���� ��Ÿ���� �������� ��

    public Animator Second_Circle_anim;
    //������ ���׶�� ������ �� ������ �ִϸ��̼�
    //�帴�� ȭ���� ��Ÿ���� �������� ��

    public Animator Square_anim;
    //Ÿ�Ӷ��� ������ �� ������ ��
    //�ȿ� 2���� é�� ����ȭ �ִ� ������ �ִϸ��̼�



    public GameObject Square_TimeLine;
    //Ÿ�Ӷ��� �ҷ����� ��
    //�ȿ� 2���� é���� ����ȭ ����

    public GameObject CheckPoint_No1;
    //ù ��° �׸� ���ý� ��, �ƴϿ�

    public GameObject CheckPoint_No2;
    //�� ��° �׸� ���ý� ��, �ƴϿ�



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
    {//Ÿ�Ӷ��� ������  ������ ��
        Square_TimeLine.SetActive(true);
        Square_anim.SetBool("Button_P", true);
        
        

    }

    public void Back_To_SquareTimeLine()
    {//Ÿ�Ӷ������� ���ư�

        Square_anim.SetBool("Button_P", false);
    }

    public void First_CheckPoint_No()//üũ����Ʈ-�ƴϿ�
    {
        CheckPoint_No1.SetActive(false);
    }

    public void Second_CheckPoint_No()//üũ����Ʈ-�ƴϿ�
    {
        CheckPoint_No2.SetActive(false);
    }

    public void Select_First_Square()//üũ����Ʈ���� 1��° �׸� ���� ������ ��
    {
        CheckPoint_No1.SetActive(true);
    }

    public void Select_Second_Square()//üũ����Ʈ���� 2��° �׸� ���� ������ ��
    {
        CheckPoint_No2.SetActive(true);
    }


}
