using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class R_Wait1_6_41 : MonoBehaviour
{
    public Save_Collection All_Save;
    public AudioSource sfx5;
    public AudioSource sfx6;
    public GameObject[] inside_1_6_41;
    public int Line_1_6_41_Index;

    public R_Wait1_5_21 inside_53;

    public Picture2 Ch1_P;


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

    public IEnumerator WaitSecond_1()//172-속마음
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

        Line_1_6_41_Index = 0;
        //inside6_2.inside_1_6_2[0].gameObject.SetActive(false);
        inside_1_6_41[0].gameObject.SetActive(true);

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

        TextContainer1.offsetMin = new Vector2(0, -12421.25f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51651.55f);    //(오, 위)

        inside_53.Line_53_Index = 0;
        inside_53.inside_Line_53[0].gameObject.SetActive(false);
        inside_53.inside_Line_53[1].gameObject.SetActive(false);
        inside_53.inside_Line_53[2].gameObject.SetActive(false);
        inside_53.inside_Line_53[3].gameObject.SetActive(false);
        inside_53.inside_Line_53[4].gameObject.SetActive(false);
        inside_53.inside_Line_53[5].gameObject.SetActive(false);
        inside_53.inside_Line_53[6].gameObject.SetActive(false);
        inside_53.inside_Line_53[7].gameObject.SetActive(false);
        inside_53.inside_Line_53[8].gameObject.SetActive(false);
        inside_53.inside_Line_53[9].gameObject.SetActive(false);
        inside_53.inside_Line_53[10].gameObject.SetActive(false);
        inside_53.inside_Line_53[11].gameObject.SetActive(false);
        inside_53.inside_Line_53[12].gameObject.SetActive(false);
        inside_53.inside_Line_53[13].gameObject.SetActive(false);
        inside_53.inside_Line_53[14].gameObject.SetActive(false);
        inside_53.inside_Line_53[15].gameObject.SetActive(false);
        inside_53.inside_Line_53[16].gameObject.SetActive(false);
        inside_53.inside_Line_53[17].gameObject.SetActive(false);
        inside_53.inside_Line_53[18].gameObject.SetActive(false);
        inside_53.inside_Line_53[19].gameObject.SetActive(false);
        inside_53.inside_Line_53[20].gameObject.SetActive(false);
        inside_53.inside_Line_53[21].gameObject.SetActive(false);
        inside_53.inside_Line_53[22].gameObject.SetActive(false);
        inside_53.inside_Line_53[23].gameObject.SetActive(false);
        inside_53.inside_Line_53[24].gameObject.SetActive(false);
        inside_53.inside_Line_53[25].gameObject.SetActive(false);
        inside_53.inside_Line_53[26].gameObject.SetActive(false);
        inside_53.inside_Line_53[27].gameObject.SetActive(false);
        inside_53.inside_Line_53[28].gameObject.SetActive(false);
        inside_53.inside_Line_53[29].gameObject.SetActive(false);
        inside_53.inside_Line_53[30].gameObject.SetActive(false);
        inside_53.inside_Line_53[31].gameObject.SetActive(false);
        inside_53.inside_Line_53[32].gameObject.SetActive(false);
        inside_53.inside_Line_53[33].gameObject.SetActive(false);
        inside_53.inside_Line_53[34].gameObject.SetActive(false);
        inside_53.inside_Line_53[35].gameObject.SetActive(false);
        inside_53.inside_Line_53[36].gameObject.SetActive(false);
        inside_53.inside_Line_53[37].gameObject.SetActive(false);
        inside_53.inside_Line_53[38].gameObject.SetActive(false);
        inside_53.inside_Line_53[39].gameObject.SetActive(false);
        inside_53.inside_Line_53[40].gameObject.SetActive(false);
        inside_53.inside_Line_53[41].gameObject.SetActive(false);
        inside_53.inside_Line_53[42].gameObject.SetActive(false);
        inside_53.inside_Line_53[43].gameObject.SetActive(false);
        inside_53.inside_Line_53[44].gameObject.SetActive(false);
        inside_53.inside_Line_53[45].gameObject.SetActive(false);
        inside_53.inside_Line_53[46].gameObject.SetActive(false);
        inside_53.inside_Line_53[47].gameObject.SetActive(false);
        inside_53.inside_Line_53[48].gameObject.SetActive(false);

        /*QuestObject.Line_Index = 121;

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

    public IEnumerator WaitSecond_2()//173-속마음
    {
        yield return new WaitForSeconds(3.0f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_1_6_41_Index = 1;
        inside_1_6_41[0].gameObject.SetActive(false);
        inside_1_6_41[1].gameObject.SetActive(true);

        //Sok_talk1.Sok_Talk_Index = 1;

        //Sok_talk1.Sok_talk[1].gameObject.SetActive(true);
        //Sok_talk1.Sok_talk[0].gameObject.SetActive(false);
        Debug.Log("2번째 실행 완료");
    }

    public IEnumerator WaitSecond_3()//174
    {
        yield return new WaitForSeconds(6.0f);

        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        Line_1_6_41_Index = 2;
        inside_1_6_41[2].gameObject.SetActive(true);
        inside_1_6_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -12072.82f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51999.98f);    //(오, 위)

    }

    public IEnumerator WaitSecond_4()//175
    {
        yield return new WaitForSeconds(7.5f);
        //Line_4.SetActive(true);

        Line_1_6_41_Index = 3;
        inside_1_6_41[3].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11727.17f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 52345.63f);    //(오, 위)

    }



    public IEnumerator WaitSecond_5()//176-1
    {
        yield return new WaitForSeconds(9.0f);
        //Line_5.SetActive(true);

        Line_1_6_41_Index = 4;
        inside_1_6_41[4].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11437.28f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 52635.52f);    //(오, 위)

    }

    public IEnumerator WaitSecond_6()//176-2
    {
        yield return new WaitForSeconds(10.5f);
        //Line_6.SetActive(true);

        Line_1_6_41_Index = 5;
        inside_1_6_41[5].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11217.07f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 52855.73f);    //(오, 위)

    }

    public IEnumerator WaitSecond_7()//177
    {
        yield return new WaitForSeconds(12.0f);
        //Line_7.SetActive(true);

        Line_1_6_41_Index = 6;
        inside_1_6_41[6].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10929.96f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 53142.84f);    //(오, 위)

    }

    public IEnumerator WaitSecond_8()//178-속마음
    {
        yield return new WaitForSeconds(14.0f);
        //Line_8.SetActive(true);
        Line_1_6_41_Index = 7;
        inside_1_6_41[7].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

    }

    public IEnumerator WaitSecond_9()//179-속마음
    {
        yield return new WaitForSeconds(18.0f);
        //Line_9.SetActive(true);
        //Line_8.SetActive(false);

        Line_1_6_41_Index = 8;
        inside_1_6_41[8].gameObject.SetActive(true);
        inside_1_6_41[7].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_10()//180
    {
        yield return new WaitForSeconds(21.0f);
        //Line_10.SetActive(true);
        //Line_9.SetActive(false);

        Line_1_6_41_Index = 9;
        inside_1_6_41[9].gameObject.SetActive(true);
        inside_1_6_41[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10589.86f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 53482.94f);    //(오, -위)

    }

    public IEnumerator WaitSecond_11()//181-1
    {
        yield return new WaitForSeconds(22.5f);
        //Line_11.SetActive(true);

        Line_1_6_41_Index = 10;
        inside_1_6_41[10].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10299.96f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 53772.84f);    //(오, 위)

    }

    public IEnumerator WaitSecond_12()//181-2
    {
        yield return new WaitForSeconds(24.0f);
        //Line_12.SetActive(true);

        Line_1_6_41_Index = 11;
        inside_1_6_41[11].gameObject.SetActive(true);
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
        TextContainer1.offsetMin = new Vector2(0, -10143.87f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 53928.93f);    //(오, 위)

    }

    public IEnumerator WaitSecond_13()//182=> 좌표 찾아야 함 ㅜㅠ
    {
        yield return new WaitForSeconds(25.5f);
        //Line_13.SetActive(true);

        Line_1_6_41_Index = 12;
        inside_1_6_41[12].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9848.396f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 54224.41f);    //(오, -위)

    }


    public IEnumerator WaitSecond_14()//183-속마음
    {
        yield return new WaitForSeconds(27.5f);
        //Line_14.SetActive(true);

        Line_1_6_41_Index = 13;
        inside_1_6_41[13].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_15()//184
    {
        yield return new WaitForSeconds(30.5f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_1_6_41_Index = 14;
        inside_1_6_41[14].gameObject.SetActive(true);
        inside_1_6_41[13].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -9636.549f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 54436.25f);    //(오, 위)

    }

    public IEnumerator WaitSecond_16()//185
    {
        yield return new WaitForSeconds(32.0f);
        //Line_16.SetActive(true);

        Line_1_6_41_Index = 15;
        inside_1_6_41[15].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9343.865f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 54728.94f);    //(오, 위)

    }

    public IEnumerator WaitSecond_17()//186-1
    {
        yield return new WaitForSeconds(33.5f);
        //Line_17.SetActive(true);

        Line_1_6_41_Index = 16;
        inside_1_6_41[16].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8992.646f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 55080.16f);    //(오, -위)
    }

    public IEnumerator WaitSecond_18()//186-2
    {
        yield return new WaitForSeconds(35.0f);
        //Line_18.SetActive(true);

        Line_1_6_41_Index = 17;
        inside_1_6_41[17].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -8833.762f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 55239.04f);    //(오, -위)
    }

    public IEnumerator WaitSecond_19()//187-1
    {
        yield return new WaitForSeconds(36.5f);

        //Line_19.SetActive(true);

        Line_1_6_41_Index = 18;
        inside_1_6_41[18].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8546.654f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 55526.15f);    //(오, -위)

    }

    public IEnumerator WaitSecond_20()//187-2
    {
        yield return new WaitForSeconds(38.0f);
        //Line_20.SetActive(true);

        Line_1_6_41_Index = 19;
        inside_1_6_41[19].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8401.748f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 55671.05f);    //(오, -위)

    }

    public IEnumerator WaitSecond_21()//188
    {
        yield return new WaitForSeconds(39.5f);
        //Line_21.SetActive(true);

        Line_1_6_41_Index = 20;
        inside_1_6_41[20].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8111.854f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 55960.95f);    //(오, -위)
    }

    public IEnumerator WaitSecond_22()//189-속마음//여기까지 했음
    {
        yield return new WaitForSeconds(41.5f);

        //Line_22.SetActive(true);

        Line_1_6_41_Index = 21;
        inside_1_6_41[21].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_23()//190-1
    {
        yield return new WaitForSeconds(44.5f);
        //Line_23.SetActive(true);
        //Line_22.SetActive(false);

        Line_1_6_41_Index = 22;
        inside_1_6_41[22].gameObject.SetActive(true);
        inside_1_6_41[21].gameObject.SetActive(false);



        TextContainer1.offsetMin = new Vector2(0, -7827.533f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 56245.27f);    //(오, -위)
    }

    public IEnumerator WaitSecond_24()//190-2
    {
        yield return new WaitForSeconds(46.0f);

        //Line_24.SetActive(true);

        Line_1_6_41_Index = 23;
        inside_1_6_41[23].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);
        TextContainer1.offsetMin = new Vector2(0, -7671.436f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 56401.37f);    //(오, -위)
    }

    public IEnumerator WaitSecond_25()//191
    {
        yield return new WaitForSeconds(47.5f);
        //Line_25.SetActive(true);


        Line_1_6_41_Index = 24;
        inside_1_6_41[24].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7384.328f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 56688.47f);    //(오, -위)

    }

    public IEnumerator WaitSecond_26()//192
    {
        yield return new WaitForSeconds(49.0f);

        Line_1_6_41_Index = 25;
        inside_1_6_41[25].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);
        //Line_26.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -7100.008f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 56972.79f);    //(오, -위)

    }

    public IEnumerator WaitSecond_27()//193-속마음
    {
        yield return new WaitForSeconds(51.0f);
        //Line_27.SetActive(true);
        Line_1_6_41_Index = 26;
        inside_1_6_41[26].gameObject.SetActive(true);

    }

    public IEnumerator WaitSecond_28()//194-속마음
    {
        yield return new WaitForSeconds(54.0f);
        //Line_28.SetActive(true);
        //Line_27.SetActive(false);

        Line_1_6_41_Index = 27;
        inside_1_6_41[27].gameObject.SetActive(true);
        inside_1_6_41[26].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_29()//195
    {
        yield return new WaitForSeconds(57.0f);
        //Line_29.SetActive(true);
        //Line_28.SetActive(false);

        Line_1_6_41_Index = 28;
        inside_1_6_41[28].gameObject.SetActive(true);
        inside_1_6_41[27].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -6801.75f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 57271.05f);    //(오, -위)

    }

    public IEnumerator WaitSecond_30()//196
    {
        yield return new WaitForSeconds(58.5f);
        //Line_30.SetActive(true);

        Line_1_6_41_Index = 29;
        inside_1_6_41[29].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[28].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6517.43f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 57555.37f);    //(오, -위)

    }

    public IEnumerator WaitSecond_31()//197-속마음
    {
        yield return new WaitForSeconds(60.5f);
        // Line_31.SetActive(true);

        Line_1_6_41_Index = 30;
        inside_1_6_41[30].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[28].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_32()//198-1
    {
        yield return new WaitForSeconds(63.5f);
        //Line_32.SetActive(true);
        // Line_31.SetActive(false);

        Line_1_6_41_Index = 31;
        inside_1_6_41[31].gameObject.SetActive(true);
        inside_1_6_41[30].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6166.211f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 57906.59f);    //(오, -위)


    }

    public IEnumerator WaitSecond_33()//198-2
    {

        yield return new WaitForSeconds(65.0f);

        //Line_33.SetActive(true);

        Line_1_6_41_Index = 32;
        inside_1_6_41[32].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -6010.113f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 58062.69f);    //(오, -위)


    }

    public IEnumerator WaitSecond_34()//199
    {
        //위치 좌표는 적기
        yield return new WaitForSeconds(66.5f);
        //Line_34.SetActive(true);

        Line_1_6_41_Index = 33;
        inside_1_6_41[33].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -5731.367f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 58341.43f);    //(오, -위)


    }

    public IEnumerator WaitSecond_35()//200-1

    {
        yield return new WaitForSeconds(68.0f);
        //Line_35.SetActive(true);

        Line_1_6_41_Index = 34;
        inside_1_6_41[34].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5438.684f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 58634.12f);    //(오, -위)

    }

    public IEnumerator WaitSecond_36()//200-2
    {
        yield return new WaitForSeconds(69.5f);
        //Line_36.SetActive(true);

        Line_1_6_41_Index = 35;
        inside_1_6_41[35].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5282.586f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 58790.21f);    //(오, -위)


    }

    public IEnumerator WaitSecond_37()//200-3
    {
        yield return new WaitForSeconds(71.0f);

        Line_1_6_41_Index = 36;
        inside_1_6_41[36].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

        //Line_37.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -5120.912f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 58951.89f);    //(오, -위)


    }

    public IEnumerator WaitSecond_38()//201
    {
        yield return new WaitForSeconds(72.5f);
        Line_1_6_41_Index = 37;
        inside_1_6_41[37].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);


        //Line_38.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4836.592f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 59236.21f);    //(오, -위)

    }


    public IEnumerator WaitSecond_39()//202-속마음
    {
        yield return new WaitForSeconds(74.5f);
        //Line_39.SetActive(true);
        Line_1_6_41_Index = 38;
        inside_1_6_41[38].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

    }

    public IEnumerator WaitSecond_40()//203-속마음
    {
        yield return new WaitForSeconds(77.5f);
        // Line_40.SetActive(true);
        //Line_39.SetActive(false);

        Line_1_6_41_Index = 39;
        inside_1_6_41[39].gameObject.SetActive(true);
        inside_1_6_41[38].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_41()//204-속마음
    {
        yield return new WaitForSeconds(80.5f);
        //Line_41.SetActive(true);
        //Line_40.SetActive(false);

        Line_1_6_41_Index = 40;
        inside_1_6_41[40].gameObject.SetActive(true);
        inside_1_6_41[39].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_42()//205-속마음
    {
        yield return new WaitForSeconds(83.5f);
        //Line_42.SetActive(true);
        // Line_41.SetActive(false);

        Line_1_6_41_Index = 41;
        inside_1_6_41[41].gameObject.SetActive(true);
        inside_1_6_41[40].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_43()//206-속마음
    {
        yield return new WaitForSeconds(86.5f);
        // Line_43.SetActive(true);
        //Line_42.SetActive(false);

        Line_1_6_41_Index = 42;
        inside_1_6_41[42].gameObject.SetActive(true);
        inside_1_6_41[41].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_44()//207-속마음
    {
        yield return new WaitForSeconds(90.5f);
        // Line_44.SetActive(true);
        // Line_43.SetActive(false);

        Line_1_6_41_Index = 43;
        inside_1_6_41[43].gameObject.SetActive(true);
        inside_1_6_41[42].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_45()//208-속마음
    {
        yield return new WaitForSeconds(94.5f);
        //Line_45.SetActive(true);
        //Line_44.SetActive(false);

        Line_1_6_41_Index = 44;
        inside_1_6_41[44].gameObject.SetActive(true);
        inside_1_6_41[43].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_46()//209-1
    {
        yield return new WaitForSeconds(97.5f);
        // Line_46.SetActive(true);
        // Line_45.SetActive(false);

        Line_1_6_41_Index = 45;
        inside_1_6_41[45].gameObject.SetActive(true);
        inside_1_6_41[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4547.385f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 59525.41f);    //(오, -위)

    }

    public IEnumerator WaitSecond_47()//209-2
    {
        yield return new WaitForSeconds(99.0f);
        //Line_47.SetActive(true);


        Line_1_6_41_Index = 46;
        inside_1_6_41[46].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4388.5f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 59684.3f);    //(오, -위)

    }

    public IEnumerator WaitSecond_48()//209-3
    {
        yield return new WaitForSeconds(100.5f);
        //Line_48.SetActive(true);

        Line_1_6_41_Index = 47;
        inside_1_6_41[47].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4226.828f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 59845.97f);    //(오, -위)

    }

    public IEnumerator WaitSecond_49()//210
    {
        yield return new WaitForSeconds(102.0f);
        //Line_49.SetActive(true);

        Line_1_6_41_Index = 48;
        inside_1_6_41[48].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4008.57f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 60064.23f);    //(오, -위)

    }

    public IEnumerator WaitSecond_50()//211
    {
        yield return new WaitForSeconds(103.5f);
        //Line_50.SetActive(true);

        Line_1_6_41_Index = 49;
        inside_1_6_41[49].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3724.25f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 60348.55f);    //(오, -위)

    }

    public IEnumerator WaitSecond_51()//212
    {
        yield return new WaitForSeconds(105.0f);
        //Line_51.SetActive(true);

        Line_1_6_41_Index = 50;
        inside_1_6_41[50].gameObject.SetActive(true);
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

        TextContainer1.offsetMin = new Vector2(0, -3425.992f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 60646.81f);    //(오, -위)

    }

    public IEnumerator WaitSecond_52()//213
    {
        yield return new WaitForSeconds(106.5f);
        //Line_52.SetActive(true);
        sfx5.Play();
        Line_1_6_41_Index = 51;
        inside_1_6_41[51].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3208.57f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0,60864.23f);    //(오, -위)

    }

    public IEnumerator WaitSecond_53()//214
    {
        yield return new WaitForSeconds(108.0f);
        // Line_53.SetActive(true);

        Line_1_6_41_Index = 52;
        inside_1_6_41[52].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2899.164f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 61173.64f);    //(오, -위)


    }

    public IEnumerator WaitSecond_54()//215
    {
        yield return new WaitForSeconds(109.5f);
        //Line_54.SetActive(true);

        Line_1_6_41_Index = 53;
        inside_1_6_41[53].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -2213.119f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 61859.68f);    //(오, -위)

    }

    public IEnumerator WaitSecond_55()//216
    {
        yield return new WaitForSeconds(111.0f);
        //Line_55.SetActive(true);

        Line_1_6_41_Index = 54;
        inside_1_6_41[54].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1909.287f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 62163.52f);    //(오, -위)

    }

    public IEnumerator WaitSecond_56()//217
    {
        yield return new WaitForSeconds(112.5f);
        // Line_56.SetActive(true);

        Line_1_6_41_Index = 55;
        inside_1_6_41[55].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1616.604f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 62456.2f);    //(오, -위)

    }

    public IEnumerator WaitSecond_57()//218
    {
        yield return new WaitForSeconds(114.0f);
        //Line_57.SetActive(true);

        Line_1_6_41_Index = 56;
        inside_1_6_41[56].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1401.969f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 62670.83f);    //(오, -위)


    }

    public IEnumerator WaitSecond_58()//219-속마음
    {
        yield return new WaitForSeconds(116.0f);
        //Line_58.SetActive(true);

        Line_1_6_41_Index = 57;
        inside_1_6_41[57].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_59()//220-속마음
    {
        yield return new WaitForSeconds(119.0f);
        //Line_59.SetActive(true);
        //Line_58.SetActive(false);

        Line_1_6_41_Index = 58;
        inside_1_6_41[58].gameObject.SetActive(true);
        inside_1_6_41[57].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_60()//221-속마음
    {
        yield return new WaitForSeconds(122.0f);
        //Line_60.SetActive(true);
        // Line_59.SetActive(false);

        Line_1_6_41_Index = 59;
        inside_1_6_41[59].gameObject.SetActive(true);
        inside_1_6_41[58].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_61()//222-속마음
    {
        yield return new WaitForSeconds(125.5f);
        //Line_61.SetActive(true);
        //Line_60.SetActive(false);

        Line_1_6_41_Index = 60;
        inside_1_6_41[60].gameObject.SetActive(true);
        inside_1_6_41[59].gameObject.SetActive(false);
    }

    public IEnumerator WaitSecond_62()//223-속마음
    {
        yield return new WaitForSeconds(128.5f);
        // Line_62.SetActive(true);
        // Line_61.SetActive(false);

        Line_1_6_41_Index = 61;
        inside_1_6_41[61].gameObject.SetActive(true);
        inside_1_6_41[60].gameObject.SetActive(false);

    }

    public IEnumerator WaitSecond_63()//224
    {
        yield return new WaitForSeconds(131.5f);
        //Line_63.SetActive(true);
        //Line_62.SetActive(false);

        sfx6.Play();

        Line_1_6_41_Index = 62;
        inside_1_6_41[62].gameObject.SetActive(true);
        inside_1_6_41[61].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1206.848f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 62865.95f);    //(오, -위)

    }

    public IEnumerator WaitSecond_64()//225
    {
        yield return new WaitForSeconds(133.0f);
        // Line_64.SetActive(true);

        Line_1_6_41_Index = 63;
        inside_1_6_41[63].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -905.8027f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 63167f);    //(오, -위)
    }

    public IEnumerator WaitSecond_65()//226-1
    {
        yield return new WaitForSeconds(134.5f);
        //Line_65.SetActive(true);

        Line_1_6_41_Index = 64;
        inside_1_6_41[64].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -618.6953f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 63454.11f);    //(오, -위)

    }

    public IEnumerator WaitSecond_66()//226-2
    {
        yield return new WaitForSeconds(136.0f);
        //Line_66.SetActive(true);

        Line_1_6_41_Index = 65;
        inside_1_6_41[65].gameObject.SetActive(true);
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

        TextContainer1.offsetMin = new Vector2(0, -387.3359f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 63685.46f);    //(오, -위)



    }
    public IEnumerator WaitSecond_67()//227
    {
        yield return new WaitForSeconds(137.5f);
        //Line_67.SetActive(true);

        Line_1_6_41_Index = 66;
        inside_1_6_41[66].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -183.8516f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 63888.95f);    //(오, -위)

    }

    public IEnumerator WaitSecond_68()//228
    {
        yield return new WaitForSeconds(139.0f);
        //Line_68.SetActive(true);

        Line_1_6_41_Index = 67;
        inside_1_6_41[67].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);

        /*if (Ending2.activeSelf == false)
        {
            //첫 번째 엔딩이 활성화 되지 않았을 경우에
            Ending2.SetActive(true);
            Achieve_Obj.SetActive(true);
            //활성화 시킨다.
            //게임 오브젝트도 보이게 한다.
            Achieve.SetBool("A_Button", true);
            //업적 달성 애니메이션도 실행한다.
        }*/

        // *** 여기서 두 번째 엔딩 관련 ***
        if (All_Save.Ending2[1].gameObject.activeSelf == true)
        {//이미 두 번째 엔딩을 오픈했다면
            //오픈한 그대로 둔다

            All_Save.Ending2_Index = 1;
            All_Save.Ending2[0].gameObject.SetActive(false);
            All_Save.Ending2[1].gameObject.SetActive(true);

            //9번 업적(2번 엔딩)을 오픈한다.
            All_Save.Achieve9_Index = 2;
            All_Save.Achieve_9[0].gameObject.SetActive(false);
            All_Save.Achieve_9[1].gameObject.SetActive(false);
            All_Save.Achieve_9[2].gameObject.SetActive(true);

        }

        //두 번째 엔딩이 오픈되어 있지 않으면
        else if (All_Save.Ending2[1].gameObject.activeSelf == false)
        {
            //두 번째 엔딩이 오픈되지 못했다면 오픈한다
            All_Save.Ending2_Index = 1;
            All_Save.Ending2[0].gameObject.SetActive(false);
            All_Save.Ending2[1].gameObject.SetActive(true);

            Achieve_Obj.SetActive(true);
            //활성화 시킨다.
            //게임 오브젝트도 보이게 한다.
            Achieve.SetBool("A_Button", true);
            //업적 달성 애니메이션도 실행한다.

            //9번 업적(2번 엔딩)을 오픈한다.
            All_Save.Achieve9_Index = 2;
            All_Save.Achieve_9[0].gameObject.SetActive(false);
            All_Save.Achieve_9[1].gameObject.SetActive(false);
            All_Save.Achieve_9[2].gameObject.SetActive(true);

        }

        //두 번째 엔딩 관련하여 자동 저장
        PlayerPrefs.SetInt("Second_Ending", All_Save.Ending2_Index);

        //2번 엔딩(9번 업적 관련)하여 자동 저장
        PlayerPrefs.SetInt("Achieve_9", All_Save.Achieve9_Index);

        //10번 앨범(2번 엔딩) 오픈 관련
        if (All_Save.Album_10[2].gameObject.activeSelf == true)
        {//이미 10번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album10_Index = 2;
            All_Save.Album_10[0].gameObject.SetActive(false);
            All_Save.Album_10[1].gameObject.SetActive(false);
            All_Save.Album_10[2].gameObject.SetActive(true);

        }

        //10번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_10[2].gameObject.activeSelf == false)
        {
            //10번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album10_Index = 2;
            All_Save.Album_10[0].gameObject.SetActive(false);
            All_Save.Album_10[1].gameObject.SetActive(false);
            All_Save.Album_10[2].gameObject.SetActive(true);

        }

        //10 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_10", All_Save.Album10_Index);

        TextContainer1.offsetMin = new Vector2(0, 0.01367188f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 64072.81f);    //(오, -위)

    }

    public IEnumerator Wait_4_Second_Achivement()
    {
        //업적 달성 애니메이션 FALSE하기 위해 새로 만듦
        //업적 달성 애니 나오고 나서 3초 후에 위로 올라감
        yield return new WaitForSeconds(143.0f);

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
        yield return new WaitForSeconds(144.0f);
        Achieve_Obj.SetActive(false);
    }

    public IEnumerator WaitSecond_69()//없음->검
    {
        yield return new WaitForSeconds(141.0f);
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

        Debug.Log("시작");


        yield return new WaitForSeconds(144.0f);

        QuestObject.Line_Index = 147;
        QuestObject.questObject[147].gameObject.SetActive(true);
        //QuestObject.questObject[0].gameObject.SetActive(false);
        Ch1_P.Picture_Coroutine = Ch1_P.WaitSecond_New();
        StartCoroutine(Ch1_P.Picture_Coroutine);
        Debug.Log("그림 리셋하자");

        Line_1_6_41_Index = 0;

        inside_1_6_41[0].gameObject.SetActive(false);
        inside_1_6_41[1].gameObject.SetActive(false);
        inside_1_6_41[2].gameObject.SetActive(false);
        inside_1_6_41[3].gameObject.SetActive(false);
        inside_1_6_41[4].gameObject.SetActive(false);
        inside_1_6_41[5].gameObject.SetActive(false);
        inside_1_6_41[6].gameObject.SetActive(false);
        inside_1_6_41[7].gameObject.SetActive(false);
        inside_1_6_41[8].gameObject.SetActive(false);
        inside_1_6_41[9].gameObject.SetActive(false);
        inside_1_6_41[10].gameObject.SetActive(false);
        inside_1_6_41[11].gameObject.SetActive(false);
        inside_1_6_41[12].gameObject.SetActive(false);
        inside_1_6_41[13].gameObject.SetActive(false);
        inside_1_6_41[14].gameObject.SetActive(false);
        inside_1_6_41[15].gameObject.SetActive(false);
        inside_1_6_41[16].gameObject.SetActive(false);
        inside_1_6_41[17].gameObject.SetActive(false);
        inside_1_6_41[18].gameObject.SetActive(false);
        inside_1_6_41[19].gameObject.SetActive(false);
        inside_1_6_41[20].gameObject.SetActive(false);
        inside_1_6_41[21].gameObject.SetActive(false);
        inside_1_6_41[22].gameObject.SetActive(false);
        inside_1_6_41[23].gameObject.SetActive(false);
        inside_1_6_41[24].gameObject.SetActive(false);
        inside_1_6_41[25].gameObject.SetActive(false);
        inside_1_6_41[26].gameObject.SetActive(false);
        inside_1_6_41[27].gameObject.SetActive(false);
        inside_1_6_41[28].gameObject.SetActive(false);
        inside_1_6_41[29].gameObject.SetActive(false);
        inside_1_6_41[30].gameObject.SetActive(false);
        inside_1_6_41[31].gameObject.SetActive(false);
        inside_1_6_41[32].gameObject.SetActive(false);
        inside_1_6_41[33].gameObject.SetActive(false);
        inside_1_6_41[34].gameObject.SetActive(false);
        inside_1_6_41[35].gameObject.SetActive(false);
        inside_1_6_41[36].gameObject.SetActive(false);
        inside_1_6_41[37].gameObject.SetActive(false);
        inside_1_6_41[38].gameObject.SetActive(false);
        inside_1_6_41[39].gameObject.SetActive(false);
        inside_1_6_41[40].gameObject.SetActive(false);
        inside_1_6_41[41].gameObject.SetActive(false);
        inside_1_6_41[42].gameObject.SetActive(false);
        inside_1_6_41[43].gameObject.SetActive(false);
        inside_1_6_41[44].gameObject.SetActive(false);
        inside_1_6_41[45].gameObject.SetActive(false);
        inside_1_6_41[46].gameObject.SetActive(false);
        inside_1_6_41[47].gameObject.SetActive(false);
        inside_1_6_41[48].gameObject.SetActive(false);
        inside_1_6_41[49].gameObject.SetActive(false);
        inside_1_6_41[50].gameObject.SetActive(false);
        inside_1_6_41[51].gameObject.SetActive(false);
        inside_1_6_41[52].gameObject.SetActive(false);
        inside_1_6_41[53].gameObject.SetActive(false);
        inside_1_6_41[54].gameObject.SetActive(false);
        inside_1_6_41[55].gameObject.SetActive(false);
        inside_1_6_41[56].gameObject.SetActive(false);
        inside_1_6_41[57].gameObject.SetActive(false);
        inside_1_6_41[58].gameObject.SetActive(false);
        inside_1_6_41[59].gameObject.SetActive(false);
        inside_1_6_41[60].gameObject.SetActive(false);
        inside_1_6_41[61].gameObject.SetActive(false);
        inside_1_6_41[62].gameObject.SetActive(false);
        inside_1_6_41[63].gameObject.SetActive(false);
        inside_1_6_41[64].gameObject.SetActive(false);
        inside_1_6_41[65].gameObject.SetActive(false);
        inside_1_6_41[66].gameObject.SetActive(false);
        inside_1_6_41[67].gameObject.SetActive(false);


        //m_IsCoroutineing = false;
        Debug.Log("멈춰");

        


    }




}
