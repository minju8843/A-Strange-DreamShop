using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class R_Wait1_5_18 : MonoBehaviour
{
    public Save_Collection All_Save;
    public AudioSource sfx5;
    public Fade_Collect FadeObject;
    /* public GameObject Line_1;
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
     public GameObject Line_49;
     public GameObject Line_50;
     public GameObject Line_51;
     public GameObject Line_52;*/

    public GameObject[] inside_Line_65;
    public int Line_65_Index;

    public R_Wait1_6_35 inside_113;
    public R_Wait1_6_36 inside_117;

    public R_Wait1_4_9 inside_34;

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
        yield return StartCoroutine(WaitSecond_52());
        yield return StartCoroutine(WaitSecond_53());
        yield return StartCoroutine(WaitSecond_54());





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

        Line_65_Index = 0;
        inside_Line_65[0].gameObject.SetActive(true);
        //inside_Line_65[1].gameObject.SetActive(false);

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

        inside_34.Line_34_Index = 0;
        inside_34.inside_Line_34[0].gameObject.SetActive(false);
        inside_34.inside_Line_34[1].gameObject.SetActive(false);
        inside_34.inside_Line_34[2].gameObject.SetActive(false);
        inside_34.inside_Line_34[3].gameObject.SetActive(false);
        inside_34.inside_Line_34[4].gameObject.SetActive(false);
        inside_34.inside_Line_34[5].gameObject.SetActive(false);
        inside_34.inside_Line_34[6].gameObject.SetActive(false);
        inside_34.inside_Line_34[7].gameObject.SetActive(false);
        inside_34.inside_Line_34[8].gameObject.SetActive(false);
        inside_34.inside_Line_34[9].gameObject.SetActive(false);
        inside_34.inside_Line_34[10].gameObject.SetActive(false);
        inside_34.inside_Line_34[11].gameObject.SetActive(false);
        inside_34.inside_Line_34[12].gameObject.SetActive(false);
        inside_34.inside_Line_34[13].gameObject.SetActive(false);
        inside_34.inside_Line_34[14].gameObject.SetActive(false);
        inside_34.inside_Line_34[15].gameObject.SetActive(false);
        inside_34.inside_Line_34[16].gameObject.SetActive(false);
        inside_34.inside_Line_34[17].gameObject.SetActive(false);
        inside_34.inside_Line_34[18].gameObject.SetActive(false);
        inside_34.inside_Line_34[19].gameObject.SetActive(false);
        inside_34.inside_Line_34[20].gameObject.SetActive(false);
        inside_34.inside_Line_34[21].gameObject.SetActive(false);
        inside_34.inside_Line_34[22].gameObject.SetActive(false);
        inside_34.inside_Line_34[23].gameObject.SetActive(false);
        inside_34.inside_Line_34[24].gameObject.SetActive(false);
        inside_34.inside_Line_34[25].gameObject.SetActive(false);
        inside_34.inside_Line_34[26].gameObject.SetActive(false);
        inside_34.inside_Line_34[27].gameObject.SetActive(false);
        inside_34.inside_Line_34[28].gameObject.SetActive(false);
        inside_34.inside_Line_34[29].gameObject.SetActive(false);
        inside_34.inside_Line_34[30].gameObject.SetActive(false);
        inside_34.inside_Line_34[31].gameObject.SetActive(false);
        inside_34.inside_Line_34[32].gameObject.SetActive(false);
        inside_34.inside_Line_34[33].gameObject.SetActive(false);
        inside_34.inside_Line_34[34].gameObject.SetActive(false);
        inside_34.inside_Line_34[35].gameObject.SetActive(false);
        inside_34.inside_Line_34[36].gameObject.SetActive(false);
        inside_34.inside_Line_34[37].gameObject.SetActive(false);
        inside_34.inside_Line_34[38].gameObject.SetActive(false);
        inside_34.inside_Line_34[39].gameObject.SetActive(false);
        inside_34.inside_Line_34[40].gameObject.SetActive(false);
        inside_34.inside_Line_34[41].gameObject.SetActive(false);
        inside_34.inside_Line_34[42].gameObject.SetActive(false);
        inside_34.inside_Line_34[43].gameObject.SetActive(false);
        inside_34.inside_Line_34[44].gameObject.SetActive(false);
        inside_34.inside_Line_34[45].gameObject.SetActive(false);
        inside_34.inside_Line_34[46].gameObject.SetActive(false);
        inside_34.inside_Line_34[47].gameObject.SetActive(false);
        inside_34.inside_Line_34[48].gameObject.SetActive(false);
        inside_34.inside_Line_34[49].gameObject.SetActive(false);
        inside_34.inside_Line_34[50].gameObject.SetActive(false);
        inside_34.inside_Line_34[51].gameObject.SetActive(false);
        inside_34.inside_Line_34[52].gameObject.SetActive(false);
        inside_34.inside_Line_34[53].gameObject.SetActive(false);
        inside_34.inside_Line_34[54].gameObject.SetActive(false);
        inside_34.inside_Line_34[55].gameObject.SetActive(false);
        inside_34.inside_Line_34[56].gameObject.SetActive(false);
        inside_34.inside_Line_34[57].gameObject.SetActive(false);
        inside_34.inside_Line_34[58].gameObject.SetActive(false);
        inside_34.inside_Line_34[59].gameObject.SetActive(false);
        inside_34.inside_Line_34[60].gameObject.SetActive(false);
        inside_34.inside_Line_34[61].gameObject.SetActive(false);
        inside_34.inside_Line_34[62].gameObject.SetActive(false);
        inside_34.inside_Line_34[63].gameObject.SetActive(false);
        inside_34.inside_Line_34[64].gameObject.SetActive(false);
        inside_34.inside_Line_34[65].gameObject.SetActive(false);
        inside_34.inside_Line_34[66].gameObject.SetActive(false);
        inside_34.inside_Line_34[67].gameObject.SetActive(false);
        inside_34.inside_Line_34[68].gameObject.SetActive(false);
        inside_34.inside_Line_34[69].gameObject.SetActive(false);
        inside_34.inside_Line_34[70].gameObject.SetActive(false);


        /*QuestObject.Line_Index = 65;

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
        TextContainer1.offsetMin = new Vector2(0, -9661.145f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39660.55f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()//134-속마음
    {
        yield return new WaitForSeconds(3.0f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_65_Index = 1;
        inside_Line_65[1].gameObject.SetActive(true);
        inside_Line_65[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_3()//135-속마음
    {

        yield return new WaitForSeconds(5.5f);
        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        Line_65_Index = 2;
        inside_Line_65[2].gameObject.SetActive(true);
        inside_Line_65[1].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_4()//136-1
    {
        yield return new WaitForSeconds(8.5f);
        //Line_4.SetActive(true);
        //Line_3.SetActive(false);

        Line_65_Index = 3;
        inside_Line_65[3].gameObject.SetActive(true);
        inside_Line_65[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9380.008f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39941.68f);    //(오, 위)


    }

    IEnumerator WaitSecond_5()//136-2
    {
        yield return new WaitForSeconds(10.0f);
        //Line_5.SetActive(true);

        Line_65_Index = 4;
        inside_Line_65[4].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9159.303f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40162.39f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//137-속마음
    {

        yield return new WaitForSeconds(12.0f);
        //Line_6.SetActive(true);

        Line_65_Index = 5;
        inside_Line_65[5].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_7()//138-속마음
    {
        yield return new WaitForSeconds(14.5f);
        //Line_7.SetActive(true);
        //Line_6.SetActive(false);

        Line_65_Index = 6;
        inside_Line_65[6].gameObject.SetActive(true);
        inside_Line_65[5].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_8()//139-1
    {
        yield return new WaitForSeconds(16.5f);
        //Line_8.SetActive(true);
        //Line_7.SetActive(false);

        Line_65_Index = 7;
        inside_Line_65[7].gameObject.SetActive(true);
        inside_Line_65[6].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8870.332f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40451.37f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()//139-2
    {
        yield return new WaitForSeconds(18.0f);
        //Line_9.SetActive(true);

        Line_65_Index = 8;
        inside_Line_65[8].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8720.558f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40601.13f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//140
    {
        yield return new WaitForSeconds(19.5f);
        //Line_10.SetActive(true);

        Line_65_Index = 9;
        inside_Line_65[9].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8505.107f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40816.59f);    //(오, 위)

    }

    IEnumerator WaitSecond_11()//141-1
    {
        yield return new WaitForSeconds(21.0f);
        //Line_11.SetActive(true);

        Line_65_Index = 10;
        inside_Line_65[10].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8185.068f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41126.63f);    //(오, 위)

    }

    IEnumerator WaitSecond_12()//141-2
    {
        yield return new WaitForSeconds(22.5f);
        //Line_12.SetActive(true);

        Line_65_Index = 11;
        inside_Line_65[11].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8045.928f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41275.77f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//142-속마음
    {
        yield return new WaitForSeconds(24.5f);
        //Line_13.SetActive(true);

        Line_65_Index = 12;
        inside_Line_65[12].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_14()//143-속마음
    {
        yield return new WaitForSeconds(26.5f);
        //Line_14.SetActive(true);
        //Line_13.SetActive(false);
        Line_65_Index = 13;
        inside_Line_65[13].gameObject.SetActive(true);
        inside_Line_65[12].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_15()//144
    {
        yield return new WaitForSeconds(29.5f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_65_Index = 14;
        inside_Line_65[14].gameObject.SetActive(true);
        inside_Line_65[13].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7757.188f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41564.5f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()//145-1
    {
        yield return new WaitForSeconds(31.0f);
        //Line_16.SetActive(true);

        Line_65_Index = 15;
        inside_Line_65[15].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7466.145f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41855.55f);    //(오, -위)

    }

    IEnumerator WaitSecond_17()//145-2
    {
        yield return new WaitForSeconds(32.5f);
        //Line_17.SetActive(true);

        Line_65_Index = 16;
        inside_Line_65[16].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7316.381f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42005.31f);    //(오, 위)


    }

    IEnumerator WaitSecond_18()//145-3
    {
        yield return new WaitForSeconds(34.0f);
        //Line_18.SetActive(true);

        Line_65_Index = 17;
        inside_Line_65[17].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7100.93f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42220.76f);    //(오, 위)

    }

    IEnumerator WaitSecond_19()//146하기 전 맨 위로 배치
    {
        yield return new WaitForSeconds(35.5f);


        TextContainer1.offsetMin = new Vector2(0, -5643.82f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43677.87f);    //(오, -위)
    }

    IEnumerator WaitSecond_20()//146
    {
        yield return new WaitForSeconds(37.5f);
        //Line_19.SetActive(true);
        Line_65_Index = 18;
        inside_Line_65[18].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -5643.82f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43677.87f);    //(오, -위)
    }

    IEnumerator WaitSecond_21()//147
    {
        yield return new WaitForSeconds(39.0f);

        //Line_20.SetActive(true);

        Line_65_Index = 19;
        inside_Line_65[19].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5643.82f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43677.87f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//148
    {
        yield return new WaitForSeconds(40.5f);
        //Line_21.SetActive(true);

        Line_65_Index = 20;
        inside_Line_65[20].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5643.82f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43677.87f);    //(오, -위)

    }

    IEnumerator WaitSecond_23()//149
    {
        yield return new WaitForSeconds(42.0f);
        //Line_22.SetActive(true);
        sfx5.Play();
        Line_65_Index = 21;
        inside_Line_65[21].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5643.82f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43677.87f);    //(오, -위)
    }

    IEnumerator WaitSecond_24()//150
    {
        yield return new WaitForSeconds(43.5f);

        //Line_23.SetActive(true);

        Line_65_Index = 22;
        inside_Line_65[22].gameObject.SetActive(true);
        //inside_Line_65[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5296.998f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44024.7f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//151-속마음
    {
        yield return new WaitForSeconds(45.5f);
        //Line_24.SetActive(true);

        Line_65_Index = 23;
        inside_Line_65[23].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_26()//152-속마음
    {
        yield return new WaitForSeconds(48.5f);

        //Line_25.SetActive(true);
        //Line_24.SetActive(false);

        Line_65_Index = 24;
        inside_Line_65[24].gameObject.SetActive(true);
        inside_Line_65[23].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_27()//153
    {
        yield return new WaitForSeconds(50.5f);
        //Line_26.SetActive(true);
        //Line_25.SetActive(false);

        Line_65_Index = 25;
        inside_Line_65[25].gameObject.SetActive(true);
        inside_Line_65[24].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -5008.373f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44313.32f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//154
    {
        yield return new WaitForSeconds(52.0f);
        //Line_27.SetActive(true);

        Line_65_Index = 26;
        inside_Line_65[26].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4716.727f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44604.96f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//155
    {
        yield return new WaitForSeconds(53.5f);
        //Line_28.SetActive(true);

        Line_65_Index = 27;
        inside_Line_65[27].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4432.961f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44888.73f);    //(오, -위)
    }

    IEnumerator WaitSecond_30()//156되기 전에 맨 위로 올리기
    {
        yield return new WaitForSeconds(55.0f);

        TextContainer1.offsetMin = new Vector2(0, -2976.686f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46345.01f);    //(오, -위)

    }

    IEnumerator WaitSecond_31()//156
    {
        yield return new WaitForSeconds(57.0f);
        //Line_29.SetActive(true);

        Line_65_Index = 28;
        inside_Line_65[28].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2976.686f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46345.01f);    //(오, -위)

    }

    IEnumerator WaitSecond_32()//157
    {
        yield return new WaitForSeconds(58.5f);
        //Line_30.SetActive(true);

        Line_65_Index = 29;
        inside_Line_65[29].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2976.686f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46345.01f);    //(오, -위)

    }

    IEnumerator WaitSecond_33()//158-속마음
    {
        yield return new WaitForSeconds(60.5f);
        //Line_31.SetActive(true);
        Line_65_Index = 30;
        inside_Line_65[30].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);




    }

    IEnumerator WaitSecond_34()//159-속마음
    {
        yield return new WaitForSeconds(63.0f);
        // Line_32.SetActive(true);
        // Line_31.SetActive(false);

        Line_65_Index = 31;
        inside_Line_65[31].gameObject.SetActive(true);
        inside_Line_65[30].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_35()//160-속마음
    {

        yield return new WaitForSeconds(66.0f);
        //Line_33.SetActive(true);
        //Line_32.SetActive(false);

        Line_65_Index = 32;
        inside_Line_65[32].gameObject.SetActive(true);
        inside_Line_65[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_36()//161
    {

        yield return new WaitForSeconds(69.5f);
        //Line_34.SetActive(true);
        //Line_33.SetActive(false);

        Line_65_Index = 33;
        inside_Line_65[33].gameObject.SetActive(true);
        inside_Line_65[32].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2976.686f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46345.01f);    //(오, -위)


    }

    IEnumerator WaitSecond_37()//162

    {
        yield return new WaitForSeconds(71.0f);
        //Line_35.SetActive(true);

        Line_65_Index = 34;
        inside_Line_65[34].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2976.686f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46345.01f);    //(오, -위)


    }

    IEnumerator WaitSecond_38()//163
    {
        yield return new WaitForSeconds(72.5f);
        //Line_36.SetActive(true);

        Line_65_Index = 35;
        inside_Line_65[35].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2976.686f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46345.01f);    //(오, -위)


    }

    IEnumerator WaitSecond_39()//164
    {
        yield return new WaitForSeconds(74.0f);

        //Line_37.SetActive(true);

        Line_65_Index = 36;
        inside_Line_65[36].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2713.941f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46607.75f);    //(오, -위)


    }

    IEnumerator WaitSecond_40()//165
    {
        yield return new WaitForSeconds(75.5f);
        //Line_38.SetActive(true);

        Line_65_Index = 37;
        inside_Line_65[37].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2516.883f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46804.81f);    //(오, -위)

    }


    IEnumerator WaitSecond_41()//166-1
    {
        yield return new WaitForSeconds(77.0f);
        //Line_39.SetActive(true);

        Line_65_Index = 38;
        inside_Line_65[38].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2203.938f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47117.75f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//166-2
    {
        yield return new WaitForSeconds(78.5f);
        //Line_40.SetActive(true);

        Line_65_Index = 39;
        inside_Line_65[39].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2046.291f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47275.4f);    //(오, -위)

    }

    IEnumerator WaitSecond_43()//167-1//여기부터 해야 함
    {
        yield return new WaitForSeconds(80.0f);
        //Line_41.SetActive(true);

        Line_65_Index = 40;
        inside_Line_65[40].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1757.271f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47564.42f);    //(오, -위)

    }

    IEnumerator WaitSecond_44()//167-2
    {
        yield return new WaitForSeconds(81.5f);
        //Line_42.SetActive(true);

        Line_65_Index = 41;
        inside_Line_65[41].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1604.879f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47716.81f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//168-속마음
    {
        yield return new WaitForSeconds(83.5f);
        //Line_43.SetActive(true);

        Line_65_Index = 42;
        inside_Line_65[42].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_46()//169-1
    {
        yield return new WaitForSeconds(85.5f);
        //Line_44.SetActive(true);
        //Line_43.SetActive(false);

        Line_65_Index = 43;
        inside_Line_65[43].gameObject.SetActive(true);
        inside_Line_65[42].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1321.115f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48000.58f);    //(오, -위)



    }

    IEnumerator WaitSecond_47()//169-2
    {
        yield return new WaitForSeconds(87.0f);
        //Line_45.SetActive(true);

        Line_65_Index = 44;
        inside_Line_65[44].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1171.961f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48149.73f);    //(오, -위)

    }

    IEnumerator WaitSecond_48()//170-1
    {
        yield return new WaitForSeconds(88.5f);
        //Line_46.SetActive(true);

        Line_65_Index = 45;
        inside_Line_65[45].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -882.9414f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48438.75f);    //(오, -위)

    }

    IEnumerator WaitSecond_49()//170-2
    {
        yield return new WaitForSeconds(90.0f);
        //Line_47.SetActive(true);

        Line_65_Index = 46;
        inside_Line_65[46].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -725.6484f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48596.04f);    //(오, -위)

    }

    IEnumerator WaitSecond_50()//171
    {
        yield return new WaitForSeconds(91.5f);
        //Line_48.SetActive(true);

        Line_65_Index = 47;
        inside_Line_65[47].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -434.002f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48887.69f);    //(오, -위)

    }

    IEnumerator WaitSecond_51()//172-속마음
    {
        yield return new WaitForSeconds(93.5f);
        //Line_49.SetActive(true);

        Line_65_Index = 48;
        inside_Line_65[48].gameObject.SetActive(true);
        //inside_Line_65[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_52()//173-속마음
    {
        yield return new WaitForSeconds(95.5f);
        //Line_50.SetActive(true);
        //Line_49.SetActive(false);

        Line_65_Index = 49;
        inside_Line_65[49].gameObject.SetActive(true);
        inside_Line_65[48].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_53()//174-속마음
    {
        yield return new WaitForSeconds(98.5f);
        //Line_51.SetActive(true);
        //Line_50.SetActive(false);

        Line_65_Index = 50;
        inside_Line_65[50].gameObject.SetActive(true);
        inside_Line_65[49].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_54()//175-선택지
    {
        yield return new WaitForSeconds(102.5f);
        //Line_52.SetActive(true);
        //Line_51.SetActive(false);

        inside_113.Line_1_6_35_Index = 0;

        inside_113.inside_1_6_35[0].gameObject.SetActive(false);
        inside_113.inside_1_6_35[1].gameObject.SetActive(false);
        inside_113.inside_1_6_35[2].gameObject.SetActive(false);
        inside_113.inside_1_6_35[3].gameObject.SetActive(false);
        inside_113.inside_1_6_35[4].gameObject.SetActive(false);
        inside_113.inside_1_6_35[5].gameObject.SetActive(false);
        inside_113.inside_1_6_35[6].gameObject.SetActive(false);
        inside_113.inside_1_6_35[7].gameObject.SetActive(false);
        inside_113.inside_1_6_35[8].gameObject.SetActive(false);
        inside_113.inside_1_6_35[9].gameObject.SetActive(false);
        inside_113.inside_1_6_35[10].gameObject.SetActive(false);
        inside_113.inside_1_6_35[11].gameObject.SetActive(false);
        inside_113.inside_1_6_35[12].gameObject.SetActive(false);
        inside_113.inside_1_6_35[13].gameObject.SetActive(false);
        inside_113.inside_1_6_35[14].gameObject.SetActive(false);
        inside_113.inside_1_6_35[15].gameObject.SetActive(false);
        inside_113.inside_1_6_35[16].gameObject.SetActive(false);
        inside_113.inside_1_6_35[17].gameObject.SetActive(false);
        inside_113.inside_1_6_35[18].gameObject.SetActive(false);
        inside_113.inside_1_6_35[19].gameObject.SetActive(false);
        inside_113.inside_1_6_35[20].gameObject.SetActive(false);
        inside_113.inside_1_6_35[21].gameObject.SetActive(false);
        inside_113.inside_1_6_35[22].gameObject.SetActive(false);
        inside_113.inside_1_6_35[23].gameObject.SetActive(false);
        inside_113.inside_1_6_35[24].gameObject.SetActive(false);
        inside_113.inside_1_6_35[25].gameObject.SetActive(false);
        inside_113.inside_1_6_35[26].gameObject.SetActive(false);
        inside_113.inside_1_6_35[27].gameObject.SetActive(false);
        inside_113.inside_1_6_35[28].gameObject.SetActive(false);
        inside_113.inside_1_6_35[29].gameObject.SetActive(false);
        inside_113.inside_1_6_35[30].gameObject.SetActive(false);
        inside_113.inside_1_6_35[31].gameObject.SetActive(false);
        inside_113.inside_1_6_35[32].gameObject.SetActive(false);
        inside_113.inside_1_6_35[33].gameObject.SetActive(false);
        inside_113.inside_1_6_35[34].gameObject.SetActive(false);
        inside_113.inside_1_6_35[35].gameObject.SetActive(false);
        inside_113.inside_1_6_35[36].gameObject.SetActive(false);
        inside_113.inside_1_6_35[37].gameObject.SetActive(false);
        inside_113.inside_1_6_35[38].gameObject.SetActive(false);
        inside_113.inside_1_6_35[39].gameObject.SetActive(false);
        inside_113.inside_1_6_35[40].gameObject.SetActive(false);
        inside_113.inside_1_6_35[41].gameObject.SetActive(false);
        inside_113.inside_1_6_35[42].gameObject.SetActive(false);
        inside_113.inside_1_6_35[43].gameObject.SetActive(false);
        inside_113.inside_1_6_35[44].gameObject.SetActive(false);
        inside_113.inside_1_6_35[45].gameObject.SetActive(false);
        inside_113.inside_1_6_35[46].gameObject.SetActive(false);
        inside_113.inside_1_6_35[47].gameObject.SetActive(false);
        inside_113.inside_1_6_35[48].gameObject.SetActive(false);
        inside_113.inside_1_6_35[49].gameObject.SetActive(false);
        inside_113.inside_1_6_35[50].gameObject.SetActive(false);
        inside_113.inside_1_6_35[51].gameObject.SetActive(false);
        inside_113.inside_1_6_35[52].gameObject.SetActive(false);
        inside_113.inside_1_6_35[53].gameObject.SetActive(false);
        inside_113.inside_1_6_35[54].gameObject.SetActive(false);
        inside_113.inside_1_6_35[55].gameObject.SetActive(false);
        inside_113.inside_1_6_35[56].gameObject.SetActive(false);
        inside_113.inside_1_6_35[57].gameObject.SetActive(false);
        inside_113.inside_1_6_35[58].gameObject.SetActive(false);
        inside_113.inside_1_6_35[59].gameObject.SetActive(false);
        inside_113.inside_1_6_35[60].gameObject.SetActive(false);
        inside_113.inside_1_6_35[61].gameObject.SetActive(false);
        inside_113.inside_1_6_35[62].gameObject.SetActive(false);
        inside_113.inside_1_6_35[63].gameObject.SetActive(false);
        inside_113.inside_1_6_35[64].gameObject.SetActive(false);
        inside_113.inside_1_6_35[65].gameObject.SetActive(false);
        inside_113.inside_1_6_35[66].gameObject.SetActive(false);
        inside_113.inside_1_6_35[67].gameObject.SetActive(false);

        Line_65_Index = 51;
        inside_Line_65[51].gameObject.SetActive(true);
        inside_Line_65[50].gameObject.SetActive(false);

        inside_117.Line_1_6_36_Index = 0;

        inside_117.inside_1_6_36[0].gameObject.SetActive(false);
        inside_117.inside_1_6_36[1].gameObject.SetActive(false);
        inside_117.inside_1_6_36[2].gameObject.SetActive(false);
        inside_117.inside_1_6_36[3].gameObject.SetActive(false);
        inside_117.inside_1_6_36[4].gameObject.SetActive(false);
        inside_117.inside_1_6_36[5].gameObject.SetActive(false);
        inside_117.inside_1_6_36[6].gameObject.SetActive(false);
        inside_117.inside_1_6_36[7].gameObject.SetActive(false);
        inside_117.inside_1_6_36[8].gameObject.SetActive(false);
        inside_117.inside_1_6_36[9].gameObject.SetActive(false);
        inside_117.inside_1_6_36[10].gameObject.SetActive(false);
        inside_117.inside_1_6_36[11].gameObject.SetActive(false);
        inside_117.inside_1_6_36[12].gameObject.SetActive(false);
        inside_117.inside_1_6_36[13].gameObject.SetActive(false);
        inside_117.inside_1_6_36[14].gameObject.SetActive(false);
        inside_117.inside_1_6_36[15].gameObject.SetActive(false);
        inside_117.inside_1_6_36[16].gameObject.SetActive(false);
        inside_117.inside_1_6_36[17].gameObject.SetActive(false);
        inside_117.inside_1_6_36[18].gameObject.SetActive(false);
        inside_117.inside_1_6_36[19].gameObject.SetActive(false);
        inside_117.inside_1_6_36[20].gameObject.SetActive(false);
        inside_117.inside_1_6_36[21].gameObject.SetActive(false);
        inside_117.inside_1_6_36[22].gameObject.SetActive(false);
        inside_117.inside_1_6_36[23].gameObject.SetActive(false);
        inside_117.inside_1_6_36[24].gameObject.SetActive(false);
        inside_117.inside_1_6_36[25].gameObject.SetActive(false);
        inside_117.inside_1_6_36[26].gameObject.SetActive(false);
        inside_117.inside_1_6_36[27].gameObject.SetActive(false);
        inside_117.inside_1_6_36[28].gameObject.SetActive(false);
        inside_117.inside_1_6_36[29].gameObject.SetActive(false);
        inside_117.inside_1_6_36[30].gameObject.SetActive(false);
        inside_117.inside_1_6_36[31].gameObject.SetActive(false);
        inside_117.inside_1_6_36[32].gameObject.SetActive(false);
        inside_117.inside_1_6_36[33].gameObject.SetActive(false);
        inside_117.inside_1_6_36[34].gameObject.SetActive(false);
        inside_117.inside_1_6_36[35].gameObject.SetActive(false);
        inside_117.inside_1_6_36[36].gameObject.SetActive(false);
        inside_117.inside_1_6_36[37].gameObject.SetActive(false);
        inside_117.inside_1_6_36[38].gameObject.SetActive(false);
        inside_117.inside_1_6_36[39].gameObject.SetActive(false);
        inside_117.inside_1_6_36[40].gameObject.SetActive(false);
        inside_117.inside_1_6_36[41].gameObject.SetActive(false);
        inside_117.inside_1_6_36[42].gameObject.SetActive(false);
        inside_117.inside_1_6_36[43].gameObject.SetActive(false);
        inside_117.inside_1_6_36[44].gameObject.SetActive(false);
        inside_117.inside_1_6_36[45].gameObject.SetActive(false);
        inside_117.inside_1_6_36[46].gameObject.SetActive(false);
        inside_117.inside_1_6_36[47].gameObject.SetActive(false);
        inside_117.inside_1_6_36[48].gameObject.SetActive(false);
        inside_117.inside_1_6_36[49].gameObject.SetActive(false);
        inside_117.inside_1_6_36[50].gameObject.SetActive(false);
        inside_117.inside_1_6_36[51].gameObject.SetActive(false);
        inside_117.inside_1_6_36[52].gameObject.SetActive(false);
        inside_117.inside_1_6_36[53].gameObject.SetActive(false);
        inside_117.inside_1_6_36[54].gameObject.SetActive(false);
        inside_117.inside_1_6_36[55].gameObject.SetActive(false);
        inside_117.inside_1_6_36[56].gameObject.SetActive(false);
        inside_117.inside_1_6_36[57].gameObject.SetActive(false);
        inside_117.inside_1_6_36[58].gameObject.SetActive(false);
        inside_117.inside_1_6_36[59].gameObject.SetActive(false);
        inside_117.inside_1_6_36[60].gameObject.SetActive(false);
        inside_117.inside_1_6_36[61].gameObject.SetActive(false);
        inside_117.inside_1_6_36[62].gameObject.SetActive(false);
        inside_117.inside_1_6_36[63].gameObject.SetActive(false);
        inside_117.inside_1_6_36[64].gameObject.SetActive(false);
        inside_117.inside_1_6_36[65].gameObject.SetActive(false);
        inside_117.inside_1_6_36[66].gameObject.SetActive(false);
        inside_117.inside_1_6_36[67].gameObject.SetActive(false);
        inside_117.inside_1_6_36[68].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.03125f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49321.72f);    //(오, -위)

    }



}
