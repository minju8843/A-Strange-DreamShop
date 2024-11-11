using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Achieve_Anim : MonoBehaviour
{
    public Animator Achieve;
    public GameObject Achieve_Obj;

    public void Up_Achieve_Button()
    {
        StartCoroutine(WaitSecond_1());
        StartCoroutine(WaitSecond_2());

        IEnumerator WaitSecond_1()
        {
            yield return new WaitForSeconds(0.0f);
            Achieve.SetBool("A_Button", false);
        }

        IEnumerator WaitSecond_2()
        {
            yield return new WaitForSeconds(1.0f);
            Achieve_Obj.SetActive(false);
        }
        
    }
}
