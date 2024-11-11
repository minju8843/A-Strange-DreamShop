using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_121_122 : MonoBehaviour
{
    public R_Wait1_6_41 inside_121;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_121_Line()
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

            questObject.Go_121_Line();
            inside_121.m_Coroutine = inside_121.WaitSecond_0();
            StartCoroutine(inside_121.m_Coroutine);
            Debug.Log("121번째 리셋하자");
        }
    }

    public void Go_122_Line()
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

            questObject.Go_122_Line();
            inside_121.m_Coroutine = inside_121.WaitSecond_0();
            StartCoroutine(inside_121.m_Coroutine);
            Debug.Log("122번째 리셋하자");
        }
    }
}
