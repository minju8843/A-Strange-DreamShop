using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class R_Wait1_4_1 : MonoBehaviour
{
    public Save_Collection All_Save;
    public Fade_Collect FadeObject;
    public GameObject[] inside_Line_25;
    public int Line_25_Index;

    public Next_1_3_1 inside_17;

    public R_Wait1_5_1 inside_41;

    public R_Wait1_5_2 inside_57;
    public AudioSource sfx2;
    public AudioSource sfx3;
    public AudioSource sfx4;


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
        yield return StartCoroutine(WaitSecond_55());
        yield return StartCoroutine(WaitSecond_56());
        yield return StartCoroutine(WaitSecond_57());
        yield return StartCoroutine(WaitSecond_58());
        yield return StartCoroutine(WaitSecond_59());
        yield return StartCoroutine(WaitSecond_60());
        yield return StartCoroutine(WaitSecond_61());
        yield return StartCoroutine(WaitSecond_62());
        yield return StartCoroutine(WaitSecond_63());
        yield return StartCoroutine(WaitSecond_64());
        yield return StartCoroutine(WaitSecond_65());
        yield return StartCoroutine(WaitSecond_66());
        yield return StartCoroutine(WaitSecond_67());
        yield return StartCoroutine(WaitSecond_68());
        yield return StartCoroutine(WaitSecond_69());
        yield return StartCoroutine(WaitSecond_70());
        yield return StartCoroutine(WaitSecond_71());
        yield return StartCoroutine(WaitSecond_72());
        yield return StartCoroutine(WaitSecond_73());
        yield return StartCoroutine(WaitSecond_74());
        yield return StartCoroutine(WaitSecond_75());




    }



    IEnumerator WaitSecond_1()//79-1
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

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

        Line_25_Index = 0;
        inside_Line_25[0].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

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

        /*QuestObject.Line_Index = 25;

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

        TextContainer1.offsetMin = new Vector2(0, -16017.81f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 26220.95f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()//79-2
    {   
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);

        Line_25_Index = 1;
        inside_Line_25[1].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -15861.72f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 26377.05f);    //(오, 위)
    }

    IEnumerator WaitSecond_3()//맨 위로 올림
    {
        yield return new WaitForSeconds(3.0f);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -14404.56f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 27834.2f);    //(오, 위)

    }

    IEnumerator WaitSecond_4()//맨 위로 올린 뒤 다음 거 나타내기
        //80
    {
        yield return new WaitForSeconds(5.0f);
        //Line_3.SetActive(true);

        Line_25_Index = 2;
        inside_Line_25[2].gameObject.SetActive(true);

        //타임라인 중간부터 시작 네모 보여주고

        if (All_Save.Time_Run[1].gameObject.activeSelf == true)
        {
            All_Save.Time_Run_Index = 1;
            All_Save.Time_Run[0].gameObject.SetActive(false);
            All_Save.Time_Run[1].gameObject.SetActive(true);
        }

        else
        {
            All_Save.Time_Run_Index = 1;
            All_Save.Time_Run[0].gameObject.SetActive(false);
            All_Save.Time_Run[1].gameObject.SetActive(true);
        }


        //만약 이미 열려 있다면 열려 있는 채로 두자.

        //자동 저장하기
        PlayerPrefs.SetInt("TimeLine_Run", All_Save.Time_Run_Index);

        //2 번째 동그라미도 오픈
        if (All_Save.Time_Circle_2[1].gameObject.activeSelf == false)
        {
            All_Save.Time_Circle_2_Index = 1;
            All_Save.Time_Circle_2[0].gameObject.SetActive(false);
            All_Save.Time_Circle_2[1].gameObject.SetActive(true);
            PlayerPrefs.SetInt("Time_Circle_2", All_Save.Time_Circle_2_Index);
        }

        else if (All_Save.Time_Circle_2[1].gameObject.activeSelf == true)
        {
            All_Save.Time_Circle_2_Index = 1;
            All_Save.Time_Circle_2[0].gameObject.SetActive(false);
            All_Save.Time_Circle_2[1].gameObject.SetActive(true);
            PlayerPrefs.SetInt("Time_Circle_2", All_Save.Time_Circle_2_Index);
        }


        TextContainer1.offsetMin = new Vector2(0, -14404.56f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 27834.2f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()//81-1
    {
        yield return new WaitForSeconds(6.5f);
        //Line_4.SetActive(true);

        Line_25_Index = 3;
        inside_Line_25[3].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -14404.56f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 27834.2f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//81-2
    {
        yield return new WaitForSeconds(8.0f);
        //Line_5.SetActive(true);

        Line_25_Index = 4;
        inside_Line_25[4].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -14404.56f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 27834.2f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()//81-3
    {
        yield return new WaitForSeconds(9.5f);
        //Line_6.SetActive(true);

        Line_25_Index = 5;
        inside_Line_25[5].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -14404.56f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 27834.2f);    //(오, 위)

    }

    IEnumerator WaitSecond_8()//82
    {
        yield return new WaitForSeconds(11.0f);
        //Line_7.SetActive(true);

        Line_25_Index = 6;
        inside_Line_25[6].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -14404.56f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 27834.2f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()//83
    {
        yield return new WaitForSeconds(12.5f);
        //Line_8.SetActive(true);

        Line_25_Index = 7;
        inside_Line_25[7].gameObject.SetActive(true);



        TextContainer1.offsetMin = new Vector2(0, -13851.67f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 28387.1f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//84
    {
        yield return new WaitForSeconds(14.0f);
        //Line_9.SetActive(true);

        Line_25_Index = 8;
        inside_Line_25[8].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -13547.83f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 28690.93f);    //(오, -위)

    }

    IEnumerator WaitSecond_11()//85
    {
        yield return new WaitForSeconds(15.5f);
        //Line_10.SetActive(true);

        Line_25_Index = 9;
        inside_Line_25[9].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -13282.88f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 28955.88f);    //(오, 위)

    }

    IEnumerator WaitSecond_12()//86
    {
        yield return new WaitForSeconds(17.0f);
        //Line_11.SetActive(true);

        Line_25_Index =10;
        inside_Line_25[10].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -13001.35f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 29237.42f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//87
    {
        yield return new WaitForSeconds(18.5f);
        //Line_12.SetActive(true);

        Line_25_Index = 11;
        inside_Line_25[11].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -12708.67f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 29530.1f);    //(오, -위)

    }

    IEnumerator WaitSecond_14()//88
    {
        yield return new WaitForSeconds(20.0f);
        //Line_13.SetActive(true);


        Line_25_Index = 12;
        inside_Line_25[12].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -12496.82f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 29741.95f);    //(오, 위)

    }

    IEnumerator WaitSecond_15()//89
    {
        yield return new WaitForSeconds(21.5f);
        //Line_14.SetActive(true);

        Line_25_Index = 13;
        inside_Line_25[13].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -12190.31f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 30048.46f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()//90-1
    {
        yield return new WaitForSeconds(23.0f);
        //Line_15.SetActive(true);

        Line_25_Index = 14;
        inside_Line_25[14].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11906.15f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 30332.61f);    //(오, -위)
    }

    IEnumerator WaitSecond_17()//90-2
    {
        yield return new WaitForSeconds(24.5f);
        //Line_16.SetActive(true);

        Line_25_Index = 15;
        inside_Line_25[15].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11750.06f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 30488.71f);    //(오, -위)
    }

    IEnumerator WaitSecond_18()//91-1
    {
        yield return new WaitForSeconds(26.0f);

        //Line_17.SetActive(true);

        Line_25_Index = 16;
        inside_Line_25[16].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11462.95f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 30775.82f);    //(오, -위)

    }

    IEnumerator WaitSecond_19()//91-2
    {
        yield return new WaitForSeconds(27.5f);
        //Line_18.SetActive(true);

        Line_25_Index = 17;
        inside_Line_25[17].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11312.43f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 30926.34f);    //(오, -위)

    }

    IEnumerator WaitSecond_20()//92
    {
        yield return new WaitForSeconds(29.0f);
        //Line_19.SetActive(true);

        Line_25_Index = 18;
        inside_Line_25[18].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11022.53f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 31216.23f);    //(오, -위)
    }

    IEnumerator WaitSecond_21()//93
    {
        yield return new WaitForSeconds(30.5f);

        //Line_20.SetActive(true);

        Line_25_Index = 19;
        inside_Line_25[19].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -10733.03f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 31505.74f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//94
    {
        yield return new WaitForSeconds(31.5f);
        //Line_21.SetActive(true);

        Line_25_Index = 20;
        inside_Line_25[20].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -10526.75f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 31712.01f);    //(오, -위)
    }

    IEnumerator WaitSecond_23()//95
    {
        yield return new WaitForSeconds(33.0f);

        //Line_22.SetActive(true);

        Line_25_Index = 21;
        inside_Line_25[21].gameObject.SetActive(true);
        TextContainer1.offsetMin = new Vector2(0, -10218.21f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 32020.55f);    //(오, -위)
    }

    IEnumerator WaitSecond_24()//96
    {
        yield return new WaitForSeconds(34.5f);
        //Line_23.SetActive(true);

        sfx2.Play();

        Line_25_Index = 22;
        inside_Line_25[22].gameObject.SetActive(true);


        TextContainer1.offsetMin = new Vector2(0, -10012.79f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 32225.97f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//97
    {
        yield return new WaitForSeconds(36.0f);
        //Line_24.SetActive(true);

        Line_25_Index = 23;
        inside_Line_25[23].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9684.329f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 32554.44f);    //(오, -위)

    }

    IEnumerator WaitSecond_26()//98
    {
        yield return new WaitForSeconds(37.5f);
        //Line_25.SetActive(true);

        sfx2.Play();

        Line_25_Index = 24;
        inside_Line_25[24].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9472.482f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 32766.28f);    //(오, -위)
    }

    IEnumerator WaitSecond_27()//99
    {
        yield return new WaitForSeconds(39.0f);
        //Line_26.SetActive(true);

        Line_25_Index = 25;
        inside_Line_25[25].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9286.873f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 32941.89f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//100
    {
        yield return new WaitForSeconds(40.5f);
        //Line_27.SetActive(true);

        Line_25_Index = 26;
        inside_Line_25[26].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -8928.929f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 33309.84f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//101
    {
        yield return new WaitForSeconds(42.0f);
        //Line_28.SetActive(true);

        Line_25_Index = 27;
        inside_Line_25[27].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -8728.7f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 33510.07f);    //(오, -위)

    }

    IEnumerator WaitSecond_30()//102
    {
        yield return new WaitForSeconds(43.5f);
        //Line_29.SetActive(true);

        Line_25_Index = 28;
        inside_Line_25[28].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -8416.524f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 33822.24f);    //(오, -위)

    }

    IEnumerator WaitSecond_31()//103-속마음
    {
        yield return new WaitForSeconds(45.5f);
        //Line_30.SetActive(true);

        QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        Line_25_Index = 29;
        inside_Line_25[29].gameObject.SetActive(true);

    }

    IEnumerator WaitSecond_32()//베경 검게 만들기
    {
        //대사 맨 위로
        //위치 좌표는 적기
        yield return new WaitForSeconds(48.0f);
        //BackGround_BLACK.SetActive(true);//70으로 하자




        //Line_30.SetActive(false);
        Line_25_Index = 29;
        inside_Line_25[29].gameObject.SetActive(false);
        inside_Line_25[70].gameObject.SetActive(true);
        //70은 배경 검정


        TextContainer1.offsetMin = new Vector2(0, -6964.608f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 35274.16f);    //(오, -위)


    }

    IEnumerator WaitSecond_33()//배경 검은데다가 대사 나타내기
        //104
    {
        //위치 좌표는 적기
        yield return new WaitForSeconds(50.0f);
        //Line_31.SetActive(true);

        Line_25_Index = 30;
        inside_Line_25[30].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -6964.608f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 35274.16f);    //(오, -위)


    }

    IEnumerator WaitSecond_34()//105-속마음
        
    {
        yield return new WaitForSeconds(52.0f);
        //Line_32.SetActive(true);

        Line_25_Index = 31;
        inside_Line_25[31].gameObject.SetActive(true);

    }

    IEnumerator WaitSecond_35()//106-속마음
    {
        yield return new WaitForSeconds(54.5f);
        //Line_33.SetActive(true);
        //Line_32.SetActive(false);

        Line_25_Index = 32;
        inside_Line_25[32].gameObject.SetActive(true);
        inside_Line_25[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_36()//35로부터 1.5초 뒤에 실행(그냥 평범한 대사가 앞에 있을 경우)
    {//1.5초 뒤에 점점 검게
        yield return new WaitForSeconds(57.0f);
        //Go_Black.SetActive(true);

        FadeObject.Fade_Index = 5;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(true);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(false);
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);



        //Line_33.SetActive(false);
        Line_25_Index = 32;
        //inside_Line_25[32].gameObject.SetActive(true);
        inside_Line_25[32].gameObject.SetActive(false);


        //TextContainer1.offsetMin = new Vector2(0, -6677.5f);//(왼, 아래)
        //TextContainer1.offsetMax = new Vector2(0, 35561.27f);    //(오, -위)


    }

    IEnumerator WaitSecond_37()//페이드 아웃 실행, 페이드 인 지우기
    {//36로부터 1.5초 뒤에 점점 연하게 실행, 검은거 삭제
     //배경 색 회색으로 바꾸기
        yield return new WaitForSeconds(58.5f);

        //Go_Black.SetActive(false);
        //Go_Empty.SetActive(true);


        FadeObject.Fade_Index = 6;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(true);
        FadeObject.fadeObject[7].gameObject.SetActive(false);
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);



        //BackGround_BLACK.SetActive(false);
        Line_25_Index = 70;
        inside_Line_25[70].gameObject.SetActive(false);
        //70은 배경 검정

        TextContainer1.offsetMin = new Vector2(0, -6677.5f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 35561.27f);    //(오, -위)

    }


    IEnumerator WaitSecond_38()//37로부터 4초후에 대사 나타내기
    {//아무것도 없는거 지우기
        //107
        yield return new WaitForSeconds(62.5f);
        //Line_34.SetActive(true);

        Line_25_Index = 33;
        inside_Line_25[33].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        //Go_Empty.SetActive(false);

        FadeObject.Fade_Index = 6;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(false);
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6677.5f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 35561.27f);    //(오, -위)

    }

    IEnumerator WaitSecond_39()//108
    {
        yield return new WaitForSeconds(64.0f);
        //Line_35.SetActive(true);

        Line_25_Index = 34;
        inside_Line_25[34].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        // % 여기부턴 앨범 관련 %

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
            //7번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album7_Index = 2;
            All_Save.Album_7[0].gameObject.SetActive(false);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(true);

        }

        //7 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);

        // % 여기부턴 다음 앨범에 대한 힌트 제공 %

        //8번 앨범 오픈 관련
        if (All_Save.Album_8[2].gameObject.activeSelf == true)
        {//이미 8번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album8_Index = 2;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(true);

        }

        //8번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_8[2].gameObject.activeSelf == false)
        {
            //8번 앨범에 대한 힌트를 준다
            All_Save.Album8_Index = 1;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(true);
            All_Save.Album_8[2].gameObject.SetActive(false);

        }

        //8 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);



        TextContainer1.offsetMin = new Vector2(0, -6677.5f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 35561.27f);    //(오, -위)

    }

    IEnumerator WaitSecond_40()//109-1
    {
        yield return new WaitForSeconds(65.5f);
        //Line_36.SetActive(true);

        Line_25_Index = 35;
        inside_Line_25[35].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6677.5f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 35561.27f);    //(오, -위)

    }

    IEnumerator WaitSecond_41()//109-2
    {
        yield return new WaitForSeconds(67.0f);
        //Line_37.SetActive(true);

        Line_25_Index = 36;
        inside_Line_25[36].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6609.965f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 35628.8f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//110-속마음
    {
        yield return new WaitForSeconds(69.0f);
        //Line_38.SetActive(true);

        Line_25_Index = 37;
        inside_Line_25[37].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_43()//111-속마음
    {
        yield return new WaitForSeconds(72.0f);
        //Line_39.SetActive(true);
        //Line_38.SetActive(false);

        Line_25_Index = 38;
        inside_Line_25[38].gameObject.SetActive(true);
        inside_Line_25[37].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_44()//112
    {
        yield return new WaitForSeconds(74.5f);
        //Line_40.SetActive(true);
        //Line_39.SetActive(false);

        Line_25_Index = 39;
        inside_Line_25[39].gameObject.SetActive(true);
        inside_Line_25[38].gameObject.SetActive(false);

        // % 여기부턴 앨범 관련 %

        //8번 앨범 오픈 관련
        if (All_Save.Album_8[2].gameObject.activeSelf == true)
        {//이미 8번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album8_Index = 2;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(true);

        }

        //8번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_8[2].gameObject.activeSelf == false)
        {
            //8번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album8_Index = 2;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(true);

        }

        //8 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);

        TextContainer1.offsetMin = new Vector2(0, -5879.339f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36359.43f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//113-1
    {
        yield return new WaitForSeconds(76.0f);
        //Line_41.SetActive(true);

        Line_25_Index = 40;
        inside_Line_25[40].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5592.23f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36646.54f);    //(오, -위)

    }

    IEnumerator WaitSecond_46()//113-2
    {
        yield return new WaitForSeconds(77.5f);
        //Line_42.SetActive(true);

        Line_25_Index = 41;
        inside_Line_25[41].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5442.315f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36796.45f);    //(오, -위)

    }

    IEnumerator WaitSecond_47()//113-3
    {
        yield return new WaitForSeconds(79.0f);
        //Line_43.SetActive(true);

        Line_25_Index = 42;
        inside_Line_25[42].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5286.218f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36952.55f);    //(오, -위)

    }

    IEnumerator WaitSecond_48()//114전
        //맨 위로 보내기
    {
        yield return new WaitForSeconds(80.5f);


   

        QuestObject.BGM_Index = 1;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(true);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3831.027f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 38407.74f);    //(오, -위)

    }

    IEnumerator WaitSecond_49()//114-1
    {//48로부터 2초 후 다음 거 나타내기
        yield return new WaitForSeconds(82.5f);
        // Line_44.SetActive(true);

        sfx3.Play();

        Line_25_Index = 43;
        inside_Line_25[43].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3831.027f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 38407.74f);    //(오, -위)

    }

    IEnumerator WaitSecond_50()//14-2
    {
        yield return new WaitForSeconds(84.0f);
        //Line_45.SetActive(true);

        Line_25_Index = 44;
        inside_Line_25[44].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3831.027f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 38407.74f);    //(오, -위)

    }

    IEnumerator WaitSecond_51()//115-속마음
    {
        yield return new WaitForSeconds(86.0f);
        //Line_46.SetActive(true);

        Line_25_Index = 45;
        inside_Line_25[45].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_52()//116속마음
    {
        yield return new WaitForSeconds(88.5f);
        //Line_47.SetActive(true);
        //Line_46.SetActive(false);

        Line_25_Index = 46;
        inside_Line_25[46].gameObject.SetActive(true);
        inside_Line_25[45].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_53()//117
    {
        yield return new WaitForSeconds(92.5f);
        //Line_48.SetActive(true);
        //Line_47.SetActive(false);

        sfx4.Play();

        Line_25_Index = 47;
        inside_Line_25[47].gameObject.SetActive(true);
        inside_Line_25[46].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -3831.027f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 38407.74f);    //(오, -위)

    }

    IEnumerator WaitSecond_54()//118
    {
        yield return new WaitForSeconds(94.0f);
        //Line_49.SetActive(true);

        Line_25_Index = 48;
        inside_Line_25[48].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3831.027f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 38407.74f);    //(오, -위)

    }

    IEnumerator WaitSecond_55()//119
    {
        yield return new WaitForSeconds(95.5f);
        //Line_50.SetActive(true);

        Line_25_Index = 49;
        inside_Line_25[49].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3831.027f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 38407.74f);    //(오, -위)

    }

    IEnumerator WaitSecond_56()//120
    {
        yield return new WaitForSeconds(97.0f);
        //Line_51.SetActive(true);

        Line_25_Index = 50;
        inside_Line_25[50].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3329.695f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 38909.07f);    //(오, -위)

    }

    IEnumerator WaitSecond_57()//121-1
    {
        yield return new WaitForSeconds(98.5f);
        //Line_52.SetActive(true);

        Line_25_Index = 51;
        inside_Line_25[51].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3047.004f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39191.76f);    //(오, -위)

    }

    IEnumerator WaitSecond_58()//121-2
    {
        yield return new WaitForSeconds(100.0f);
        //Line_53.SetActive(true);

        Line_25_Index = 52;
        inside_Line_25[52].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2890.906f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39347.86f);    //(오, -위)

    }

    IEnumerator WaitSecond_59()//122-1
    {
        yield return new WaitForSeconds(101.5f);
        //Line_54.SetActive(true);

        Line_25_Index = 53;
        inside_Line_25[53].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2594.559f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39644.21f);    //(오, -위)

    }

    IEnumerator WaitSecond_60()//122-2
    {
        yield return new WaitForSeconds(103.0f);
        //Line_55.SetActive(true);

        Line_25_Index = 54;
        inside_Line_25[54].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2441.248f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39797.52f);    //(오, -위)

    }

    IEnumerator WaitSecond_61()//123
    {
        yield return new WaitForSeconds(104.5f);
        //Line_56.SetActive(true);

        Line_25_Index = 55;
        inside_Line_25[55].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2154.141f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40084.63f);    //(오, -위)

    }

    IEnumerator WaitSecond_62()//124
    {
        yield return new WaitForSeconds(106.0f);
        //Line_57.SetActive(true);

        Line_25_Index = 56;
        inside_Line_25[56].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1867.033f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40371.73f);    //(오, -위)

    }

    IEnumerator WaitSecond_63()//125-속마음
    {
        yield return new WaitForSeconds(108.0f);
        //Line_58.SetActive(true);
        Line_25_Index = 57;
        inside_Line_25[57].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_64()//126-속마음
    {
        yield return new WaitForSeconds(110.0f);
        // Line_59.SetActive(true);
        //Line_58.SetActive(false);

        Line_25_Index = 58;
        inside_Line_25[58].gameObject.SetActive(true);
        inside_Line_25[57].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_65()//127-속마음
    {
        yield return new WaitForSeconds(113.0f);
        //Line_60.SetActive(true);
        //Line_59.SetActive(false);

        Line_25_Index = 59;
        inside_Line_25[59].gameObject.SetActive(true);
        inside_Line_25[58].gameObject.SetActive(false);
    }
    IEnumerator WaitSecond_66()//128
    {
        yield return new WaitForSeconds(116.0f);
        //Line_61.SetActive(true);
        //Line_60.SetActive(false);

        Line_25_Index = 60;
        inside_Line_25[60].gameObject.SetActive(true);
        inside_Line_25[59].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1591.254f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40647.51f);    //(오, -위)

    }

    IEnumerator WaitSecond_67()//129
    {
        yield return new WaitForSeconds(117.5f);
        //Line_62.SetActive(true);

        Line_25_Index = 61;
        inside_Line_25[61].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1304.146f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40934.62f);    //(오, -위)

    }

    IEnumerator WaitSecond_68()//130
    {
        yield return new WaitForSeconds(119.0f);
        //Line_63.SetActive(true);

        Line_25_Index = 62;
        inside_Line_25[62].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1011.463f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41227.3f);    //(오, -위)

    }

    IEnumerator WaitSecond_69()//131
    {
        yield return new WaitForSeconds(120.5f);
        //Line_64.SetActive(true);

        Line_25_Index = 63;
        inside_Line_25[63].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -730.4473f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41508.32f);    //(오, -위)

    }

    IEnumerator WaitSecond_70()//132
    {
        yield return new WaitForSeconds(122.0f);
        //Line_65.SetActive(true);

        Line_25_Index = 64;
        inside_Line_25[64].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -432.1895f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41806.58f);    //(오, -위)

    }

    IEnumerator WaitSecond_71()//133-속마음
    {
        yield return new WaitForSeconds(124.0f);
        // Line_66.SetActive(true);

        Line_25_Index = 65;
        inside_Line_25[65].gameObject.SetActive(true);
        //inside_Line_25[31].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_72()//134-속마음
    {
        yield return new WaitForSeconds(126.0f);
        //Line_67.SetActive(true);
        //Line_66.SetActive(false);

        Line_25_Index = 66;
        inside_Line_25[66].gameObject.SetActive(true);
        inside_Line_25[65].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_73()//135-속마음
    {
        yield return new WaitForSeconds(130.0f);
        //Line_68.SetActive(true);
        //Line_67.SetActive(false);

        Line_25_Index = 67;
        inside_Line_25[67].gameObject.SetActive(true);
        inside_Line_25[66].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_74()//136-속마음
    {
        yield return new WaitForSeconds(133.0f);
        //Line_69.SetActive(true);
        //Line_68.SetActive(false);

        Line_25_Index = 68;
        inside_Line_25[68].gameObject.SetActive(true);
        inside_Line_25[67].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_75()//137-선택지
    {
        yield return new WaitForSeconds(135.5f);
        //Line_70.SetActive(true);
        //Line_69.SetActive(false);

        Line_25_Index = 69;
        inside_Line_25[69].gameObject.SetActive(true);
        inside_Line_25[68].gameObject.SetActive(false);

        //inside_Line_25[70]도 있는데, 이건 배경 검정

        inside_41.Line_41_Index = 0;
        inside_41.inside_Line_41[0].gameObject.SetActive(false);
        inside_41.inside_Line_41[1].gameObject.SetActive(false);
        inside_41.inside_Line_41[2].gameObject.SetActive(false);
        inside_41.inside_Line_41[3].gameObject.SetActive(false);
        inside_41.inside_Line_41[4].gameObject.SetActive(false);
        inside_41.inside_Line_41[5].gameObject.SetActive(false);
        inside_41.inside_Line_41[6].gameObject.SetActive(false);
        inside_41.inside_Line_41[7].gameObject.SetActive(false);
        inside_41.inside_Line_41[8].gameObject.SetActive(false);
        inside_41.inside_Line_41[9].gameObject.SetActive(false);
        inside_41.inside_Line_41[10].gameObject.SetActive(false);
        inside_41.inside_Line_41[11].gameObject.SetActive(false);
        inside_41.inside_Line_41[12].gameObject.SetActive(false);
        inside_41.inside_Line_41[13].gameObject.SetActive(false);
        inside_41.inside_Line_41[14].gameObject.SetActive(false);
        inside_41.inside_Line_41[15].gameObject.SetActive(false);
        inside_41.inside_Line_41[16].gameObject.SetActive(false);
        inside_41.inside_Line_41[17].gameObject.SetActive(false);
        inside_41.inside_Line_41[18].gameObject.SetActive(false);
        inside_41.inside_Line_41[19].gameObject.SetActive(false);
        inside_41.inside_Line_41[20].gameObject.SetActive(false);
        inside_41.inside_Line_41[21].gameObject.SetActive(false);
        inside_41.inside_Line_41[22].gameObject.SetActive(false);
        inside_41.inside_Line_41[23].gameObject.SetActive(false);
        inside_41.inside_Line_41[24].gameObject.SetActive(false);
        inside_41.inside_Line_41[25].gameObject.SetActive(false);
        inside_41.inside_Line_41[26].gameObject.SetActive(false);
        inside_41.inside_Line_41[27].gameObject.SetActive(false);
        inside_41.inside_Line_41[28].gameObject.SetActive(false);
        inside_41.inside_Line_41[29].gameObject.SetActive(false);
        inside_41.inside_Line_41[30].gameObject.SetActive(false);
        inside_41.inside_Line_41[31].gameObject.SetActive(false);
        inside_41.inside_Line_41[32].gameObject.SetActive(false);
        inside_41.inside_Line_41[33].gameObject.SetActive(false);
        inside_41.inside_Line_41[34].gameObject.SetActive(false);
        inside_41.inside_Line_41[35].gameObject.SetActive(false);
        inside_41.inside_Line_41[36].gameObject.SetActive(false);
        inside_41.inside_Line_41[37].gameObject.SetActive(false);
        inside_41.inside_Line_41[38].gameObject.SetActive(false);
        inside_41.inside_Line_41[39].gameObject.SetActive(false);
        inside_41.inside_Line_41[40].gameObject.SetActive(false);
        inside_41.inside_Line_41[41].gameObject.SetActive(false);
        inside_41.inside_Line_41[42].gameObject.SetActive(false);
        inside_41.inside_Line_41[43].gameObject.SetActive(false);
        inside_41.inside_Line_41[44].gameObject.SetActive(false);
        inside_41.inside_Line_41[45].gameObject.SetActive(false);
        inside_41.inside_Line_41[46].gameObject.SetActive(false);
        inside_41.inside_Line_41[47].gameObject.SetActive(false);
        inside_41.inside_Line_41[48].gameObject.SetActive(false);

        inside_57.Line_57_Index = 0;
        inside_57.inside_Line_57[0].gameObject.SetActive(false);
        inside_57.inside_Line_57[1].gameObject.SetActive(false);
        inside_57.inside_Line_57[2].gameObject.SetActive(false);
        inside_57.inside_Line_57[3].gameObject.SetActive(false);
        inside_57.inside_Line_57[4].gameObject.SetActive(false);
        inside_57.inside_Line_57[5].gameObject.SetActive(false);
        inside_57.inside_Line_57[6].gameObject.SetActive(false);
        inside_57.inside_Line_57[7].gameObject.SetActive(false);
        inside_57.inside_Line_57[8].gameObject.SetActive(false);
        inside_57.inside_Line_57[9].gameObject.SetActive(false);
        inside_57.inside_Line_57[10].gameObject.SetActive(false);
        inside_57.inside_Line_57[11].gameObject.SetActive(false);
        inside_57.inside_Line_57[12].gameObject.SetActive(false);
        inside_57.inside_Line_57[13].gameObject.SetActive(false);
        inside_57.inside_Line_57[14].gameObject.SetActive(false);
        inside_57.inside_Line_57[15].gameObject.SetActive(false);
        inside_57.inside_Line_57[16].gameObject.SetActive(false);
        inside_57.inside_Line_57[17].gameObject.SetActive(false);
        inside_57.inside_Line_57[18].gameObject.SetActive(false);
        inside_57.inside_Line_57[19].gameObject.SetActive(false);
        inside_57.inside_Line_57[20].gameObject.SetActive(false);
        inside_57.inside_Line_57[21].gameObject.SetActive(false);
        inside_57.inside_Line_57[22].gameObject.SetActive(false);
        inside_57.inside_Line_57[23].gameObject.SetActive(false);
        inside_57.inside_Line_57[24].gameObject.SetActive(false);
        inside_57.inside_Line_57[25].gameObject.SetActive(false);
        inside_57.inside_Line_57[26].gameObject.SetActive(false);
        inside_57.inside_Line_57[27].gameObject.SetActive(false);
        inside_57.inside_Line_57[28].gameObject.SetActive(false);
        inside_57.inside_Line_57[29].gameObject.SetActive(false);
        inside_57.inside_Line_57[30].gameObject.SetActive(false);
        inside_57.inside_Line_57[31].gameObject.SetActive(false);
        inside_57.inside_Line_57[32].gameObject.SetActive(false);
        inside_57.inside_Line_57[33].gameObject.SetActive(false);
        inside_57.inside_Line_57[34].gameObject.SetActive(false);
        inside_57.inside_Line_57[35].gameObject.SetActive(false);
        inside_57.inside_Line_57[36].gameObject.SetActive(false);
        inside_57.inside_Line_57[37].gameObject.SetActive(false);
        inside_57.inside_Line_57[38].gameObject.SetActive(false);
        inside_57.inside_Line_57[39].gameObject.SetActive(false);
        inside_57.inside_Line_57[40].gameObject.SetActive(false);
        inside_57.inside_Line_57[41].gameObject.SetActive(false);
        inside_57.inside_Line_57[42].gameObject.SetActive(false);
        inside_57.inside_Line_57[43].gameObject.SetActive(false);
        inside_57.inside_Line_57[44].gameObject.SetActive(false);
        inside_57.inside_Line_57[45].gameObject.SetActive(false);
        inside_57.inside_Line_57[46].gameObject.SetActive(false);
        inside_57.inside_Line_57[47].gameObject.SetActive(false);
        inside_57.inside_Line_57[48].gameObject.SetActive(false);
        inside_57.inside_Line_57[49].gameObject.SetActive(false);
        inside_57.inside_Line_57[50].gameObject.SetActive(false);
        inside_57.inside_Line_57[51].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.1308594f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42238.9f);    //(오, -위)

    }


}
