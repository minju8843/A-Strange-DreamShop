using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Achievement : MonoBehaviour
{
    //public GameObject Achievements;
    public GameObject Inside_Achievements1;
    public GameObject Inside_Achievements2;
    public GameObject Inside_Achievements3;
    public GameObject Inside_Achievements4;
    public GameObject Inside_Achievements5;
    public GameObject Inside_Achievements6;
    public GameObject Inside_Achievements7;
    public GameObject Inside_Achievements8;
    public GameObject Inside_Achievements9;
    public GameObject Inside_Achievements10;
    public GameObject Inside_Achievements11;
    public GameObject Inside_Achievements12;
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;
    public Animator anim6;
    public Animator anim7;
    public Animator anim8;
    public Animator anim9;
    public Animator anim10;
    public Animator anim11;
    public Animator anim12;

    void Start()
    {
        anim1.SetBool("Button_P", false);
        anim2.SetBool("Button_P", false);
        anim3.SetBool("Button_P", false);
        anim4.SetBool("Button_P", false);
        anim5.SetBool("Button_P", false);
        anim6.SetBool("Button_P", false);
        anim7.SetBool("Button_P", false);
        anim8.SetBool("Button_P", false);
        anim9.SetBool("Button_P", false);
        anim10.SetBool("Button_P", false);
        anim11.SetBool("Button_P", false);
        anim12.SetBool("Button_P", false);
    }

    public void Achievement_1()
    {
        Inside_Achievements1.SetActive(true);
        anim1.SetBool("Button_P", true);

    }

    public void Achievement_2()
    {
        Inside_Achievements2.SetActive(true);
        anim2.SetBool("Button_P", true);

    }

    public void Achievement_3()
    {
        Inside_Achievements3.SetActive(true);
        anim3.SetBool("Button_P", true);

    }

    public void Achievement_4()
    {
        Inside_Achievements4.SetActive(true);
        anim4.SetBool("Button_P", true);

    }

    public void Achievement_5()
    {
        Inside_Achievements5.SetActive(true);
        anim5.SetBool("Button_P", true);

    }

    public void Achievement_6()
    {
        Inside_Achievements6.SetActive(true);
        anim6.SetBool("Button_P", true);

    }

    public void Achievement_7()
    {
        Inside_Achievements7.SetActive(true);
        anim7.SetBool("Button_P", true);

    }

    public void Achievement_8()
    {
        Inside_Achievements8.SetActive(true);
        anim8.SetBool("Button_P", true);

    }

    public void Achievement_9()
    {
        Inside_Achievements9.SetActive(true);
        anim9.SetBool("Button_P", true);

    }

    public void Achievement_10()
    {
        Inside_Achievements10.SetActive(true);
        anim10.SetBool("Button_P", true);

    }

    public void Achievement_11()
    {
        Inside_Achievements11.SetActive(true);
        anim11.SetBool("Button_P", true);

    }

    public void Achievement_12()
    {
        Inside_Achievements12.SetActive(true);
        anim12.SetBool("Button_P", true);

    }

    public void Back_To_Achievement()
    {

        anim1.SetBool("Button_P", false);
        anim2.SetBool("Button_P", false);
        anim3.SetBool("Button_P", false);
        anim4.SetBool("Button_P", false);
        anim5.SetBool("Button_P", false);
        anim6.SetBool("Button_P", false);
        anim7.SetBool("Button_P", false);
        anim8.SetBool("Button_P", false);
        anim9.SetBool("Button_P", false);
        anim10.SetBool("Button_P", false);
        anim11.SetBool("Button_P", false);
        anim12.SetBool("Button_P", false);
    }

    /*public void Back_To_Achievement2()
    {

        anim2.SetBool("Button_P", false);
    }

    public void Back_To_Achievement3()
    {

        anim3.SetBool("Button_P", false);
    }

    public void Back_To_Achievement4()
    {

        anim4.SetBool("Button_P", false);
    }

    public void Back_To_Achievement5()
    {

        anim5.SetBool("Button_P", false);
    }

    public void Back_To_Achievement6()
    {

        anim6.SetBool("Button_P", false);
    }

    public void Back_To_Achievement7()
    {

        anim7.SetBool("Button_P", false);
    }

    public void Back_To_Achievement8()
    {

        anim8.SetBool("Button_P", false);
    }

    public void Back_To_Achievement9()
    {

        anim9.SetBool("Button_P", false);
    }

    public void Back_To_Achievement10()
    {

        anim10.SetBool("Button_P", false);
    }

    public void Back_To_Achievement11()
    {

        anim11.SetBool("Button_P", false);
    }

    public void Back_To_Achievement12()
    {

        anim12.SetBool("Button_P", false);
    }*/
}
