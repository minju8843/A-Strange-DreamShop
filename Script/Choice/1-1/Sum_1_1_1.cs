using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Sum_1_1_1 : MonoBehaviour
{
    public GameObject[] inside_Line_1;
    public int Line_1_Index;

    public Save_Collection All_Save;

    public R_Wait1 Wait1;

    public R_Wait1_2_1 inside_5;
    public R_Wait1_2_4 inside_8;

    public Only_Line QuestObject;

    public IEnumerator m_Coroutine;

    public RectTransform TextContainer1;//텍스트 컨테이너

    public Fade_Collect FadeObject;//페이드 스크립트 불러오려고



    /*void OnEnable()
    {
        //m_Coroutine = NewCoroutine();
        //StartCoroutine(m_Coroutine);
    }*/

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

    }



    IEnumerator WaitSecond_1()
    {
        yield return new WaitForSeconds(0.0f);

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);




        QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        Line_1_Index = 0;
        inside_Line_1[0].gameObject.SetActive(true);

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


        //타임라인 첫 번째 오픈
        //타임라인 큰 네모 보여주고

        if (All_Save.Time_Line_Open[1].gameObject.activeSelf == true)
        {
            All_Save.Time_Line_Open_Index = 1;
            All_Save.Time_Line_Open[0].gameObject.SetActive(false);
            All_Save.Time_Line_Open[1].gameObject.SetActive(true);
        }

        else
        {
            All_Save.Time_Line_Open_Index = 1;
            All_Save.Time_Line_Open[0].gameObject.SetActive(false);
            All_Save.Time_Line_Open[1].gameObject.SetActive(true);
        }
        //만약 이미 열려 있다면 열려 있는 채로 두자.

        //자동 저장하기
        PlayerPrefs.SetInt("TimeLine", All_Save.Time_Line_Open_Index);

        //첫 번째 동그라미도 오픈
        if(All_Save.Time_Circle_1[1].gameObject.activeSelf == false)
        {
            All_Save.Time_Circle_1_Index = 1;
            All_Save.Time_Circle_1[0].gameObject.SetActive(false);
            All_Save.Time_Circle_1[1].gameObject.SetActive(true);
            PlayerPrefs.SetInt("Time_Circle_1", All_Save.Time_Circle_1_Index);
        }

        else if (All_Save.Time_Circle_1[1].gameObject.activeSelf == true)
        {
            All_Save.Time_Circle_1_Index = 1;
            All_Save.Time_Circle_1[0].gameObject.SetActive(false);
            All_Save.Time_Circle_1[1].gameObject.SetActive(true);
            PlayerPrefs.SetInt("Time_Circle_1", All_Save.Time_Circle_1_Index);
        }






        //Line_1.SetActive(true);
        //Remove_Black_Empty.SetActive(false);//페이드 지우기

        FadeObject.Fade_Index = 8;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(false);
        //FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

        Wait1.Line_0_Index = 0;
        Wait1.inside_Line_0[0].gameObject.SetActive(false);
        Wait1.inside_Line_0[1].gameObject.SetActive(false);
        Wait1.inside_Line_0[2].gameObject.SetActive(false);
        Wait1.inside_Line_0[3].gameObject.SetActive(false);
        Wait1.inside_Line_0[4].gameObject.SetActive(false);
        Wait1.inside_Line_0[5].gameObject.SetActive(false);
        Wait1.inside_Line_0[6].gameObject.SetActive(false);
        Wait1.inside_Line_0[7].gameObject.SetActive(false);
        Wait1.inside_Line_0[8].gameObject.SetActive(false);
        Wait1.inside_Line_0[9].gameObject.SetActive(false);
        Wait1.inside_Line_0[10].gameObject.SetActive(false);
        Wait1.inside_Line_0[11].gameObject.SetActive(false);
        Wait1.inside_Line_0[12].gameObject.SetActive(false);


        QuestObject.Line_Index = 3;

        QuestObject.questObject[0].gameObject.SetActive(false);
        QuestObject.questObject[1].gameObject.SetActive(false);
        QuestObject.questObject[2].gameObject.SetActive(false);
        QuestObject.questObject[3].gameObject.SetActive(true);
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
        QuestObject.questObject[146].gameObject.SetActive(false);

        QuestObject.questObject[147].gameObject.SetActive(false);
        QuestObject.questObject[148].gameObject.SetActive(false);
        QuestObject.questObject[149].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2893.394f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 2217.526f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);
        Line_1_Index = 1;
        inside_Line_1[1].gameObject.SetActive(true);

        //Go_White.SetActive(false);//페이드 지우기

        TextContainer1.offsetMin = new Vector2(0, -2742.871f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 2368.049f);    //(오, 위)
    }

    IEnumerator WaitSecond_3()
    {
        yield return new WaitForSeconds(3.0f);
        //Line_3.SetActive(true);

        Line_1_Index = 2;
        inside_Line_1[2].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;

        FadeObject.fadeObject[8].gameObject.SetActive(false);

  

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


        //Go_White.SetActive(false);//페이드 지우기
        TextContainer1.offsetMin = new Vector2(0, -2589.561f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 2521.359f);    //(오, 위)

    }

    IEnumerator WaitSecond_4()
    {
        yield return new WaitForSeconds(4.5f);
        //Line_4.SetActive(true);

        Line_1_Index = 3;
        inside_Line_1[3].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;

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

        //Go_White.SetActive(false);//페이드 지우기
        TextContainer1.offsetMin = new Vector2(0, -2302.453f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 2808.467f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()
    {
        yield return new WaitForSeconds(6.0f);
        //Line_5.SetActive(true);

        Line_1_Index = 4;
        inside_Line_1[4].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;

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
        //Go_White.SetActive(false);//페이드 지우기
        TextContainer1.offsetMin = new Vector2(0, -2018.133f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 3092.787f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//페이드 인&아웃 그리고 이동까지
    {



        yield return new WaitForSeconds(7.5f);

        //Go_White.SetActive(true);

        FadeObject.Fade_Index = 7;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(true);
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

        //TextContainer1.offsetMin = new Vector2(0, -412.4721f);//(왼, 아래)
        //TextContainer1.offsetMax = new Vector2(0, 1929.618f);    //(오, 위)

    }

    //7은 성공할 때까지 보류
    IEnumerator WaitSecond_7()//페이드 인&아웃 그리고 이동까지
    {



        yield return new WaitForSeconds(9.0f);


        // Remove_First_Line.SetActive(false);



        //QuestObject.Line_Index = 3;
        //QuestObject.questObject[3].gameObject.SetActive(true);
        //QuestObject.questObject[1].gameObject.SetActive(false);

        //원래는 세 번째 라인으로 이동이지만
        //일단 회색 배경이 나타나도록 한다.
        //회색 배경은 [12]이다.

        Line_1_Index = 12;
        inside_Line_1[12].gameObject.SetActive(true);


        FadeObject.Fade_Index = 4;

        FadeObject.fadeObject[0].gameObject.SetActive(false);
        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(true);
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

        TextContainer1.offsetMin = new Vector2(0, -565.996f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 4544.924f);    //(오, 위)


        // Go_Third_Line.SetActive(true);

        //Go_White.SetActive(false);



    }


    //7로부터 4초 후에 진행된다. IEnumerator WaitSecond_1()이라고 보면 된다.
    IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(13.0f);

        Line_1_Index = 5;
        inside_Line_1[5].gameObject.SetActive(true);

        //Go_Empty.SetActive(false);//하얀거 점점 연하게

        FadeObject.Fade_Index = 4;

        FadeObject.fadeObject[0].gameObject.SetActive(false);
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



        TextContainer1.offsetMin = new Vector2(0, -565.996f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 4544.924f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(14.5f);

        Line_1_Index = 6;
        inside_Line_1[6].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;

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

        TextContainer1.offsetMin = new Vector2(0, -565.996f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 4544.924f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()
    {
        yield return new WaitForSeconds(16.0f);

        Line_1_Index = 7;
        inside_Line_1[7].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;

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

        TextContainer1.offsetMin = new Vector2(0, -565.996f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 4544.924f);    //(오, 위)
    }

    IEnumerator WaitSecond_11()
    {
        yield return new WaitForSeconds(17.5f);

        Line_1_Index = 8;
        inside_Line_1[8].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;

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

        TextContainer1.offsetMin = new Vector2(0, -565.996f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 4544.924f);    //(오, 위)

    }

    IEnumerator WaitSecond_12()
    {
        yield return new WaitForSeconds(19.0f);

        Line_1_Index = 9;
        inside_Line_1[9].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;

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

        TextContainer1.offsetMin = new Vector2(0, -565.996f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 4544.924f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()
    {
        yield return new WaitForSeconds(20.5f);

        Line_1_Index = 10;
        inside_Line_1[10].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;

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

        TextContainer1.offsetMin = new Vector2(0, -476.7974f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 4634.123f);    //(오, 위)

    }

    IEnumerator WaitSecond_14()
    {
        yield return new WaitForSeconds(22.0f);

        FadeObject.Fade_Index = 8;

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

        Line_1_Index = 11;
        inside_Line_1[11].gameObject.SetActive(true);

        // % 여기부터 첫 번째 앨범에 대한 힌트 제공 %

        //만약 1번 앨범이 오픈되어 있다면 그대로 두고
        if (All_Save.Album_1[2].gameObject.activeSelf == true)
        {

            All_Save.Album1_Index = 2;
            All_Save.Album_1[0].gameObject.SetActive(false);
            All_Save.Album_1[1].gameObject.SetActive(false);
            All_Save.Album_1[2].gameObject.SetActive(true);

        }

        //1번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_1[2].gameObject.activeSelf == false)
        {
            //1번 앨범에 대한 힌트를 제공한다.
            All_Save.Album1_Index = 1;
            All_Save.Album_1[0].gameObject.SetActive(false);
            All_Save.Album_1[1].gameObject.SetActive(true);
            All_Save.Album_1[2].gameObject.SetActive(false);

        }

        //첫 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_1", All_Save.Album1_Index);



        




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

        inside_8.Line_8_Index = 0;
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


        TextContainer1.offsetMin = new Vector2(0, -0.04858398f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 5110.969f);    //(오, 위)

    }

}
