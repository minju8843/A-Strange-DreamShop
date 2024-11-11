using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_33_34 : MonoBehaviour
{
    //public Tiket T;
    public R_Wait1_4_9 inside_34;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_ThirtyThree_Line()
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

            questObject.Go_ThirtyThree_Line();
            inside_34.m_Coroutine = inside_34.NewCoroutine();
            StartCoroutine(inside_34.m_Coroutine);
            Debug.Log("33번째 리셋하자");
        }
    }

    public void Go_ThirtyFour_Line()
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

            questObject.Go_ThirtyFour_Line();
            inside_34.m_Coroutine = inside_34.NewCoroutine();
            StartCoroutine(inside_34.m_Coroutine);
            Debug.Log("34번째 리셋하자");
        }
    }
}
