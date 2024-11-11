using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_133_134 : MonoBehaviour
{
    public R_Wait1_6_44 inside_133;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_133_Line()
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

            questObject.Go_133_Line();
            inside_133.m_Coroutine = inside_133.WaitSecond_0();
            StartCoroutine(inside_133.m_Coroutine);
            Debug.Log("133번째 리셋하자");
        }
    }

    public void Go_134_Line()
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

            questObject.Go_134_Line();
            inside_133.m_Coroutine = inside_133.WaitSecond_0();
            StartCoroutine(inside_133.m_Coroutine);
            Debug.Log("134번째 리셋하자");
        }
    }
}
