using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class R_Wait1_5_21 : MonoBehaviour
{
    public Save_Collection All_Save;
    public AudioSource sfx5;
    public Fade_Collect FadeObject;
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
    public GameObject Line_45;
    public GameObject Line_46;
    public GameObject Line_47;
    public GameObject Line_48;
    public GameObject Line_49;*/


    public GameObject[] inside_Line_53;
    public int Line_53_Index;

    public R_Wait1_4_11 inside_37;


    public R_Wait1_6_41 inside_121;
    public R_Wait_1_6_42 inside_125;

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
        yield return StartCoroutine(WaitSecond_47());
        yield return StartCoroutine(WaitSecond_48());
        yield return StartCoroutine(WaitSecond_49());
        yield return StartCoroutine(WaitSecond_50());
        yield return StartCoroutine(WaitSecond_51());






    }



    IEnumerator WaitSecond_1()//133-속마음
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        QuestObject.BGM_Index = 1;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(true);
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

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_53_Index = 0;
        inside_Line_53[0].gameObject.SetActive(true);
        //inside_Line_53[1].gameObject.SetActive(false);

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

        /*QuestObject.Line_Index = 53;

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

        TextContainer1.offsetMin = new Vector2(0, -9408.156f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42670.84f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()//134-속마음
    {
        yield return new WaitForSeconds(2.5f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);

        

        Line_53_Index = 1;
        inside_Line_53[1].gameObject.SetActive(true);
        inside_Line_53[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_3()//135-1
    {

        yield return new WaitForSeconds(5.0f);
        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_53_Index = 2;
        inside_Line_53[2].gameObject.SetActive(true);
        inside_Line_53[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9112.686f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42966.31f);    //(오, 위)


    }

    IEnumerator WaitSecond_4()//135-2
    {
        yield return new WaitForSeconds(6.5f);
        //Line_4.SetActive(true);

        Line_53_Index = 3;
        inside_Line_53[3].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8970.525f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43108.48f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()//136-1
    {
        yield return new WaitForSeconds(8.0f);
        //Line_5.SetActive(true);

        Line_53_Index = 4;
        inside_Line_53[4].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8687.068f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43391.93f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//136-2
    {
        yield return new WaitForSeconds(9.5f);
        //Line_6.SetActive(true);

        Line_53_Index = 5;
        inside_Line_53[5].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8533.758f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43545.24f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()//137
    {
        yield return new WaitForSeconds(11.0f);
        //Line_7.SetActive(true);

        Line_53_Index = 6;
        inside_Line_53[6].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8241.074f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43837.93f);    //(오, 위)

    }

    IEnumerator WaitSecond_8()//138
    {
        yield return new WaitForSeconds(12.5f);
        //Line_8.SetActive(true);

        Line_53_Index = 7;
        inside_Line_53[7].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8045.953f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44033.05f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()//139
    {
        yield return new WaitForSeconds(14.0f);
        //Line_9.SetActive(true);

        Line_53_Index = 8;
        inside_Line_53[8].gameObject.SetActive(true);
        //inside_Line_53[7].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7733.467f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44345.53f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//140-속마음
    {
        yield return new WaitForSeconds(16.0f);
        //Line_10.SetActive(true);

        Line_53_Index = 9;
        inside_Line_53[9].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_11()//141-속마음
    {
        yield return new WaitForSeconds(18.5f);
        //Line_11.SetActive(true);
        //Line_10.SetActive(false);


        Line_53_Index = 10;
        inside_Line_53[10].gameObject.SetActive(true);
        inside_Line_53[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_12()//142
    {
        yield return new WaitForSeconds(22.0f);
        //Line_12.SetActive(true);
        //Line_11.SetActive(false);

        Line_53_Index = 11;
        inside_Line_53[11].gameObject.SetActive(true);
        inside_Line_53[10].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7381.689f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44697.31f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//143
    {
        yield return new WaitForSeconds(23.5f);
        //Line_13.SetActive(true);

        Line_53_Index = 12;
        inside_Line_53[12].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7091.795f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44987.2f);    //(오, -위)

    }

    IEnumerator WaitSecond_14()//144-속마음
    {
        yield return new WaitForSeconds(25.5f);
        //Line_14.SetActive(true);

        Line_53_Index = 13;
        inside_Line_53[13].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_15()//145-속마음
    {
        yield return new WaitForSeconds(29.0f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_53_Index = 14;
        inside_Line_53[14].gameObject.SetActive(true);
        inside_Line_53[13].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_16()//146하기 전 맨 위로 배치
    {
        yield return new WaitForSeconds(31.5f);
        //Line_15.SetActive(false);

        Line_53_Index = 14;
        inside_Line_53[14].gameObject.SetActive(false);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5623.762f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46455.24f);    //(오, -위)
    }

    IEnumerator WaitSecond_17()//146
    {
        yield return new WaitForSeconds(33.0f);
        //Line_16.SetActive(true);

        Line_53_Index = 15;
        inside_Line_53[15].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5623.762f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46455.24f);    //(오, -위)
    }

    IEnumerator WaitSecond_18()//147
    {
        yield return new WaitForSeconds(34.5f);

        // Line_17.SetActive(true);

        Line_53_Index = 16;
        inside_Line_53[16].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5623.762f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46455.24f);    //(오, -위)

    }

    IEnumerator WaitSecond_19()//148
    {
        yield return new WaitForSeconds(36.0f);
        //Line_18.SetActive(true);

        Line_53_Index = 17;
        inside_Line_53[17].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5623.762f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46455.24f);    //(오, -위)

    }

    IEnumerator WaitSecond_20()//149
    {
        yield return new WaitForSeconds(37.5f);
        //Line_19.SetActive(true);
        sfx5.Play();
        Line_53_Index = 18;
        inside_Line_53[18].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5623.762f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46455.24f);    //(오, -위)
    }

    IEnumerator WaitSecond_21()//150
    {
        yield return new WaitForSeconds(39.0f);

        //Line_20.SetActive(true);

        Line_53_Index = 19;
        inside_Line_53[19].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5295.986f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46783.02f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//151-속마음
    {
        yield return new WaitForSeconds(41.0f);
        //Line_21.SetActive(true);

        Line_53_Index = 20;
        inside_Line_53[20].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_23()//152-속마음
    {
        yield return new WaitForSeconds(44.0f);

        //Line_22.SetActive(true);
        //Line_21.SetActive(false);

        Line_53_Index = 21;
        inside_Line_53[21].gameObject.SetActive(true);
        inside_Line_53[20].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_24()//153
    {
        yield return new WaitForSeconds(46.0f);
        //Line_23.SetActive(true);
        //Line_22.SetActive(false);

        Line_53_Index = 22;
        inside_Line_53[22].gameObject.SetActive(true);
        inside_Line_53[21].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -5006.404f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47072.59f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//154
    {
        yield return new WaitForSeconds(47.5f);
        //Line_24.SetActive(true);

        Line_53_Index = 23;
        inside_Line_53[23].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4719.297f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47359.7f);    //(오, -위)

    }

    IEnumerator WaitSecond_26()//155
    {
        yield return new WaitForSeconds(49.0f);
        //Line_25.SetActive(true);

        Line_53_Index = 24;
        inside_Line_53[24].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4429.402f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47649.6f);    //(오, -위)
    }

    IEnumerator WaitSecond_27()//156되기 전에 맨 위로 올리기
    {
        yield return new WaitForSeconds(50.5f);

        TextContainer1.offsetMin = new Vector2(0, -2969.977f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49109.02f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//156
    {
        yield return new WaitForSeconds(52.5f);
        //Line_26.SetActive(true);

        Line_53_Index = 25;
        inside_Line_53[25].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2969.977f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49109.02f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//157
    {
        yield return new WaitForSeconds(54.0f);
        //Line_27.SetActive(true);

        Line_53_Index = 26;
        inside_Line_53[26].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2969.977f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49109.02f);    //(오, -위)

    }

    IEnumerator WaitSecond_30()//158-속마음
    {
        yield return new WaitForSeconds(56.0f);
        //Line_28.SetActive(true);
        Line_53_Index = 27;
        inside_Line_53[27].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);




    }

    IEnumerator WaitSecond_31()//159-속마음
    {
        yield return new WaitForSeconds(59.0f);
        //Line_29.SetActive(true);
        //Line_28.SetActive(false);

        Line_53_Index = 28;
        inside_Line_53[28].gameObject.SetActive(true);
        inside_Line_53[27].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_32()//160-속마음
    {

        yield return new WaitForSeconds(62.0f);
        //Line_30.SetActive(true);
        //Line_29.SetActive(false);

        Line_53_Index = 29;
        inside_Line_53[29].gameObject.SetActive(true);
        inside_Line_53[28].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_33()//161
    {

        yield return new WaitForSeconds(65.5f);
        //Line_31.SetActive(true);
        //Line_30.SetActive(false);

        Line_53_Index = 30;
        inside_Line_53[30].gameObject.SetActive(true);
        inside_Line_53[29].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2969.977f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49109.02f);    //(오, -위)


    }

    IEnumerator WaitSecond_34()//162

    {
        yield return new WaitForSeconds(67.0f);
        //Line_32.SetActive(true);

        Line_53_Index = 31;
        inside_Line_53[31].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2969.977f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49109.02f);    //(오, -위)



    }

    IEnumerator WaitSecond_35()//163
    {
        yield return new WaitForSeconds(68.5f);
        //Line_33.SetActive(true);

        Line_53_Index = 32;
        inside_Line_53[32].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2969.977f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49109.02f);    //(오, -위)


    }

    IEnumerator WaitSecond_36()//164
    {
        yield return new WaitForSeconds(70.0f);

        //Line_34.SetActive(true);

        Line_53_Index = 33;
        inside_Line_53[33].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2710.742f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49368.26f);    //(오, -위)


    }

    IEnumerator WaitSecond_37()//165
    {
        yield return new WaitForSeconds(71.5f);
        //Line_35.SetActive(true);

        Line_53_Index = 34;
        inside_Line_53[34].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2487.904f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49591.09f);    //(오, -위)

    }


    IEnumerator WaitSecond_38()//166-1
    {
        yield return new WaitForSeconds(73.0f);
        //Line_36.SetActive(true);

        Line_53_Index = 35;
        inside_Line_53[35].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -2198.01f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49880.99f);    //(오, -위)

    }

    IEnumerator WaitSecond_39()//166-2
    {
        yield return new WaitForSeconds(74.5f);
        //Line_37.SetActive(true);

        Line_53_Index = 36;
        inside_Line_53[36].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2041.912f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50037.09f);    //(오, -위)

    }

    IEnumerator WaitSecond_40()//167-1
    {
        yield return new WaitForSeconds(76.0f);
        //Line_38.SetActive(true);

        Line_53_Index = 37;
        inside_Line_53[37].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1754.805f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50324.2f);    //(오, -위)

    }

    IEnumerator WaitSecond_41()//167-2
    {
        yield return new WaitForSeconds(77.5f);
        //Line_39.SetActive(true);

        Line_53_Index = 38;
        inside_Line_53[38].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1601.494f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50477.51f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//168-속마음
    {
        yield return new WaitForSeconds(79.5f);
        //Line_40.SetActive(true);

        Line_53_Index = 39;
        inside_Line_53[39].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_43()//169-1
    {
        yield return new WaitForSeconds(81.5f);
        //Line_41.SetActive(true);
        //Line_40.SetActive(false);

        Line_53_Index = 40;
        inside_Line_53[40].gameObject.SetActive(true);
        inside_Line_53[39].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1311.598f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50767.4f);    //(오, -위)



    }

    IEnumerator WaitSecond_44()//169-2
    {
        yield return new WaitForSeconds(83.0f);
        //Line_42.SetActive(true);

        Line_53_Index = 41;
        inside_Line_53[41].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1166.65f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50912.35f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//170-1
    {
        yield return new WaitForSeconds(84.5f);
        //Line_43.SetActive(true);

        Line_53_Index = 42;
        inside_Line_53[42].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -882.3301f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51196.67f);    //(오, -위)

    }

    IEnumerator WaitSecond_46()//170-2
    {
        yield return new WaitForSeconds(86.0f);
        //Line_44.SetActive(true);

        Line_53_Index = 43;
        inside_Line_53[43].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -729.0195f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51349.98f);    //(오, -위)

    }

    IEnumerator WaitSecond_47()//171
    {
        yield return new WaitForSeconds(87.5f);
        //Line_45.SetActive(true);

        Line_53_Index = 44;
        inside_Line_53[44].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -433.5488f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51645.45f);    //(오, -위)

    }

    IEnumerator WaitSecond_48()//172-속마음
    {
        yield return new WaitForSeconds(89.5f);
        //Line_46.SetActive(true);
        Line_53_Index = 45;
        inside_Line_53[45].gameObject.SetActive(true);
        //inside_Line_53[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_49()//173-속마음
    {
        yield return new WaitForSeconds(91.5f);
        //Line_47.SetActive(true);
        //Line_46.SetActive(false);

        Line_53_Index = 46;
        inside_Line_53[46].gameObject.SetActive(true);
        inside_Line_53[45].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_50()//174-속마음
    {
        yield return new WaitForSeconds(95.0f);
        //Line_48.SetActive(true);
        //Line_47.SetActive(false);

        Line_53_Index = 47;
        inside_Line_53[47].gameObject.SetActive(true);
        inside_Line_53[46].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_51()//175-선택지
    {
        yield return new WaitForSeconds(99.0f);
        //Line_49.SetActive(true);
        //Line_48.SetActive(false);

        inside_121.Line_1_6_41_Index = 0;

        inside_121.inside_1_6_41[0].gameObject.SetActive(false);
        inside_121.inside_1_6_41[1].gameObject.SetActive(false);
        inside_121.inside_1_6_41[2].gameObject.SetActive(false);
        inside_121.inside_1_6_41[3].gameObject.SetActive(false);
        inside_121.inside_1_6_41[4].gameObject.SetActive(false);
        inside_121.inside_1_6_41[5].gameObject.SetActive(false);
        inside_121.inside_1_6_41[6].gameObject.SetActive(false);
        inside_121.inside_1_6_41[7].gameObject.SetActive(false);
        inside_121.inside_1_6_41[8].gameObject.SetActive(false);
        inside_121.inside_1_6_41[9].gameObject.SetActive(false);
        inside_121.inside_1_6_41[10].gameObject.SetActive(false);
        inside_121.inside_1_6_41[11].gameObject.SetActive(false);
        inside_121.inside_1_6_41[12].gameObject.SetActive(false);
        inside_121.inside_1_6_41[13].gameObject.SetActive(false);
        inside_121.inside_1_6_41[14].gameObject.SetActive(false);
        inside_121.inside_1_6_41[15].gameObject.SetActive(false);
        inside_121.inside_1_6_41[16].gameObject.SetActive(false);
        inside_121.inside_1_6_41[17].gameObject.SetActive(false);
        inside_121.inside_1_6_41[18].gameObject.SetActive(false);
        inside_121.inside_1_6_41[19].gameObject.SetActive(false);
        inside_121.inside_1_6_41[20].gameObject.SetActive(false);
        inside_121.inside_1_6_41[21].gameObject.SetActive(false);
        inside_121.inside_1_6_41[22].gameObject.SetActive(false);
        inside_121.inside_1_6_41[23].gameObject.SetActive(false);
        inside_121.inside_1_6_41[24].gameObject.SetActive(false);
        inside_121.inside_1_6_41[25].gameObject.SetActive(false);
        inside_121.inside_1_6_41[26].gameObject.SetActive(false);
        inside_121.inside_1_6_41[27].gameObject.SetActive(false);
        inside_121.inside_1_6_41[28].gameObject.SetActive(false);
        inside_121.inside_1_6_41[29].gameObject.SetActive(false);
        inside_121.inside_1_6_41[30].gameObject.SetActive(false);
        inside_121.inside_1_6_41[31].gameObject.SetActive(false);
        inside_121.inside_1_6_41[32].gameObject.SetActive(false);
        inside_121.inside_1_6_41[33].gameObject.SetActive(false);
        inside_121.inside_1_6_41[34].gameObject.SetActive(false);
        inside_121.inside_1_6_41[35].gameObject.SetActive(false);
        inside_121.inside_1_6_41[36].gameObject.SetActive(false);
        inside_121.inside_1_6_41[37].gameObject.SetActive(false);
        inside_121.inside_1_6_41[38].gameObject.SetActive(false);
        inside_121.inside_1_6_41[39].gameObject.SetActive(false);
        inside_121.inside_1_6_41[40].gameObject.SetActive(false);
        inside_121.inside_1_6_41[41].gameObject.SetActive(false);
        inside_121.inside_1_6_41[42].gameObject.SetActive(false);
        inside_121.inside_1_6_41[43].gameObject.SetActive(false);
        inside_121.inside_1_6_41[44].gameObject.SetActive(false);
        inside_121.inside_1_6_41[45].gameObject.SetActive(false);
        inside_121.inside_1_6_41[46].gameObject.SetActive(false);
        inside_121.inside_1_6_41[47].gameObject.SetActive(false);
        inside_121.inside_1_6_41[48].gameObject.SetActive(false);
        inside_121.inside_1_6_41[49].gameObject.SetActive(false);
        inside_121.inside_1_6_41[50].gameObject.SetActive(false);
        inside_121.inside_1_6_41[51].gameObject.SetActive(false);
        inside_121.inside_1_6_41[52].gameObject.SetActive(false);
        inside_121.inside_1_6_41[53].gameObject.SetActive(false);
        inside_121.inside_1_6_41[54].gameObject.SetActive(false);
        inside_121.inside_1_6_41[55].gameObject.SetActive(false);
        inside_121.inside_1_6_41[56].gameObject.SetActive(false);
        inside_121.inside_1_6_41[57].gameObject.SetActive(false);
        inside_121.inside_1_6_41[58].gameObject.SetActive(false);
        inside_121.inside_1_6_41[59].gameObject.SetActive(false);
        inside_121.inside_1_6_41[60].gameObject.SetActive(false);
        inside_121.inside_1_6_41[61].gameObject.SetActive(false);
        inside_121.inside_1_6_41[62].gameObject.SetActive(false);
        inside_121.inside_1_6_41[63].gameObject.SetActive(false);
        inside_121.inside_1_6_41[64].gameObject.SetActive(false);
        inside_121.inside_1_6_41[65].gameObject.SetActive(false);
        inside_121.inside_1_6_41[66].gameObject.SetActive(false);
        inside_121.inside_1_6_41[67].gameObject.SetActive(false);

        Line_53_Index = 48;
        inside_Line_53[48].gameObject.SetActive(true);
        inside_Line_53[47].gameObject.SetActive(false);

        inside_125.Line_1_6_42_Index = 0;

        inside_125.inside_1_6_42[0].gameObject.SetActive(false);
        inside_125.inside_1_6_42[1].gameObject.SetActive(false);
        inside_125.inside_1_6_42[2].gameObject.SetActive(false);
        inside_125.inside_1_6_42[3].gameObject.SetActive(false);
        inside_125.inside_1_6_42[4].gameObject.SetActive(false);
        inside_125.inside_1_6_42[5].gameObject.SetActive(false);
        inside_125.inside_1_6_42[6].gameObject.SetActive(false);
        inside_125.inside_1_6_42[7].gameObject.SetActive(false);
        inside_125.inside_1_6_42[8].gameObject.SetActive(false);
        inside_125.inside_1_6_42[9].gameObject.SetActive(false);
        inside_125.inside_1_6_42[10].gameObject.SetActive(false);
        inside_125.inside_1_6_42[11].gameObject.SetActive(false);
        inside_125.inside_1_6_42[12].gameObject.SetActive(false);
        inside_125.inside_1_6_42[13].gameObject.SetActive(false);
        inside_125.inside_1_6_42[14].gameObject.SetActive(false);
        inside_125.inside_1_6_42[15].gameObject.SetActive(false);
        inside_125.inside_1_6_42[16].gameObject.SetActive(false);
        inside_125.inside_1_6_42[17].gameObject.SetActive(false);
        inside_125.inside_1_6_42[18].gameObject.SetActive(false);
        inside_125.inside_1_6_42[19].gameObject.SetActive(false);
        inside_125.inside_1_6_42[20].gameObject.SetActive(false);
        inside_125.inside_1_6_42[21].gameObject.SetActive(false);
        inside_125.inside_1_6_42[22].gameObject.SetActive(false);
        inside_125.inside_1_6_42[23].gameObject.SetActive(false);
        inside_125.inside_1_6_42[24].gameObject.SetActive(false);
        inside_125.inside_1_6_42[25].gameObject.SetActive(false);
        inside_125.inside_1_6_42[26].gameObject.SetActive(false);
        inside_125.inside_1_6_42[27].gameObject.SetActive(false);
        inside_125.inside_1_6_42[28].gameObject.SetActive(false);
        inside_125.inside_1_6_42[29].gameObject.SetActive(false);
        inside_125.inside_1_6_42[30].gameObject.SetActive(false);
        inside_125.inside_1_6_42[31].gameObject.SetActive(false);
        inside_125.inside_1_6_42[32].gameObject.SetActive(false);
        inside_125.inside_1_6_42[33].gameObject.SetActive(false);
        inside_125.inside_1_6_42[34].gameObject.SetActive(false);
        inside_125.inside_1_6_42[35].gameObject.SetActive(false);
        inside_125.inside_1_6_42[36].gameObject.SetActive(false);
        inside_125.inside_1_6_42[37].gameObject.SetActive(false);
        inside_125.inside_1_6_42[38].gameObject.SetActive(false);
        inside_125.inside_1_6_42[39].gameObject.SetActive(false);
        inside_125.inside_1_6_42[40].gameObject.SetActive(false);
        inside_125.inside_1_6_42[41].gameObject.SetActive(false);
        inside_125.inside_1_6_42[42].gameObject.SetActive(false);
        inside_125.inside_1_6_42[43].gameObject.SetActive(false);
        inside_125.inside_1_6_42[44].gameObject.SetActive(false);
        inside_125.inside_1_6_42[45].gameObject.SetActive(false);
        inside_125.inside_1_6_42[46].gameObject.SetActive(false);
        inside_125.inside_1_6_42[47].gameObject.SetActive(false);
        inside_125.inside_1_6_42[48].gameObject.SetActive(false);
        inside_125.inside_1_6_42[49].gameObject.SetActive(false);
        inside_125.inside_1_6_42[50].gameObject.SetActive(false);
        inside_125.inside_1_6_42[51].gameObject.SetActive(false);
        inside_125.inside_1_6_42[52].gameObject.SetActive(false);
        inside_125.inside_1_6_42[53].gameObject.SetActive(false);
        inside_125.inside_1_6_42[54].gameObject.SetActive(false);
        inside_125.inside_1_6_42[55].gameObject.SetActive(false);
        inside_125.inside_1_6_42[56].gameObject.SetActive(false);
        inside_125.inside_1_6_42[57].gameObject.SetActive(false);
        inside_125.inside_1_6_42[58].gameObject.SetActive(false);
        inside_125.inside_1_6_42[59].gameObject.SetActive(false);
        inside_125.inside_1_6_42[60].gameObject.SetActive(false);
        inside_125.inside_1_6_42[61].gameObject.SetActive(false);
        inside_125.inside_1_6_42[62].gameObject.SetActive(false);
        inside_125.inside_1_6_42[63].gameObject.SetActive(false);
        inside_125.inside_1_6_42[64].gameObject.SetActive(false);
        inside_125.inside_1_6_42[65].gameObject.SetActive(false);
        inside_125.inside_1_6_42[66].gameObject.SetActive(false);
        inside_125.inside_1_6_42[67].gameObject.SetActive(false);
        inside_125.inside_1_6_42[68].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.04882813f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 52079.05f);    //(오, -위)

    }



}
