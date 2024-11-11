using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Inside : MonoBehaviour
{
    public GameObject Character;
    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;
    public GameObject Character4;
    public Animator anim;
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;


    void Start()
    {
        anim.SetBool("C_Button", false);
        anim1.SetBool("C_Button", false);
        anim2.SetBool("C_Button", false);
        anim3.SetBool("C_Button", false);
        anim4.SetBool("C_Button", false);
    }

    public void First_Character()
    {
        Character.SetActive(true);
        anim.SetBool("C_Button", true);

    }

    public void Second_Character()
    {
        Character1.SetActive(true);
        anim1.SetBool("C_Button", true);

    }

    public void Third_Character()
    {
        Character2.SetActive(true);
        anim2.SetBool("C_Button", true);

    }

    public void Fourth_Character()
    {
        Character3.SetActive(true);
        anim3.SetBool("C_Button", true);

    }

    public void Fifth_Character()
    {
        Character4.SetActive(true);
        anim4.SetBool("C_Button", true);

    }

    public void Back_To_Character()
    {

        anim.SetBool("C_Button", false);
        anim1.SetBool("C_Button", false);
        anim2.SetBool("C_Button", false);
        anim3.SetBool("C_Button", false);
        anim4.SetBool("C_Button", false);
    }



}
