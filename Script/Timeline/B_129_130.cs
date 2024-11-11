using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_129_130 : MonoBehaviour
{
    public R_Wait1_6_43 inside_129;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_129_Line()
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

            questObject.Go_129_Line();
            inside_129.m_Coroutine = inside_129.WaitSecond_0();
            StartCoroutine(inside_129.m_Coroutine);
            Debug.Log("129번째 리셋하자");
        }
    }

    public void Go_130_Line()
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

            questObject.Go_130_Line();
            inside_129.m_Coroutine = inside_129.WaitSecond_0();
            StartCoroutine(inside_129.m_Coroutine);
            Debug.Log("130번째 리셋하자");
        }
    }
}
