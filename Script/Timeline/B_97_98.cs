using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_97_98 : MonoBehaviour
{
    public R_Wait1_6_11 inside_97;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_97_Line()
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

            questObject.Go_97_Line();
            inside_97.m_Coroutine = inside_97.WaitSecond_0();
            StartCoroutine(inside_97.m_Coroutine);
            Debug.Log("97번째 리셋하자");
        }
    }

    public void Go_98_Line()
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

            questObject.Go_98_Line();
            inside_97.m_Coroutine = inside_97.WaitSecond_0();
            StartCoroutine(inside_97.m_Coroutine);
            Debug.Log("98번째 리셋하자");
        }
    }
}
