using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class R_Wait1_2_4 : MonoBehaviour
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
    public GameObject Line_29;
    public GameObject Line_30;
    public GameObject Line_31;
    public GameObject Line_32;
    public GameObject Line_33;
    public GameObject Line_34;
    public GameObject Line_35;
    public GameObject Line_36;
    public GameObject Line_37;
    public GameObject Line_38;
    public GameObject Line_39;
    public GameObject Line_40;
    public GameObject Line_41;
    public GameObject Line_42;
    public GameObject Line_43;
    public GameObject Line_44;
    public GameObject Line_45;*/

    public Fade_Collect FadeObject;//페이드 스크립트 불러오려고
    public GameObject[] inside_Line_8;
    public int Line_8_Index;

    public Sum_1_1_1 inside_1_1_1;
    public Sum_1_1_2 inside_1_1_2;

    public R_Wait1_3_2 inside_13;
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
        //yield return StartCoroutine(WaitSecond_0());
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
        yield return StartCoroutine(WaitSecond_30());
        yield return StartCoroutine(WaitSecond_31());
        yield return StartCoroutine(WaitSecond_32());
        yield return StartCoroutine(WaitSecond_33());
        yield return StartCoroutine(WaitSecond_34());
        yield return StartCoroutine(WaitSecond_35());
        yield return StartCoroutine(WaitSecond_36());
        yield return StartCoroutine(WaitSecond_37());
        yield return StartCoroutine(WaitSecond_38());
        yield return StartCoroutine(WaitSecond_39());
        yield return StartCoroutine(WaitSecond_40());
        yield return StartCoroutine(WaitSecond_41());
        yield return StartCoroutine(WaitSecond_42());
        yield return StartCoroutine(WaitSecond_43());
        yield return StartCoroutine(WaitSecond_44());
        yield return StartCoroutine(WaitSecond_45());
        yield return StartCoroutine(WaitSecond_46());



    }



    IEnumerator WaitSecond_1()
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
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

        Line_8_Index = 0;
        inside_Line_8[0].gameObject.SetActive(true);

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

        TextContainer1.offsetMin = new Vector2(0, -11847.17f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 4853.337f);    //(오, 위)

        inside_1_1_1.Line_1_Index = 0;
        inside_1_1_1.inside_Line_1[0].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[1].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[2].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[3].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[4].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[5].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[6].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[7].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[8].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[9].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[10].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[11].gameObject.SetActive(false);
        inside_1_1_1.inside_Line_1[12].gameObject.SetActive(false);

        inside_1_1_2.Line_2_Index = 0;
        inside_1_1_2.inside_Line_2[0].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[1].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[2].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[3].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[4].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[5].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[6].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[7].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[8].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[9].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[10].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[11].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_2[12].gameObject.SetActive(false);

        

    }

    IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);

        Line_8_Index = 1;
        inside_Line_8[1].gameObject.SetActive(true);

        /*QuestObject.Line_Index = 6;

        QuestObject.questObject[0].gameObject.SetActive(false);
        QuestObject.questObject[1].gameObject.SetActive(false);
        QuestObject.questObject[2].gameObject.SetActive(false);
        QuestObject.questObject[3].gameObject.SetActive(false);
        QuestObject.questObject[4].gameObject.SetActive(false);
        QuestObject.questObject[5].gameObject.SetActive(false);

        QuestObject.questObject[7].gameObject.SetActive(false);

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
        QuestObject.questObject[19].gameObject.SetActive(false);
        QuestObject.questObject[20].gameObject.SetActive(false);
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

        TextContainer1.offsetMin = new Vector2(0, -11629.75f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 5070.758f);    //(오, 위)
    }

    IEnumerator WaitSecond_3()
    {
        yield return new WaitForSeconds(3.0f);
        //Line_3.SetActive(true);

        Line_8_Index = 2;
        inside_Line_8[2].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11345.43f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 5355.079f);    //(오, 위)

    }

    IEnumerator WaitSecond_4()
    {
        yield return new WaitForSeconds(4.5f);
        //Line_4.SetActive(true);

        Line_8_Index = 3;
        inside_Line_8[3].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11120f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 5580.509f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()
    {
        yield return new WaitForSeconds(6.0f);
        //Line_5.SetActive(true);

        Line_8_Index = 4;
        inside_Line_8[4].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -10830.63f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 5869.876f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()
    {
        yield return new WaitForSeconds(7.5f);
        //Line_6.SetActive(true);

        Line_8_Index = 5;
        inside_Line_8[5].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -10644.33f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 6056.181f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()
    {
        yield return new WaitForSeconds(9.0f);
        //Line_7.SetActive(true);

        Line_8_Index = 6;
        inside_Line_8[6].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -10446.42f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 6254.09f);    //(오, 위)

    }

    IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(10.5f);
        //Line_8.SetActive(true);

        Line_8_Index = 7;
        inside_Line_8[7].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -10097.99f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 6602.522f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(12.0f);
        //Line_9.SetActive(true);

        Line_8_Index = 8;
        inside_Line_8[8].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9947.465f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 6753.045f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//그림 나타나기 전
    {
        yield return new WaitForSeconds(13.5f);
        //Line_10.SetActive(true);

        Line_8_Index = 9;
        inside_Line_8[9].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9596.245f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 7104.265f);    //(오, 위)

    }

    IEnumerator WaitSecond_11()//그림 나타남//10
    {
        yield return new WaitForSeconds(15.0f);
        //Line_11.SetActive(true);

        Line_8_Index =10;
        inside_Line_8[10].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9310.76f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 7389.75f);    //(오, 위)

    }

    IEnumerator WaitSecond_12()//11
    {
        yield return new WaitForSeconds(16.5f);
        //Line_12.SetActive(true);

        Line_8_Index = 11;
        inside_Line_8[11].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9137.938f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 7562.573f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//그림없음
    {
        yield return new WaitForSeconds(18.0f);
        //Line_12.SetActive(true);

        QuestObject.BGM_Index = 3;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(true);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7704.951f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 8995.559f);    //(오, 위)

    }

    IEnumerator WaitSecond_14()//그림 그림 나타나기까지 2초
    {
        yield return new WaitForSeconds(20.0f);
        //Line_13.SetActive(true);

        Line_8_Index = 12;
        inside_Line_8[12].gameObject.SetActive(true);

        

        // % 여기부턴 앨범 관련 %

        //1번 앨범 오픈 관련
        if (All_Save.Album_1[2].gameObject.activeSelf == true)
        {//이미 1번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album1_Index = 2;
            All_Save.Album_1[0].gameObject.SetActive(false);
            All_Save.Album_1[1].gameObject.SetActive(false);
            All_Save.Album_1[2].gameObject.SetActive(true);

        }

        //1번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_1[2].gameObject.activeSelf == false)
        {
            //1번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album1_Index = 2;
            All_Save.Album_1[0].gameObject.SetActive(false);
            All_Save.Album_1[1].gameObject.SetActive(false);
            All_Save.Album_1[2].gameObject.SetActive(true);

        }

        //첫 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_1", All_Save.Album1_Index);

        // % 여기부턴 다음 앨범에 대한 힌트 제공 %

        //2번 앨범 오픈 관련
        if (All_Save.Album_2[2].gameObject.activeSelf == true)
        {//이미 2번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album2_Index = 2;
            All_Save.Album_2[0].gameObject.SetActive(false);
            All_Save.Album_2[1].gameObject.SetActive(false);
            All_Save.Album_2[2].gameObject.SetActive(true);

        }

        //2번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_2[2].gameObject.activeSelf == false)
        {
            //2번 앨범에 대한 힌트를 준다
            All_Save.Album2_Index = 1;
            All_Save.Album_2[0].gameObject.SetActive(false);
            All_Save.Album_2[1].gameObject.SetActive(true);
            All_Save.Album_2[2].gameObject.SetActive(false);

        }

        //두 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_2", All_Save.Album2_Index);



        TextContainer1.offsetMin = new Vector2(0, -7704.951f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 8995.559f);    //(오, 위)

    }

    IEnumerator WaitSecond_15()//14
    {
        yield return new WaitForSeconds(21.5f);
        //Line_14.SetActive(true);

        Line_8_Index = 13;
        inside_Line_8[13].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -7704.951f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 8995.559f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()//15
    {
        yield return new WaitForSeconds(23.0f);
        //Line_15.SetActive(true);

        Line_8_Index = 14;
        inside_Line_8[14].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -7704.951f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 8995.559f);    //(오, 위)

    }

    IEnumerator WaitSecond_17()//15
    {
        yield return new WaitForSeconds(24.5f);
        //Line_16.SetActive(true);

        Line_8_Index = 15;
        inside_Line_8[15].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -7645.117f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 9055.393f);    //(오, -위)

    }

    IEnumerator WaitSecond_18()//15
    {
        yield return new WaitForSeconds(26.0f);
        //Line_17.SetActive(true);

        Line_8_Index = 16;
        inside_Line_8[16].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -7484.298f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 9216.212f);    //(오, -위)

    }

    IEnumerator WaitSecond_19()//15
    {
        yield return new WaitForSeconds(27.5f);
        //Line_18.SetActive(true);

        Line_8_Index = 17;
        inside_Line_8[17].gameObject.SetActive(true);
        TextContainer1.offsetMin = new Vector2(0, -7334.458f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 9366.051f);    //(오, -위)

    }

    IEnumerator WaitSecond_20()//15
    {
        yield return new WaitForSeconds(29.0f);
        //Line_19.SetActive(true);

        Line_8_Index = 18;
        inside_Line_8[18].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -7047.489f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 9653.021f);    //(오, -위)

    }

    IEnumerator WaitSecond_21()//15
    {
        yield return new WaitForSeconds(30.5f);
        //Line_20.SetActive(true);

        Line_8_Index = 19;
        inside_Line_8[19].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -6880.242f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 9820.268f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//15
    {
        yield return new WaitForSeconds(32.0f);
        //Line_21.SetActive(true);

        Line_8_Index = 20;
        inside_Line_8[20].gameObject.SetActive(true);

        // % 여기부턴 앨범 관련 %

        //2번 앨범 오픈 관련
        if (All_Save.Album_2[2].gameObject.activeSelf == true)
        {//이미 2번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album2_Index = 2;
            All_Save.Album_2[0].gameObject.SetActive(false);
            All_Save.Album_2[1].gameObject.SetActive(false);
            All_Save.Album_2[2].gameObject.SetActive(true);

        }

        //2번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_2[2].gameObject.activeSelf == false)
        {
            //2번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album2_Index = 2;
            All_Save.Album_2[0].gameObject.SetActive(false);
            All_Save.Album_2[1].gameObject.SetActive(false);
            All_Save.Album_2[2].gameObject.SetActive(true);

        }

        //두 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_2", All_Save.Album2_Index);

        // % 여기부턴 다음 앨범에 대한 힌트 제공 %

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
            //3번 앨범에 대한 힌트를 준다
            All_Save.Album3_Index = 1;
            All_Save.Album_3[0].gameObject.SetActive(false);
            All_Save.Album_3[1].gameObject.SetActive(true);
            All_Save.Album_3[2].gameObject.SetActive(false);

        }

        //세 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_3", All_Save.Album3_Index);


        TextContainer1.offsetMin = new Vector2(0, -6161.471f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 10539.04f);    //(오, -위)

    }

    IEnumerator WaitSecond_23()//15
    {
        yield return new WaitForSeconds(33.5f);
        //Line_22.SetActive(true);

        Line_8_Index = 21;
        inside_Line_8[21].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -5874.482f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 10826.03f);    //(오, -위)

    }

    IEnumerator WaitSecond_24()//15
    {
        yield return new WaitForSeconds(35.0f);
        //Line_23.SetActive(true);

        Line_8_Index = 22;
        inside_Line_8[22].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -5721.172f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 10979.34f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//15
    {
        yield return new WaitForSeconds(36.5f);
        //Line_24.SetActive(true);

        Line_8_Index = 23;
        inside_Line_8[23].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -5431.276f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 11269.23f);    //(오, -위)

    }

    IEnumerator WaitSecond_26()//15
    {
        yield return new WaitForSeconds(38.0f);
        //Line_25.SetActive(true);

        Line_8_Index = 24;
        inside_Line_8[24].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -5280.754f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 11419.76f);    //(오, -위)

    }

    IEnumerator WaitSecond_27()//15
    {
        yield return new WaitForSeconds(39.5f);
        //Line_26.SetActive(true);

        Line_8_Index = 25;
        inside_Line_8[25].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4990.858f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 11709.65f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//15
    {
        yield return new WaitForSeconds(41.0f);
        //Line_27.SetActive(true);

        Line_8_Index = 26;
        inside_Line_8[26].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4840.509f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 11860f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//15
    {
        yield return new WaitForSeconds(42.5f);
        //Line_28.SetActive(true);

        Line_8_Index = 27;
        inside_Line_8[27].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4549.397f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 12151.11f);    //(오, -위)

    }

    IEnumerator WaitSecond_30()//15
    {
        yield return new WaitForSeconds(44.0f);
        //Line_29.SetActive(true);

        Line_8_Index = 28;
        inside_Line_8[28].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4396.192f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 12304.32f);    //(오, -위)

    }

    IEnumerator WaitSecond_31()//15
    {
        yield return new WaitForSeconds(45.5f);
        //Line_30.SetActive(true);

        Line_8_Index = 29;
        inside_Line_8[29].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4145.322f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 12555.19f);    //(오, -위)

    }

    IEnumerator WaitSecond_32()//15
    {
        yield return new WaitForSeconds(47.0f);
        //Line_31.SetActive(true);

        Line_8_Index = 30;
        inside_Line_8[30].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3952.987f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 12747.52f);    //(오, -위)

    }

    IEnumerator WaitSecond_33()//15
    {
        yield return new WaitForSeconds(48.5f);
        //Line_32.SetActive(true);

        Line_8_Index = 31;
        inside_Line_8[31].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3258.13f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 13442.38f);    //(오, -위)

    }

    IEnumerator WaitSecond_34()//15
    {
        yield return new WaitForSeconds(50.0f);
        //Line_33.SetActive(true);

        Line_8_Index = 32;
        inside_Line_8[32].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2968.282f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 13732.23f);    //(오, -위)

    }

    IEnumerator WaitSecond_35()//15
    {
        yield return new WaitForSeconds(51.5f);
        //Line_34.SetActive(true);

        Line_8_Index = 33;
        inside_Line_8[33].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2815.351f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 13885.16f);    //(오, -위)

    }

    IEnumerator WaitSecond_36()//15
    {
        yield return new WaitForSeconds(53.0f);
        //Line_35.SetActive(true);

        Line_8_Index = 34;
        inside_Line_8[34].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2664.684f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 14035.83f);    //(오, -위)

    }

    IEnumerator WaitSecond_37()//15
    {
        yield return new WaitForSeconds(54.5f);
        //Line_36.SetActive(true);

        Line_8_Index = 35;
        inside_Line_8[35].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2343.481f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 14357.03f);    //(오, -위)

    }

    IEnumerator WaitSecond_38()//15
    {
        yield return new WaitForSeconds(56.0f);
        //Line_37.SetActive(true);

        Line_8_Index = 36;
        inside_Line_8[36].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2145.571f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 14554.94f);    //(오, -위)

    }

    IEnumerator WaitSecond_39()//15
    {
        yield return new WaitForSeconds(57.5f);
        //Line_38.SetActive(true);

        Line_8_Index = 37;
        inside_Line_8[37].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -1797.372f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 14903.14f);    //(오, -위)

    }

    IEnumerator WaitSecond_40()//15
    {
        yield return new WaitForSeconds(59.0f);
        //Line_39.SetActive(true);

        Line_8_Index = 38;
        inside_Line_8[38].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -1641.274f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15059.24f);    //(오, -위)

    }

    IEnumerator WaitSecond_41()//15
    {
        yield return new WaitForSeconds(60.5f);
        //Line_40.SetActive(true);

        Line_8_Index = 39;
        inside_Line_8[39].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -1353.385f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15347.13f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//15
    {
        yield return new WaitForSeconds(62.0f);
        //Line_41.SetActive(true);

        Line_8_Index = 40;
        inside_Line_8[40].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -1163.838f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15536.67f);    //(오, -위)

    }

    IEnumerator WaitSecond_43()//15
    {
        yield return new WaitForSeconds(63.5f);
        //Line_42.SetActive(true);

        Line_8_Index = 41;
        inside_Line_8[41].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -868.2012f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15832.31f);    //(오, -위)

    }

    IEnumerator WaitSecond_44()//15
    {
        yield return new WaitForSeconds(65.0f);
        //Line_43.SetActive(true);

        Line_8_Index = 42;
        inside_Line_8[42].gameObject.SetActive(true);


        TextContainer1.offsetMin = new Vector2(0, -654.4165f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16046.09f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//15
    {
        yield return new WaitForSeconds(66.5f);
        //Line_44.SetActive(true);

        Line_8_Index = 43;
        inside_Line_8[43].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -491.1143f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16209.4f);    //(오, -위)

    }

    IEnumerator WaitSecond_46()//15
    {
        yield return new WaitForSeconds(68.0f);
        //Line_45.SetActive(true);

        Line_8_Index = 44;
        inside_Line_8[44].gameObject.SetActive(true);

        inside_13.Line_13_Index = 0;
        inside_13.inside_Line_13[0].gameObject.SetActive(false);
        inside_13.inside_Line_13[1].gameObject.SetActive(false);
        inside_13.inside_Line_13[2].gameObject.SetActive(false);
        inside_13.inside_Line_13[3].gameObject.SetActive(false);
        inside_13.inside_Line_13[4].gameObject.SetActive(false);
        inside_13.inside_Line_13[5].gameObject.SetActive(false);
        inside_13.inside_Line_13[6].gameObject.SetActive(false);
        inside_13.inside_Line_13[7].gameObject.SetActive(false);
        inside_13.inside_Line_13[8].gameObject.SetActive(false);
        inside_13.inside_Line_13[9].gameObject.SetActive(false);
        inside_13.inside_Line_13[10].gameObject.SetActive(false);
        inside_13.inside_Line_13[11].gameObject.SetActive(false);
        inside_13.inside_Line_13[12].gameObject.SetActive(false);
        inside_13.inside_Line_13[13].gameObject.SetActive(false);
        inside_13.inside_Line_13[14].gameObject.SetActive(false);
        inside_13.inside_Line_13[15].gameObject.SetActive(false);
        inside_13.inside_Line_13[16].gameObject.SetActive(false);
        inside_13.inside_Line_13[17].gameObject.SetActive(false);
        inside_13.inside_Line_13[18].gameObject.SetActive(false);
        inside_13.inside_Line_13[19].gameObject.SetActive(false);
        inside_13.inside_Line_13[20].gameObject.SetActive(false);
        inside_13.inside_Line_13[21].gameObject.SetActive(false);
        inside_13.inside_Line_13[22].gameObject.SetActive(false);

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

        TextContainer1.offsetMin = new Vector2(0, 0.06933594f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16700.58f);    //(오, -위)

    }

}
