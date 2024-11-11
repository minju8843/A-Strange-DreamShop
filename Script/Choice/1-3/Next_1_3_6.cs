using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Next_1_3_6 : MonoBehaviour
{
    public Save_Collection All_Save;
    public Fade_Collect FadeObject;//페이드 스크립트 불러오려고
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

    public GameObject[] inside_Line_19;
    public int Line_19_Index;

    public R_Wait1_4_11 inside_37;
    

    public R_Wait1_3_6 inside_11;
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
    }



    IEnumerator WaitSecond_1()
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        /*QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);*/

        QuestObject.BGM_Index = 2;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(true);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
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

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_19_Index = 0;
        inside_Line_19[0].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

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

        inside_11.Line_11_Index = 0;
        inside_11.inside_Line_11[0].gameObject.SetActive(false);
        inside_11.inside_Line_11[1].gameObject.SetActive(false);
        inside_11.inside_Line_11[2].gameObject.SetActive(false);
        inside_11.inside_Line_11[3].gameObject.SetActive(false);
        inside_11.inside_Line_11[4].gameObject.SetActive(false);
        inside_11.inside_Line_11[5].gameObject.SetActive(false);
        inside_11.inside_Line_11[6].gameObject.SetActive(false);
        inside_11.inside_Line_11[7].gameObject.SetActive(false);
        inside_11.inside_Line_11[8].gameObject.SetActive(false);
        inside_11.inside_Line_11[9].gameObject.SetActive(false);
        inside_11.inside_Line_11[10].gameObject.SetActive(false);
        inside_11.inside_Line_11[11].gameObject.SetActive(false);
        inside_11.inside_Line_11[12].gameObject.SetActive(false);
        inside_11.inside_Line_11[13].gameObject.SetActive(false);
        inside_11.inside_Line_11[14].gameObject.SetActive(false);
        inside_11.inside_Line_11[15].gameObject.SetActive(false);
        inside_11.inside_Line_11[16].gameObject.SetActive(false);
        inside_11.inside_Line_11[17].gameObject.SetActive(false);
        inside_11.inside_Line_11[18].gameObject.SetActive(false);
        inside_11.inside_Line_11[19].gameObject.SetActive(false);
        inside_11.inside_Line_11[20].gameObject.SetActive(false);
        inside_11.inside_Line_11[21].gameObject.SetActive(false);
        inside_11.inside_Line_11[22].gameObject.SetActive(false);
        inside_11.inside_Line_11[23].gameObject.SetActive(false);
        inside_11.inside_Line_11[24].gameObject.SetActive(false);
        inside_11.inside_Line_11[25].gameObject.SetActive(false);
        inside_11.inside_Line_11[26].gameObject.SetActive(false);
        inside_11.inside_Line_11[27].gameObject.SetActive(false);
        inside_11.inside_Line_11[28].gameObject.SetActive(false);

        /*QuestObject.Line_Index = 19;

        QuestObject.questObject[0].gameObject.SetActive(false);
        QuestObject.questObject[1].gameObject.SetActive(false);
        QuestObject.questObject[2].gameObject.SetActive(false);
        QuestObject.questObject[3].gameObject.SetActive(false);
        QuestObject.questObject[4].gameObject.SetActive(false);
        QuestObject.questObject[5].gameObject.SetActive(false);
        QuestObject.questObject[6].gameObject.SetActive(false);
        QuestObject.questObject[7].gameObject.SetActive(false);
        QuestObject.questObject[8].gameObject.SetActive(false);
        QuestObject.questObject[9].gameObject.SetActive(false);
        QuestObject.questObject[10].gameObject.SetActive(false);
        QuestObject.questObject[11].gameObject.SetActive(false);
        QuestObject.questObject[12].gameObject.SetActive(false);
        QuestObject.questObject[13].gameObject.SetActive(false);
        QuestObject.questObject[14].gameObject.SetActive(false);
        QuestObject.questObject[15].gameObject.SetActive(false);
        QuestObject.questObject[16].gameObject.SetActive(false);
        QuestObject.questObject[17].gameObject.SetActive(false);
        QuestObject.questObject[18].gameObject.SetActive(false);
       
        QuestObject.questObject[21].gameObject.SetActive(false);
        QuestObject.questObject[22].gameObject.SetActive(false);
        QuestObject.questObject[23].gameObject.SetActive(false);
        QuestObject.questObject[24].gameObject.SetActive(false);
        QuestObject.questObject[25].gameObject.SetActive(false);
        QuestObject.questObject[26].gameObject.SetActive(false);
        QuestObject.questObject[27].gameObject.SetActive(false);
        QuestObject.questObject[28].gameObject.SetActive(false);
        QuestObject.questObject[29].gameObject.SetActive(false);
        QuestObject.questObject[30].gameObject.SetActive(false);
        QuestObject.questObject[31].gameObject.SetActive(false);
        QuestObject.questObject[32].gameObject.SetActive(false);
        QuestObject.questObject[33].gameObject.SetActive(false);
        QuestObject.questObject[34].gameObject.SetActive(false);
        QuestObject.questObject[35].gameObject.SetActive(false);
        QuestObject.questObject[36].gameObject.SetActive(false);
        QuestObject.questObject[37].gameObject.SetActive(false);
        QuestObject.questObject[38].gameObject.SetActive(false);
        QuestObject.questObject[39].gameObject.SetActive(false);
        QuestObject.questObject[40].gameObject.SetActive(false);
        QuestObject.questObject[41].gameObject.SetActive(false);
        QuestObject.questObject[42].gameObject.SetActive(false);
        QuestObject.questObject[43].gameObject.SetActive(false);
        QuestObject.questObject[44].gameObject.SetActive(false);
        QuestObject.questObject[45].gameObject.SetActive(false);
        QuestObject.questObject[46].gameObject.SetActive(false);
        QuestObject.questObject[47].gameObject.SetActive(false);
        QuestObject.questObject[48].gameObject.SetActive(false);
        QuestObject.questObject[49].gameObject.SetActive(false);
        QuestObject.questObject[50].gameObject.SetActive(false);
        QuestObject.questObject[51].gameObject.SetActive(false);
        QuestObject.questObject[52].gameObject.SetActive(false);
        QuestObject.questObject[53].gameObject.SetActive(false);
        QuestObject.questObject[54].gameObject.SetActive(false);
        QuestObject.questObject[55].gameObject.SetActive(false);
        QuestObject.questObject[56].gameObject.SetActive(false);
        QuestObject.questObject[57].gameObject.SetActive(false);
        QuestObject.questObject[58].gameObject.SetActive(false);
        QuestObject.questObject[59].gameObject.SetActive(false);
        QuestObject.questObject[60].gameObject.SetActive(false);
        QuestObject.questObject[61].gameObject.SetActive(false);
        QuestObject.questObject[62].gameObject.SetActive(false);
        QuestObject.questObject[63].gameObject.SetActive(false);
        QuestObject.questObject[64].gameObject.SetActive(false);
        QuestObject.questObject[65].gameObject.SetActive(false);
        QuestObject.questObject[66].gameObject.SetActive(false);
        QuestObject.questObject[67].gameObject.SetActive(false);
        QuestObject.questObject[68].gameObject.SetActive(false);
        QuestObject.questObject[69].gameObject.SetActive(false);
        QuestObject.questObject[70].gameObject.SetActive(false);
        QuestObject.questObject[71].gameObject.SetActive(false);
        QuestObject.questObject[72].gameObject.SetActive(false);
        QuestObject.questObject[73].gameObject.SetActive(false);
        QuestObject.questObject[74].gameObject.SetActive(false);
        QuestObject.questObject[75].gameObject.SetActive(false);
        QuestObject.questObject[76].gameObject.SetActive(false);
        QuestObject.questObject[77].gameObject.SetActive(false);
        QuestObject.questObject[78].gameObject.SetActive(false);
        QuestObject.questObject[79].gameObject.SetActive(false);
        QuestObject.questObject[80].gameObject.SetActive(false);
        QuestObject.questObject[81].gameObject.SetActive(false);
        QuestObject.questObject[82].gameObject.SetActive(false);
        QuestObject.questObject[83].gameObject.SetActive(false);
        QuestObject.questObject[84].gameObject.SetActive(false);
        QuestObject.questObject[85].gameObject.SetActive(false);
        QuestObject.questObject[86].gameObject.SetActive(false);
        QuestObject.questObject[87].gameObject.SetActive(false);
        QuestObject.questObject[88].gameObject.SetActive(false);
        QuestObject.questObject[89].gameObject.SetActive(false);
        QuestObject.questObject[90].gameObject.SetActive(false);
        QuestObject.questObject[91].gameObject.SetActive(false);
        QuestObject.questObject[92].gameObject.SetActive(false);
        QuestObject.questObject[93].gameObject.SetActive(false);
        QuestObject.questObject[94].gameObject.SetActive(false);
        QuestObject.questObject[95].gameObject.SetActive(false);
        QuestObject.questObject[96].gameObject.SetActive(false);
        QuestObject.questObject[97].gameObject.SetActive(false);
        QuestObject.questObject[98].gameObject.SetActive(false);
        QuestObject.questObject[99].gameObject.SetActive(false);
        QuestObject.questObject[100].gameObject.SetActive(false);
        QuestObject.questObject[101].gameObject.SetActive(false);
        QuestObject.questObject[102].gameObject.SetActive(false);
        QuestObject.questObject[103].gameObject.SetActive(false);
        QuestObject.questObject[104].gameObject.SetActive(false);
        QuestObject.questObject[105].gameObject.SetActive(false);
        QuestObject.questObject[106].gameObject.SetActive(false);
        QuestObject.questObject[107].gameObject.SetActive(false);
        QuestObject.questObject[108].gameObject.SetActive(false);
        QuestObject.questObject[109].gameObject.SetActive(false);
        QuestObject.questObject[110].gameObject.SetActive(false);
        QuestObject.questObject[111].gameObject.SetActive(false);
        QuestObject.questObject[112].gameObject.SetActive(false);
        QuestObject.questObject[113].gameObject.SetActive(false);
        QuestObject.questObject[114].gameObject.SetActive(false);
        QuestObject.questObject[115].gameObject.SetActive(false);
        QuestObject.questObject[116].gameObject.SetActive(false);
        QuestObject.questObject[117].gameObject.SetActive(false);
        QuestObject.questObject[118].gameObject.SetActive(false);
        QuestObject.questObject[119].gameObject.SetActive(false);
        QuestObject.questObject[120].gameObject.SetActive(false);
        QuestObject.questObject[121].gameObject.SetActive(false);
        QuestObject.questObject[122].gameObject.SetActive(false);
        QuestObject.questObject[123].gameObject.SetActive(false);
        QuestObject.questObject[124].gameObject.SetActive(false);
        QuestObject.questObject[125].gameObject.SetActive(false);
        QuestObject.questObject[126].gameObject.SetActive(false);
        QuestObject.questObject[127].gameObject.SetActive(false);
        QuestObject.questObject[128].gameObject.SetActive(false);
        QuestObject.questObject[129].gameObject.SetActive(false);
        QuestObject.questObject[130].gameObject.SetActive(false);
        QuestObject.questObject[131].gameObject.SetActive(false);
        QuestObject.questObject[132].gameObject.SetActive(false);
        QuestObject.questObject[133].gameObject.SetActive(false);
        QuestObject.questObject[134].gameObject.SetActive(false);
        QuestObject.questObject[135].gameObject.SetActive(false);
        QuestObject.questObject[136].gameObject.SetActive(false);
        QuestObject.questObject[137].gameObject.SetActive(false);
        QuestObject.questObject[138].gameObject.SetActive(false);
        QuestObject.questObject[139].gameObject.SetActive(false);
        QuestObject.questObject[140].gameObject.SetActive(false);
        QuestObject.questObject[141].gameObject.SetActive(false);
        QuestObject.questObject[142].gameObject.SetActive(false);
        QuestObject.questObject[143].gameObject.SetActive(false);
        QuestObject.questObject[144].gameObject.SetActive(false);
        QuestObject.questObject[145].gameObject.SetActive(false);
        QuestObject.questObject[146].gameObject.SetActive(false);*/

        TextContainer1.offsetMin = new Vector2(0, -5019.949f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22219.13f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);

        Line_19_Index = 1;
        inside_Line_19[1].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4872.214f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22366.87f);    //(오, 위)
    }

    IEnumerator WaitSecond_3()//속마음
    {
        yield return new WaitForSeconds(3.5f);
        //Line_3.SetActive(true);
        Line_19_Index = 2;
        inside_Line_19[2].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        //inside_Line_11[27].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_4()//아무것도 없음
    {
        yield return new WaitForSeconds(6.0f);
        //Line_3.SetActive(false);

        Line_19_Index = 2;
        inside_Line_19[2].gameObject.SetActive(false);

        QuestObject.BGM_Index = 2;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(true);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        //inside_Line_11[27].gameObject.SetActive(false);
        TextContainer1.offsetMin = new Vector2(0, -3409.122f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23829.96f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()//그림 나타남
    {
        yield return new WaitForSeconds(8.0f);
        //Line_4.SetActive(true);

        Line_19_Index = 3;
        inside_Line_19[3].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3409.122f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23829.96f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()
    {
        yield return new WaitForSeconds(9.5f);
        //Line_5.SetActive(true);

        Line_19_Index = 4;
        inside_Line_19[4].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3409.122f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23829.96f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()
    {
        yield return new WaitForSeconds(11.0f);
        //Line_6.SetActive(true);

        Line_19_Index = 5;
        inside_Line_19[5].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

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

        TextContainer1.offsetMin = new Vector2(0, -3409.122f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23829.96f);    //(오, 위)
    }

    IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(12.5f);
        //Line_7.SetActive(true);

        Line_19_Index = 6;
        inside_Line_19[6].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3284.233f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23954.85f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(14.0f);
        //Line_8.SetActive(true);

        Line_19_Index = 7;
        inside_Line_19[7].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3041.725f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 24197.36f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()
    {
        yield return new WaitForSeconds(15.5f);
        //Line_9.SetActive(true);

        Line_19_Index = 8;
        inside_Line_19[8].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2838.24f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 24400.84f);    //(오, 위)

    }

    IEnumerator WaitSecond_11()
    {
        yield return new WaitForSeconds(17.0f);
        //Line_10.SetActive(true);

        Line_19_Index = 9;
        inside_Line_19[9].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2551.819f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 24687.26f);    //(오, 위)


    }

    IEnumerator WaitSecond_12()
    {
        yield return new WaitForSeconds(18.5f);
        //Line_11.SetActive(true);

        Line_19_Index = 10;
        inside_Line_19[10].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2244.923f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 24994.16f);    //(오, 위)



    }

    IEnumerator WaitSecond_13()//속마음
    {
        yield return new WaitForSeconds(20.5f);
        //Line_12.SetActive(true);

        Line_19_Index = 11;
        inside_Line_19[11].gameObject.SetActive(true);
        //inside_Line_11[27].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_14()//속마음
    {
        yield return new WaitForSeconds(22.5f);
        //Line_13.SetActive(true);
        //Line_12.SetActive(false);


        Line_19_Index = 12;
        inside_Line_19[12].gameObject.SetActive(true);
        inside_Line_19[11].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_15()
    {
        yield return new WaitForSeconds(25.5f);
        //Line_14.SetActive(true);
        //Line_13.SetActive(false);

        Line_19_Index = 13;
        inside_Line_19[13].gameObject.SetActive(true);
        inside_Line_19[12].gameObject.SetActive(false);

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

        TextContainer1.offsetMin = new Vector2(0, -1538.097f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 25700.98f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()
    {
        yield return new WaitForSeconds(27.0f);
        //Line_15.SetActive(true);

        Line_19_Index = 14;
        inside_Line_19[14].gameObject.SetActive(true);
        //inside_Line_19[11].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1240.354f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 25998.73f);    //(오, 위)

    }

    IEnumerator WaitSecond_17()
    {
        yield return new WaitForSeconds(28.5f);
        //Line_16.SetActive(true);

        Line_19_Index = 15;
        inside_Line_19[15].gameObject.SetActive(true);
        //inside_Line_19[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -950.8203f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 26288.26f);    //(오, 위)


    }

    IEnumerator WaitSecond_18()
    {
        yield return new WaitForSeconds(30.0f);
        //Line_17.SetActive(true);

        Line_19_Index = 16;
        inside_Line_19[16].gameObject.SetActive(true);
        //inside_Line_19[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -794.7227f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 26444.36f);    //(오, 위)


    }

    IEnumerator WaitSecond_19()
    {
        yield return new WaitForSeconds(31.5f);
        //Line_18.SetActive(true);

        Line_19_Index = 17;
        inside_Line_19[17].gameObject.SetActive(true);
        //inside_Line_19[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -646.9873f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 26592.09f);    //(오, 위)

    }

    IEnumerator WaitSecond_20()
    {
        yield return new WaitForSeconds(33.0f);
        //Line_19.SetActive(true);

        Line_19_Index = 18;
        inside_Line_19[18].gameObject.SetActive(true);
        //inside_Line_19[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -426.5186f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 26812.56f);    //(오, 위)
    }

    IEnumerator WaitSecond_21()//선택지
    {
        yield return new WaitForSeconds(34.5f);
        //Line_20.SetActive(true);

        Line_19_Index = 19;
        inside_Line_19[19].gameObject.SetActive(true);
        //inside_Line_19[11].gameObject.SetActive(false);

        inside_37.Line_37_Index = 0;
        inside_37.inside_Line_37[0].gameObject.SetActive(false);
        inside_37.inside_Line_37[1].gameObject.SetActive(false);
        inside_37.inside_Line_37[2].gameObject.SetActive(false);
        inside_37.inside_Line_37[3].gameObject.SetActive(false);
        inside_37.inside_Line_37[4].gameObject.SetActive(false);
        inside_37.inside_Line_37[5].gameObject.SetActive(false);
        inside_37.inside_Line_37[6].gameObject.SetActive(false);
        inside_37.inside_Line_37[7].gameObject.SetActive(false);
        inside_37.inside_Line_37[8].gameObject.SetActive(false);
        inside_37.inside_Line_37[9].gameObject.SetActive(false);
        inside_37.inside_Line_37[10].gameObject.SetActive(false);
        inside_37.inside_Line_37[11].gameObject.SetActive(false);
        inside_37.inside_Line_37[12].gameObject.SetActive(false);
        inside_37.inside_Line_37[13].gameObject.SetActive(false);
        inside_37.inside_Line_37[14].gameObject.SetActive(false);
        inside_37.inside_Line_37[15].gameObject.SetActive(false);
        inside_37.inside_Line_37[16].gameObject.SetActive(false);
        inside_37.inside_Line_37[17].gameObject.SetActive(false);
        inside_37.inside_Line_37[18].gameObject.SetActive(false);
        inside_37.inside_Line_37[19].gameObject.SetActive(false);
        inside_37.inside_Line_37[20].gameObject.SetActive(false);
        inside_37.inside_Line_37[21].gameObject.SetActive(false);
        inside_37.inside_Line_37[22].gameObject.SetActive(false);
        inside_37.inside_Line_37[23].gameObject.SetActive(false);
        inside_37.inside_Line_37[24].gameObject.SetActive(false);
        inside_37.inside_Line_37[25].gameObject.SetActive(false);
        inside_37.inside_Line_37[26].gameObject.SetActive(false);
        inside_37.inside_Line_37[27].gameObject.SetActive(false);
        inside_37.inside_Line_37[28].gameObject.SetActive(false);
        inside_37.inside_Line_37[29].gameObject.SetActive(false);
        inside_37.inside_Line_37[30].gameObject.SetActive(false);
        inside_37.inside_Line_37[31].gameObject.SetActive(false);
        inside_37.inside_Line_37[32].gameObject.SetActive(false);
        inside_37.inside_Line_37[33].gameObject.SetActive(false);
        inside_37.inside_Line_37[34].gameObject.SetActive(false);
        inside_37.inside_Line_37[35].gameObject.SetActive(false);
        inside_37.inside_Line_37[36].gameObject.SetActive(false);
        inside_37.inside_Line_37[37].gameObject.SetActive(false);
        inside_37.inside_Line_37[38].gameObject.SetActive(false);
        inside_37.inside_Line_37[39].gameObject.SetActive(false);
        inside_37.inside_Line_37[40].gameObject.SetActive(false);
        inside_37.inside_Line_37[41].gameObject.SetActive(false);
        inside_37.inside_Line_37[42].gameObject.SetActive(false);
        inside_37.inside_Line_37[43].gameObject.SetActive(false);
        inside_37.inside_Line_37[44].gameObject.SetActive(false);
        inside_37.inside_Line_37[45].gameObject.SetActive(false);
        inside_37.inside_Line_37[46].gameObject.SetActive(false);
        inside_37.inside_Line_37[47].gameObject.SetActive(false);
        inside_37.inside_Line_37[48].gameObject.SetActive(false);
        inside_37.inside_Line_37[49].gameObject.SetActive(false);
        inside_37.inside_Line_37[50].gameObject.SetActive(false);
        inside_37.inside_Line_37[51].gameObject.SetActive(false);
        inside_37.inside_Line_37[52].gameObject.SetActive(false);
        inside_37.inside_Line_37[53].gameObject.SetActive(false);
        inside_37.inside_Line_37[54].gameObject.SetActive(false);
        inside_37.inside_Line_37[55].gameObject.SetActive(false);
        inside_37.inside_Line_37[56].gameObject.SetActive(false);
        inside_37.inside_Line_37[57].gameObject.SetActive(false);
        inside_37.inside_Line_37[58].gameObject.SetActive(false);
        inside_37.inside_Line_37[59].gameObject.SetActive(false);
        inside_37.inside_Line_37[60].gameObject.SetActive(false);
        inside_37.inside_Line_37[61].gameObject.SetActive(false);
        inside_37.inside_Line_37[62].gameObject.SetActive(false);
        inside_37.inside_Line_37[63].gameObject.SetActive(false);
        inside_37.inside_Line_37[64].gameObject.SetActive(false);
        inside_37.inside_Line_37[65].gameObject.SetActive(false);
        inside_37.inside_Line_37[66].gameObject.SetActive(false);
        inside_37.inside_Line_37[67].gameObject.SetActive(false);
        inside_37.inside_Line_37[68].gameObject.SetActive(false);
        inside_37.inside_Line_37[69].gameObject.SetActive(false);
        inside_37.inside_Line_37[70].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.07617188f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 27239.16f);    //(오, 위)


    }


}
