using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Up_and_Down : MonoBehaviour
{

    public GameObject Setting_Go_Cradit;
    public Animator anim;

    void Start()
    {
        anim.SetBool("Cradit_Push", false);
    }


    public void Back_To_Setting()
    {
        anim.SetBool("Cradit_Push", false);
    }

    public void Show_Cradit()
    {
        Setting_Go_Cradit.SetActive(true);
        anim.SetBool("Cradit_Push", true);
    }





}
