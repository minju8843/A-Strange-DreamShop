using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_131_132 : MonoBehaviour
{
    public R_Wait1_6_43 inside_129;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_131_Line()
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

            questObject.Go_131_Line();
            inside_129.m_Coroutine = inside_129.WaitSecond_0();
            StartCoroutine(inside_129.m_Coroutine);
            Debug.Log("131번째 리셋하자");
        }
    }

    public void Go_132_Line()
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

            questObject.Go_132_Line();
            inside_129.m_Coroutine = inside_129.WaitSecond_0();
            StartCoroutine(inside_129.m_Coroutine);
            Debug.Log("132번째 리셋하자");
        }
    }
}
