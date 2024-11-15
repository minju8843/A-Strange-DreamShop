using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class R_Wait1_3_1 : MonoBehaviour
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
    public GameObject Line_20;
    public GameObject Line_21;
    public GameObject Line_22;
    public GameObject Line_23;
    public GameObject Line_24;
    public GameObject Line_25;
    public GameObject Line_26;
    public GameObject Line_27;
    public GameObject Line_28;
    public GameObject Line_29;*/
    public Fade_Collect FadeObject;//페이드 스크립트 불러오려고
    public GameObject[] inside_Line_9;
    public int Line_9_Index;
    public R_Wait1_2_1 inside_5;
    public R_Wait1_2_4 inside_8;

    public Next_1_3_1 inside_17;

    public Only_Line QuestObject;
    public IEnumerator m_Coroutine;

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
        yield return StartCoroutine(WaitSecond_22());
        yield return StartCoroutine(WaitSecond_23());
        yield return StartCoroutine(WaitSecond_24());
        yield return StartCoroutine(WaitSecond_25());
        yield return StartCoroutine(WaitSecond_26());
        yield return StartCoroutine(WaitSecond_27());
        yield return StartCoroutine(WaitSecond_28());
        yield return StartCoroutine(WaitSecond_29());



    }



    IEnumerator WaitSecond_1()
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        QuestObject.BGM_Index = 3;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(true);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

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

        Line_9_Index = 0;
        inside_Line_9[0].gameObject.SetActive(true);

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

        //Go_Black.SetActive(false);//페이드 지우기


        inside_5.Line_5_Index = 0;
        inside_5.inside_Line_5[0].gameObject.SetActive(false);
        inside_5.inside_Line_5[1].gameObject.SetActive(false);
        inside_5.inside_Line_5[2].gameObject.SetActive(false);
        inside_5.inside_Line_5[3].gameObject.SetActive(false);
        inside_5.inside_Line_5[4].gameObject.SetActive(false);
        inside_5.inside_Line_5[5].gameObject.SetActive(false);
        inside_5.inside_Line_5[6].gameObject.SetActive(false);
        inside_5.inside_Line_5[7].gameObject.SetActive(false);
        inside_5.inside_Line_5[8].gameObject.SetActive(false);
        inside_5.inside_Line_5[9].gameObject.SetActive(false);
        inside_5.inside_Line_5[10].gameObject.SetActive(false);
        inside_5.inside_Line_5[11].gameObject.SetActive(false);
        inside_5.inside_Line_5[12].gameObject.SetActive(false);
        inside_5.inside_Line_5[13].gameObject.SetActive(false);
        inside_5.inside_Line_5[14].gameObject.SetActive(false);
        inside_5.inside_Line_5[15].gameObject.SetActive(false);
        inside_5.inside_Line_5[16].gameObject.SetActive(false);
        inside_5.inside_Line_5[17].gameObject.SetActive(false);
        inside_5.inside_Line_5[18].gameObject.SetActive(false);
        inside_5.inside_Line_5[19].gameObject.SetActive(false);
        inside_5.inside_Line_5[20].gameObject.SetActive(false);
        inside_5.inside_Line_5[21].gameObject.SetActive(false);
        inside_5.inside_Line_5[22].gameObject.SetActive(false);
        inside_5.inside_Line_5[23].gameObject.SetActive(false);
        inside_5.inside_Line_5[24].gameObject.SetActive(false);
        inside_5.inside_Line_5[25].gameObject.SetActive(false);
        inside_5.inside_Line_5[26].gameObject.SetActive(false);
        inside_5.inside_Line_5[27].gameObject.SetActive(false);
        inside_5.inside_Line_5[28].gameObject.SetActive(false);
        inside_5.inside_Line_5[29].gameObject.SetActive(false);
        inside_5.inside_Line_5[30].gameObject.SetActive(false);
        inside_5.inside_Line_5[31].gameObject.SetActive(false);
        inside_5.inside_Line_5[32].gameObject.SetActive(false);
        inside_5.inside_Line_5[33].gameObject.SetActive(false);
        inside_5.inside_Line_5[34].gameObject.SetActive(false);
        inside_5.inside_Line_5[35].gameObject.SetActive(false);
        inside_5.inside_Line_5[36].gameObject.SetActive(false);
        inside_5.inside_Line_5[37].gameObject.SetActive(false);
        inside_5.inside_Line_5[38].gameObject.SetActive(false);
        inside_5.inside_Line_5[39].gameObject.SetActive(false);
        inside_5.inside_Line_5[40].gameObject.SetActive(false);
        inside_5.inside_Line_5[41].gameObject.SetActive(false);

        inside_8.Line_8_Index= 0;
        inside_8.inside_Line_8[0].gameObject.SetActive(false);
        inside_8.inside_Line_8[1].gameObject.SetActive(false);
        inside_8.inside_Line_8[2].gameObject.SetActive(false);
        inside_8.inside_Line_8[3].gameObject.SetActive(false);
        inside_8.inside_Line_8[4].gameObject.SetActive(false);
        inside_8.inside_Line_8[5].gameObject.SetActive(false);
        inside_8.inside_Line_8[6].gameObject.SetActive(false);
        inside_8.inside_Line_8[7].gameObject.SetActive(false);
        inside_8.inside_Line_8[8].gameObject.SetActive(false);
        inside_8.inside_Line_8[9].gameObject.SetActive(false);
        inside_8.inside_Line_8[10].gameObject.SetActive(false);
        inside_8.inside_Line_8[11].gameObject.SetActive(false);
        inside_8.inside_Line_8[12].gameObject.SetActive(false);
        inside_8.inside_Line_8[13].gameObject.SetActive(false);
        inside_8.inside_Line_8[14].gameObject.SetActive(false);
        inside_8.inside_Line_8[15].gameObject.SetActive(false);
        inside_8.inside_Line_8[16].gameObject.SetActive(false);
        inside_8.inside_Line_8[17].gameObject.SetActive(false);
        inside_8.inside_Line_8[18].gameObject.SetActive(false);
        inside_8.inside_Line_8[19].gameObject.SetActive(false);
        inside_8.inside_Line_8[20].gameObject.SetActive(false);
        inside_8.inside_Line_8[21].gameObject.SetActive(false);
        inside_8.inside_Line_8[22].gameObject.SetActive(false);
        inside_8.inside_Line_8[23].gameObject.SetActive(false);
        inside_8.inside_Line_8[24].gameObject.SetActive(false);
        inside_8.inside_Line_8[25].gameObject.SetActive(false);
        inside_8.inside_Line_8[26].gameObject.SetActive(false);
        inside_8.inside_Line_8[27].gameObject.SetActive(false);
        inside_8.inside_Line_8[28].gameObject.SetActive(false);
        inside_8.inside_Line_8[29].gameObject.SetActive(false);
        inside_8.inside_Line_8[30].gameObject.SetActive(false);
        inside_8.inside_Line_8[31].gameObject.SetActive(false);
        inside_8.inside_Line_8[32].gameObject.SetActive(false);
        inside_8.inside_Line_8[33].gameObject.SetActive(false);
        inside_8.inside_Line_8[34].gameObject.SetActive(false);
        inside_8.inside_Line_8[35].gameObject.SetActive(false);
        inside_8.inside_Line_8[36].gameObject.SetActive(false);
        inside_8.inside_Line_8[37].gameObject.SetActive(false);
        inside_8.inside_Line_8[38].gameObject.SetActive(false);
        inside_8.inside_Line_8[39].gameObject.SetActive(false);
        inside_8.inside_Line_8[40].gameObject.SetActive(false);
        inside_8.inside_Line_8[41].gameObject.SetActive(false);
        inside_8.inside_Line_8[42].gameObject.SetActive(false);
        inside_8.inside_Line_8[43].gameObject.SetActive(false);
        inside_8.inside_Line_8[44].gameObject.SetActive(false);



        TextContainer1.offsetMin = new Vector2(0, -5630.963f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15682.91f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);

        Line_9_Index = 1;
        inside_Line_9[1].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -5465.592f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15848.28f);    //(오, 위)
    }

    IEnumerator WaitSecond_3()
    {
        yield return new WaitForSeconds(3.0f);
        //Line_3.SetActive(true);

        Line_9_Index = 2;
        inside_Line_9[2].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5250.958f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16062.91f);    //(오, 위)

    }

    IEnumerator WaitSecond_4()
    {
        yield return new WaitForSeconds(4.5f);
        //Line_4.SetActive(true);

        Line_9_Index = 3;
        inside_Line_9[3].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4966.637f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16347.23f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()
    {
        yield return new WaitForSeconds(6.0f);
        //Line_5.SetActive(true);

        Line_9_Index = 4;
        inside_Line_9[4].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4682.316f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16631.55f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()
    {
        yield return new WaitForSeconds(7.5f);
        //Line_6.SetActive(true);

        Line_9_Index = 5;
        inside_Line_9[5].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4389.634f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16924.23f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()
    {
        yield return new WaitForSeconds(9.0f);
        //Line_7.SetActive(true);

        Line_9_Index = 6;
        inside_Line_9[6].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4236.775f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17077.09f);    //(오, 위)

    }

    IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(10.5f);
        //Line_8.SetActive(true);

        Line_9_Index = 7;
        inside_Line_9[7].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3949.667f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17364.2f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(12.0f);
        //Line_9.SetActive(true);

        Line_9_Index = 8;
        inside_Line_9[8].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3638.922f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17674.95f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//속마음
    {
        yield return new WaitForSeconds(14.0f);
        //Line_10.SetActive(true);//속마음1

        Line_9_Index = 9;
        inside_Line_9[9].gameObject.SetActive(true);

    }

    IEnumerator WaitSecond_11()//속마음1 없애기
    {
        yield return new WaitForSeconds(18.0f);
        //Line_10.SetActive(false);//속마음1 없애기
        //Line_11.SetActive(true);

        Line_9_Index = 10;
        inside_Line_9[10].gameObject.SetActive(true);
        inside_Line_9[9].gameObject.SetActive(false);





        TextContainer1.offsetMin = new Vector2(0, -2928.027f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 18385.84f);    //(오, 위)

    }

    IEnumerator WaitSecond_12()//11
    {
        yield return new WaitForSeconds(19.5f);
        //Line_12.SetActive(true);

        QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        Line_9_Index = 11;
        inside_Line_9[11].gameObject.SetActive(true);
        //inside_Line_9[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2643.707f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 18670.16f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//속마음
    {
        yield return new WaitForSeconds(21.5f);
        //Line_13.SetActive(true);


        Line_9_Index = 12;
        inside_Line_9[12].gameObject.SetActive(true);
        //inside_Line_9[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_14()//13
    {
        yield return new WaitForSeconds(23.5f);
        //Line_14.SetActive(true);
        //Line_13.SetActive(false);

        Line_9_Index = 13;
        inside_Line_9[13].gameObject.SetActive(true);
        inside_Line_9[12].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2362.79f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 18951.08f);    //(오, 위)

    }

    IEnumerator WaitSecond_15()//14
    {
        yield return new WaitForSeconds(25.0f);
        //Line_15.SetActive(true);

        Line_9_Index = 14;
        inside_Line_9[14].gameObject.SetActive(true);
        //inside_Line_9[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2039.445f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 19274.42f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()//속마음
    {
        yield return new WaitForSeconds(27.0f);
        //Line_16.SetActive(true);

        Line_9_Index = 15;
        inside_Line_9[15].gameObject.SetActive(true);
        //inside_Line_9[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_17()
    {
        yield return new WaitForSeconds(30.5f);//속마음
        //Line_17.SetActive(true);
        //Line_16.SetActive(false);

        Line_9_Index = 16;
        inside_Line_9[16].gameObject.SetActive(true);
        inside_Line_9[15].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_18()//15
    {
        yield return new WaitForSeconds(32.5f);
        //Line_17.SetActive(false);
        //Line_18.SetActive(true);

        Line_9_Index = 17;
        inside_Line_9[17].gameObject.SetActive(true);
        inside_Line_9[16].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1847.11f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 19466.76f);    //(오, -위)

    }

    IEnumerator WaitSecond_19()//15
    {
        yield return new WaitForSeconds(34.0f);
        //Line_19.SetActive(true);

        Line_9_Index = 18;
        inside_Line_9[18].gameObject.SetActive(true);
        //inside_Line_9[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1518.19f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 19795.68f);    //(오, -위)

    }

    IEnumerator WaitSecond_20()//속마음
    {
        yield return new WaitForSeconds(36.0f);
        //Line_20.SetActive(true);

        Line_9_Index = 19;
        inside_Line_9[19].gameObject.SetActive(true);
        //inside_Line_9[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_21()//15
    {
        yield return new WaitForSeconds(39.5f);
        //Line_20.SetActive(false);
        //Line_21.SetActive(true);

        Line_9_Index = 20;
        inside_Line_9[20].gameObject.SetActive(true);
        inside_Line_9[19].gameObject.SetActive(false);


        // % 여기부턴 앨범 관련 %

        //3번 앨범 오픈 관련
        if (All_Save.Album_3[2].gameObject.activeSelf == true)
        {//이미 3번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album3_Index = 2;
            All_Save.Album_3[0].gameObject.SetActive(false);
            All_Save.Album_3[1].gameObject.SetActive(false);
            All_Save.Album_3[2].gameObject.SetActive(true);

        }

        //3번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_3[2].gameObject.activeSelf == false)
        {
            //2번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album3_Index = 2;
            All_Save.Album_3[0].gameObject.SetActive(false);
            All_Save.Album_3[1].gameObject.SetActive(false);
            All_Save.Album_3[2].gameObject.SetActive(true);

        }

        //3 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_3", All_Save.Album3_Index);

        // % 여기부턴 다음 앨범에 대한 힌트 제공 %

        //4번 앨범 오픈 관련
        if (All_Save.Album_4[2].gameObject.activeSelf == true)
        {//이미 4번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album4_Index = 2;
            All_Save.Album_4[0].gameObject.SetActive(false);
            All_Save.Album_4[1].gameObject.SetActive(false);
            All_Save.Album_4[2].gameObject.SetActive(true);

        }

        //4번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_4[2].gameObject.activeSelf == false)
        {
            //4번 앨범에 대한 힌트를 준다
            All_Save.Album4_Index = 1;
            All_Save.Album_4[0].gameObject.SetActive(false);
            All_Save.Album_4[1].gameObject.SetActive(true);
            All_Save.Album_4[2].gameObject.SetActive(false);

        }

        //4 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_4", All_Save.Album4_Index);

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
            //5번 앨범에 대한 힌트를 준다
            All_Save.Album5_Index = 1;
            All_Save.Album_5[0].gameObject.SetActive(false);
            All_Save.Album_5[1].gameObject.SetActive(true);
            All_Save.Album_5[2].gameObject.SetActive(false);

        }

        //5 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);

        TextContainer1.offsetMin = new Vector2(0, -829.4873f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 20484.38f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//속마음
    {
        yield return new WaitForSeconds(41.0f);
        //Line_22.SetActive(true);

        Line_9_Index = 21;
        inside_Line_9[21].gameObject.SetActive(true);
        //inside_Line_9[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_23()//속마음
    {
        yield return new WaitForSeconds(43.0f);
        //Line_22.SetActive(false);
        //Line_23.SetActive(true);

        Line_9_Index = 22;
        inside_Line_9[22].gameObject.SetActive(true);
        inside_Line_9[21].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_24()//15
    {
        yield return new WaitForSeconds(45.0f);
        //Line_24.SetActive(true);
        //Line_23.SetActive(false);

        Line_9_Index = 23;
        inside_Line_9[23].gameObject.SetActive(true);
        inside_Line_9[22].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -536.6563f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 20777.21f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//15
    {
        yield return new WaitForSeconds(46.5f);
        //Line_25.SetActive(true);

        Line_9_Index = 24;
        inside_Line_9[24].gameObject.SetActive(true);
        //inside_Line_9[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -232.9648f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 21080.9f);    //(오, -위)

    }

    IEnumerator WaitSecond_26()//속마음
    {
        yield return new WaitForSeconds(48.5f);
        //Line_26.SetActive(true);

        Line_9_Index = 25;
        inside_Line_9[25].gameObject.SetActive(true);
        //inside_Line_9[9].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_27()//속마음
    {
        yield return new WaitForSeconds(51.0f);
        //Line_27.SetActive(true);
        //Line_26.SetActive(false);

        Line_9_Index = 26;
        inside_Line_9[26].gameObject.SetActive(true);
        inside_Line_9[25].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_28()//속마음
    {
        yield return new WaitForSeconds(53.0f);
        //Line_28.SetActive(true);
        //Line_27.SetActive(false);

        Line_9_Index = 27;
        inside_Line_9[27].gameObject.SetActive(true);
        inside_Line_9[26].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_29()//15
    {
        yield return new WaitForSeconds(55.0f);
        //Line_29.SetActive(true);
        //Line_28.SetActive(false);

        Line_9_Index = 28;
        inside_Line_9[28].gameObject.SetActive(true);
        inside_Line_9[27].gameObject.SetActive(false);

        inside_17.Line_17_Index = 0;
        inside_17.inside_Line_17[0].gameObject.SetActive(false);
        inside_17.inside_Line_17[1].gameObject.SetActive(false);
        inside_17.inside_Line_17[2].gameObject.SetActive(false);
        inside_17.inside_Line_17[3].gameObject.SetActive(false);
        inside_17.inside_Line_17[4].gameObject.SetActive(false);
        inside_17.inside_Line_17[5].gameObject.SetActive(false);
        inside_17.inside_Line_17[6].gameObject.SetActive(false);
        inside_17.inside_Line_17[7].gameObject.SetActive(false);
        inside_17.inside_Line_17[8].gameObject.SetActive(false);
        inside_17.inside_Line_17[9].gameObject.SetActive(false);
        inside_17.inside_Line_17[10].gameObject.SetActive(false);
        inside_17.inside_Line_17[11].gameObject.SetActive(false);
        inside_17.inside_Line_17[12].gameObject.SetActive(false);
        inside_17.inside_Line_17[13].gameObject.SetActive(false);
        inside_17.inside_Line_17[14].gameObject.SetActive(false);
        inside_17.inside_Line_17[15].gameObject.SetActive(false);
        inside_17.inside_Line_17[16].gameObject.SetActive(false);
        inside_17.inside_Line_17[17].gameObject.SetActive(false);
        inside_17.inside_Line_17[18].gameObject.SetActive(false);
        inside_17.inside_Line_17[19].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.08496094f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 21313.95f);    //(오, -위)

    }

}
