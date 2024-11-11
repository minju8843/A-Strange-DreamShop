using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_103_104 : MonoBehaviour
{
    public R_Wait1_6_12 inside_101;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_103_Line()
    {
        if (Tiket.Total < 5)
        {
            No_More_Ticket.SetActive(true);
        }
        else
        {
            Tiket.Total -= 5;
            PlayerPrefs.SetInt("Count", Tiket.Total);
            PlayerPrefs.Save();

            questObject.Go_103_Line();
            inside_101.m_Coroutine = inside_101.WaitSecond_0();
            StartCoroutine(inside_101.m_Coroutine);
            Debug.Log("103번째 리셋하자");
        }
    }

    public void Go_104_Line()
    {
        if (Tiket.Total < 5)
        {
            No_More_Ticket.SetActive(true);
        }
        else
        {
            Tiket.Total -= 5;
            PlayerPrefs.SetInt("Count", Tiket.Total);
            PlayerPrefs.Save();

            questObject.Go_104_Line();
            inside_101.m_Coroutine = inside_101.WaitSecond_0();
            StartCoroutine(inside_101.m_Coroutine);
            Debug.Log("104번째 리셋하자");
        }
    }
}
