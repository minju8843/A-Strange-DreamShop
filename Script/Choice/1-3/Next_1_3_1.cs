using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Next_1_3_1 : MonoBehaviour
{
    public Save_Collection All_Save;
    /*public GameObject Line_1;
    public GameObject Line_2;
    public GameObject Line_3;
    public GameObject Line_4;
    public GameObject Line_5;
    public GameObject Line_6;
    public GameObject Line_7;
    public GameObject Line_8;
    public GameObject Line_9;
    public GameObject Line_10;
    public GameObject Line_11;
    public GameObject Line_12;
    public GameObject Line_13;
    public GameObject Line_14;
    public GameObject Line_15;
    public GameObject Line_16;
    public GameObject Line_17;
    public GameObject Line_18;
    public GameObject Line_19;
    public GameObject Line_20;*/
    public Fade_Collect FadeObject;//페이드 스크립트 불러오려고
    public GameObject[] inside_Line_17;
    public int Line_17_Index;

    public R_Wait1_3_1 inside_9;
    public Only_Line QuestObject;
    public IEnumerator m_Coroutine;

    public R_Wait1_4_1 inside_25;

    public RectTransform TextContainer1;//텍스트 컨테이너

    //public GameObject Go_Black;//페이드 인 & 아웃


    void Start()
    {
        m_Coroutine = NewCoroutine();
    }


    void Update()
    {
        StartCoroutine(m_Coroutine);
    }


    public IEnumerator NewCoroutine()
    {

        yield return StartCoroutine(WaitSecond_1());
        yield return StartCoroutine(WaitSecond_2());
        yield return StartCoroutine(WaitSecond_3());
        yield return StartCoroutine(WaitSecond_4());
        yield return StartCoroutine(WaitSecond_5());
        yield return StartCoroutine(WaitSecond_6());
        yield return StartCoroutine(WaitSecond_7());
        yield return StartCoroutine(WaitSecond_8());
        yield return StartCoroutine(WaitSecond_9());
        yield return StartCoroutine(WaitSecond_10());
        yield return StartCoroutine(WaitSecond_11());
        yield return StartCoroutine(WaitSecond_12());
        yield return StartCoroutine(WaitSecond_13());
        yield return StartCoroutine(WaitSecond_14());
        yield return StartCoroutine(WaitSecond_15());
        yield return StartCoroutine(WaitSecond_16());
        yield return StartCoroutine(WaitSecond_17());
        yield return StartCoroutine(WaitSecond_18());
        yield return StartCoroutine(WaitSecond_19());
        yield return StartCoroutine(WaitSecond_20());
        yield return StartCoroutine(WaitSecond_21());
    }



    IEnumerator WaitSecond_1()
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        QuestObject.BGM_Index = 2;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(true);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        /*QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);*/

        FadeObject.Fade_Index = 8;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(false);

        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_17_Index = 0;
        inside_Line_17[0].gameObject.SetActive(true);

        //오류때문에 만듦. 오류 아니었으면 진작에 지움
        // *** 첫 번째 업적과 앨범 힌트 보여주기 ***

        if (All_Save.Achieve_1[2].gameObject.activeSelf == true)
        {
            All_Save.Achieve1_Index = 2;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(true);
        }
        else
        {
            All_Save.Achieve1_Index = 1;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(true);
            All_Save.Achieve_1[2].gameObject.SetActive(false);
        }

        // *** 업적과 앨범 보여준 거 자동저장 ***
        PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

        inside_9.Line_9_Index = 0;
        inside_9.inside_Line_9[0].gameObject.SetActive(false);
        inside_9.inside_Line_9[1].gameObject.SetActive(false);
        inside_9.inside_Line_9[2].gameObject.SetActive(false);
        inside_9.inside_Line_9[3].gameObject.SetActive(false);
        inside_9.inside_Line_9[4].gameObject.SetActive(false);
        inside_9.inside_Line_9[5].gameObject.SetActive(false);
        inside_9.inside_Line_9[6].gameObject.SetActive(false);
        inside_9.inside_Line_9[7].gameObject.SetActive(false);
        inside_9.inside_Line_9[8].gameObject.SetActive(false);
        inside_9.inside_Line_9[9].gameObject.SetActive(false);
        inside_9.inside_Line_9[10].gameObject.SetActive(false);
        inside_9.inside_Line_9[11].gameObject.SetActive(false);
        inside_9.inside_Line_9[12].gameObject.SetActive(false);
        inside_9.inside_Line_9[13].gameObject.SetActive(false);
        inside_9.inside_Line_9[14].gameObject.SetActive(false);
        inside_9.inside_Line_9[15].gameObject.SetActive(false);
        inside_9.inside_Line_9[16].gameObject.SetActive(false);
        inside_9.inside_Line_9[17].gameObject.SetActive(false);
        inside_9.inside_Line_9[18].gameObject.SetActive(false);
        inside_9.inside_Line_9[19].gameObject.SetActive(false);
        inside_9.inside_Line_9[20].gameObject.SetActive(false);
        inside_9.inside_Line_9[21].gameObject.SetActive(false);
        inside_9.inside_Line_9[22].gameObject.SetActive(false);
        inside_9.inside_Line_9[23].gameObject.SetActive(false);
        inside_9.inside_Line_9[24].gameObject.SetActive(false);
        inside_9.inside_Line_9[25].gameObject.SetActive(false);
        inside_9.inside_Line_9[26].gameObject.SetActive(false);
        inside_9.inside_Line_9[27].gameObject.SetActive(false);
        inside_9.inside_Line_9[28].gameObject.SetActive(false);

        

        TextContainer1.offsetMin = new Vector2(0, -5029.503f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 21348.17f);    //(오, 위)

        
    }

    IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);

        Line_17_Index = 1;
        inside_Line_17[1].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4882.698f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 21494.97f);    //(오, 위)
    }

    IEnumerator WaitSecond_3()//속마음
    {
        yield return new WaitForSeconds(3.5f);
        //Line_3.SetActive(true);

        Line_17_Index = 2;
        inside_Line_17[2].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_4()//아무것도 없음
    {
        yield return new WaitForSeconds(6.0f);
        //Line_3.SetActive(false);

        QuestObject.BGM_Index = 2;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(true);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        Line_17_Index = 2;
        inside_Line_17[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3427.561f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22950.11f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()//그림 나타남
    {
        yield return new WaitForSeconds(8.0f);
        //Line_4.SetActive(true);

        Line_17_Index = 3;
        inside_Line_17[3].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3427.561f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22950.11f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()
    {
        yield return new WaitForSeconds(9.5f);
        //Line_5.SetActive(true);

        Line_17_Index = 4;
        inside_Line_17[4].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3427.561f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22950.11f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()
    {
        yield return new WaitForSeconds(11.0f);
        //Line_6.SetActive(true);

        Line_17_Index = 5;
        inside_Line_17[5].gameObject.SetActive(true);

        // % 여기부턴 앨범 관련 %

        //5번 앨범 오픈 관련
        if (All_Save.Album_5[2].gameObject.activeSelf == true)
        {//이미 5번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album5_Index = 2;
            All_Save.Album_5[0].gameObject.SetActive(false);
            All_Save.Album_5[1].gameObject.SetActive(false);
            All_Save.Album_5[2].gameObject.SetActive(true);

        }

        //5번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_5[2].gameObject.activeSelf == false)
        {
            //1번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album5_Index = 2;
            All_Save.Album_5[0].gameObject.SetActive(false);
            All_Save.Album_5[1].gameObject.SetActive(false);
            All_Save.Album_5[2].gameObject.SetActive(true);

        }

        //5 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);

        // % 여기부턴 다음 앨범에 대한 힌트 제공 %

        //6번 앨범 오픈 관련
        if (All_Save.Album_6[2].gameObject.activeSelf == true)
        {//이미 6번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album6_Index = 2;
            All_Save.Album_6[0].gameObject.SetActive(false);
            All_Save.Album_6[1].gameObject.SetActive(false);
            All_Save.Album_6[2].gameObject.SetActive(true);

        }

        //6번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_6[2].gameObject.activeSelf == false)
        {
            //6번 앨범에 대한 힌트를 준다
            All_Save.Album6_Index = 1;
            All_Save.Album_6[0].gameObject.SetActive(false);
            All_Save.Album_6[1].gameObject.SetActive(true);
            All_Save.Album_6[2].gameObject.SetActive(false);

        }

        //6 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_6", All_Save.Album6_Index);

        TextContainer1.offsetMin = new Vector2(0, -3427.561f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22950.11f);    //(오, 위)

    }

    IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(12.5f);
        //Line_7.SetActive(true);

        Line_17_Index = 6;
        inside_Line_17[6].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3288.82f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23088.97f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(14.0f);
        //Line_8.SetActive(true);

        Line_17_Index = 7;
        inside_Line_17[7].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3068.139f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23309.65f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()
    {
        yield return new WaitForSeconds(15.5f);
        //Line_9.SetActive(true);

        Line_17_Index = 8;
        inside_Line_17[8].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2850.801f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23526.99f);    //(오, 위)

    }

    IEnumerator WaitSecond_11()
    {
        yield return new WaitForSeconds(17.0f);
        //Line_10.SetActive(true);

        Line_17_Index = 9;
        inside_Line_17[9].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2562.066f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23815.72f);    //(오, 위)


    }

    IEnumerator WaitSecond_12()
    {
        yield return new WaitForSeconds(18.5f);
        //Line_11.SetActive(true);

        Line_17_Index = 10;
        inside_Line_17[10].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2252.062f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 24125.73f);    //(오, 위)



    }

    IEnumerator WaitSecond_13()//속마음
    {
        yield return new WaitForSeconds(20.5f);
        //Line_12.SetActive(true);


        Line_17_Index = 11;
        inside_Line_17[11].gameObject.SetActive(true);

    }

    IEnumerator WaitSecond_14()//속마음
    {
        yield return new WaitForSeconds(22.5f);
        //Line_13.SetActive(true);
        //Line_12.SetActive(false);

        Line_17_Index = 12;
        inside_Line_17[12].gameObject.SetActive(true);
        inside_Line_17[11].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_15()
    {
        yield return new WaitForSeconds(25.5f);
        //Line_14.SetActive(true);
        //Line_13.SetActive(false);

        Line_17_Index = 13;
        inside_Line_17[13].gameObject.SetActive(true);
        inside_Line_17[12].gameObject.SetActive(false);

        // % 여기부턴 앨범 관련 %

        //6번 앨범 오픈 관련
        if (All_Save.Album_6[2].gameObject.activeSelf == true)
        {//이미 6번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album6_Index = 2;
            All_Save.Album_6[0].gameObject.SetActive(false);
            All_Save.Album_6[1].gameObject.SetActive(false);
            All_Save.Album_6[2].gameObject.SetActive(true);

        }

        //6번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_6[2].gameObject.activeSelf == false)
        {
            //6번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album6_Index = 2;
            All_Save.Album_6[0].gameObject.SetActive(false);
            All_Save.Album_6[1].gameObject.SetActive(false);
            All_Save.Album_6[2].gameObject.SetActive(true);

        }

        //6 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_6", All_Save.Album6_Index);

        // % 여기부턴 다음 앨범에 대한 힌트 제공 %

        //7번 앨범 오픈 관련
        if (All_Save.Album_7[2].gameObject.activeSelf == true)
        {//이미 7번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album7_Index = 2;
            All_Save.Album_7[0].gameObject.SetActive(false);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(true);

        }

        //7번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_7[2].gameObject.activeSelf == false)
        {
            //7번 앨범에 대한 힌트를 준다
            All_Save.Album7_Index = 1;
            All_Save.Album_7[0].gameObject.SetActive(false);
            All_Save.Album_7[1].gameObject.SetActive(true);
            All_Save.Album_7[2].gameObject.SetActive(false);

        }

        //7 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);

        TextContainer1.offsetMin = new Vector2(0, -1588.133f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 24819.66f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()
    {
        yield return new WaitForSeconds(27.0f);
        //Line_15.SetActive(true);


        Line_17_Index = 14;
        inside_Line_17[14].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1253.86f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 25123.93f);    //(오, 위)

    }

    IEnumerator WaitSecond_17()
    {
        yield return new WaitForSeconds(28.5f);
        //Line_16.SetActive(true);

        Line_17_Index = 15;
        inside_Line_17[15].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -964.8379f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 25412.95f);    //(오, 위)


    }

    IEnumerator WaitSecond_18()
    {
        yield return new WaitForSeconds(30.0f);
        //Line_17.SetActive(true);

        Line_17_Index = 16;
        inside_Line_17[16].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -814.374f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 25563.41f);    //(오, 위)


    }

    IEnumerator WaitSecond_19()
    {
        yield return new WaitForSeconds(31.5f);
        //Line_18.SetActive(true);

        Line_17_Index = 17;
        inside_Line_17[17].gameObject.SetActive(true);
        //inside_Line_17[16].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -660.5664f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 25717.22f);    //(오, 위)

    }

    IEnumerator WaitSecond_20()
    {
        yield return new WaitForSeconds(33.0f);
        //Line_19.SetActive(true);

        Line_17_Index = 18;
        inside_Line_17[18].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -436.542f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 25941.25f);    //(오, 위)
    }

    IEnumerator WaitSecond_21()//선택지
    {
        yield return new WaitForSeconds(34.5f);
        //Line_20.SetActive(true);

        Line_17_Index = 19;
        inside_Line_17[19].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        inside_25.Line_25_Index = 0;
        inside_25.inside_Line_25[0].gameObject.SetActive(false);
        inside_25.inside_Line_25[1].gameObject.SetActive(false);
        inside_25.inside_Line_25[2].gameObject.SetActive(false);
        inside_25.inside_Line_25[3].gameObject.SetActive(false);
        inside_25.inside_Line_25[4].gameObject.SetActive(false);
        inside_25.inside_Line_25[5].gameObject.SetActive(false);
        inside_25.inside_Line_25[6].gameObject.SetActive(false);
        inside_25.inside_Line_25[7].gameObject.SetActive(false);
        inside_25.inside_Line_25[8].gameObject.SetActive(false);
        inside_25.inside_Line_25[9].gameObject.SetActive(false);
        inside_25.inside_Line_25[10].gameObject.SetActive(false);
        inside_25.inside_Line_25[11].gameObject.SetActive(false);
        inside_25.inside_Line_25[12].gameObject.SetActive(false);
        inside_25.inside_Line_25[13].gameObject.SetActive(false);
        inside_25.inside_Line_25[14].gameObject.SetActive(false);
        inside_25.inside_Line_25[15].gameObject.SetActive(false);
        inside_25.inside_Line_25[16].gameObject.SetActive(false);
        inside_25.inside_Line_25[17].gameObject.SetActive(false);
        inside_25.inside_Line_25[18].gameObject.SetActive(false);
        inside_25.inside_Line_25[19].gameObject.SetActive(false);
        inside_25.inside_Line_25[20].gameObject.SetActive(false);
        inside_25.inside_Line_25[21].gameObject.SetActive(false);
        inside_25.inside_Line_25[22].gameObject.SetActive(false);
        inside_25.inside_Line_25[23].gameObject.SetActive(false);
        inside_25.inside_Line_25[24].gameObject.SetActive(false);
        inside_25.inside_Line_25[25].gameObject.SetActive(false);
        inside_25.inside_Line_25[26].gameObject.SetActive(false);
        inside_25.inside_Line_25[27].gameObject.SetActive(false);
        inside_25.inside_Line_25[28].gameObject.SetActive(false);
        inside_25.inside_Line_25[29].gameObject.SetActive(false);
        inside_25.inside_Line_25[30].gameObject.SetActive(false);
        inside_25.inside_Line_25[31].gameObject.SetActive(false);
        inside_25.inside_Line_25[32].gameObject.SetActive(false);
        inside_25.inside_Line_25[33].gameObject.SetActive(false);
        inside_25.inside_Line_25[34].gameObject.SetActive(false);
        inside_25.inside_Line_25[35].gameObject.SetActive(false);
        inside_25.inside_Line_25[36].gameObject.SetActive(false);
        inside_25.inside_Line_25[37].gameObject.SetActive(false);
        inside_25.inside_Line_25[38].gameObject.SetActive(false);
        inside_25.inside_Line_25[39].gameObject.SetActive(false);
        inside_25.inside_Line_25[40].gameObject.SetActive(false);
        inside_25.inside_Line_25[41].gameObject.SetActive(false);
        inside_25.inside_Line_25[42].gameObject.SetActive(false);
        inside_25.inside_Line_25[43].gameObject.SetActive(false);
        inside_25.inside_Line_25[44].gameObject.SetActive(false);
        inside_25.inside_Line_25[45].gameObject.SetActive(false);
        inside_25.inside_Line_25[46].gameObject.SetActive(false);
        inside_25.inside_Line_25[47].gameObject.SetActive(false);
        inside_25.inside_Line_25[48].gameObject.SetActive(false);
        inside_25.inside_Line_25[49].gameObject.SetActive(false);
        inside_25.inside_Line_25[50].gameObject.SetActive(false);
        inside_25.inside_Line_25[51].gameObject.SetActive(false);
        inside_25.inside_Line_25[52].gameObject.SetActive(false);
        inside_25.inside_Line_25[53].gameObject.SetActive(false);
        inside_25.inside_Line_25[54].gameObject.SetActive(false);
        inside_25.inside_Line_25[55].gameObject.SetActive(false);
        inside_25.inside_Line_25[56].gameObject.SetActive(false);
        inside_25.inside_Line_25[57].gameObject.SetActive(false);
        inside_25.inside_Line_25[58].gameObject.SetActive(false);
        inside_25.inside_Line_25[59].gameObject.SetActive(false);
        inside_25.inside_Line_25[60].gameObject.SetActive(false);
        inside_25.inside_Line_25[61].gameObject.SetActive(false);
        inside_25.inside_Line_25[62].gameObject.SetActive(false);
        inside_25.inside_Line_25[63].gameObject.SetActive(false);
        inside_25.inside_Line_25[64].gameObject.SetActive(false);
        inside_25.inside_Line_25[65].gameObject.SetActive(false);
        inside_25.inside_Line_25[66].gameObject.SetActive(false);
        inside_25.inside_Line_25[67].gameObject.SetActive(false);
        inside_25.inside_Line_25[68].gameObject.SetActive(false);
        inside_25.inside_Line_25[69].gameObject.SetActive(false);
        inside_25.inside_Line_25[70].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.09375f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 26377.88f);    //(오, 위)


    }


}
