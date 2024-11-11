using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade_Collect : MonoBehaviour
{

    public GameObject[] fadeObject;
    public int Fade_Index;

    // Start is called before the first frame update
    void Start()
    {
        //Fade_Index = PlayerPrefs.GetInt("Fade_Index");
        //fadeObject[Fade_Index].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.SetInt("Fade_Index", Fade_Index);
        PlayerPrefs.Save();
    }
}
