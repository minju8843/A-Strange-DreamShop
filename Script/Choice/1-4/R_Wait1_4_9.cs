using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class R_Wait1_4_9 : MonoBehaviour
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
    public GameObject Line_45;
    public GameObject Line_46;
    public GameObject Line_47;
    public GameObject Line_48;
    public GameObject Line_49;
    public GameObject Line_50;
    public GameObject Line_51;
    public GameObject Line_52;
    public GameObject Line_53;
    public GameObject Line_54;
    public GameObject Line_55;
    public GameObject Line_56;
    public GameObject Line_57;
    public GameObject Line_58;
    public GameObject Line_59;
    public GameObject Line_60;
    public GameObject Line_61;
    public GameObject Line_62;
    public GameObject Line_63;
    public GameObject Line_64;
    public GameObject Line_65;
    public GameObject Line_66;
    public GameObject Line_67;
    public GameObject Line_68;
    public GameObject Line_69;
    public GameObject Line_70;*/

    public GameObject[] inside_Line_34;
    public int Line_34_Index;

    public R_Wait1_5_17 inside_49;
    public R_Wait1_5_18 inside_65;
    public Next_1_3_5 inside_23;

    public AudioSource sfx2;
    public AudioSource sfx3;
    public AudioSource sfx4;

    public Only_Line QuestObject;
    public IEnumerator m_Coroutine;

    public Fade_Collect FadeObject;

    //public GameObject Go_Black;
    //public GameObject Go_Empty;

   //public GameObject BackGround_BLACK;
    //public GameObject BackGround_Gray;



    public RectTransform TextContainer1;//�ؽ�Ʈ �����̳�

    //public GameObject Go_Black;//���̵� �� & �ƿ�


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

        // *** �ڵ����� ���� ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_34_Index = 0;
        inside_Line_34[0].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        //���������� ����. ���� �ƴϾ����� ���ۿ� ����
        // *** ù ��° ������ �ٹ� ��Ʈ �����ֱ� ***

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

        // *** ������ �ٹ� ������ �� �ڵ����� ***
        PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

        inside_23.Line_23_Index = 0;
        inside_23.inside_Line_23[0].gameObject.SetActive(false);
        inside_23.inside_Line_23[1].gameObject.SetActive(false);
        inside_23.inside_Line_23[2].gameObject.SetActive(false);
        inside_23.inside_Line_23[3].gameObject.SetActive(false);
        inside_23.inside_Line_23[4].gameObject.SetActive(false);
        inside_23.inside_Line_23[5].gameObject.SetActive(false);
        inside_23.inside_Line_23[6].gameObject.SetActive(false);
        inside_23.inside_Line_23[7].gameObject.SetActive(false);
        inside_23.inside_Line_23[8].gameObject.SetActive(false);
        inside_23.inside_Line_23[9].gameObject.SetActive(false);
        inside_23.inside_Line_23[10].gameObject.SetActive(false);
        inside_23.inside_Line_23[11].gameObject.SetActive(false);
        inside_23.inside_Line_23[12].gameObject.SetActive(false);
        inside_23.inside_Line_23[13].gameObject.SetActive(false);
        inside_23.inside_Line_23[14].gameObject.SetActive(false);
        inside_23.inside_Line_23[15].gameObject.SetActive(false);
        inside_23.inside_Line_23[16].gameObject.SetActive(false);
        inside_23.inside_Line_23[17].gameObject.SetActive(false);

        /*QuestObject.Line_Index = 33;

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

        TextContainer1.offsetMin = new Vector2(0, -15985.83f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 24089.76f);    //(��, ��)


    }

    IEnumerator WaitSecond_2()//79-2
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);

        Line_34_Index = 1;
        inside_Line_34[1].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -15833.95f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 24241.64f);    //(��, ��)
    }

    IEnumerator WaitSecond_3()//�� ���� �ø�
    {
        yield return new WaitForSeconds(3.0f);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -14377.28f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25698.31f);    //(��, ��)

    }

    IEnumerator WaitSecond_4()//�� ���� �ø� �� ���� �� ��Ÿ����
                              //80
    {
        yield return new WaitForSeconds(5.0f);
        //Line_3.SetActive(true);

        Line_34_Index = 2;
        inside_Line_34[2].gameObject.SetActive(true);

        //Ÿ�Ӷ��� �߰����� ���� �׸� �����ְ�

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


        //���� �̹� ���� �ִٸ� ���� �ִ� ä�� ����.

        //�ڵ� �����ϱ�
        PlayerPrefs.SetInt("TimeLine_Run", All_Save.Time_Run_Index);

        //2 ��° ���׶�̵� ����
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

        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -14377.28f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25698.31f);    //(��, ��)

    }

    IEnumerator WaitSecond_5()//81-1
    {
        yield return new WaitForSeconds(6.5f);
        //Line_4.SetActive(true);

        Line_34_Index = 3;
        inside_Line_34[3].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -14377.28f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25698.31f);    //(��, ��)

    }

    IEnumerator WaitSecond_6()//81-2
    {
        yield return new WaitForSeconds(8.0f);
        //Line_5.SetActive(true);

        Line_34_Index = 4;
        inside_Line_34[4].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -14377.28f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25698.31f);    //(��, ��)

    }

    IEnumerator WaitSecond_7()//81-3
    {
        yield return new WaitForSeconds(9.5f);
        //Line_6.SetActive(true);

        Line_34_Index = 5;
        inside_Line_34[5].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -14377.28f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25698.31f);    //(��, ��)

    }

    IEnumerator WaitSecond_8()//82
    {
        yield return new WaitForSeconds(11.0f);
        //Line_7.SetActive(true);

        Line_34_Index = 6;
        inside_Line_34[6].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -14377.28f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25698.31f);    //(��, ��)

    }

    IEnumerator WaitSecond_9()//83
    {
        yield return new WaitForSeconds(12.5f);
        //Line_8.SetActive(true);

        Line_34_Index = 7;
        inside_Line_34[7].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -13814.68f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 26260.91f);    //(��, ��)

    }

    IEnumerator WaitSecond_10()//84
    {
        yield return new WaitForSeconds(14.0f);
        //Line_9.SetActive(true);

        Line_34_Index = 8;
        inside_Line_34[8].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -13525.67f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 26549.92f);    //(��, -��)

    }

    IEnumerator WaitSecond_11()//85
    {
        yield return new WaitForSeconds(15.5f);
        //Line_10.SetActive(true);

        Line_34_Index = 9;
        inside_Line_34[9].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -13254.22f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 26821.37f);    //(��, ��)

    }

    IEnumerator WaitSecond_12()//86
    {
        yield return new WaitForSeconds(17.0f);
        //Line_11.SetActive(true);

        Line_34_Index = 10;
        inside_Line_34[10].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -12969.84f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 27105.75f);    //(��, ��)

    }

    IEnumerator WaitSecond_13()//87
    {
        yield return new WaitForSeconds(18.5f);
        //Line_12.SetActive(true);

        Line_34_Index = 11;
        inside_Line_34[11].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -12682.23f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 27393.36f);    //(��, -��)

    }

    IEnumerator WaitSecond_14()//88
    {
        yield return new WaitForSeconds(20.0f);
        //Line_13.SetActive(true);

        Line_34_Index = 12;
        inside_Line_34[12].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -12485.0f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 27590.59f);    //(��, ��)

    }

    IEnumerator WaitSecond_15()//89
    {
        yield return new WaitForSeconds(21.5f);
        //Line_14.SetActive(true);

        Line_34_Index = 13;
        inside_Line_34[13].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -12165.26f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 27910.33f);    //(��, ��)

    }

    IEnumerator WaitSecond_16()//90-1
    {
        yield return new WaitForSeconds(23.0f);
        //Line_15.SetActive(true);

        Line_34_Index = 14;
        inside_Line_34[14].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11873.43f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 28202.16f);    //(��, -��)
    }

    IEnumerator WaitSecond_17()//90-2
    {
        yield return new WaitForSeconds(24.5f);
        //Line_16.SetActive(true);

        Line_34_Index = 15;
        inside_Line_34[15].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11718.32f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 28357.27f);    //(��, -��)
    }

    IEnumerator WaitSecond_18()//91-1
    {
        yield return new WaitForSeconds(26.0f);

        //Line_17.SetActive(true);

        Line_34_Index = 16;
        inside_Line_34[16].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11430.7f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 28644.89f);    //(��, -��)

    }

    IEnumerator WaitSecond_19()//91-2
    {
        yield return new WaitForSeconds(27.5f);
        //Line_18.SetActive(true);

        Line_34_Index = 17;
        inside_Line_34[17].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11278.82f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 28796.77f);    //(��, -��)

    }

    IEnumerator WaitSecond_20()//92
    {
        yield return new WaitForSeconds(29.0f);
        //Line_19.SetActive(true);

        Line_34_Index = 18;
        inside_Line_34[18].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10991.21f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 29084.38f);    //(��, -��)
    }

    IEnumerator WaitSecond_21()//93
    {
        yield return new WaitForSeconds(30.5f);

        //Line_20.SetActive(true);

        Line_34_Index = 19;
        inside_Line_34[19].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10700.36f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 29375.23f);    //(��, -��)

    }

    IEnumerator WaitSecond_22()//94
    {
        yield return new WaitForSeconds(31.5f);
        //Line_21.SetActive(true);

        Line_34_Index = 20;
        inside_Line_34[20].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10509.7f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 29565.89f);    //(��, -��)
    }

    IEnumerator WaitSecond_23()//95
    {
        yield return new WaitForSeconds(33.0f);

        //Line_22.SetActive(true);

        Line_34_Index = 21;
        inside_Line_34[21].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10184.32f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 29891.27f);    //(��, -��)
    }

    IEnumerator WaitSecond_24()//96
    {
        yield return new WaitForSeconds(34.5f);
        //Line_23.SetActive(true);
        sfx2.Play();
        Line_34_Index = 22;
        inside_Line_34[22].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9990.428f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 30085.16f);    //(��, -��)

    }

    IEnumerator WaitSecond_25()//97
    {
        yield return new WaitForSeconds(36.0f);
        //Line_24.SetActive(true);

        Line_34_Index = 23;
        inside_Line_34[23].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9670.5f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 30405.09f);    //(��, -��)

    }

    IEnumerator WaitSecond_26()//98
    {
        yield return new WaitForSeconds(37.5f);
        // Line_25.SetActive(true);
        sfx2.Play();
        Line_34_Index = 24;
        inside_Line_34[24].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9476.604f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 30598.98f);    //(��, -��)
    }

    IEnumerator WaitSecond_27()//99
    {
        yield return new WaitForSeconds(39.0f);
        //Line_26.SetActive(true);

        Line_34_Index = 25;
        inside_Line_34[25].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9276.245f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 30799.34f);    //(��, -��)

    }

    IEnumerator WaitSecond_28()//100
    {
        yield return new WaitForSeconds(40.5f);
        //Line_27.SetActive(true);

        Line_34_Index = 26;
        inside_Line_34[26].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8904.271f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 31171.32f);    //(��, -��)

    }

    IEnumerator WaitSecond_29()//101
    {
        yield return new WaitForSeconds(42.0f);
        //Line_28.SetActive(true);

        Line_34_Index = 27;
        inside_Line_34[27].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -8710.376f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 31365.21f);    //(��, -��)

    }

    IEnumerator WaitSecond_30()//102
    {
        yield return new WaitForSeconds(43.5f);
        //Line_29.SetActive(true);

        Line_34_Index = 28;
        inside_Line_34[28].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8387.216f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 31688.38f);    //(��, -��)

    }

    IEnumerator WaitSecond_31()//103-�Ӹ���
    {
        yield return new WaitForSeconds(45.5f);
        //Line_30.SetActive(true);

        QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        Line_34_Index = 29;
        inside_Line_34[29].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_32()//���� �˰� �����
    {
        //��� �� ����
        //��ġ ��ǥ�� ����
        yield return new WaitForSeconds(48.0f);
        //BackGround_BLACK.SetActive(true);//70
        //Line_30.SetActive(false);

        Line_34_Index = 70;
        inside_Line_34[70].gameObject.SetActive(true);
        inside_Line_34[29].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -6937.371f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 33138.22f);    //(��, -��)


    }

    IEnumerator WaitSecond_33()//��� �������ٰ� ��� ��Ÿ����
                               //104
    {
        //��ġ ��ǥ�� ����
        yield return new WaitForSeconds(50.0f);
        //Line_31.SetActive(true);

        Line_34_Index = 30;
        inside_Line_34[30].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6937.371f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 33138.22f);    //(��, -��)


    }

    IEnumerator WaitSecond_34()//105-�Ӹ���

    {
        yield return new WaitForSeconds(52.0f);
        //Line_32.SetActive(true);

        Line_34_Index = 31;
        inside_Line_34[31].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_35()//106-�Ӹ���
    {
        yield return new WaitForSeconds(54.5f);
        //Line_33.SetActive(true);
        //Line_32.SetActive(false);

        Line_34_Index = 32;
        inside_Line_34[32].gameObject.SetActive(true);
        inside_Line_34[31].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_36()//35�κ��� 1.5�� �ڿ� ����(�׳� ����� ��簡 �տ� ���� ���)
    {//1.5�� �ڿ� ���� �˰�
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

        Line_34_Index = 32;
        inside_Line_34[32].gameObject.SetActive(false);
        //inside_Line_34[21].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_37()//���̵� �ƿ� ����, ���̵� �� �����
    {//36�κ��� 1.5�� �ڿ� ���� ���ϰ� ����, ������ ����
     //��� �� ȸ������ �ٲٱ�
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

        Line_34_Index = 70;
        inside_Line_34[70].gameObject.SetActive(false);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6652.143f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 33423.45f);    //(��, -��)

    }


    IEnumerator WaitSecond_38()//37�κ��� 4���Ŀ� ��� ��Ÿ����
    {//�ƹ��͵� ���°� �����
        //107
        yield return new WaitForSeconds(62.5f);
        //Line_34.SetActive(true);

        Line_34_Index = 33;
        inside_Line_34[33].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

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

        TextContainer1.offsetMin = new Vector2(0, -6652.143f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 33423.45f);    //(��, -��)

    }

    IEnumerator WaitSecond_39()//108
    {
        yield return new WaitForSeconds(64.0f);
        //Line_35.SetActive(true);

        Line_34_Index = 34;
        inside_Line_34[34].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        // % ������� �ٹ� ���� %

        //7�� �ٹ� ���� ����
        if (All_Save.Album_7[2].gameObject.activeSelf == true)
        {//�̹� 7�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album7_Index = 2;
            All_Save.Album_7[0].gameObject.SetActive(false);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(true);

        }

        //7�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_7[2].gameObject.activeSelf == false)
        {
            //7�� �ٹ��� ���µ��� ���ߴٸ� �����Ѵ�
            All_Save.Album7_Index = 2;
            All_Save.Album_7[0].gameObject.SetActive(false);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(true);

        }

        //7 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);

        // % ������� ���� �ٹ��� ���� ��Ʈ ���� %

        //8�� �ٹ� ���� ����
        if (All_Save.Album_8[2].gameObject.activeSelf == true)
        {//�̹� 8�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album8_Index = 2;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(true);

        }

        //8�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_8[2].gameObject.activeSelf == false)
        {
            //8�� �ٹ��� ���� ��Ʈ�� �ش�
            All_Save.Album8_Index = 1;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(true);
            All_Save.Album_8[2].gameObject.SetActive(false);

        }

        //8 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);

        TextContainer1.offsetMin = new Vector2(0, -6652.143f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 33423.45f);    //(��, -��)

    }

    IEnumerator WaitSecond_40()//109-1
    {
        yield return new WaitForSeconds(65.5f);
        //Line_36.SetActive(true);

        Line_34_Index = 35;
        inside_Line_34[35].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6652.143f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 33423.45f);    //(��, -��)

    }

    IEnumerator WaitSecond_41()//109-2
    {
        yield return new WaitForSeconds(67.0f);
        //Line_37.SetActive(true);

        Line_34_Index = 36;
        inside_Line_34[36].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6577.815f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 33497.77f);    //(��, -��)

    }

    IEnumerator WaitSecond_42()//110-�Ӹ���
    {
        yield return new WaitForSeconds(69.0f);
        //Line_38.SetActive(true);

        Line_34_Index = 37;
        inside_Line_34[37].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_43()//111-�Ӹ���
    {
        yield return new WaitForSeconds(72.0f);
        //Line_39.SetActive(true);
        //Line_38.SetActive(false);

        Line_34_Index = 38;
        inside_Line_34[38].gameObject.SetActive(true);
        inside_Line_34[37].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_44()//112
    {
        yield return new WaitForSeconds(74.5f);
        //Line_40.SetActive(true);
        //Line_39.SetActive(false);

        Line_34_Index = 39;
        inside_Line_34[39].gameObject.SetActive(true);
        inside_Line_34[38].gameObject.SetActive(false);

        // % ������� �ٹ� ���� %

        //8�� �ٹ� ���� ����
        if (All_Save.Album_8[2].gameObject.activeSelf == true)
        {//�̹� 8�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album8_Index = 2;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(true);

        }

        //8�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_8[2].gameObject.activeSelf == false)
        {
            //8�� �ٹ��� ���µ��� ���ߴٸ� �����Ѵ�
            All_Save.Album8_Index = 2;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(true);

        }

        //8 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);

        TextContainer1.offsetMin = new Vector2(0, -5855.427f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 34220.16f);    //(��, -��)

    }

    IEnumerator WaitSecond_45()//113-1
    {
        yield return new WaitForSeconds(76.0f);
        //Line_41.SetActive(true);

        Line_34_Index = 40;
        inside_Line_34[40].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5558.12f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 34517.47f);    //(��, -��)

    }

    IEnumerator WaitSecond_46()//113-2
    {
        yield return new WaitForSeconds(77.5f);
        //Line_42.SetActive(true);

        Line_34_Index = 41;
        inside_Line_34[41].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5406.383f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 34669.21f);    //(��, -��)

    }

    IEnumerator WaitSecond_47()//113-3
    {
        yield return new WaitForSeconds(79.0f);
        //Line_43.SetActive(true);

        Line_34_Index = 42;
        inside_Line_34[42].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5244.498f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 34821.09f);    //(��, -��)

    }

    IEnumerator WaitSecond_48()//114��
                               //�� ���� ������
    {
        yield return new WaitForSeconds(80.5f);

        QuestObject.BGM_Index = 1;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(true);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -3801.046f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 36274.54f);    //(��, -��)

    }

    IEnumerator WaitSecond_49()//114-1
    {//48�κ��� 2�� �� ���� �� ��Ÿ����
        yield return new WaitForSeconds(82.5f);
        // Line_44.SetActive(true);

        sfx3.Play();

        Line_34_Index = 43;
        inside_Line_34[43].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3801.046f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 36274.54f);    //(��, -��)

    }

    IEnumerator WaitSecond_50()//14-2
    {
        yield return new WaitForSeconds(84.0f);
        //Line_45.SetActive(true);

        Line_34_Index = 44;
        inside_Line_34[44].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3801.046f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 36274.54f);    //(��, -��)

    }

    IEnumerator WaitSecond_51()//115-�Ӹ���
    {
        yield return new WaitForSeconds(86.0f);
        //Line_46.SetActive(true);
        Line_34_Index = 45;
        inside_Line_34[45].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_52()//116�Ӹ���
    {
        yield return new WaitForSeconds(88.5f);
        //Line_47.SetActive(true);
        //Line_46.SetActive(false);

        Line_34_Index = 46;
        inside_Line_34[46].gameObject.SetActive(true);
        inside_Line_34[45].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_53()//117
    {
        yield return new WaitForSeconds(92.5f);
        //Line_48.SetActive(true);
        //Line_47.SetActive(false);

        sfx4.Play();

        Line_34_Index = 47;
        inside_Line_34[47].gameObject.SetActive(true);
        inside_Line_34[46].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3801.046f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 36274.54f);    //(��, -��)

    }

    IEnumerator WaitSecond_54()//118
    {
        yield return new WaitForSeconds(94.0f);
        //Line_49.SetActive(true);

        Line_34_Index = 48;
        inside_Line_34[48].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3801.046f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 36274.54f);    //(��, -��)

    }

    IEnumerator WaitSecond_55()//119
    {
        yield return new WaitForSeconds(95.5f);
        //Line_50.SetActive(true);

        Line_34_Index = 49;
        inside_Line_34[49].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3801.046f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 36274.54f);    //(��, -��)

    }

    IEnumerator WaitSecond_56()//120
    {
        yield return new WaitForSeconds(97.0f);
        //Line_51.SetActive(true);

        Line_34_Index = 50;
        inside_Line_34[50].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3300.055f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 36775.54f);    //(��, -��)

    }

    IEnumerator WaitSecond_57()//121-1
    {
        yield return new WaitForSeconds(98.5f);
        //Line_52.SetActive(true);

        Line_34_Index = 51;
        inside_Line_34[51].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3009.211f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 37066.38f);    //(��, -��)

    }

    IEnumerator WaitSecond_58()//121-2
    {
        yield return new WaitForSeconds(100.0f);
        //Line_53.SetActive(true);

        Line_34_Index = 52;
        inside_Line_34[52].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2854.094f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 37221.5f);    //(��, -��)

    }

    IEnumerator WaitSecond_59()//122-1
    {
        yield return new WaitForSeconds(101.5f);
        //Line_54.SetActive(true);

        Line_34_Index = 53;
        inside_Line_34[53].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2573.109f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 37502.48f);    //(��, -��)

    }

    IEnumerator WaitSecond_60()//122-2
    {
        yield return new WaitForSeconds(103.0f);
        //Line_55.SetActive(true);

        Line_34_Index = 54;
        inside_Line_34[54].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2414.762f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 37660.83f);    //(��, -��)

    }

    IEnumerator WaitSecond_61()//123
    {
        yield return new WaitForSeconds(104.5f);
        //Line_56.SetActive(true);

        Line_34_Index = 55;
        inside_Line_34[55].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2127.15f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 37948.44f);    //(��, -��)

    }

    IEnumerator WaitSecond_62()//124
    {
        yield return new WaitForSeconds(106.0f);
        //Line_57.SetActive(true);

        Line_34_Index = 56;
        inside_Line_34[56].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1842.77f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 38232.82f);    //(��, -��)

    }

    IEnumerator WaitSecond_63()//125-�Ӹ���
    {
        yield return new WaitForSeconds(108.0f);
        //Line_58.SetActive(true);

        Line_34_Index = 57;
        inside_Line_34[57].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_64()//126-�Ӹ���
    {
        yield return new WaitForSeconds(110.0f);
        // Line_59.SetActive(true);
        // Line_58.SetActive(false);

        Line_34_Index = 58;
        inside_Line_34[58].gameObject.SetActive(true);
        inside_Line_34[57].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_65()//127-�Ӹ���
    {
        yield return new WaitForSeconds(113.0f);
        //Line_60.SetActive(true);
        //Line_59.SetActive(false);

        Line_34_Index = 59;
        inside_Line_34[59].gameObject.SetActive(true);
        inside_Line_34[58].gameObject.SetActive(false);

    }
    IEnumerator WaitSecond_66()//128
    {
        yield return new WaitForSeconds(116.0f);
        //Line_61.SetActive(true);
        //Line_60.SetActive(false);

        Line_34_Index = 60;
        inside_Line_34[60].gameObject.SetActive(true);
        inside_Line_34[59].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1558.389f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 38517.2f);    //(��, -��)

    }

    IEnumerator WaitSecond_67()//129
    {
        yield return new WaitForSeconds(117.5f);
        //Line_62.SetActive(true);

        Line_34_Index = 61;
        inside_Line_34[61].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1278.158f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 38797.43f);    //(��, -��)

    }

    IEnumerator WaitSecond_68()//130
    {
        yield return new WaitForSeconds(119.0f);
        //Line_63.SetActive(true);

        Line_34_Index = 62;
        inside_Line_34[62].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -990.5469f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 39085.04f);    //(��, -��)

    }

    IEnumerator WaitSecond_69()//131
    {
        yield return new WaitForSeconds(120.5f);
        //Line_64.SetActive(true);

        Line_34_Index = 63;
        inside_Line_34[63].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -702.9355f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 39372.66f);    //(��, -��)

    }

    IEnumerator WaitSecond_70()//132
    {
        yield return new WaitForSeconds(122.0f);
        //Line_65.SetActive(true);

        Line_34_Index = 64;
        inside_Line_34[64].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -406.0215f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 39669.57f);    //(��, -��)

    }

    IEnumerator WaitSecond_71()//133-�Ӹ���
    {
        yield return new WaitForSeconds(124.0f);
        //Line_66.SetActive(true);
        Line_34_Index = 65;
        inside_Line_34[65].gameObject.SetActive(true);
        //inside_Line_34[21].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_72()//134-�Ӹ���
    {
        yield return new WaitForSeconds(126.0f);
        //Line_67.SetActive(true);
        //Line_66.SetActive(false);

        Line_34_Index = 66;
        inside_Line_34[66].gameObject.SetActive(true);
        inside_Line_34[65].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_73()//135-�Ӹ���
    {
        yield return new WaitForSeconds(130.0f);
        //Line_68.SetActive(true);
        //Line_67.SetActive(false);

        Line_34_Index = 67;
        inside_Line_34[67].gameObject.SetActive(true);
        inside_Line_34[66].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_74()//136-�Ӹ���
    {
        yield return new WaitForSeconds(133.0f);
        //Line_69.SetActive(true);
        //Line_68.SetActive(false);

        Line_34_Index = 68;
        inside_Line_34[68].gameObject.SetActive(true);
        inside_Line_34[67].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_75()//137-������
    {
        yield return new WaitForSeconds(135.5f);
        //Line_70.SetActive(true);
        //Line_69.SetActive(false);

        Line_34_Index = 69;
        inside_Line_34[69].gameObject.SetActive(true);
        inside_Line_34[68].gameObject.SetActive(false);

        inside_49.Line_49_Index = 0;
        inside_49.inside_Line_49[0].gameObject.SetActive(false);
        inside_49.inside_Line_49[1].gameObject.SetActive(false);
        inside_49.inside_Line_49[2].gameObject.SetActive(false);
        inside_49.inside_Line_49[3].gameObject.SetActive(false);
        inside_49.inside_Line_49[4].gameObject.SetActive(false);
        inside_49.inside_Line_49[5].gameObject.SetActive(false);
        inside_49.inside_Line_49[6].gameObject.SetActive(false);
        inside_49.inside_Line_49[7].gameObject.SetActive(false);
        inside_49.inside_Line_49[8].gameObject.SetActive(false);
        inside_49.inside_Line_49[9].gameObject.SetActive(false);
        inside_49.inside_Line_49[10].gameObject.SetActive(false);
        inside_49.inside_Line_49[11].gameObject.SetActive(false);
        inside_49.inside_Line_49[12].gameObject.SetActive(false);
        inside_49.inside_Line_49[13].gameObject.SetActive(false);
        inside_49.inside_Line_49[14].gameObject.SetActive(false);
        inside_49.inside_Line_49[15].gameObject.SetActive(false);
        inside_49.inside_Line_49[16].gameObject.SetActive(false);
        inside_49.inside_Line_49[17].gameObject.SetActive(false);
        inside_49.inside_Line_49[18].gameObject.SetActive(false);
        inside_49.inside_Line_49[19].gameObject.SetActive(false);
        inside_49.inside_Line_49[20].gameObject.SetActive(false);
        inside_49.inside_Line_49[21].gameObject.SetActive(false);
        inside_49.inside_Line_49[22].gameObject.SetActive(false);
        inside_49.inside_Line_49[23].gameObject.SetActive(false);
        inside_49.inside_Line_49[24].gameObject.SetActive(false);
        inside_49.inside_Line_49[25].gameObject.SetActive(false);
        inside_49.inside_Line_49[26].gameObject.SetActive(false);
        inside_49.inside_Line_49[27].gameObject.SetActive(false);
        inside_49.inside_Line_49[28].gameObject.SetActive(false);
        inside_49.inside_Line_49[29].gameObject.SetActive(false);
        inside_49.inside_Line_49[30].gameObject.SetActive(false);
        inside_49.inside_Line_49[31].gameObject.SetActive(false);
        inside_49.inside_Line_49[32].gameObject.SetActive(false);
        inside_49.inside_Line_49[33].gameObject.SetActive(false);
        inside_49.inside_Line_49[34].gameObject.SetActive(false);
        inside_49.inside_Line_49[35].gameObject.SetActive(false);
        inside_49.inside_Line_49[36].gameObject.SetActive(false);
        inside_49.inside_Line_49[37].gameObject.SetActive(false);
        inside_49.inside_Line_49[38].gameObject.SetActive(false);
        inside_49.inside_Line_49[39].gameObject.SetActive(false);
        inside_49.inside_Line_49[40].gameObject.SetActive(false);
        inside_49.inside_Line_49[41].gameObject.SetActive(false);
        inside_49.inside_Line_49[42].gameObject.SetActive(false);
        inside_49.inside_Line_49[43].gameObject.SetActive(false);
        inside_49.inside_Line_49[44].gameObject.SetActive(false);
        inside_49.inside_Line_49[45].gameObject.SetActive(false);
        inside_49.inside_Line_49[46].gameObject.SetActive(false);
        inside_49.inside_Line_49[47].gameObject.SetActive(false);
        inside_49.inside_Line_49[48].gameObject.SetActive(false);

        inside_65.Line_65_Index = 0;
        inside_65.inside_Line_65[0].gameObject.SetActive(false);
        inside_65.inside_Line_65[1].gameObject.SetActive(false);
        inside_65.inside_Line_65[2].gameObject.SetActive(false);
        inside_65.inside_Line_65[3].gameObject.SetActive(false);
        inside_65.inside_Line_65[4].gameObject.SetActive(false);
        inside_65.inside_Line_65[5].gameObject.SetActive(false);
        inside_65.inside_Line_65[6].gameObject.SetActive(false);
        inside_65.inside_Line_65[7].gameObject.SetActive(false);
        inside_65.inside_Line_65[8].gameObject.SetActive(false);
        inside_65.inside_Line_65[9].gameObject.SetActive(false);
        inside_65.inside_Line_65[10].gameObject.SetActive(false);
        inside_65.inside_Line_65[11].gameObject.SetActive(false);
        inside_65.inside_Line_65[12].gameObject.SetActive(false);
        inside_65.inside_Line_65[13].gameObject.SetActive(false);
        inside_65.inside_Line_65[14].gameObject.SetActive(false);
        inside_65.inside_Line_65[15].gameObject.SetActive(false);
        inside_65.inside_Line_65[16].gameObject.SetActive(false);
        inside_65.inside_Line_65[17].gameObject.SetActive(false);
        inside_65.inside_Line_65[18].gameObject.SetActive(false);
        inside_65.inside_Line_65[19].gameObject.SetActive(false);
        inside_65.inside_Line_65[20].gameObject.SetActive(false);
        inside_65.inside_Line_65[21].gameObject.SetActive(false);
        inside_65.inside_Line_65[22].gameObject.SetActive(false);
        inside_65.inside_Line_65[23].gameObject.SetActive(false);
        inside_65.inside_Line_65[24].gameObject.SetActive(false);
        inside_65.inside_Line_65[25].gameObject.SetActive(false);
        inside_65.inside_Line_65[26].gameObject.SetActive(false);
        inside_65.inside_Line_65[27].gameObject.SetActive(false);
        inside_65.inside_Line_65[28].gameObject.SetActive(false);
        inside_65.inside_Line_65[29].gameObject.SetActive(false);
        inside_65.inside_Line_65[30].gameObject.SetActive(false);
        inside_65.inside_Line_65[31].gameObject.SetActive(false);
        inside_65.inside_Line_65[32].gameObject.SetActive(false);
        inside_65.inside_Line_65[33].gameObject.SetActive(false);
        inside_65.inside_Line_65[34].gameObject.SetActive(false);
        inside_65.inside_Line_65[35].gameObject.SetActive(false);
        inside_65.inside_Line_65[36].gameObject.SetActive(false);
        inside_65.inside_Line_65[37].gameObject.SetActive(false);
        inside_65.inside_Line_65[38].gameObject.SetActive(false);
        inside_65.inside_Line_65[39].gameObject.SetActive(false);
        inside_65.inside_Line_65[40].gameObject.SetActive(false);
        inside_65.inside_Line_65[41].gameObject.SetActive(false);
        inside_65.inside_Line_65[42].gameObject.SetActive(false);
        inside_65.inside_Line_65[43].gameObject.SetActive(false);
        inside_65.inside_Line_65[44].gameObject.SetActive(false);
        inside_65.inside_Line_65[45].gameObject.SetActive(false);
        inside_65.inside_Line_65[46].gameObject.SetActive(false);
        inside_65.inside_Line_65[47].gameObject.SetActive(false);
        inside_65.inside_Line_65[48].gameObject.SetActive(false);
        inside_65.inside_Line_65[49].gameObject.SetActive(false);
        inside_65.inside_Line_65[50].gameObject.SetActive(false);
        inside_65.inside_Line_65[51].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.03515625f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 40075.63f);    //(��, -��)

    }


}
