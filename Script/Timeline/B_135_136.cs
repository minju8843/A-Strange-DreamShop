using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_135_136 : MonoBehaviour
{
    //public Tiket T;
    public R_Wait1_6_44 inside_133;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_135_Line()
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

            questObject.Go_135_Line();
            inside_133.m_Coroutine = inside_133.WaitSecond_0();
            StartCoroutine(inside_133.m_Coroutine);
            Debug.Log("135번째 리셋하자");
        }
    }

    public void Go_136_Line()
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

            questObject.Go_136_Line();
            inside_133.m_Coroutine = inside_133.WaitSecond_0();
            StartCoroutine(inside_133.m_Coroutine);
            Debug.Log("136번째 리셋하자");
        }
    }
}
