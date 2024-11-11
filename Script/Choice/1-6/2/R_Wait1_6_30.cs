using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class R_Wait1_6_30 : MonoBehaviour
{
    public Save_Collection All_Save;
    //public Inside_1_6_1 inside6_1;
    public AudioSource sfx5;
    public GameObject[] inside_1_6_30;
    public int Line_1_6_30_Index;
    public AudioSource sfx6;
    public R_Wait1_5_5 inside_45;

    public Picture3 Ch1_P;
   
    public Only_Line QuestObject;

    public Animator Achieve;//업적을 달성했습니다. 애니메이션
    public GameObject Achieve_Obj;//업적 달성했습니다 오브젝트

    public GameObject Ending1;//첫 번째 엔딩 그림
    public GameObject Ending2;//두 번째 엔딩 그림
    public GameObject Ending3;//세 번쨰 엔딩 그림
    public GameObject Ending4;//네 번째 엔딩 그림

    public Fade_Collect FadeObject;

    public RectTransform TextContainer1;//텍스트 컨테이너

  

    public IEnumerator m_Coroutine;//원래 private였음
    //private bool m_IsCoroutineing;//코루틴 실행 유무 확인

    //Coroutine m_myCoroutineReference;


    void Start()
    {


        m_Coroutine = WaitSecond_0();

    }

    void Update()
    {

        StartCoroutine(m_Coroutine);
        
    }


    public IEnumerator WaitSecond_0()
    {
        yield return StartCoroutine(Before_1());
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
        yield return StartCoroutine(Wait_4_Second_Achivement());
        yield return StartCoroutine(Wait_One_Second());
        //yield return StartCoroutine(WaitSecond_80());
    }


    public IEnumerator Before_1()//172-속마음
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        QuestObject.BGM_Index = 1;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(true);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_1_6_30_Index = 0;
        //inside6_2.inside_1_6_2[0].gameObject.SetActive(false);
        inside_1_6_30[0].gameObject.SetActive(true);

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

        if (All_Save.Achieve_7[2].gameObject.activeSelf == true)
        {//이미 1회차를 끝낸 경우
            //업적 내용물을 보여준다

            All_Save.Achieve7_Index = 2;
            All_Save.Achieve_7[0].gameObject.SetActive(false);
            All_Save.Achieve_7[1].gameObject.SetActive(false);
            All_Save.Achieve_7[2].gameObject.SetActive(true);
        }
        else if (All_Save.Achieve_7[0].gameObject.activeSelf == true)
        {
            //1회차를 끝내지 못한 경우 힌트를 보여준다.
            All_Save.Achieve7_Index = 1;
            All_Save.Achieve_7[0].gameObject.SetActive(false);
            All_Save.Achieve_7[1].gameObject.SetActive(true);
            All_Save.Achieve_7[2].gameObject.SetActive(false);
        }

        // *** 업적과 앨범 보여준 거 자동저장 ***
        PlayerPrefs.SetInt("Achieve_7", All_Save.Achieve7_Index);

        //QuestObject.Line_Index = 0;
        //QuestObject.questObject[139].gameObject.SetActive(false);

        //FadeObject.Fade_Index = 12;

        //FadeObject.fadeObject[12].gameObject.SetActive(false);
        //FadeObject.fadeObject[14].gameObject.SetActive(false);

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

        //Sok_talk1.Sok_Talk_Index = 0;

        //Sok_talk1.Sok_talk[0].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -12452.16f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49504.79f);    //(오, 위)

        inside_45.Line_45_Index = 0;
        inside_45.inside_Line_45[0].gameObject.SetActive(false);
        inside_45.inside_Line_45[1].gameObject.SetActive(false);
        inside_45.inside_Line_45[2].gameObject.SetActive(false);
        inside_45.inside_Line_45[3].gameObject.SetActive(false);
        inside_45.inside_Line_45[4].gameObject.SetActive(false);
        inside_45.inside_Line_45[5].gameObject.SetActive(false);
        inside_45.inside_Line_45[6].gameObject.SetActive(false);
        inside_45.inside_Line_45[7].gameObject.SetActive(false);
        inside_45.inside_Line_45[8].gameObject.SetActive(false);
        inside_45.inside_Line_45[9].gameObject.SetActive(false);
        inside_45.inside_Line_45[10].gameObject.SetActive(false);
        inside_45.inside_Line_45[11].gameObject.SetActive(false);
        inside_45.inside_Line_45[12].gameObject.SetActive(false);
        inside_45.inside_Line_45[13].gameObject.SetActive(false);
        inside_45.inside_Line_45[14].gameObject.SetActive(false);
        inside_45.inside_Line_45[15].gameObject.SetActive(false);
        inside_45.inside_Line_45[16].gameObject.SetActive(false);
        inside_45.inside_Line_45[17].gameObject.SetActive(false);
        inside_45.inside_Line_45[18].gameObject.SetActive(false);
        inside_45.inside_Line_45[19].gameObject.SetActive(false);
        inside_45.inside_Line_45[20].gameObject.SetActive(false);
        inside_45.inside_Line_45[21].gameObject.SetActive(false);
        inside_45.inside_Line_45[22].gameObject.SetActive(false);
        inside_45.inside_Line_45[23].gameObject.SetActive(false);
        inside_45.inside_Line_45[24].gameObject.SetActive(false);
        inside_45.inside_Line_45[25].gameObject.SetActive(false);
        inside_45.inside_Line_45[26].gameObject.SetActive(false);
        inside_45.inside_Line_45[27].gameObject.SetActive(false);
        inside_45.inside_Line_45[28].gameObject.SetActive(false);
        inside_45.inside_Line_45[29].gameObject.SetActive(false);
        inside_45.inside_Line_45[30].gameObject.SetActive(false);
        inside_45.inside_Line_45[31].gameObject.SetActive(false);
        inside_45.inside_Line_45[32].gameObject.SetActive(false);
        inside_45.inside_Line_45[33].gameObject.SetActive(false);
        inside_45.inside_Line_45[34].gameObject.SetActive(false);
        inside_45.inside_Line_45[35].gameObject.SetActive(false);
        inside_45.inside_Line_45[36].gameObject.SetActive(false);
        inside_45.inside_Line_45[37].gameObject.SetActive(false);
        inside_45.inside_Line_45[38].gameObject.SetActive(false);
        inside_45.inside_Line_45[39].gameObject.SetActive(false);
        inside_45.inside_Line_45[40].gameObject.SetActive(false);
        inside_45.inside_Line_45[41].gameObject.SetActive(false);
        inside_45.inside_Line_45[42].gameObject.SetActive(false);
        inside_45.inside_Line_45[43].gameObject.SetActive(false);
        inside_45.inside_Line_45[44].gameObject.SetActive(false);
        inside_45.inside_Line_45[45].gameObject.SetActive(false);
        inside_45.inside_Line_45[46].gameObject.SetActive(false);
        inside_45.inside_Line_45[47].gameObject.SetActive(false);
        inside_45.inside_Line_45[48].gameObject.SetActive(false);

        /*QuestObject.Line_Index = 93;

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

        Debug.Log("1번째 실행 완료");

    }

    public IEnumerator WaitSecond_1()//172-속마음
    {
        yield return new WaitForSeconds(3.0f);
        //Line_1.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_1_6_30_Index = 1;
        //inside6_2.inside_1_6_2[0].gameObject.SetActive(false);
        inside_1_6_30[1].gameObject.SetActive(true);
        inside_1_6_30[0].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_2()//173-속마음
    {
        yield return new WaitForSeconds(7.0f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);

        Line_1_6_30_Index = 2;
        inside_1_6_30[1].gameObject.SetActive(false);
        inside_1_6_30[2].gameObject.SetActive(true);

        //Sok_talk1.Sok_Talk_Index = 1;

        //Sok_talk1.Sok_talk[1].gameObject.SetActive(true);
        //Sok_talk1.Sok_talk[0].gameObject.SetActive(false);
        Debug.Log("2번째 실행 완료");
    }

    public IEnumerator WaitSecond_3()//174
    {
        yield return new WaitForSeconds(10.0f);

        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        Line_1_6_30_Index = 3;
        inside_1_6_30[3].gameObject.SetActive(true);
        inside_1_6_30[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -12100.95f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49856f);    //(오, 위)

    }

    public IEnumerator WaitSecond_4()//175
    {
        yield return new WaitForSeconds(11.5f);
        //Line_4.SetActive(true);

        Line_1_6_30_Index = 4;
        inside_1_6_30[4].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11758.09f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50198.86f);    //(오, 위)

    }



    public IEnumerator WaitSecond_5()//176-1
    {
        yield return new WaitForSeconds(13.0f);
        //Line_5.SetActive(true);

        Line_1_6_30_Index = 5;
        inside_1_6_30[5].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11468.19f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50488.76f);    //(오, 위)

    }

    public IEnumerator WaitSecond_6()//176-2
    {
        yield return new WaitForSeconds(14.5f);
        //Line_6.SetActive(true);

        Line_1_6_30_Index = 6;
        inside_1_6_30[6].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11247.98f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50708.96f);    //(오, 위)

    }

    public IEnumerator WaitSecond_7()//177
    {
        yield return new WaitForSeconds(16.0f);
        //Line_7.SetActive(true);

        Line_1_6_30_Index = 7;
        inside_1_6_30[7].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10960.88f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50996.07f);    //(오, 위)

    }

    public IEnumerator WaitSecond_8()//178-속마음
    {
        yield return new WaitForSeconds(18.0f);
        //Line_8.SetActive(true);
        Line_1_6_30_Index = 8;
        inside_1_6_30[8].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

    }

    public IEnumerator WaitSecond_9()//179-속마음
    {
        yield return new WaitForSeconds(22.0f);
        //Line_9.SetActive(true);
        //Line_8.SetActive(false);

        Line_1_6_30_Index = 9;
        inside_1_6_30[9].gameObject.SetActive(true);
        inside_1_6_30[8].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_10()//180
    {
        yield return new WaitForSeconds(25.0f);
        //Line_10.SetActive(true);
        //Line_9.SetActive(false);

        Line_1_6_30_Index = 10;
        inside_1_6_30[10].gameObject.SetActive(true);
        inside_1_6_30[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10618.02f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51338.93f);    //(오, -위)

    }

    public IEnumerator WaitSecond_11()//181-1
    {
        yield return new WaitForSeconds(26.5f);
        //Line_11.SetActive(true);

        Line_1_6_30_Index = 11;
        inside_1_6_30[11].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10330.91f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51626.04f);    //(오, 위)

    }

    public IEnumerator WaitSecond_12()//181-2
    {
        yield return new WaitForSeconds(28.0f);
        //Line_12.SetActive(true);

        Line_1_6_30_Index = 12;
        inside_1_6_30[12].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);

        //여기서 등장인물-사장 내용 풀기
        if (All_Save.Boss[1].gameObject.activeSelf == true)
        {//이미 사장을 오픈했다면
            //오픈한 그대로 둔다

            All_Save.Boss_Index = 1;
            All_Save.Boss[0].gameObject.SetActive(false);
            All_Save.Boss[1].gameObject.SetActive(true);

        }
        else
        {
            //사장이 오픈되지 못했다면 오픈한다
            All_Save.Boss_Index = 1;
            All_Save.Boss[0].gameObject.SetActive(false);
            All_Save.Boss[1].gameObject.SetActive(true);

        }

        // *** 사장님 보여준 거 자동저장 ***
        PlayerPrefs.SetInt("Boss", All_Save.Boss_Index);

        TextContainer1.offsetMin = new Vector2(0, -10175.7f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51781.25f);    //(오, 위)

    }

    public IEnumerator WaitSecond_13()//182
    {
        yield return new WaitForSeconds(29.5f);
        //Line_13.SetActive(true);

        Line_1_6_30_Index = 13;
        inside_1_6_30[13].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9874.654f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 52082.3f);    //(오, -위)

    }


    public IEnumerator WaitSecond_14()//183-속마음
    {
        yield return new WaitForSeconds(31.5f);
        //Line_14.SetActive(true);

        Line_1_6_30_Index = 14;
        inside_1_6_30[14].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_15()//184
    {
        yield return new WaitForSeconds(34.5f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_1_6_30_Index = 15;
        inside_1_6_30[15].gameObject.SetActive(true);
        inside_1_6_30[14].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -9673.957f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 52282.99f);    //(오, 위)

    }

    public IEnumerator WaitSecond_16()//185
    {
        yield return new WaitForSeconds(36.0f);
        //Line_16.SetActive(true);

        Line_1_6_30_Index = 16;
        inside_1_6_30[16].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9372.912f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 52584.04f);    //(오, 위)

    }

    public IEnumerator WaitSecond_17()//186-1
    {
        yield return new WaitForSeconds(37.5f);
        //Line_17.SetActive(true);

        Line_1_6_30_Index = 17;
        inside_1_6_30[17].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9024.48f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 52932.47f);    //(오, -위)
    }

    public IEnumerator WaitSecond_18()//186-2
    {
        yield return new WaitForSeconds(39.0f);
        //Line_18.SetActive(true);

        Line_1_6_30_Index = 18;
        inside_1_6_30[18].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -8868.383f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 53088.57f);    //(오, -위)
    }

    public IEnumerator WaitSecond_19()//187-1
    {
        yield return new WaitForSeconds(40.5f);

        //Line_19.SetActive(true);

        Line_1_6_30_Index = 19;
        inside_1_6_30[19].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8575.699f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 53381.25f);    //(오, -위)

    }

    public IEnumerator WaitSecond_20()//187-2
    {
        yield return new WaitForSeconds(42.0f);
        //Line_20.SetActive(true);

        Line_1_6_30_Index = 20;
        inside_1_6_30[20].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8430.752f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 53526.2f);    //(오, -위)

    }

    public IEnumerator WaitSecond_21()//188
    {
        yield return new WaitForSeconds(43.5f);
        //Line_21.SetActive(true);

        Line_1_6_30_Index = 21;
        inside_1_6_30[21].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8152.111f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 53804.84f);    //(오, -위)
    }

    public IEnumerator WaitSecond_22()//189-속마음//여기까지 했음
    {
        yield return new WaitForSeconds(45.5f);

        //Line_22.SetActive(true);

        Line_1_6_30_Index = 22;
        inside_1_6_30[22].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_23()//190-1
    {
        yield return new WaitForSeconds(48.5f);
        //Line_23.SetActive(true);
        //Line_22.SetActive(false);

        Line_1_6_30_Index = 23;
        inside_1_6_30[23].gameObject.SetActive(true);
        inside_1_6_30[22].gameObject.SetActive(false);



        TextContainer1.offsetMin = new Vector2(0, -7853.854f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 54103.09f);    //(오, -위)
    }

    public IEnumerator WaitSecond_24()//190-2
    {
        yield return new WaitForSeconds(50.0f);

        //Line_24.SetActive(true);

        Line_1_6_30_Index = 24;
        inside_1_6_30[24].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);
        TextContainer1.offsetMin = new Vector2(0, -7703.33f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 54253.62f);    //(오, -위)
    }

    public IEnumerator WaitSecond_25()//191
    {
        yield return new WaitForSeconds(51.5f);
        //Line_25.SetActive(true);


        Line_1_6_30_Index = 25;
        inside_1_6_30[25].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7414.016f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 54542.93f);    //(오, -위)

    }

    public IEnumerator WaitSecond_26()//192
    {
        yield return new WaitForSeconds(53.0f);

        Line_1_6_30_Index = 26;
        inside_1_6_30[26].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);
        //Line_26.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -7132.482f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 54824.47f);    //(오, -위)

    }

    public IEnumerator WaitSecond_27()//193-속마음
    {
        yield return new WaitForSeconds(55.0f);
        //Line_27.SetActive(true);
        Line_1_6_30_Index = 27;
        inside_1_6_30[27].gameObject.SetActive(true);

    }

    public IEnumerator WaitSecond_28()//194-속마음
    {
        yield return new WaitForSeconds(58.0f);
        //Line_28.SetActive(true);
        //Line_27.SetActive(false);

        Line_1_6_30_Index = 28;
        inside_1_6_30[28].gameObject.SetActive(true);
        inside_1_6_30[27].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_29()//195
    {
        yield return new WaitForSeconds(61.0f);
        //Line_29.SetActive(true);
        //Line_28.SetActive(false);

        Line_1_6_30_Index = 29;
        inside_1_6_30[29].gameObject.SetActive(true);
        inside_1_6_30[28].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -6836.037f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 55120.91f);    //(오, -위)

    }

    public IEnumerator WaitSecond_30()//196
    {
        yield return new WaitForSeconds(62.5f);
        //Line_30.SetActive(true);

        Line_1_6_30_Index = 30;
        inside_1_6_30[30].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[28].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6551.717f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 55405.23f);    //(오, -위)

    }

    public IEnumerator WaitSecond_31()//197-속마음
    {
        yield return new WaitForSeconds(64.5f);
        // Line_31.SetActive(true);

        Line_1_6_30_Index = 31;
        inside_1_6_30[31].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[28].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_32()//198-1
    {
        yield return new WaitForSeconds(67.5f);
        //Line_32.SetActive(true);
        // Line_31.SetActive(false);

        Line_1_6_30_Index = 32;
        inside_1_6_30[32].gameObject.SetActive(true);
        inside_1_6_30[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6200.975f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 55755.98f);    //(오, -위)


    }

    public IEnumerator WaitSecond_33()//198-2
    {

        yield return new WaitForSeconds(69.0f);

        //Line_33.SetActive(true);

        Line_1_6_30_Index = 33;
        inside_1_6_30[33].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -6042.09f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 55914.86f);    //(오, -위)


    }

    public IEnumerator WaitSecond_34()//199
    {
        //위치 좌표는 적기
        yield return new WaitForSeconds(70.5f);
        //Line_34.SetActive(true);

        Line_1_6_30_Index = 34;
        inside_1_6_30[34].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -5763.688f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 56193.26f);    //(오, -위)


    }

    public IEnumerator WaitSecond_35()//200-1

    {
        yield return new WaitForSeconds(72.0f);
        //Line_35.SetActive(true);

        Line_1_6_30_Index = 35;
        inside_1_6_30[35].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5471.004f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 56485.95f);    //(오, -위)

    }

    public IEnumerator WaitSecond_36()//200-2
    {
        yield return new WaitForSeconds(73.5f);
        //Line_36.SetActive(true);

        Line_1_6_30_Index = 36;
        inside_1_6_30[36].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5314.906f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 56642.04f);    //(오, -위)


    }

    public IEnumerator WaitSecond_37()//200-3
    {
        yield return new WaitForSeconds(75.0f);

        Line_1_6_30_Index = 37;
        inside_1_6_30[37].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

        //Line_37.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -5156.021f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 56800.93f);    //(오, -위)


    }

    public IEnumerator WaitSecond_38()//201
    {
        yield return new WaitForSeconds(76.5f);
        Line_1_6_30_Index = 38;
        inside_1_6_30[38].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);


        //Line_38.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4868.914f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 57088.04f);    //(오, -위)

    }


    public IEnumerator WaitSecond_39()//202-속마음
    {
        yield return new WaitForSeconds(78.5f);
        //Line_39.SetActive(true);
        Line_1_6_30_Index = 39;
        inside_1_6_30[39].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

    }

    public IEnumerator WaitSecond_40()//203-속마음
    {
        yield return new WaitForSeconds(81.5f);
        // Line_40.SetActive(true);
        //Line_39.SetActive(false);

        Line_1_6_30_Index = 40;
        inside_1_6_30[40].gameObject.SetActive(true);
        inside_1_6_30[39].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_41()//204-속마음
    {
        yield return new WaitForSeconds(84.5f);
        //Line_41.SetActive(true);
        //Line_40.SetActive(false);

        Line_1_6_30_Index = 41;
        inside_1_6_30[41].gameObject.SetActive(true);
        inside_1_6_30[40].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_42()//205-속마음
    {
        yield return new WaitForSeconds(87.5f);
        //Line_42.SetActive(true);
        // Line_41.SetActive(false);

        Line_1_6_30_Index = 42;
        inside_1_6_30[42].gameObject.SetActive(true);
        inside_1_6_30[41].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_43()//206-속마음
    {
        yield return new WaitForSeconds(90.5f);
        // Line_43.SetActive(true);
        //Line_42.SetActive(false);

        Line_1_6_30_Index = 43;
        inside_1_6_30[43].gameObject.SetActive(true);
        inside_1_6_30[42].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_44()//207-속마음
    {
        yield return new WaitForSeconds(94.5f);
        // Line_44.SetActive(true);
        // Line_43.SetActive(false);

        Line_1_6_30_Index = 44;
        inside_1_6_30[44].gameObject.SetActive(true);
        inside_1_6_30[43].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_45()//208-속마음
    {
        yield return new WaitForSeconds(98.5f);
        //Line_45.SetActive(true);
        //Line_44.SetActive(false);

        Line_1_6_30_Index = 45;
        inside_1_6_30[45].gameObject.SetActive(true);
        inside_1_6_30[44].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_46()//209-1
    {
        yield return new WaitForSeconds(101.5f);
        // Line_46.SetActive(true);
        // Line_45.SetActive(false);

        Line_1_6_30_Index = 46;
        inside_1_6_30[46].gameObject.SetActive(true);
        inside_1_6_30[45].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4576.23f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 57380.72f);    //(오, -위)

    }

    public IEnumerator WaitSecond_47()//209-2
    {
        yield return new WaitForSeconds(103.0f);
        //Line_47.SetActive(true);


        Line_1_6_30_Index = 47;
        inside_1_6_30[47].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4422.92f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 57534.03f);    //(오, -위)

    }

    public IEnumerator WaitSecond_48()//209-3
    {
        yield return new WaitForSeconds(104.5f);
        //Line_48.SetActive(true);

        Line_1_6_30_Index = 48;
        inside_1_6_30[48].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4265.586f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 57691.36f);    //(오, -위)

    }

    public IEnumerator WaitSecond_49()//210
    {
        yield return new WaitForSeconds(106.0f);
        //Line_49.SetActive(true);

        Line_1_6_30_Index = 4;
        inside_1_6_30[49].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4053.738f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 57903.21f);    //(오, -위)

    }

    public IEnumerator WaitSecond_50()//211
    {
        yield return new WaitForSeconds(107.5f);
        //Line_50.SetActive(true);

        Line_1_6_30_Index = 50;
        inside_1_6_30[50].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3749.906f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 58207.04f);    //(오, -위)

    }

    public IEnumerator WaitSecond_51()//212
    {
        yield return new WaitForSeconds(109.0f);
        //Line_51.SetActive(true);

        Line_1_6_30_Index = 51;
        inside_1_6_30[51].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        //여기서 등장인물-소리 내용 풀기
        if (All_Save.Sori[1].gameObject.activeSelf == true)
        {//이미 소리를 오픈했다면
            //오픈한 그대로 둔다

            All_Save.Sori_Index = 1;
            All_Save.Sori[0].gameObject.SetActive(false);
            All_Save.Sori[1].gameObject.SetActive(true);

        }
        else
        {
            //소리기 오픈되지 못했다면 오픈한다
            All_Save.Sori_Index = 1;
            All_Save.Sori[0].gameObject.SetActive(false);
            All_Save.Sori[1].gameObject.SetActive(true);

        }

        // *** 소리 보여준 거 자동저장 ***
        PlayerPrefs.SetInt("Sori", All_Save.Sori_Index);

        TextContainer1.offsetMin = new Vector2(0, -3465.586f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 58491.36f);    //(오, -위)

    }

    public IEnumerator WaitSecond_52()//213
    {
        yield return new WaitForSeconds(110.5f);
        //Line_52.SetActive(true);
        sfx5.Play();
        Line_1_6_30_Index = 52;
        inside_1_6_30[52].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3250.951f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 58706.0f);    //(오, -위)

    }

    public IEnumerator WaitSecond_53()//214
    {
        yield return new WaitForSeconds(112.0f);
        // Line_53.SetActive(true);

        Line_1_6_30_Index = 53;
        inside_1_6_30[53].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2938.756f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 59018.2f);    //(오, -위)


    }

    public IEnumerator WaitSecond_54()//215
    {
        yield return new WaitForSeconds(113.5f);
        //Line_54.SetActive(true);

        Line_1_6_30_Index = 54;
        inside_1_6_30[54].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -2242.148f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 59714.8f);    //(오, -위)

    }

    public IEnumerator WaitSecond_55()//216
    {
        yield return new WaitForSeconds(115.0f);
        //Line_55.SetActive(true);

        Line_1_6_30_Index = 55;
        inside_1_6_30[55].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1943.891f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 60013.06f);    //(오, -위)

    }

    public IEnumerator WaitSecond_56()//217
    {
        yield return new WaitForSeconds(116.5f);
        // Line_56.SetActive(true);

        Line_1_6_30_Index = 56;
        inside_1_6_30[56].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1653.994f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 60302.95f);    //(오, -위)

    }

    public IEnumerator WaitSecond_57()//218
    {
        yield return new WaitForSeconds(118.0f);
        //Line_57.SetActive(true);

        Line_1_6_30_Index = 57;
        inside_1_6_30[57].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1444.936f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 60512.02f);    //(오, -위)


    }

    public IEnumerator WaitSecond_58()//219-속마음
    {
        yield return new WaitForSeconds(120.0f);
        //Line_58.SetActive(true);

        Line_1_6_30_Index = 58;
        inside_1_6_30[58].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_59()//220-속마음
    {
        yield return new WaitForSeconds(123.0f);
        //Line_59.SetActive(true);
        //Line_58.SetActive(false);

        Line_1_6_30_Index = 59;
        inside_1_6_30[59].gameObject.SetActive(true);
        inside_1_6_30[58].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_60()//221-속마음
    {
        yield return new WaitForSeconds(126.0f);
        //Line_60.SetActive(true);
        // Line_59.SetActive(false);

        Line_1_6_30_Index = 60;
        inside_1_6_30[60].gameObject.SetActive(true);
        inside_1_6_30[59].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_61()//222-속마음
    {
        yield return new WaitForSeconds(129.5f);
        //Line_61.SetActive(true);
        //Line_60.SetActive(false);

        Line_1_6_30_Index = 61;
        inside_1_6_30[61].gameObject.SetActive(true);
        inside_1_6_30[60].gameObject.SetActive(false);
    }

    public IEnumerator WaitSecond_62()//223-속마음
    {
        yield return new WaitForSeconds(132.5f);
        // Line_62.SetActive(true);
        // Line_61.SetActive(false);

        Line_1_6_30_Index = 62;
        inside_1_6_30[62].gameObject.SetActive(true);
        inside_1_6_30[61].gameObject.SetActive(false);

    }

    public IEnumerator WaitSecond_63()//224
    {
        yield return new WaitForSeconds(135.5f);
        //Line_63.SetActive(true);
        //Line_62.SetActive(false);

        sfx6.Play();

        Line_1_6_30_Index = 63;
        inside_1_6_30[63].gameObject.SetActive(true);
        inside_1_6_30[62].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1247.025f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 60709.92f);    //(오, -위)

    }

    public IEnumerator WaitSecond_64()//225
    {
        yield return new WaitForSeconds(137.0f);
        // Line_64.SetActive(true);

        Line_1_6_30_Index = 64;
        inside_1_6_30[64].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -948.7676f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 61008.18f);    //(오, -위)
    }

    public IEnumerator WaitSecond_65()//226-1
    {
        yield return new WaitForSeconds(138.5f);
        //Line_65.SetActive(true);

        Line_1_6_30_Index = 65;
        inside_1_6_30[65].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -650.5098f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 61306.44f);    //(오, -위)

    }

    public IEnumerator WaitSecond_66()//226-2
    {
        yield return new WaitForSeconds(140.0f);
        //Line_66.SetActive(true);

        Line_1_6_30_Index = 66;
        inside_1_6_30[66].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);

        // *** 첫 번째 업적 보여주기 ***

        if (All_Save.Achieve_1[2].gameObject.activeSelf == true)
        {
            All_Save.Achieve1_Index = 2;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(true);


        }
        else
        {
            All_Save.Achieve1_Index = 2;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(true);
        }

        // *** 첫 번째 업적 보여준 거 자동저장 ***
        PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

        TextContainer1.offsetMin = new Vector2(0, -430.3008f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 61526.65f);    //(오, -위)



    }
    public IEnumerator WaitSecond_67()//227
    {
        yield return new WaitForSeconds(141.5f);
        //Line_67.SetActive(true);

        Line_1_6_30_Index = 67;
        inside_1_6_30[67].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -229.6035f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 61727.34f);    //(오, -위)

    }

    public IEnumerator WaitSecond_68()//228
    {
        yield return new WaitForSeconds(143.0f);
        //Line_68.SetActive(true);

        Line_1_6_30_Index = 68;
        inside_1_6_30[68].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);

        //여기서 업적이 달성되었습니다 창이 나와야 함!
        //<업적 달성되었습니다 창이 나와야 합니다.>
        /*if (Ending3.activeSelf == false)
        {
            //첫 번째 엔딩이 활성화 되지 않았을 경우에
            Ending3.SetActive(true);
            Achieve_Obj.SetActive(true);
            //활성화 시킨다.
            //게임 오브젝트도 보이게 한다.
            Achieve.SetBool("A_Button", true);
            //업적 달성 애니메이션도 실행한다.
        }*/

        // *** 여기서 세 번째 엔딩 관련 ***
        if (All_Save.Ending3[1].gameObject.activeSelf == true)
        {//이미 세 번째 엔딩을 오픈했다면
            //오픈한 그대로 둔다

            All_Save.Ending3_Index = 1;
            All_Save.Ending3[0].gameObject.SetActive(false);
            All_Save.Ending3[1].gameObject.SetActive(true);

            //10번 업적(3번 엔딩)을 오픈한다.
            All_Save.Achieve10_Index = 2;
            All_Save.Achieve_10[0].gameObject.SetActive(false);
            All_Save.Achieve_10[1].gameObject.SetActive(false);
            All_Save.Achieve_10[2].gameObject.SetActive(true);

        }

        //세 번째 엔딩이 오픈되어 있지 않으면
        else if (All_Save.Ending3[1].gameObject.activeSelf == false)
        {
            //세 번째 엔딩이 오픈되지 못했다면 오픈한다
            All_Save.Ending3_Index = 1;
            All_Save.Ending3[0].gameObject.SetActive(false);
            All_Save.Ending3[1].gameObject.SetActive(true);

            Achieve_Obj.SetActive(true);
            //활성화 시킨다.
            //게임 오브젝트도 보이게 한다.
            Achieve.SetBool("A_Button", true);
            //업적 달성 애니메이션도 실행한다.

            //10번 업적(3번 엔딩)을 오픈한다.
            All_Save.Achieve10_Index = 2;
            All_Save.Achieve_10[0].gameObject.SetActive(false);
            All_Save.Achieve_10[1].gameObject.SetActive(false);
            All_Save.Achieve_10[2].gameObject.SetActive(true);

        }

        //세 번째 엔딩 관련하여 자동 저장
        PlayerPrefs.SetInt("Thrid_Ending", All_Save.Ending3_Index);

        //10번 업적(3번 엔딩 관련) 하여 자동 저장
        PlayerPrefs.SetInt("Achieve_10", All_Save.Achieve10_Index);

        //11번 앨범(3번 엔딩) 오픈 관련
        if (All_Save.Album_11[2].gameObject.activeSelf == true)
        {//이미 11번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album11_Index = 2;
            All_Save.Album_11[0].gameObject.SetActive(false);
            All_Save.Album_11[1].gameObject.SetActive(false);
            All_Save.Album_11[2].gameObject.SetActive(true);

        }

        //11번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_11[2].gameObject.activeSelf == false)
        {
            //11번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album11_Index = 2;
            All_Save.Album_11[0].gameObject.SetActive(false);
            All_Save.Album_11[1].gameObject.SetActive(false);
            All_Save.Album_11[2].gameObject.SetActive(true);

        }

        //11 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_11", All_Save.Album11_Index);

        TextContainer1.offsetMin = new Vector2(0, 0.02148438f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 61956.97f);    //(오, -위)

    }

    public IEnumerator Wait_4_Second_Achivement()
    {
        //업적 달성 애니메이션 FALSE하기 위해 새로 만듦
        //업적 달성 애니 나오고 나서 3초 후에 위로 올라감
        yield return new WaitForSeconds(147.0f);

        //평소라면 3초 후에 위로 올라가는 애니메이션 실행하고

        if (Achieve.GetCurrentAnimatorStateInfo(0).IsName("Down"))
        {
            Achieve.SetBool("A_Button", false);
        }

        //만약 이미 얇은 X버튼을 눌러서 올라가는 애니메이션이 실행되었다면
        //게임 오브젝트 안보이게

        if (Achieve.GetCurrentAnimatorStateInfo(0).IsName("Up"))
        {
            Achieve_Obj.SetActive(false);
        }

    }

    public IEnumerator Wait_One_Second()
    {
        yield return new WaitForSeconds(148.0f);
        Achieve_Obj.SetActive(false);
    }

    public IEnumerator WaitSecond_69()//없음->검
    {
        yield return new WaitForSeconds(145.0f);
        //Go_Black.SetActive(true);

        //밑에거 원래 쓰는 건데 확인차 안씀
        FadeObject.Fade_Index = 9;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(false);
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(true);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_70()//다른 곳으로 이동
    {
        //m_IsCoroutineing = true;

        Debug.Log("시작");


        yield return new WaitForSeconds(148.0f);
        //Go_Ch1_Picture.SetActive(true);

        QuestObject.Line_Index = 148;
        QuestObject.questObject[148].gameObject.SetActive(true);
        //QuestObject.questObject[0].gameObject.SetActive(false);
        Ch1_P.Picture_Coroutine = Ch1_P.WaitSecond_New();
        StartCoroutine(Ch1_P.Picture_Coroutine);
        Debug.Log("그림 리셋하자");

        /*if(Ch1_P.m_IsCoroutineing==true)//코루틴이 이제 막 시작되었을 경우
        {

        }*/

        /*if(Ch1_P.m_IsCoroutineing==false && Ch1_Text.m_IsCoroutineing == false)//코루틴이 종료되었을 경우
        {
            QuestObject.Line_Index = 127;
            QuestObject.questObject[127].gameObject.SetActive(true);

            Ch1_P.Picture_Coroutine = Ch1_P.WaitSecond_New();
            StartCoroutine(Ch1_P.Picture_Coroutine);
            Debug.Log("그림 리셋하자");


            Ch1_Text.Picture_Text = Ch1_Text.WaitSecond_0();
            StartCoroutine(Ch1_Text.Picture_Text);
            Debug.Log("그림 글씨도 리셋하자");

           
        }

        else//코루틴이 시작되지 않았을 경우
        {
            QuestObject.Line_Index = 127;

            QuestObject.questObject[127].gameObject.SetActive(true);


            
        }*/







        //127은 원래 해보는 거

        //QuestObject.questObject[0].gameObject.SetActive(false);
        //  Remove_1_6_1_Line.SetActive(false);


        Line_1_6_30_Index = 0;

        inside_1_6_30[0].gameObject.SetActive(false);
        inside_1_6_30[1].gameObject.SetActive(false);
        inside_1_6_30[2].gameObject.SetActive(false);
        inside_1_6_30[3].gameObject.SetActive(false);
        inside_1_6_30[4].gameObject.SetActive(false);
        inside_1_6_30[5].gameObject.SetActive(false);
        inside_1_6_30[6].gameObject.SetActive(false);
        inside_1_6_30[7].gameObject.SetActive(false);
        inside_1_6_30[8].gameObject.SetActive(false);
        inside_1_6_30[9].gameObject.SetActive(false);
        inside_1_6_30[10].gameObject.SetActive(false);
        inside_1_6_30[11].gameObject.SetActive(false);
        inside_1_6_30[12].gameObject.SetActive(false);
        inside_1_6_30[13].gameObject.SetActive(false);
        inside_1_6_30[14].gameObject.SetActive(false);
        inside_1_6_30[15].gameObject.SetActive(false);
        inside_1_6_30[16].gameObject.SetActive(false);
        inside_1_6_30[17].gameObject.SetActive(false);
        inside_1_6_30[18].gameObject.SetActive(false);
        inside_1_6_30[19].gameObject.SetActive(false);
        inside_1_6_30[20].gameObject.SetActive(false);
        inside_1_6_30[21].gameObject.SetActive(false);
        inside_1_6_30[22].gameObject.SetActive(false);
        inside_1_6_30[23].gameObject.SetActive(false);
        inside_1_6_30[24].gameObject.SetActive(false);
        inside_1_6_30[25].gameObject.SetActive(false);
        inside_1_6_30[26].gameObject.SetActive(false);
        inside_1_6_30[27].gameObject.SetActive(false);
        inside_1_6_30[28].gameObject.SetActive(false);
        inside_1_6_30[29].gameObject.SetActive(false);
        inside_1_6_30[30].gameObject.SetActive(false);
        inside_1_6_30[31].gameObject.SetActive(false);
        inside_1_6_30[32].gameObject.SetActive(false);
        inside_1_6_30[33].gameObject.SetActive(false);
        inside_1_6_30[34].gameObject.SetActive(false);
        inside_1_6_30[35].gameObject.SetActive(false);
        inside_1_6_30[36].gameObject.SetActive(false);
        inside_1_6_30[37].gameObject.SetActive(false);
        inside_1_6_30[38].gameObject.SetActive(false);
        inside_1_6_30[39].gameObject.SetActive(false);
        inside_1_6_30[40].gameObject.SetActive(false);
        inside_1_6_30[41].gameObject.SetActive(false);
        inside_1_6_30[42].gameObject.SetActive(false);
        inside_1_6_30[43].gameObject.SetActive(false);
        inside_1_6_30[44].gameObject.SetActive(false);
        inside_1_6_30[45].gameObject.SetActive(false);
        inside_1_6_30[46].gameObject.SetActive(false);
        inside_1_6_30[47].gameObject.SetActive(false);
        inside_1_6_30[48].gameObject.SetActive(false);
        inside_1_6_30[49].gameObject.SetActive(false);
        inside_1_6_30[50].gameObject.SetActive(false);
        inside_1_6_30[51].gameObject.SetActive(false);
        inside_1_6_30[52].gameObject.SetActive(false);
        inside_1_6_30[53].gameObject.SetActive(false);
        inside_1_6_30[54].gameObject.SetActive(false);
        inside_1_6_30[55].gameObject.SetActive(false);
        inside_1_6_30[56].gameObject.SetActive(false);
        inside_1_6_30[57].gameObject.SetActive(false);
        inside_1_6_30[58].gameObject.SetActive(false);
        inside_1_6_30[59].gameObject.SetActive(false);
        inside_1_6_30[60].gameObject.SetActive(false);
        inside_1_6_30[61].gameObject.SetActive(false);
        inside_1_6_30[62].gameObject.SetActive(false);
        inside_1_6_30[63].gameObject.SetActive(false);
        inside_1_6_30[64].gameObject.SetActive(false);
        inside_1_6_30[65].gameObject.SetActive(false);
        inside_1_6_30[66].gameObject.SetActive(false);
        inside_1_6_30[67].gameObject.SetActive(false);
        inside_1_6_30[68].gameObject.SetActive(false);


        //m_IsCoroutineing = false;
        Debug.Log("멈춰");

        


        //Ch1_Text.Picture_Text = Ch1_Text.WaitSecond_0();
        //StartCoroutine(Ch1_Text.Picture_Text);
        //Debug.Log("그림 글씨도 리셋하자");

        /*if (Ch1_P.m_IsCoroutineing == false && Ch1_Text.m_IsCoroutineing == false)//코루틴이 종료되었을 경우
        {
            QuestObject.Line_Index = 127;
            QuestObject.questObject[127].gameObject.SetActive(true);

            Ch1_P.Picture_Coroutine = Ch1_P.WaitSecond_New();
            StartCoroutine(Ch1_P.Picture_Coroutine);
            Debug.Log("그림 리셋하자");


            Ch1_Text.Picture_Text = Ch1_Text.WaitSecond_0();
            StartCoroutine(Ch1_Text.Picture_Text);
            Debug.Log("그림 글씨도 리셋하자");


        }

        else//코루틴이 시작되지 않았을 경우
        {
            QuestObject.Line_Index = 127;

            QuestObject.questObject[127].gameObject.SetActive(true);



        }*/


    }

    /*public IEnumerator WaitSecond_80()//지금 재시작 되는지 확인차 보는 거임
        {//재시작 됨!

        

        m_IsCoroutineing = true;

        Debug.Log("시작");
            
        yield return new WaitForSeconds(145.0f);
        Debug.Log("종료");
        m_IsCoroutineing = false;
        Debug.Log("멈춰");



        
        Debug.Log("다시 시작이야");

        m_Coroutine = WaitSecond_0();//요거하고
        StartCoroutine(m_Coroutine);//요거가 재시작



    }*/



    /*IEnumerator WaitSecond_72()//134-속마음
    {
        yield return new WaitForSeconds(126.0f);
        Line_67.SetActive(true);
        Line_66.SetActive(false);


    }

    IEnumerator WaitSecond_73()//135-속마음
    {
        yield return new WaitForSeconds(130.0f);
        Line_68.SetActive(true);
        Line_67.SetActive(false);


    }

    IEnumerator WaitSecond_74()//136-속마음
    {
        yield return new WaitForSeconds(133.0f);
        Line_69.SetActive(true);
        Line_68.SetActive(false);


    }

    IEnumerator WaitSecond_75()//137-선택지
    {
        yield return new WaitForSeconds(135.5f);
        Line_70.SetActive(true);
        Line_69.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.03515625f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40075.63f);    //(오, -위)

    }*/



}
