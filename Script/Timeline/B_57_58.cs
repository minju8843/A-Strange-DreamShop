using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_57_58 : MonoBehaviour
{
    public R_Wait1_5_2 inside_57;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_57_Line()
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

            questObject.Go_57_Line();
            inside_57.m_Coroutine = inside_57.NewCoroutine();
            StartCoroutine(inside_57.m_Coroutine);
            Debug.Log("57번째 리셋하자");
        }
    }

    public void Go_58_Line()
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

            questObject.Go_58_Line();
            inside_57.m_Coroutine = inside_57.NewCoroutine();
            StartCoroutine(inside_57.m_Coroutine);
            Debug.Log("58번째 리셋하자");
        }
    }
}
