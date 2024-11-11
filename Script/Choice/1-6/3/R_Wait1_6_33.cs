using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class R_Wait1_6_33 : MonoBehaviour
{
    public Save_Collection All_Save;
    public AudioSource sfx5;
    public AudioSource sfx6;
    public GameObject[] inside_1_6_33;
    public int Line_1_6_33_Index;

    public R_Wait1_5_17 inside_49;

    public Pivture4 Ch1_P;
    

    public Only_Line QuestObject;

    public Animator Achieve;//������ �޼��߽��ϴ�. �ִϸ��̼�
    public GameObject Achieve_Obj;//���� �޼��߽��ϴ� ������Ʈ

    public GameObject Ending1;//ù ��° ���� �׸�
    public GameObject Ending2;//�� ��° ���� �׸�
    public GameObject Ending3;//�� ���� ���� �׸�
    public GameObject Ending4;//�� ��° ���� �׸�                         

    public Fade_Collect FadeObject;

    public RectTransform TextContainer1;//�ؽ�Ʈ �����̳�

   
    public IEnumerator m_Coroutine;//���� private����
   

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

    public IEnumerator WaitSecond_1()//172-�Ӹ���
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        QuestObject.BGM_Index = 1;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(true);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        // *** �ڵ����� ���� ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_1_6_33_Index = 0;
        //inside6_2.inside_1_6_2[0].gameObject.SetActive(false);
        inside_1_6_33[0].gameObject.SetActive(true);

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

        if (All_Save.Achieve_7[2].gameObject.activeSelf == true)
        {//�̹� 1ȸ���� ���� ���
            //���� ���빰�� �����ش�

            All_Save.Achieve7_Index = 2;
            All_Save.Achieve_7[0].gameObject.SetActive(false);
            All_Save.Achieve_7[1].gameObject.SetActive(false);
            All_Save.Achieve_7[2].gameObject.SetActive(true);
        }
        else if (All_Save.Achieve_7[0].gameObject.activeSelf == true)
        {
            //1ȸ���� ������ ���� ��� ��Ʈ�� �����ش�.
            All_Save.Achieve7_Index = 1;
            All_Save.Achieve_7[0].gameObject.SetActive(false);
            All_Save.Achieve_7[1].gameObject.SetActive(true);
            All_Save.Achieve_7[2].gameObject.SetActive(false);
        }

        // *** ������ �ٹ� ������ �� �ڵ����� ***
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

        TextContainer1.offsetMin = new Vector2(0, -12448.18f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48647.82f);    //(��, ��)

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


        /*QuestObject.Line_Index = 105;

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

        Debug.Log("1��° ���� �Ϸ�");

    }

    public IEnumerator WaitSecond_2()//173-�Ӹ���
    {
        yield return new WaitForSeconds(3.0f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_1_6_33_Index = 1;
        inside_1_6_33[0].gameObject.SetActive(false);
        inside_1_6_33[1].gameObject.SetActive(true);

        //Sok_talk1.Sok_Talk_Index = 1;

        //Sok_talk1.Sok_talk[1].gameObject.SetActive(true);
        //Sok_talk1.Sok_talk[0].gameObject.SetActive(false);
        Debug.Log("2��° ���� �Ϸ�");
    }

    public IEnumerator WaitSecond_3()//174
    {
        yield return new WaitForSeconds(6.0f);

        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        Line_1_6_33_Index = 2;
        inside_1_6_33[2].gameObject.SetActive(true);
        inside_1_6_33[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -12105.32f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48990.68f);    //(��, ��)

    }

    public IEnumerator WaitSecond_4()//175
    {
        yield return new WaitForSeconds(7.5f);
        //Line_4.SetActive(true);

        Line_1_6_33_Index = 3;
        inside_1_6_33[3].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11759.68f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 49336.32f);    //(��, ��)

    }



    public IEnumerator WaitSecond_5()//176-1
    {
        yield return new WaitForSeconds(9.0f);
        //Line_5.SetActive(true);

        Line_1_6_33_Index = 4;
        inside_1_6_33[4].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11469.79f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 49626.21f);    //(��, ��)

    }

    public IEnumerator WaitSecond_6()//176-2
    {
        yield return new WaitForSeconds(10.5f);
        //Line_6.SetActive(true);

        Line_1_6_33_Index = 5;
        inside_1_6_33[5].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -11252.36f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 49843.64f);    //(��, ��)

    }

    public IEnumerator WaitSecond_7()//177
    {
        yield return new WaitForSeconds(12.0f);
        //Line_7.SetActive(true);

        Line_1_6_33_Index = 6;
        inside_1_6_33[6].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10965.26f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 50130.74f);    //(��, ��)

    }

    public IEnumerator WaitSecond_8()//178-�Ӹ���
    {
        yield return new WaitForSeconds(14.0f);
        //Line_8.SetActive(true);
        Line_1_6_33_Index = 7;
        inside_1_6_33[7].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[2].gameObject.SetActive(false);

    }

    public IEnumerator WaitSecond_9()//179-�Ӹ���
    {
        yield return new WaitForSeconds(18.0f);
        //Line_9.SetActive(true);
        //Line_8.SetActive(false);

        Line_1_6_33_Index = 8;
        inside_1_6_33[8].gameObject.SetActive(true);
        inside_1_6_33[7].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_10()//180
    {
        yield return new WaitForSeconds(21.0f);
        //Line_10.SetActive(true);
        //Line_9.SetActive(false);

        Line_1_6_33_Index = 9;
        inside_1_6_33[9].gameObject.SetActive(true);
        inside_1_6_33[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10616.82f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 50479.18f);    //(��, -��)

    }

    public IEnumerator WaitSecond_11()//181-1
    {
        yield return new WaitForSeconds(22.5f);
        //Line_11.SetActive(true);

        Line_1_6_33_Index = 10;
        inside_1_6_33[10].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -10329.72f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 50766.28f);    //(��, ��)

    }

    public IEnumerator WaitSecond_12()//181-2
    {
        yield return new WaitForSeconds(24.0f);
        //Line_12.SetActive(true);

        Line_1_6_33_Index = 11;
        inside_1_6_33[11].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);

        //���⼭ �����ι�-���� ���� Ǯ��
        if (All_Save.Boss[1].gameObject.activeSelf == true)
        {//�̹� ������ �����ߴٸ�
            //������ �״�� �д�

            All_Save.Boss_Index = 1;
            All_Save.Boss[0].gameObject.SetActive(false);
            All_Save.Boss[1].gameObject.SetActive(true);

        }
        else
        {
            //������ ���µ��� ���ߴٸ� �����Ѵ�
            All_Save.Boss_Index = 1;
            All_Save.Boss[0].gameObject.SetActive(false);
            All_Save.Boss[1].gameObject.SetActive(true);

        }

        // *** ����� ������ �� �ڵ����� ***
        PlayerPrefs.SetInt("Boss", All_Save.Boss_Index);

        TextContainer1.offsetMin = new Vector2(0, -10173.62f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 50922.38f);    //(��, ��)

    }

    public IEnumerator WaitSecond_13()//182=> ��ǥ ã�ƾ� �� �̤�
    {
        yield return new WaitForSeconds(25.5f);
        //Line_13.SetActive(true);

        Line_1_6_33_Index = 12;
        inside_1_6_33[12].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9883.725f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 51212.27f);    //(��, -��)

    }


    public IEnumerator WaitSecond_14()//183-�Ӹ���
    {
        yield return new WaitForSeconds(27.5f);
        //Line_14.SetActive(true);

        Line_1_6_33_Index = 13;
        inside_1_6_33[13].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[8].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_15()//184
    {
        yield return new WaitForSeconds(30.5f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_1_6_33_Index = 14;
        inside_1_6_33[14].gameObject.SetActive(true);
        inside_1_6_33[13].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -9663.516f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 51432.48f);    //(��, ��)

    }

    public IEnumerator WaitSecond_16()//185
    {
        yield return new WaitForSeconds(32.0f);
        //Line_16.SetActive(true);

        Line_1_6_33_Index = 15;
        inside_1_6_33[15].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9373.621f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 51722.38f);    //(��, ��)

    }

    public IEnumerator WaitSecond_17()//186-1
    {
        yield return new WaitForSeconds(33.5f);
        //Line_17.SetActive(true);

        Line_1_6_33_Index = 16;
        inside_1_6_33[16].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9023.219f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 52072.78f);    //(��, -��)
    }

    public IEnumerator WaitSecond_18()//186-2
    {
        yield return new WaitForSeconds(35.0f);
        //Line_18.SetActive(true);

        Line_1_6_33_Index = 17;
        inside_1_6_33[17].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -8867.121f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 52228.88f);    //(��, -��)
    }

    public IEnumerator WaitSecond_19()//187-1
    {
        yield return new WaitForSeconds(36.5f);

        //Line_19.SetActive(true);

        Line_1_6_33_Index = 18;
        inside_1_6_33[18].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8577.227f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 52518.77f);    //(��, -��)

    }

    public IEnumerator WaitSecond_20()//187-2
    {
        yield return new WaitForSeconds(38.0f);
        //Line_20.SetActive(true);

        Line_1_6_33_Index = 19;
        inside_1_6_33[19].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8426.703f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 52669.3f);    //(��, -��)

    }

    public IEnumerator WaitSecond_21()//188
    {
        yield return new WaitForSeconds(39.5f);
        //Line_21.SetActive(true);

        Line_1_6_33_Index = 20;
        inside_1_6_33[20].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8142.383f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 52953.62f);    //(��, -��)
    }

    public IEnumerator WaitSecond_22()//189-�Ӹ���//������� ����
    {
        yield return new WaitForSeconds(41.5f);

        //Line_22.SetActive(true);

        Line_1_6_33_Index = 21;
        inside_1_6_33[21].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_23()//190-1
    {
        yield return new WaitForSeconds(44.5f);
        //Line_23.SetActive(true);
        //Line_22.SetActive(false);

        Line_1_6_33_Index = 22;
        inside_1_6_33[22].gameObject.SetActive(true);
        inside_1_6_33[21].gameObject.SetActive(false);



        TextContainer1.offsetMin = new Vector2(0, -7855.275f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 53240.73f);    //(��, -��)
    }

    public IEnumerator WaitSecond_24()//190-2
    {
        yield return new WaitForSeconds(46.0f);

        //Line_24.SetActive(true);

        Line_1_6_33_Index = 23;
        inside_1_6_33[23].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);
        TextContainer1.offsetMin = new Vector2(0, -7699.178f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 53396.82f);    //(��, -��)
    }

    public IEnumerator WaitSecond_25()//191
    {
        yield return new WaitForSeconds(47.5f);
        //Line_25.SetActive(true);


        Line_1_6_33_Index = 24;
        inside_1_6_33[24].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7414.855f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 53681.14f);    //(��, -��)

    }

    public IEnumerator WaitSecond_26()//192
    {
        yield return new WaitForSeconds(49.0f);

        Line_1_6_33_Index = 25;
        inside_1_6_33[25].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[14].gameObject.SetActive(false);
        //Line_26.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -7125.902f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 53970.1f);    //(��, -��)

    }

    public IEnumerator WaitSecond_27()//193-�Ӹ���
    {
        yield return new WaitForSeconds(51.0f);
        //Line_27.SetActive(true);
        Line_1_6_33_Index = 26;
        inside_1_6_33[26].gameObject.SetActive(true);

    }

    public IEnumerator WaitSecond_28()//194-�Ӹ���
    {
        yield return new WaitForSeconds(54.0f);
        //Line_28.SetActive(true);
        //Line_27.SetActive(false);

        Line_1_6_33_Index = 27;
        inside_1_6_33[27].gameObject.SetActive(true);
        inside_1_6_33[26].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_29()//195
    {
        yield return new WaitForSeconds(57.0f);
        //Line_29.SetActive(true);
        //Line_28.SetActive(false);

        Line_1_6_33_Index = 28;
        inside_1_6_33[28].gameObject.SetActive(true);
        inside_1_6_33[27].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -6836.008f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 54259.99f);    //(��, -��)

    }

    public IEnumerator WaitSecond_30()//196
    {
        yield return new WaitForSeconds(58.5f);
        //Line_30.SetActive(true);

        Line_1_6_33_Index = 29;
        inside_1_6_33[29].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[28].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6551.688f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 54544.31f);    //(��, -��)

    }

    public IEnumerator WaitSecond_31()//197-�Ӹ���
    {
        yield return new WaitForSeconds(60.5f);
        // Line_31.SetActive(true);

        Line_1_6_33_Index = 30;
        inside_1_6_33[30].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[28].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_32()//198-1
    {
        yield return new WaitForSeconds(63.5f);
        //Line_32.SetActive(true);
        // Line_31.SetActive(false);

        Line_1_6_33_Index = 31;
        inside_1_6_33[31].gameObject.SetActive(true);
        inside_1_6_33[30].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6203.256f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 54892.74f);    //(��, -��)


    }

    public IEnumerator WaitSecond_33()//198-2
    {

        yield return new WaitForSeconds(65.0f);

        //Line_33.SetActive(true);

        Line_1_6_33_Index = 32;
        inside_1_6_33[32].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -6041.584f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 55054.41f);    //(��, -��)


    }

    public IEnumerator WaitSecond_34()//199
    {
        //��ġ ��ǥ�� ����
        yield return new WaitForSeconds(66.5f);
        //Line_34.SetActive(true);

        Line_1_6_33_Index = 33;
        inside_1_6_33[33].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -5757.264f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 55338.73f);    //(��, -��)


    }

    public IEnumerator WaitSecond_35()//200-1

    {
        yield return new WaitForSeconds(68.0f);
        //Line_35.SetActive(true);

        Line_1_6_33_Index = 34;
        inside_1_6_33[34].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5472.943f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 55623.05f);    //(��, -��)

    }

    public IEnumerator WaitSecond_36()//200-2
    {
        yield return new WaitForSeconds(69.5f);
        //Line_36.SetActive(true);

        Line_1_6_33_Index = 35;
        inside_1_6_33[35].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5316.846f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 55779.16f);    //(��, -��)


    }

    public IEnumerator WaitSecond_37()//200-3
    {
        yield return new WaitForSeconds(71.0f);

        Line_1_6_33_Index = 36;
        inside_1_6_33[36].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

        //Line_37.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -5155.174f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 55940.83f);    //(��, -��)


    }

    public IEnumerator WaitSecond_38()//201
    {
        yield return new WaitForSeconds(72.5f);
        Line_1_6_33_Index = 37;
        inside_1_6_33[37].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);


        //Line_38.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4862.49f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 56233.51f);    //(��, -��)

    }


    public IEnumerator WaitSecond_39()//202-�Ӹ���
    {
        yield return new WaitForSeconds(74.5f);
        //Line_39.SetActive(true);
        Line_1_6_33_Index = 38;
        inside_1_6_33[38].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[31].gameObject.SetActive(false);

    }

    public IEnumerator WaitSecond_40()//203-�Ӹ���
    {
        yield return new WaitForSeconds(77.5f);
        // Line_40.SetActive(true);
        //Line_39.SetActive(false);

        Line_1_6_33_Index = 39;
        inside_1_6_33[39].gameObject.SetActive(true);
        inside_1_6_33[38].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_41()//204-�Ӹ���
    {
        yield return new WaitForSeconds(80.5f);
        //Line_41.SetActive(true);
        //Line_40.SetActive(false);

        Line_1_6_33_Index = 40;
        inside_1_6_33[40].gameObject.SetActive(true);
        inside_1_6_33[39].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_42()//205-�Ӹ���
    {
        yield return new WaitForSeconds(83.5f);
        //Line_42.SetActive(true);
        // Line_41.SetActive(false);

        Line_1_6_33_Index = 41;
        inside_1_6_33[41].gameObject.SetActive(true);
        inside_1_6_33[40].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_43()//206-�Ӹ���
    {
        yield return new WaitForSeconds(86.5f);
        // Line_43.SetActive(true);
        //Line_42.SetActive(false);

        Line_1_6_33_Index = 42;
        inside_1_6_33[42].gameObject.SetActive(true);
        inside_1_6_33[41].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_44()//207-�Ӹ���
    {
        yield return new WaitForSeconds(90.5f);
        // Line_44.SetActive(true);
        // Line_43.SetActive(false);

        Line_1_6_33_Index = 43;
        inside_1_6_33[43].gameObject.SetActive(true);
        inside_1_6_33[42].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_45()//208-�Ӹ���
    {
        yield return new WaitForSeconds(94.5f);
        //Line_45.SetActive(true);
        //Line_44.SetActive(false);

        Line_1_6_33_Index = 44;
        inside_1_6_33[44].gameObject.SetActive(true);
        inside_1_6_33[43].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_46()//209-1
    {
        yield return new WaitForSeconds(97.5f);
        // Line_46.SetActive(true);
        // Line_45.SetActive(false);

        Line_1_6_33_Index = 45;
        inside_1_6_33[45].gameObject.SetActive(true);
        inside_1_6_33[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4580.957f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 56515.04f);    //(��, -��)

    }

    public IEnumerator WaitSecond_47()//209-2
    {
        yield return new WaitForSeconds(99.0f);
        //Line_47.SetActive(true);


        Line_1_6_33_Index = 46;
        inside_1_6_33[46].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4422.072f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 56673.93f);    //(��, -��)

    }

    public IEnumerator WaitSecond_48()//209-3
    {
        yield return new WaitForSeconds(100.5f);
        //Line_48.SetActive(true);

        Line_1_6_33_Index = 47;
        inside_1_6_33[47].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4263.188f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 56832.81f);    //(��, -��)

    }

    public IEnumerator WaitSecond_49()//210
    {
        yield return new WaitForSeconds(102.0f);
        //Line_49.SetActive(true);

        Line_1_6_33_Index = 48;
        inside_1_6_33[48].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4040.191f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 57055.81f);    //(��, -��)

    }

    public IEnumerator WaitSecond_50()//211
    {
        yield return new WaitForSeconds(103.5f);
        //Line_50.SetActive(true);

        Line_1_6_33_Index = 49;
        inside_1_6_33[49].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3750.297f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 57345.7f);    //(��, -��)

    }

    public IEnumerator WaitSecond_51()//212
    {
        yield return new WaitForSeconds(105.0f);
        //Line_51.SetActive(true);

        Line_1_6_33_Index = 50;
        inside_1_6_33[50].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        //���⼭ �����ι�-�Ҹ� ���� Ǯ��
        if (All_Save.Sori[1].gameObject.activeSelf == true)
        {//�̹� �Ҹ��� �����ߴٸ�
            //������ �״�� �д�

            All_Save.Sori_Index = 1;
            All_Save.Sori[0].gameObject.SetActive(false);
            All_Save.Sori[1].gameObject.SetActive(true);

        }
        else
        {
            //�Ҹ��� ���µ��� ���ߴٸ� �����Ѵ�
            All_Save.Sori_Index = 1;
            All_Save.Sori[0].gameObject.SetActive(false);
            All_Save.Sori[1].gameObject.SetActive(true);

        }

        // *** �Ҹ� ������ �� �ڵ����� ***
        PlayerPrefs.SetInt("Sori", All_Save.Sori_Index);

        TextContainer1.offsetMin = new Vector2(0, -3457.615f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 57638.38f);    //(��, -��)

    }

    public IEnumerator WaitSecond_52()//213
    {
        yield return new WaitForSeconds(106.5f);
        //Line_52.SetActive(true);
        sfx5.Play();
        Line_1_6_33_Index = 51;
        inside_1_6_33[51].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3240.193f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 57855.8f);    //(��, -��)

    }

    public IEnumerator WaitSecond_53()//214
    {
        yield return new WaitForSeconds(108.0f);
        // Line_53.SetActive(true);

        Line_1_6_33_Index = 52;
        inside_1_6_33[52].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2933.572f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 58162.43f);    //(��, -��)


    }

    public IEnumerator WaitSecond_54()//215
    {
        yield return new WaitForSeconds(109.5f);
        //Line_54.SetActive(true);

        Line_1_6_33_Index = 53;
        inside_1_6_33[53].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -2235.494f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 58860.51f);    //(��, -��)

    }

    public IEnumerator WaitSecond_55()//216
    {
        yield return new WaitForSeconds(111.0f);
        //Line_55.SetActive(true);

        Line_1_6_33_Index = 54;
        inside_1_6_33[54].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1942.811f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 59153.19f);    //(��, -��)

    }

    public IEnumerator WaitSecond_56()//217
    {
        yield return new WaitForSeconds(112.5f);
        // Line_56.SetActive(true);

        Line_1_6_33_Index = 55;
        inside_1_6_33[55].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1647.457f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 59448.54f);    //(��, -��)

    }

    public IEnumerator WaitSecond_57()//218
    {
        yield return new WaitForSeconds(114.0f);
        //Line_57.SetActive(true);

        Line_1_6_33_Index = 56;
        inside_1_6_33[56].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1443.973f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 59652.03f);    //(��, -��)


    }

    public IEnumerator WaitSecond_58()//219-�Ӹ���
    {
        yield return new WaitForSeconds(116.0f);
        //Line_58.SetActive(true);

        Line_1_6_33_Index = 57;
        inside_1_6_33[57].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[44].gameObject.SetActive(false);



    }

    public IEnumerator WaitSecond_59()//220-�Ӹ���
    {
        yield return new WaitForSeconds(119.0f);
        //Line_59.SetActive(true);
        //Line_58.SetActive(false);

        Line_1_6_33_Index = 58;
        inside_1_6_33[58].gameObject.SetActive(true);
        inside_1_6_33[57].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_60()//221-�Ӹ���
    {
        yield return new WaitForSeconds(122.0f);
        //Line_60.SetActive(true);
        // Line_59.SetActive(false);

        Line_1_6_33_Index = 59;
        inside_1_6_33[59].gameObject.SetActive(true);
        inside_1_6_33[58].gameObject.SetActive(false);


    }

    public IEnumerator WaitSecond_61()//222-�Ӹ���
    {
        yield return new WaitForSeconds(125.5f);
        //Line_61.SetActive(true);
        //Line_60.SetActive(false);

        Line_1_6_33_Index = 60;
        inside_1_6_33[60].gameObject.SetActive(true);
        inside_1_6_33[59].gameObject.SetActive(false);
    }

    public IEnumerator WaitSecond_62()//223-�Ӹ���
    {
        yield return new WaitForSeconds(128.5f);
        // Line_62.SetActive(true);
        // Line_61.SetActive(false);

        Line_1_6_33_Index = 61;
        inside_1_6_33[61].gameObject.SetActive(true);
        inside_1_6_33[60].gameObject.SetActive(false);

    }

    public IEnumerator WaitSecond_63()//224
    {
        yield return new WaitForSeconds(131.5f);
        //Line_63.SetActive(true);
        //Line_62.SetActive(false);

        sfx6.Play();

        Line_1_6_33_Index = 62;
        inside_1_6_33[62].gameObject.SetActive(true);
        inside_1_6_33[61].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1243.275f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 59852.73f);    //(��, -��)

    }

    public IEnumerator WaitSecond_64()//225
    {
        yield return new WaitForSeconds(133.0f);
        // Line_64.SetActive(true);

        Line_1_6_33_Index = 63;
        inside_1_6_33[63].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -950.5918f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 60145.41f);    //(��, -��)
    }

    public IEnumerator WaitSecond_65()//226-1
    {
        yield return new WaitForSeconds(134.5f);
        //Line_65.SetActive(true);

        Line_1_6_33_Index = 64;
        inside_1_6_33[64].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -663.4844f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 60432.52f);    //(��, -��)

    }

    public IEnumerator WaitSecond_66()//226-2
    {
        yield return new WaitForSeconds(136.0f);
        //Line_66.SetActive(true);

        Line_1_6_33_Index = 65;
        inside_1_6_33[65].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);

        // *** ù ��° ���� �����ֱ� ***

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

        // *** ù ��° ���� ������ �� �ڵ����� ***
        PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

        TextContainer1.offsetMin = new Vector2(0, -446.0625f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 60649.94f);    //(��, -��)



    }
    public IEnumerator WaitSecond_67()//227
    {
        yield return new WaitForSeconds(137.5f);
        //Line_67.SetActive(true);

        Line_1_6_33_Index = 66;
        inside_1_6_33[66].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -228.6406f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 60867.36f);    //(��, -��)

    }

    public IEnumerator WaitSecond_68()//228
    {
        yield return new WaitForSeconds(139.0f);
        //Line_68.SetActive(true);

        Line_1_6_33_Index = 67;
        inside_1_6_33[67].gameObject.SetActive(true);
        //inside6_2.inside_1_6_2[61].gameObject.SetActive(false);

        //���⼭ ������ �޼��Ǿ����ϴ� â�� ���;� ��!
        //<���� �޼��Ǿ����ϴ� â�� ���;� �մϴ�.>
        /*if (Ending4.activeSelf == false)
        {
            //�� ��° ������ Ȱ��ȭ ���� �ʾ��� ��쿡
            Ending4.SetActive(true);
            Achieve_Obj.SetActive(true);
            //Ȱ��ȭ ��Ų��.
            //���� ������Ʈ�� ���̰� �Ѵ�.
            Achieve.SetBool("A_Button", true);
            //���� �޼� �ִϸ��̼ǵ� �����Ѵ�.
        }*/

        // *** ���⼭ �� ��° ���� ���� ***
        if (All_Save.Ending4[1].gameObject.activeSelf == true)
        {//�̹� �� ��° ������ �����ߴٸ�
            //������ �״�� �д�

            All_Save.Ending4_Index = 1;
            All_Save.Ending4[0].gameObject.SetActive(false);
            All_Save.Ending4[1].gameObject.SetActive(true);

            //11�� ����(4�� ����)�� �����Ѵ�.
            All_Save.Achieve11_Index = 2;
            All_Save.Achieve_11[0].gameObject.SetActive(false);
            All_Save.Achieve_11[1].gameObject.SetActive(false);
            All_Save.Achieve_11[2].gameObject.SetActive(true);

        }

        //�� ��° ������ ���µǾ� ���� ������
        else if (All_Save.Ending4[1].gameObject.activeSelf == false)
        {
            //�� ��° ������ ���µ��� ���ߴٸ� �����Ѵ�
            All_Save.Ending4_Index = 1;
            All_Save.Ending4[0].gameObject.SetActive(false);
            All_Save.Ending4[1].gameObject.SetActive(true);

            Achieve_Obj.SetActive(true);
            //Ȱ��ȭ ��Ų��.
            //���� ������Ʈ�� ���̰� �Ѵ�.
            Achieve.SetBool("A_Button", true);
            //���� �޼� �ִϸ��̼ǵ� �����Ѵ�.

            //11�� ����(4�� ����)�� �����Ѵ�.
            All_Save.Achieve11_Index = 2;
            All_Save.Achieve_11[0].gameObject.SetActive(false);
            All_Save.Achieve_11[1].gameObject.SetActive(false);
            All_Save.Achieve_11[2].gameObject.SetActive(true);

        }

        //�� ��° ���� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Fourth_Ending", All_Save.Ending4_Index);

        //11��° ����(4�� ����) ���� �ڵ� ����
        PlayerPrefs.SetInt("Achieve_11", All_Save.Achieve11_Index);

        //12�� �ٹ�(4�� ����) ���� ����
        if (All_Save.Album_12[2].gameObject.activeSelf == true)
        {//�̹� 12�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album12_Index = 2;
            All_Save.Album_12[0].gameObject.SetActive(false);
            All_Save.Album_12[1].gameObject.SetActive(false);
            All_Save.Album_12[2].gameObject.SetActive(true);

        }

        //12�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_12[2].gameObject.activeSelf == false)
        {
            //12�� �ٹ��� ���µ��� ���ߴٸ� �����Ѵ�
            All_Save.Album12_Index = 2;
            All_Save.Album_12[0].gameObject.SetActive(false);
            All_Save.Album_12[1].gameObject.SetActive(false);
            All_Save.Album_12[2].gameObject.SetActive(true);

        }

        //12 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_12", All_Save.Album12_Index);

        TextContainer1.offsetMin = new Vector2(0, 0.0078125f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 61096.01f);    //(��, -��)

    }

    public IEnumerator Wait_4_Second_Achivement()
    {
        //���� �޼� �ִϸ��̼� FALSE�ϱ� ���� ���� ����
        //���� �޼� �ִ� ������ ���� 3�� �Ŀ� ���� �ö�
        yield return new WaitForSeconds(143.0f);

        //��Ҷ�� 3�� �Ŀ� ���� �ö󰡴� �ִϸ��̼� �����ϰ�

        if (Achieve.GetCurrentAnimatorStateInfo(0).IsName("Down"))
        {
            Achieve.SetBool("A_Button", false);
        }

        //���� �̹� ���� X��ư�� ������ �ö󰡴� �ִϸ��̼��� ����Ǿ��ٸ�
        //���� ������Ʈ �Ⱥ��̰�

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

    public IEnumerator WaitSecond_69()//����->��
    {
        yield return new WaitForSeconds(141.0f);
        //Go_Black.SetActive(true);

        //�ؿ��� ���� ���� �ǵ� Ȯ���� �Ⱦ�
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

    public IEnumerator WaitSecond_70()//�ٸ� ������ �̵�
    {
        //m_IsCoroutineing = true;

        Debug.Log("����");


        yield return new WaitForSeconds(144.0f);

        QuestObject.Line_Index = 149;
        QuestObject.questObject[149].gameObject.SetActive(true);
        //QuestObject.questObject[0].gameObject.SetActive(false);
        Ch1_P.Picture_Coroutine = Ch1_P.WaitSecond_New();
        StartCoroutine(Ch1_P.Picture_Coroutine);
        Debug.Log("�׸� ��������");
        //Go_Ch1_Picture.SetActive(true);

        /*if(Ch1_P.m_IsCoroutineing==true)//�ڷ�ƾ�� ���� �� ���۵Ǿ��� ���
        {

        }*/

        /*if(Ch1_P.m_IsCoroutineing==false && Ch1_Text.m_IsCoroutineing == false)//�ڷ�ƾ�� ����Ǿ��� ���
        {
            QuestObject.Line_Index = 127;
            QuestObject.questObject[127].gameObject.SetActive(true);

            Ch1_P.Picture_Coroutine = Ch1_P.WaitSecond_New();
            StartCoroutine(Ch1_P.Picture_Coroutine);
            Debug.Log("�׸� ��������");


            Ch1_Text.Picture_Text = Ch1_Text.WaitSecond_0();
            StartCoroutine(Ch1_Text.Picture_Text);
            Debug.Log("�׸� �۾��� ��������");

           
        }

        else//�ڷ�ƾ�� ���۵��� �ʾ��� ���
        {
            QuestObject.Line_Index = 127;

            QuestObject.questObject[127].gameObject.SetActive(true);


            
        }*/







        //127�� ���� �غ��� ��

        //QuestObject.questObject[0].gameObject.SetActive(false);
        //  Remove_1_6_1_Line.SetActive(false);


        Line_1_6_33_Index = 0;

        inside_1_6_33[0].gameObject.SetActive(false);
        inside_1_6_33[1].gameObject.SetActive(false);
        inside_1_6_33[2].gameObject.SetActive(false);
        inside_1_6_33[3].gameObject.SetActive(false);
        inside_1_6_33[4].gameObject.SetActive(false);
        inside_1_6_33[5].gameObject.SetActive(false);
        inside_1_6_33[6].gameObject.SetActive(false);
        inside_1_6_33[7].gameObject.SetActive(false);
        inside_1_6_33[8].gameObject.SetActive(false);
        inside_1_6_33[9].gameObject.SetActive(false);
        inside_1_6_33[10].gameObject.SetActive(false);
        inside_1_6_33[11].gameObject.SetActive(false);
        inside_1_6_33[12].gameObject.SetActive(false);
        inside_1_6_33[13].gameObject.SetActive(false);
        inside_1_6_33[14].gameObject.SetActive(false);
        inside_1_6_33[15].gameObject.SetActive(false);
        inside_1_6_33[16].gameObject.SetActive(false);
        inside_1_6_33[17].gameObject.SetActive(false);
        inside_1_6_33[18].gameObject.SetActive(false);
        inside_1_6_33[19].gameObject.SetActive(false);
        inside_1_6_33[20].gameObject.SetActive(false);
        inside_1_6_33[21].gameObject.SetActive(false);
        inside_1_6_33[22].gameObject.SetActive(false);
        inside_1_6_33[23].gameObject.SetActive(false);
        inside_1_6_33[24].gameObject.SetActive(false);
        inside_1_6_33[25].gameObject.SetActive(false);
        inside_1_6_33[26].gameObject.SetActive(false);
        inside_1_6_33[27].gameObject.SetActive(false);
        inside_1_6_33[28].gameObject.SetActive(false);
        inside_1_6_33[29].gameObject.SetActive(false);
        inside_1_6_33[30].gameObject.SetActive(false);
        inside_1_6_33[31].gameObject.SetActive(false);
        inside_1_6_33[32].gameObject.SetActive(false);
        inside_1_6_33[33].gameObject.SetActive(false);
        inside_1_6_33[34].gameObject.SetActive(false);
        inside_1_6_33[35].gameObject.SetActive(false);
        inside_1_6_33[36].gameObject.SetActive(false);
        inside_1_6_33[37].gameObject.SetActive(false);
        inside_1_6_33[38].gameObject.SetActive(false);
        inside_1_6_33[39].gameObject.SetActive(false);
        inside_1_6_33[40].gameObject.SetActive(false);
        inside_1_6_33[41].gameObject.SetActive(false);
        inside_1_6_33[42].gameObject.SetActive(false);
        inside_1_6_33[43].gameObject.SetActive(false);
        inside_1_6_33[44].gameObject.SetActive(false);
        inside_1_6_33[45].gameObject.SetActive(false);
        inside_1_6_33[46].gameObject.SetActive(false);
        inside_1_6_33[47].gameObject.SetActive(false);
        inside_1_6_33[48].gameObject.SetActive(false);
        inside_1_6_33[49].gameObject.SetActive(false);
        inside_1_6_33[50].gameObject.SetActive(false);
        inside_1_6_33[51].gameObject.SetActive(false);
        inside_1_6_33[52].gameObject.SetActive(false);
        inside_1_6_33[53].gameObject.SetActive(false);
        inside_1_6_33[54].gameObject.SetActive(false);
        inside_1_6_33[55].gameObject.SetActive(false);
        inside_1_6_33[56].gameObject.SetActive(false);
        inside_1_6_33[57].gameObject.SetActive(false);
        inside_1_6_33[58].gameObject.SetActive(false);
        inside_1_6_33[59].gameObject.SetActive(false);
        inside_1_6_33[60].gameObject.SetActive(false);
        inside_1_6_33[61].gameObject.SetActive(false);
        inside_1_6_33[62].gameObject.SetActive(false);
        inside_1_6_33[63].gameObject.SetActive(false);
        inside_1_6_33[64].gameObject.SetActive(false);
        inside_1_6_33[65].gameObject.SetActive(false);
        inside_1_6_33[66].gameObject.SetActive(false);
        inside_1_6_33[67].gameObject.SetActive(false);


        //m_IsCoroutineing = false;
        Debug.Log("����");

        


        //Ch1_Text.Picture_Text = Ch1_Text.WaitSecond_0();
        //StartCoroutine(Ch1_Text.Picture_Text);
        //Debug.Log("�׸� �۾��� ��������");

        /*if (Ch1_P.m_IsCoroutineing == false && Ch1_Text.m_IsCoroutineing == false)//�ڷ�ƾ�� ����Ǿ��� ���
        {
            QuestObject.Line_Index = 127;
            QuestObject.questObject[127].gameObject.SetActive(true);

            Ch1_P.Picture_Coroutine = Ch1_P.WaitSecond_New();
            StartCoroutine(Ch1_P.Picture_Coroutine);
            Debug.Log("�׸� ��������");


            Ch1_Text.Picture_Text = Ch1_Text.WaitSecond_0();
            StartCoroutine(Ch1_Text.Picture_Text);
            Debug.Log("�׸� �۾��� ��������");


        }

        else//�ڷ�ƾ�� ���۵��� �ʾ��� ���
        {
            QuestObject.Line_Index = 127;

            QuestObject.questObject[127].gameObject.SetActive(true);



        }*/


    }




}