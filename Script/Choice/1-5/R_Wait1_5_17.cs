using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class R_Wait1_5_17 : MonoBehaviour
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

    public GameObject[] inside_Line_49;
    public int Line_49_Index;

    public R_Wait1_4_9 inside_34;

    public R_Wait1_6_33 inside_105;
    public R_Wait1_6_34 inside_109;


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

        Line_49_Index = 0;
        inside_Line_49[0].gameObject.SetActive(true);
        //inside_Line_49[1].gameObject.SetActive(false);

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

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

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

        /*QuestObject.Line_Index = 49;

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

        TextContainer1.offsetMin = new Vector2(0, -9395.39f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39671.07f);    //(오, 위)

        

    }

    IEnumerator WaitSecond_2()//134-속마음
    {
        yield return new WaitForSeconds(2.5f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);

        

        Line_49_Index = 1;
        inside_Line_49[1].gameObject.SetActive(true);
        inside_Line_49[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_3()//135-1
    {

        yield return new WaitForSeconds(5.0f);
        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_49_Index = 2;
        inside_Line_49[2].gameObject.SetActive(true);
        inside_Line_49[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9102.651f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39963.81f);    //(오, 위)


    }

    IEnumerator WaitSecond_4()//135-2
    {
        yield return new WaitForSeconds(6.5f);
        //Line_4.SetActive(true);

        Line_49_Index = 3;
        inside_Line_49[3].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8954.916f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40111.55f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()//136-1
    {
        yield return new WaitForSeconds(8.0f);
        //Line_5.SetActive(true);

        Line_49_Index = 4;
        inside_Line_49[4].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8670.596f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40395.87f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//136-2
    {
        yield return new WaitForSeconds(9.5f);
        //Line_6.SetActive(true);

        Line_49_Index = 5;
        inside_Line_49[5].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8511.711f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40554.75f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()//137
    {
        yield return new WaitForSeconds(11.0f);
        //Line_7.SetActive(true);

        Line_49_Index = 6;
        inside_Line_49[6].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8227.391f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40839.07f);    //(오, 위)

    }

    IEnumerator WaitSecond_8()//138
    {
        yield return new WaitForSeconds(12.5f);
        //Line_8.SetActive(true);

        Line_49_Index = 7;
        inside_Line_49[7].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8020.855f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41045.61f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()//139
    {
        yield return new WaitForSeconds(14.0f);
        //Line_9.SetActive(true);

        Line_49_Index = 8;
        inside_Line_49[8].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7717.258f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41349.2f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//140-속마음
    {
        yield return new WaitForSeconds(16.0f);
        //Line_10.SetActive(true);

        Line_49_Index = 9;
        inside_Line_49[9].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_11()//141-속마음
    {
        yield return new WaitForSeconds(18.5f);
        //Line_11.SetActive(true);
        //Line_10.SetActive(false);

        Line_49_Index = 10;
        inside_Line_49[10].gameObject.SetActive(true);
        inside_Line_49[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_12()//142
    {
        yield return new WaitForSeconds(22.0f);
        //Line_12.SetActive(true);
        //Line_11.SetActive(false);

        Line_49_Index = 11;
        inside_Line_49[11].gameObject.SetActive(true);
        inside_Line_49[10].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7366.039f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41700.42f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//143
    {
        yield return new WaitForSeconds(23.5f);
        //Line_13.SetActive(true);

        Line_49_Index = 12;
        inside_Line_49[12].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7078.932f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41987.53f);    //(오, -위)

    }

    IEnumerator WaitSecond_14()//144-속마음
    {
        yield return new WaitForSeconds(25.5f);
        //Line_14.SetActive(true);

        Line_49_Index = 13;
        inside_Line_49[13].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_15()//145-속마음
    {
        yield return new WaitForSeconds(29.0f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_49_Index = 14;
        inside_Line_49[14].gameObject.SetActive(true);
        inside_Line_49[13].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_16()//146하기 전 맨 위로 배치
    {
        yield return new WaitForSeconds(31.5f);
        //Line_15.SetActive(false);

        Line_49_Index = 14;
        //inside_Line_49[1].gameObject.SetActive(true);
        inside_Line_49[14].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -5616.115f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43450.34f);    //(오, -위)
    }

    IEnumerator WaitSecond_17()//146
    {
        yield return new WaitForSeconds(33.0f);
        //Line_16.SetActive(true);

        Line_49_Index = 15;
        inside_Line_49[15].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5616.115f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43450.34f);    //(오, -위)
    }

    IEnumerator WaitSecond_18()//147
    {
        yield return new WaitForSeconds(34.5f);

        //Line_17.SetActive(true);

        Line_49_Index = 16;
        inside_Line_49[16].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5616.115f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43450.34f);    //(오, -위)

    }

    IEnumerator WaitSecond_19()//148
    {
        yield return new WaitForSeconds(36.0f);
        //Line_18.SetActive(true);

        Line_49_Index = 17;
        inside_Line_49[17].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5616.115f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43450.34f);    //(오, -위)

    }

    IEnumerator WaitSecond_20()//149
    {
        yield return new WaitForSeconds(37.5f);
        //Line_19.SetActive(true);
        sfx5.Play();
        Line_49_Index = 18;
        inside_Line_49[18].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5616.115f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43450.34f);    //(오, -위)
    }

    IEnumerator WaitSecond_21()//150
    {
        yield return new WaitForSeconds(39.0f);

        //Line_20.SetActive(true);

        Line_49_Index = 19;
        inside_Line_49[19].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5278.832f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43787.63f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//151-속마음
    {
        yield return new WaitForSeconds(41.0f);
        //Line_21.SetActive(true);

        Line_49_Index = 20;
        inside_Line_49[20].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_23()//152-속마음
    {
        yield return new WaitForSeconds(44.0f);

        //Line_22.SetActive(true);
        //Line_21.SetActive(false);

        Line_49_Index = 21;
        inside_Line_49[21].gameObject.SetActive(true);
        inside_Line_49[20].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_24()//153
    {
        yield return new WaitForSeconds(46.0f);
        //Line_23.SetActive(true);
        //Line_22.SetActive(false);

        Line_49_Index = 22;
        inside_Line_49[22].gameObject.SetActive(true);
        inside_Line_49[21].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -4991.441f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44075.02f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//154
    {
        yield return new WaitForSeconds(47.5f);
        //Line_24.SetActive(true);

        Line_49_Index = 23;
        inside_Line_49[23].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4706.502f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44359.96f);    //(오, -위)

    }

    IEnumerator WaitSecond_26()//155
    {
        yield return new WaitForSeconds(49.0f);
        //Line_25.SetActive(true);

        Line_49_Index = 24;
        inside_Line_49[24].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4416.607f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44649.85f);    //(오, -위)
    }

    IEnumerator WaitSecond_27()//156되기 전에 맨 위로 올리기
    {
        yield return new WaitForSeconds(50.5f);

        TextContainer1.offsetMin = new Vector2(0, -2958.73f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46107.73f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//156
    {
        yield return new WaitForSeconds(52.5f);
        //Line_26.SetActive(true);

        Line_49_Index = 25;
        inside_Line_49[25].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2958.73f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46107.73f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//157
    {
        yield return new WaitForSeconds(54.0f);
        //Line_27.SetActive(true);

        Line_49_Index = 26;
        inside_Line_49[26].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -2958.73f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46107.73f);    //(오, -위)

    }

    IEnumerator WaitSecond_30()//158-속마음
    {
        yield return new WaitForSeconds(56.0f);
        //Line_28.SetActive(true);

        Line_49_Index = 27;
        inside_Line_49[27].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_31()//159-속마음
    {
        yield return new WaitForSeconds(59.0f);
        //Line_29.SetActive(true);
        //Line_28.SetActive(false);

        Line_49_Index = 28;
        inside_Line_49[28].gameObject.SetActive(true);
        inside_Line_49[27].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_32()//160-속마음
    {

        yield return new WaitForSeconds(62.5f);
        //Line_30.SetActive(true);
        //Line_29.SetActive(false);

        Line_49_Index = 29;
        inside_Line_49[29].gameObject.SetActive(true);
        inside_Line_49[28].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_33()//161
    {

        yield return new WaitForSeconds(66.5f);
        //Line_31.SetActive(true);
        //Line_30.SetActive(false);

        Line_49_Index = 30;
        inside_Line_49[30].gameObject.SetActive(true);
        inside_Line_49[29].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2958.73f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46107.73f);    //(오, -위)


    }

    IEnumerator WaitSecond_34()//162

    {
        yield return new WaitForSeconds(68.0f);
        //Line_32.SetActive(true);

        Line_49_Index = 31;
        inside_Line_49[31].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2958.73f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46107.73f);    //(오, -위)



    }

    IEnumerator WaitSecond_35()//163
    {
        yield return new WaitForSeconds(69.5f);
        //Line_33.SetActive(true);

        Line_49_Index = 32;
        inside_Line_49[32].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2958.73f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46107.73f);    //(오, -위)


    }

    IEnumerator WaitSecond_36()//164
    {
        yield return new WaitForSeconds(71.0f);

        //Line_34.SetActive(true);

        Line_49_Index = 33;
        inside_Line_49[33].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2696.281f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46370.18f);    //(오, -위)


    }

    IEnumerator WaitSecond_37()//165
    {
        yield return new WaitForSeconds(72.5f);
        //Line_35.SetActive(true);

        Line_49_Index = 34;
        inside_Line_49[34].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2501.16f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46565.3f);    //(오, -위)

    }


    IEnumerator WaitSecond_38()//166-1
    {
        yield return new WaitForSeconds(74.0f);
        //Line_36.SetActive(true);

        Line_49_Index = 35;
        inside_Line_49[35].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2183.391f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46883.07f);    //(오, -위)

    }

    IEnumerator WaitSecond_39()//166-2
    {
        yield return new WaitForSeconds(75.5f);
        //Line_37.SetActive(true);

        Line_49_Index = 36;
        inside_Line_49[36].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2027.293f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47039.17f);    //(오, -위)

    }

    IEnumerator WaitSecond_40()//167-1
    {
        yield return new WaitForSeconds(77.0f);
        //Line_38.SetActive(true);

        Line_49_Index = 37;
        inside_Line_49[37].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1745.111f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47321.35f);    //(오, -위)

    }

    IEnumerator WaitSecond_41()//167-2
    {
        yield return new WaitForSeconds(78.5f);
        //Line_39.SetActive(true);

        Line_49_Index = 38;
        inside_Line_49[38].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1583.439f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47483.02f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//168-속마음
    {
        yield return new WaitForSeconds(80.5f);
        //Line_40.SetActive(true);

        Line_49_Index = 39;
        inside_Line_49[39].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_43()//169-1
    {
        yield return new WaitForSeconds(82.5f);
        //Line_41.SetActive(true);
        //Line_40.SetActive(false);

        Line_49_Index = 40;
        inside_Line_49[40].gameObject.SetActive(true);
        inside_Line_49[39].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1305.676f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47760.79f);    //(오, -위)



    }

    IEnumerator WaitSecond_44()//169-2
    {
        yield return new WaitForSeconds(84.0f);
        //Line_42.SetActive(true);

        Line_49_Index = 41;
        inside_Line_49[41].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1149.578f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47916.88f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//170-1
    {
        yield return new WaitForSeconds(85.5f);
        //Line_43.SetActive(true);

        Line_49_Index = 42;
        inside_Line_49[42].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -865.2578f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48201.2f);    //(오, -위)

    }

    IEnumerator WaitSecond_46()//170-2
    {
        yield return new WaitForSeconds(87.0f);
        //Line_44.SetActive(true);

        Line_49_Index = 43;
        inside_Line_49[43].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -709.1602f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48357.3f);    //(오, -위)

    }

    IEnumerator WaitSecond_47()//171
    {
        yield return new WaitForSeconds(88.5f);
        //Line_45.SetActive(true);

        Line_49_Index = 44;
        inside_Line_49[44].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -416.4766f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48649.98f);    //(오, -위)

    }

    IEnumerator WaitSecond_48()//172-속마음
    {
        yield return new WaitForSeconds(90.5f);
        //Line_46.SetActive(true);
        Line_49_Index = 45;
        inside_Line_49[45].gameObject.SetActive(true);
        //inside_Line_49[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_49()//173-속마음
    {
        yield return new WaitForSeconds(92.5f);
        //Line_47.SetActive(true);
        //Line_46.SetActive(false);

        Line_49_Index = 46;
        inside_Line_49[46].gameObject.SetActive(true);
        inside_Line_49[45].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_50()//174-속마음
    {
        yield return new WaitForSeconds(96.0f);
        //Line_48.SetActive(true);
        //Line_47.SetActive(false);

        Line_49_Index = 47;
        inside_Line_49[47].gameObject.SetActive(true);
        inside_Line_49[46].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_51()//175-선택지
    {
        yield return new WaitForSeconds(100.0f);
        //Line_49.SetActive(true);
        //Line_48.SetActive(false);

        inside_105.Line_1_6_33_Index = 0;

        inside_105.inside_1_6_33[0].gameObject.SetActive(false);
        inside_105.inside_1_6_33[1].gameObject.SetActive(false);
        inside_105.inside_1_6_33[2].gameObject.SetActive(false);
        inside_105.inside_1_6_33[3].gameObject.SetActive(false);
        inside_105.inside_1_6_33[4].gameObject.SetActive(false);
        inside_105.inside_1_6_33[5].gameObject.SetActive(false);
        inside_105.inside_1_6_33[6].gameObject.SetActive(false);
        inside_105.inside_1_6_33[7].gameObject.SetActive(false);
        inside_105.inside_1_6_33[8].gameObject.SetActive(false);
        inside_105.inside_1_6_33[9].gameObject.SetActive(false);
        inside_105.inside_1_6_33[10].gameObject.SetActive(false);
        inside_105.inside_1_6_33[11].gameObject.SetActive(false);
        inside_105.inside_1_6_33[12].gameObject.SetActive(false);
        inside_105.inside_1_6_33[13].gameObject.SetActive(false);
        inside_105.inside_1_6_33[14].gameObject.SetActive(false);
        inside_105.inside_1_6_33[15].gameObject.SetActive(false);
        inside_105.inside_1_6_33[16].gameObject.SetActive(false);
        inside_105.inside_1_6_33[17].gameObject.SetActive(false);
        inside_105.inside_1_6_33[18].gameObject.SetActive(false);
        inside_105.inside_1_6_33[19].gameObject.SetActive(false);
        inside_105.inside_1_6_33[20].gameObject.SetActive(false);
        inside_105.inside_1_6_33[21].gameObject.SetActive(false);
        inside_105.inside_1_6_33[22].gameObject.SetActive(false);
        inside_105.inside_1_6_33[23].gameObject.SetActive(false);
        inside_105.inside_1_6_33[24].gameObject.SetActive(false);
        inside_105.inside_1_6_33[25].gameObject.SetActive(false);
        inside_105.inside_1_6_33[26].gameObject.SetActive(false);
        inside_105.inside_1_6_33[27].gameObject.SetActive(false);
        inside_105.inside_1_6_33[28].gameObject.SetActive(false);
        inside_105.inside_1_6_33[29].gameObject.SetActive(false);
        inside_105.inside_1_6_33[30].gameObject.SetActive(false);
        inside_105.inside_1_6_33[31].gameObject.SetActive(false);
        inside_105.inside_1_6_33[32].gameObject.SetActive(false);
        inside_105.inside_1_6_33[33].gameObject.SetActive(false);
        inside_105.inside_1_6_33[34].gameObject.SetActive(false);
        inside_105.inside_1_6_33[35].gameObject.SetActive(false);
        inside_105.inside_1_6_33[36].gameObject.SetActive(false);
        inside_105.inside_1_6_33[37].gameObject.SetActive(false);
        inside_105.inside_1_6_33[38].gameObject.SetActive(false);
        inside_105.inside_1_6_33[39].gameObject.SetActive(false);
        inside_105.inside_1_6_33[40].gameObject.SetActive(false);
        inside_105.inside_1_6_33[41].gameObject.SetActive(false);
        inside_105.inside_1_6_33[42].gameObject.SetActive(false);
        inside_105.inside_1_6_33[43].gameObject.SetActive(false);
        inside_105.inside_1_6_33[44].gameObject.SetActive(false);
        inside_105.inside_1_6_33[45].gameObject.SetActive(false);
        inside_105.inside_1_6_33[46].gameObject.SetActive(false);
        inside_105.inside_1_6_33[47].gameObject.SetActive(false);
        inside_105.inside_1_6_33[48].gameObject.SetActive(false);
        inside_105.inside_1_6_33[49].gameObject.SetActive(false);
        inside_105.inside_1_6_33[50].gameObject.SetActive(false);
        inside_105.inside_1_6_33[51].gameObject.SetActive(false);
        inside_105.inside_1_6_33[52].gameObject.SetActive(false);
        inside_105.inside_1_6_33[53].gameObject.SetActive(false);
        inside_105.inside_1_6_33[54].gameObject.SetActive(false);
        inside_105.inside_1_6_33[55].gameObject.SetActive(false);
        inside_105.inside_1_6_33[56].gameObject.SetActive(false);
        inside_105.inside_1_6_33[57].gameObject.SetActive(false);
        inside_105.inside_1_6_33[58].gameObject.SetActive(false);
        inside_105.inside_1_6_33[59].gameObject.SetActive(false);
        inside_105.inside_1_6_33[60].gameObject.SetActive(false);
        inside_105.inside_1_6_33[61].gameObject.SetActive(false);
        inside_105.inside_1_6_33[62].gameObject.SetActive(false);
        inside_105.inside_1_6_33[63].gameObject.SetActive(false);
        inside_105.inside_1_6_33[64].gameObject.SetActive(false);
        inside_105.inside_1_6_33[65].gameObject.SetActive(false);
        inside_105.inside_1_6_33[66].gameObject.SetActive(false);
        inside_105.inside_1_6_33[67].gameObject.SetActive(false);

        Line_49_Index = 48;
        inside_Line_49[48].gameObject.SetActive(true);
        inside_Line_49[47].gameObject.SetActive(false);

        inside_109.Line_1_6_34_Index = 0;

        inside_109.inside_1_6_34[0].gameObject.SetActive(false);
        inside_109.inside_1_6_34[1].gameObject.SetActive(false);
        inside_109.inside_1_6_34[2].gameObject.SetActive(false);
        inside_109.inside_1_6_34[3].gameObject.SetActive(false);
        inside_109.inside_1_6_34[4].gameObject.SetActive(false);
        inside_109.inside_1_6_34[5].gameObject.SetActive(false);
        inside_109.inside_1_6_34[6].gameObject.SetActive(false);
        inside_109.inside_1_6_34[7].gameObject.SetActive(false);
        inside_109.inside_1_6_34[8].gameObject.SetActive(false);
        inside_109.inside_1_6_34[9].gameObject.SetActive(false);
        inside_109.inside_1_6_34[10].gameObject.SetActive(false);
        inside_109.inside_1_6_34[11].gameObject.SetActive(false);
        inside_109.inside_1_6_34[12].gameObject.SetActive(false);
        inside_109.inside_1_6_34[13].gameObject.SetActive(false);
        inside_109.inside_1_6_34[14].gameObject.SetActive(false);
        inside_109.inside_1_6_34[15].gameObject.SetActive(false);
        inside_109.inside_1_6_34[16].gameObject.SetActive(false);
        inside_109.inside_1_6_34[17].gameObject.SetActive(false);
        inside_109.inside_1_6_34[18].gameObject.SetActive(false);
        inside_109.inside_1_6_34[19].gameObject.SetActive(false);
        inside_109.inside_1_6_34[20].gameObject.SetActive(false);
        inside_109.inside_1_6_34[21].gameObject.SetActive(false);
        inside_109.inside_1_6_34[22].gameObject.SetActive(false);
        inside_109.inside_1_6_34[23].gameObject.SetActive(false);
        inside_109.inside_1_6_34[24].gameObject.SetActive(false);
        inside_109.inside_1_6_34[25].gameObject.SetActive(false);
        inside_109.inside_1_6_34[26].gameObject.SetActive(false);
        inside_109.inside_1_6_34[27].gameObject.SetActive(false);
        inside_109.inside_1_6_34[28].gameObject.SetActive(false);
        inside_109.inside_1_6_34[29].gameObject.SetActive(false);
        inside_109.inside_1_6_34[30].gameObject.SetActive(false);
        inside_109.inside_1_6_34[31].gameObject.SetActive(false);
        inside_109.inside_1_6_34[32].gameObject.SetActive(false);
        inside_109.inside_1_6_34[33].gameObject.SetActive(false);
        inside_109.inside_1_6_34[34].gameObject.SetActive(false);
        inside_109.inside_1_6_34[35].gameObject.SetActive(false);
        inside_109.inside_1_6_34[36].gameObject.SetActive(false);
        inside_109.inside_1_6_34[37].gameObject.SetActive(false);
        inside_109.inside_1_6_34[38].gameObject.SetActive(false);
        inside_109.inside_1_6_34[39].gameObject.SetActive(false);
        inside_109.inside_1_6_34[40].gameObject.SetActive(false);
        inside_109.inside_1_6_34[41].gameObject.SetActive(false);
        inside_109.inside_1_6_34[42].gameObject.SetActive(false);
        inside_109.inside_1_6_34[43].gameObject.SetActive(false);
        inside_109.inside_1_6_34[44].gameObject.SetActive(false);
        inside_109.inside_1_6_34[45].gameObject.SetActive(false);
        inside_109.inside_1_6_34[46].gameObject.SetActive(false);
        inside_109.inside_1_6_34[47].gameObject.SetActive(false);
        inside_109.inside_1_6_34[48].gameObject.SetActive(false);
        inside_109.inside_1_6_34[49].gameObject.SetActive(false);
        inside_109.inside_1_6_34[50].gameObject.SetActive(false);
        inside_109.inside_1_6_34[51].gameObject.SetActive(false);
        inside_109.inside_1_6_34[52].gameObject.SetActive(false);
        inside_109.inside_1_6_34[53].gameObject.SetActive(false);
        inside_109.inside_1_6_34[54].gameObject.SetActive(false);
        inside_109.inside_1_6_34[55].gameObject.SetActive(false);
        inside_109.inside_1_6_34[56].gameObject.SetActive(false);
        inside_109.inside_1_6_34[57].gameObject.SetActive(false);
        inside_109.inside_1_6_34[58].gameObject.SetActive(false);
        inside_109.inside_1_6_34[59].gameObject.SetActive(false);
        inside_109.inside_1_6_34[60].gameObject.SetActive(false);
        inside_109.inside_1_6_34[61].gameObject.SetActive(false);
        inside_109.inside_1_6_34[62].gameObject.SetActive(false);
        inside_109.inside_1_6_34[63].gameObject.SetActive(false);
        inside_109.inside_1_6_34[64].gameObject.SetActive(false);
        inside_109.inside_1_6_34[65].gameObject.SetActive(false);
        inside_109.inside_1_6_34[66].gameObject.SetActive(false);
        inside_109.inside_1_6_34[67].gameObject.SetActive(false);
        inside_109.inside_1_6_34[68].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.05078125f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49066.53f);    //(오, -위)

    }



}
