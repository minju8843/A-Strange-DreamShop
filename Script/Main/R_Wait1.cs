using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class R_Wait1 : MonoBehaviour
{
    public Fast_2023 speed;
    public Fast_2023_2 speed1;

    public GameObject StopPlease;
    public GameObject GoPlease;

    //public GameObject Ticket_Count_Panel;

    public Animator Achieve;//������ �޼��߽��ϴ�. �ִϸ��̼�
    public GameObject Achieve_Obj;//���� �޼��߽��ϴ� ������Ʈ

    public GameObject[] inside_Line_0;
    public int Line_0_Index;

    public Save_Collection All_Save;

    //public Fast_2023 speed;

    public Sum_1_1_1 inside_1;
    public Sum_1_1_2 inside_2;




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
     public GameObject Line_13;*/
    

    public RectTransform TextContainer1;//�ؽ�Ʈ �����̳�

    public Only_Line QuestObject;

    public Fade_Collect FadeObject;

    //public GameObject Go_Black;//���̵� �� & �ƿ�

    public GameObject Fade;

    public IEnumerator m_Coroutine;

    void OnEnable()
    {
        m_Coroutine = NewCoroutine();
        //StartCoroutine(m_Coroutine);
        
    }

    void Start()
    {
        //m_Coroutine = NewCoroutine();
        

    }


    void Update()
    {
        StartCoroutine(m_Coroutine);

        /*if (GoPlease.activeSelf == true)
        {
            Time.timeScale = speed.Speed;
            Debug.Log(Time.timeScale);



        }


        if (StopPlease.activeSelf == true)
        {
            Time.timeScale = speed1.Speed;
            Debug.Log(Time.timeScale);

        }*/

        Debug.Log("���� 1 Ÿ�ӵ�Ÿ Ÿ�� Ȯ�� " + Time.timeScale + "�̰� �´�?");




        //speed.SoundSlider();
    }




    public IEnumerator NewCoroutine()
    {
        yield return StartCoroutine(WaitSecond_0());
        yield return StartCoroutine(Between_0_1());
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

        //���� ������ ����
        yield return StartCoroutine(Please_Wait_One_Second());
        yield return StartCoroutine(Wait_4_Second_Achivement());
        yield return StartCoroutine(Wait_One_Second());

    }

    public IEnumerator WaitSecond_0()
    {
        

        yield return new WaitForSeconds(0.0f);

        //�����ι� ����
        //�����ι��� ������ ������
        //�ڹ��� ���·� �д�
        if (All_Save.Boss[1].gameObject.activeSelf == false)
        {
            //����
            All_Save.Boss_Index = 0;
            All_Save.Boss[0].gameObject.SetActive(true);
            All_Save.Boss[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Boss", All_Save.Boss_Index);
        }

        if (All_Save.Sori[1].gameObject.activeSelf == false)
        {
            //�Ҹ�
            All_Save.Sori_Index = 0;
            All_Save.Sori[0].gameObject.SetActive(true);
            All_Save.Sori[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Sori", All_Save.Sori_Index);
        }

        if (All_Save.Fake_Boss[1].gameObject.activeSelf == false)
        {
            //��¥ ����
            All_Save.Fake_Boss_Index = 0;
            All_Save.Fake_Boss[0].gameObject.SetActive(true);
            All_Save.Fake_Boss[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Fake_Boss", All_Save.Fake_Boss_Index);
        }

        if (All_Save.Black_Face_Man[1].gameObject.activeSelf == false)
        {//������
            All_Save.Black_Face_Man_Index = 0;
            All_Save.Black_Face_Man[0].gameObject.SetActive(true);
            All_Save.Black_Face_Man[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Black_Face_Man", All_Save.Black_Face_Man_Index);
        }


        //Ÿ�Ӷ��� ����
        //Ÿ�Ӷ��� ���׶�̰� �������� ������
        //�ڹ��� ���·� �д�

        if(All_Save.Time_Circle_1[1].gameObject.activeSelf == false)
        {
            //Ÿ�Ӷ��� �ȿ� ���׶��1 �ݱ�
            All_Save.Time_Circle_1_Index = 0;
            All_Save.Time_Circle_1[0].gameObject.SetActive(true);
            All_Save.Time_Circle_1[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Time_Circle_1", All_Save.Time_Circle_1_Index);
        }
        
        if(All_Save.Time_Circle_2[1].gameObject.activeSelf == false)
        {
            //Ÿ�Ӷ��� �ȿ� ���׶�� 2 �ݱ�
            All_Save.Time_Circle_2_Index = 0;
            All_Save.Time_Circle_2[0].gameObject.SetActive(true);
            All_Save.Time_Circle_2[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Time_Circle_2", All_Save.Time_Circle_2_Index);
        }

        


        //Ÿ�Ӷ��� �׸� �������� ������
        //�ڹ��� ���·� �д�.
        //Ÿ�Ӷ��� ū �׸� �����ְ�

        if (All_Save.Time_Line_Open[1].gameObject.activeSelf == false)
        {
            All_Save.Time_Line_Open_Index = 0;
            All_Save.Time_Line_Open[0].gameObject.SetActive(true);
            All_Save.Time_Line_Open[1].gameObject.SetActive(false);

            //�ڵ� �����ϱ�
            PlayerPrefs.SetInt("TimeLine", All_Save.Time_Line_Open_Index);
        }

        //�׸� ���빰 �ȿ� �ִ� �͵� �Ȱ��� �����Ѵ�.

        if (All_Save.Time_Run[1].gameObject.activeSelf == false)
        {
            All_Save.Time_Run_Index = 0;
            All_Save.Time_Run[0].gameObject.SetActive(true);
            All_Save.Time_Run[1].gameObject.SetActive(false);

            PlayerPrefs.SetInt("TimeLine_Run", All_Save.Time_Run_Index);
        }
        






        //���� ����
        //���� ��Ʈ ���� ���� ������ �ʴٸ� 
        //�ڹ��� ���·� �д�(������ �� ���� �� �� false�����̱� ����)

        if (All_Save.Achieve_1[1].gameObject.activeSelf == false && All_Save.Achieve_1[2].gameObject.activeSelf == false)
        {
            //1�� ����
            All_Save.Achieve1_Index = 0;
            All_Save.Achieve_1[0].gameObject.SetActive(true);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);
        }

        if (All_Save.Achieve_2[1].gameObject.activeSelf == false && All_Save.Achieve_2[2].gameObject.activeSelf == false)
        {
            //2�� ����
            All_Save.Achieve2_Index = 0;
            All_Save.Achieve_2[0].gameObject.SetActive(true);
            All_Save.Achieve_2[1].gameObject.SetActive(false);
            All_Save.Achieve_2[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_2", All_Save.Achieve2_Index);
        }

        if (All_Save.Achieve_3[1].gameObject.activeSelf == false && All_Save.Achieve_3[2].gameObject.activeSelf == false)
        {
            //3�� ����
            All_Save.Achieve3_Index = 0;
            All_Save.Achieve_3[0].gameObject.SetActive(true);
            All_Save.Achieve_3[1].gameObject.SetActive(false);
            All_Save.Achieve_3[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_3", All_Save.Achieve3_Index);
        }

        if (All_Save.Achieve_4[1].gameObject.activeSelf == false && All_Save.Achieve_4[2].gameObject.activeSelf == false)
        {
            //4�� ����
            All_Save.Achieve4_Index = 0;
            All_Save.Achieve_4[0].gameObject.SetActive(true);
            All_Save.Achieve_4[1].gameObject.SetActive(false);
            All_Save.Achieve_4[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_4", All_Save.Achieve4_Index);
        }

        if (All_Save.Achieve_5[1].gameObject.activeSelf == false && All_Save.Achieve_5[2].gameObject.activeSelf == false)
        {
            //5�� ����
            All_Save.Achieve5_Index = 0;
            All_Save.Achieve_5[0].gameObject.SetActive(true);
            All_Save.Achieve_5[1].gameObject.SetActive(false);
            All_Save.Achieve_5[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_5", All_Save.Achieve5_Index);
        }

        if (All_Save.Achieve_6[1].gameObject.activeSelf == false && All_Save.Achieve_6[2].gameObject.activeSelf == false)
        {
            //6�� ����
            All_Save.Achieve6_Index = 0;
            All_Save.Achieve_6[0].gameObject.SetActive(true);
            All_Save.Achieve_6[1].gameObject.SetActive(false);
            All_Save.Achieve_6[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_6", All_Save.Achieve6_Index);
        }

        if (All_Save.Achieve_7[1].gameObject.activeSelf == false && All_Save.Achieve_7[2].gameObject.activeSelf == false)
        {
            //7�� ����
            All_Save.Achieve7_Index = 0;
            All_Save.Achieve_7[0].gameObject.SetActive(true);
            All_Save.Achieve_7[1].gameObject.SetActive(false);
            All_Save.Achieve_7[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_7", All_Save.Achieve7_Index);
        }

        if (All_Save.Achieve_8[1].gameObject.activeSelf == false && All_Save.Achieve_8[2].gameObject.activeSelf == false)
        {
            //8�� ����
            All_Save.Achieve8_Index = 0;
            All_Save.Achieve_8[0].gameObject.SetActive(true);
            All_Save.Achieve_8[1].gameObject.SetActive(false);
            All_Save.Achieve_8[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_8", All_Save.Achieve8_Index);
        }

        if (All_Save.Achieve_9[1].gameObject.activeSelf == false && All_Save.Achieve_9[2].gameObject.activeSelf == false)
        {
            //9�� ����
            All_Save.Achieve9_Index = 0;
            All_Save.Achieve_9[0].gameObject.SetActive(true);
            All_Save.Achieve_9[1].gameObject.SetActive(false);
            All_Save.Achieve_9[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_9", All_Save.Achieve9_Index);
        }

        if (All_Save.Achieve_10[1].gameObject.activeSelf == false && All_Save.Achieve_10[2].gameObject.activeSelf == false)
        {
            //10�� ����
            All_Save.Achieve10_Index = 0;
            All_Save.Achieve_10[0].gameObject.SetActive(true);
            All_Save.Achieve_10[1].gameObject.SetActive(false);
            All_Save.Achieve_10[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_10", All_Save.Achieve10_Index);
        }

        if (All_Save.Achieve_11[1].gameObject.activeSelf == false && All_Save.Achieve_11[2].gameObject.activeSelf == false)
        {
            //11�� ����
            All_Save.Achieve11_Index = 0;
            All_Save.Achieve_11[0].gameObject.SetActive(true);
            All_Save.Achieve_11[1].gameObject.SetActive(false);
            All_Save.Achieve_11[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_11", All_Save.Achieve11_Index);
        }

        if (All_Save.Achieve_12[1].gameObject.activeSelf == false && All_Save.Achieve_12[2].gameObject.activeSelf == false)
        {
            //12�� ����
            All_Save.Achieve12_Index = 0;
            All_Save.Achieve_12[0].gameObject.SetActive(true);
            All_Save.Achieve_12[1].gameObject.SetActive(false);
            All_Save.Achieve_12[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_12", All_Save.Achieve12_Index);
        }

        //�ٹ� ����
        if(All_Save.Album_1[1].gameObject.activeSelf == false && All_Save.Album_1[2].gameObject.activeSelf == false)
        {
            //1�� �ٹ�
            All_Save.Album1_Index = 0;
            All_Save.Album_1[0].gameObject.SetActive(true);
            All_Save.Album_1[1].gameObject.SetActive(false);
            All_Save.Album_1[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_1", All_Save.Album1_Index);


        }

        if (All_Save.Album_2[1].gameObject.activeSelf == false && All_Save.Album_2[2].gameObject.activeSelf == false)
        {
            //2�� �ٹ�
            All_Save.Album2_Index = 0;
            All_Save.Album_2[0].gameObject.SetActive(true);
            All_Save.Album_2[1].gameObject.SetActive(false);
            All_Save.Album_2[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_2", All_Save.Album2_Index);


        }

        if (All_Save.Album_3[1].gameObject.activeSelf == false && All_Save.Album_3[2].gameObject.activeSelf == false)
        {
            //3�� �ٹ�
            All_Save.Album3_Index = 0;
            All_Save.Album_3[0].gameObject.SetActive(true);
            All_Save.Album_3[1].gameObject.SetActive(false);
            All_Save.Album_3[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_3", All_Save.Album3_Index);


        }

        if (All_Save.Album_4[1].gameObject.activeSelf == false && All_Save.Album_4[2].gameObject.activeSelf == false)
        {
            //4�� �ٹ�
            All_Save.Album4_Index = 0;
            All_Save.Album_4[0].gameObject.SetActive(true);
            All_Save.Album_4[1].gameObject.SetActive(false);
            All_Save.Album_4[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_4", All_Save.Album4_Index);


        }

        if (All_Save.Album_5[1].gameObject.activeSelf == false && All_Save.Album_5[2].gameObject.activeSelf == false)
        {
            //5�� �ٹ�
            All_Save.Album5_Index = 0;
            All_Save.Album_5[0].gameObject.SetActive(true);
            All_Save.Album_5[1].gameObject.SetActive(false);
            All_Save.Album_5[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);


        }

        if (All_Save.Album_6[1].gameObject.activeSelf == false && All_Save.Album_6[2].gameObject.activeSelf == false)
        {
            //6�� �ٹ�
            All_Save.Album6_Index = 0;
            All_Save.Album_6[0].gameObject.SetActive(true);
            All_Save.Album_6[1].gameObject.SetActive(false);
            All_Save.Album_6[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_6", All_Save.Album6_Index);


        }

        if (All_Save.Album_7[1].gameObject.activeSelf == false && All_Save.Album_7[2].gameObject.activeSelf == false)
        {
            //7�� �ٹ�
            All_Save.Album7_Index = 0;
            All_Save.Album_7[0].gameObject.SetActive(true);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);


        }

        if (All_Save.Album_8[1].gameObject.activeSelf == false && All_Save.Album_8[2].gameObject.activeSelf == false)
        {
            //8�� �ٹ�
            All_Save.Album8_Index = 0;
            All_Save.Album_8[0].gameObject.SetActive(true);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);


        }

        if (All_Save.Album_9[1].gameObject.activeSelf == false && All_Save.Album_9[2].gameObject.activeSelf == false)
        {
            //9�� �ٹ�
            All_Save.Album9_Index = 0;
            All_Save.Album_9[0].gameObject.SetActive(true);
            All_Save.Album_9[1].gameObject.SetActive(false);
            All_Save.Album_9[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_9", All_Save.Album9_Index);


        }

        if (All_Save.Album_10[1].gameObject.activeSelf == false && All_Save.Album_10[2].gameObject.activeSelf == false)
        {
            //10�� �ٹ�
            All_Save.Album10_Index = 0;
            All_Save.Album_10[0].gameObject.SetActive(true);
            All_Save.Album_10[1].gameObject.SetActive(false);
            All_Save.Album_10[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_10", All_Save.Album10_Index);


        }

        if (All_Save.Album_11[1].gameObject.activeSelf == false && All_Save.Album_11[2].gameObject.activeSelf == false)
        {
            //11�� �ٹ�
            All_Save.Album11_Index = 0;
            All_Save.Album_11[0].gameObject.SetActive(true);
            All_Save.Album_11[1].gameObject.SetActive(false);
            All_Save.Album_11[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_11", All_Save.Album11_Index);


        }

        if (All_Save.Album_12[1].gameObject.activeSelf == false && All_Save.Album_12[2].gameObject.activeSelf == false)
        {
            //12�� �ٹ�
            All_Save.Album12_Index = 0;
            All_Save.Album_12[0].gameObject.SetActive(true);
            All_Save.Album_12[1].gameObject.SetActive(false);
            All_Save.Album_12[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_12", All_Save.Album12_Index);


        }








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

        //Fade.SetActive(true);
        FadeObject.fadeObject[8].gameObject.SetActive(true);


        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

        FadeObject.fadeObject[12].gameObject.SetActive(false);

        

       


        QuestObject.Line_Index = 0;
        QuestObject.questObject[139].gameObject.SetActive(false);

        QuestObject.questObject[0].gameObject.SetActive(true);
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

        Line_0_Index = 0;
        inside_Line_0[0].gameObject.SetActive(false);
        inside_Line_0[1].gameObject.SetActive(false);
        inside_Line_0[2].gameObject.SetActive(false);
        inside_Line_0[3].gameObject.SetActive(false);
        inside_Line_0[4].gameObject.SetActive(false);
        inside_Line_0[5].gameObject.SetActive(false);
        inside_Line_0[6].gameObject.SetActive(false);
        inside_Line_0[7].gameObject.SetActive(false);
        inside_Line_0[8].gameObject.SetActive(false);
        inside_Line_0[9].gameObject.SetActive(false);
        inside_Line_0[10].gameObject.SetActive(false);
        inside_Line_0[11].gameObject.SetActive(false);
        inside_Line_0[12].gameObject.SetActive(false);

        //TextContainer1.offsetMin = new Vector2(0, -2342.113f);//(��, �Ʒ�)
        //TextContainer1.offsetMax = new Vector2(0, 0.02746582f);    //(��, ��)

    }

    public IEnumerator Please_Wait_One_Second()
    {
        yield return new WaitForSeconds(1.0f);


        if (All_Save.Ending1[1].gameObject.activeSelf == true && All_Save.Ending2[1].gameObject.activeSelf == true && All_Save.Ending3[1].gameObject.activeSelf == true && All_Save.Ending4[1].gameObject.activeSelf == true)
        {
            //4���� ���� ��θ� ����������

            //12�� ������ �ر��Ѵ�.
            //���� �޼� �ִϸ��̼ǵ� �����Ѵ�.

            Achieve_Obj.SetActive(true);
            //Ȱ��ȭ ��Ų��.
            //���� ������Ʈ�� ���̰� �Ѵ�.
            Achieve.SetBool("A_Button", true);
            //���� �޼� �ִϸ��̼ǵ� �����Ѵ�.

            //12�� ���� �� �����Ѵ�.
            All_Save.Achieve12_Index = 2;
            All_Save.Achieve_12[0].gameObject.SetActive(false);
            All_Save.Achieve_12[1].gameObject.SetActive(false);
            All_Save.Achieve_12[2].gameObject.SetActive(true);


            //12��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_12", All_Save.Achieve12_Index);

            //1�� ���� �׸�
            All_Save.Ending1_Index = 1;
            All_Save.Ending1[0].gameObject.SetActive(false);
            All_Save.Ending1[1].gameObject.SetActive(true);

            PlayerPrefs.SetInt("First_Ending", All_Save.Ending1_Index);

            //2�� ���� �׸�
            All_Save.Ending2_Index = 1;
            All_Save.Ending2[0].gameObject.SetActive(false);
            All_Save.Ending2[1].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Second_Ending", All_Save.Ending2_Index);

            //3�� ���� �׸�
            All_Save.Ending3_Index = 1;
            All_Save.Ending3[0].gameObject.SetActive(false);
            All_Save.Ending3[1].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Thrid_Ending", All_Save.Ending3_Index);

            //4�� ���� �׸�
            All_Save.Ending4_Index = 1;
            All_Save.Ending4[0].gameObject.SetActive(false);
            All_Save.Ending4[1].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Fourth_Ending", All_Save.Ending4_Index);

            //1�� ������ �����Ѵ�.
            All_Save.Achieve1_Index = 2;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(true);

            //2�� ������ �����Ѵ�.
            All_Save.Achieve2_Index = 2;
            All_Save.Achieve_2[0].gameObject.SetActive(false);
            All_Save.Achieve_2[1].gameObject.SetActive(false);
            All_Save.Achieve_2[2].gameObject.SetActive(true);

            //3�� ������ �����Ѵ�.
            All_Save.Achieve3_Index = 2;
            All_Save.Achieve_3[0].gameObject.SetActive(false);
            All_Save.Achieve_3[1].gameObject.SetActive(false);
            All_Save.Achieve_3[2].gameObject.SetActive(true);

            //4�� ������ �����Ѵ�.
            All_Save.Achieve4_Index = 2;
            All_Save.Achieve_4[0].gameObject.SetActive(false);
            All_Save.Achieve_4[1].gameObject.SetActive(false);
            All_Save.Achieve_4[2].gameObject.SetActive(true);

            //5�� ������ �����Ѵ�.
            All_Save.Achieve5_Index = 2;
            All_Save.Achieve_5[0].gameObject.SetActive(false);
            All_Save.Achieve_5[1].gameObject.SetActive(false);
            All_Save.Achieve_5[2].gameObject.SetActive(true);

            //6�� ������ �����Ѵ�.
            All_Save.Achieve6_Index = 2;
            All_Save.Achieve_6[0].gameObject.SetActive(false);
            All_Save.Achieve_6[1].gameObject.SetActive(false);
            All_Save.Achieve_6[2].gameObject.SetActive(true);

            //7�� ������ �����Ѵ�.
            All_Save.Achieve7_Index = 2;
            All_Save.Achieve_7[0].gameObject.SetActive(false);
            All_Save.Achieve_7[1].gameObject.SetActive(false);
            All_Save.Achieve_7[2].gameObject.SetActive(true);

            //1��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

            //2��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_2", All_Save.Achieve2_Index);

            //3��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_3", All_Save.Achieve3_Index);

            //4��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_4", All_Save.Achieve4_Index);

            //5��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_5", All_Save.Achieve5_Index);

            //6��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_6", All_Save.Achieve6_Index);

            //7��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_7", All_Save.Achieve7_Index);

            //8 ( 1�� ���� )
            All_Save.Achieve8_Index = 2;
            All_Save.Achieve_8[0].gameObject.SetActive(false);
            All_Save.Achieve_8[1].gameObject.SetActive(false);
            All_Save.Achieve_8[2].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Achieve_8", All_Save.Achieve8_Index);

            //9 ( 2�� ���� )
            All_Save.Achieve9_Index = 2;
            All_Save.Achieve_9[0].gameObject.SetActive(false);
            All_Save.Achieve_9[1].gameObject.SetActive(false);
            All_Save.Achieve_9[2].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Achieve_9", All_Save.Achieve9_Index);

            //10 ( 3�� ���� )
            All_Save.Achieve10_Index = 2;
            All_Save.Achieve_10[0].gameObject.SetActive(false);
            All_Save.Achieve_10[1].gameObject.SetActive(false);
            All_Save.Achieve_10[2].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Achieve_10", All_Save.Achieve10_Index);

            //11 ( 4�� ���� )
            All_Save.Achieve11_Index = 2;
            All_Save.Achieve_11[0].gameObject.SetActive(false);
            All_Save.Achieve_11[1].gameObject.SetActive(false);
            All_Save.Achieve_11[2].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Achieve_11", All_Save.Achieve11_Index);



        }

        //���� 12�� �������� �� ������ ���
        //�ִϸ��̼��� �������� �ʴ´�.
        else if (All_Save.Achieve_12[2].gameObject.activeSelf == true)
        {
            //12�� ���� �� �����Ѵ�.
            All_Save.Achieve12_Index = 2;
            All_Save.Achieve_12[0].gameObject.SetActive(false);
            All_Save.Achieve_12[1].gameObject.SetActive(false);
            All_Save.Achieve_12[2].gameObject.SetActive(true);


            //12��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_12", All_Save.Achieve12_Index);

            //1�� ���� �׸�
            All_Save.Ending1_Index = 1;
            All_Save.Ending1[0].gameObject.SetActive(false);
            All_Save.Ending1[1].gameObject.SetActive(true);

            PlayerPrefs.SetInt("First_Ending", All_Save.Ending1_Index);

            //2�� ���� �׸�
            All_Save.Ending2_Index = 1;
            All_Save.Ending2[0].gameObject.SetActive(false);
            All_Save.Ending2[1].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Second_Ending", All_Save.Ending2_Index);

            //3�� ���� �׸�
            All_Save.Ending3_Index = 1;
            All_Save.Ending3[0].gameObject.SetActive(false);
            All_Save.Ending3[1].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Thrid_Ending", All_Save.Ending3_Index);

            //4�� ���� �׸�
            All_Save.Ending4_Index = 1;
            All_Save.Ending4[0].gameObject.SetActive(false);
            All_Save.Ending4[1].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Fourth_Ending", All_Save.Ending4_Index);

            //1�� ������ �����Ѵ�.
            All_Save.Achieve1_Index = 2;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(true);

            //2�� ������ �����Ѵ�.
            All_Save.Achieve2_Index = 2;
            All_Save.Achieve_2[0].gameObject.SetActive(false);
            All_Save.Achieve_2[1].gameObject.SetActive(false);
            All_Save.Achieve_2[2].gameObject.SetActive(true);

            //3�� ������ �����Ѵ�.
            All_Save.Achieve3_Index = 2;
            All_Save.Achieve_3[0].gameObject.SetActive(false);
            All_Save.Achieve_3[1].gameObject.SetActive(false);
            All_Save.Achieve_3[2].gameObject.SetActive(true);

            //4�� ������ �����Ѵ�.
            All_Save.Achieve4_Index = 2;
            All_Save.Achieve_4[0].gameObject.SetActive(false);
            All_Save.Achieve_4[1].gameObject.SetActive(false);
            All_Save.Achieve_4[2].gameObject.SetActive(true);

            //5�� ������ �����Ѵ�.
            All_Save.Achieve5_Index = 2;
            All_Save.Achieve_5[0].gameObject.SetActive(false);
            All_Save.Achieve_5[1].gameObject.SetActive(false);
            All_Save.Achieve_5[2].gameObject.SetActive(true);

            //6�� ������ �����Ѵ�.
            All_Save.Achieve6_Index = 2;
            All_Save.Achieve_6[0].gameObject.SetActive(false);
            All_Save.Achieve_6[1].gameObject.SetActive(false);
            All_Save.Achieve_6[2].gameObject.SetActive(true);

            //7�� ������ �����Ѵ�.
            All_Save.Achieve7_Index = 2;
            All_Save.Achieve_7[0].gameObject.SetActive(false);
            All_Save.Achieve_7[1].gameObject.SetActive(false);
            All_Save.Achieve_7[2].gameObject.SetActive(true);

            //1��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

            //2��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_2", All_Save.Achieve2_Index);

            //3��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_3", All_Save.Achieve3_Index);

            //4��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_4", All_Save.Achieve4_Index);

            //5��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_5", All_Save.Achieve5_Index);

            //6��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_6", All_Save.Achieve6_Index);

            //7��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
            PlayerPrefs.SetInt("Achieve_7", All_Save.Achieve7_Index);

            //8 ( 1�� ���� )
            All_Save.Achieve8_Index = 2;
            All_Save.Achieve_8[0].gameObject.SetActive(false);
            All_Save.Achieve_8[1].gameObject.SetActive(false);
            All_Save.Achieve_8[2].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Achieve_8", All_Save.Achieve8_Index);

            //9 ( 2�� ���� )
            All_Save.Achieve9_Index = 2;
            All_Save.Achieve_9[0].gameObject.SetActive(false);
            All_Save.Achieve_9[1].gameObject.SetActive(false);
            All_Save.Achieve_9[2].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Achieve_9", All_Save.Achieve9_Index);

            //10 ( 3�� ���� )
            All_Save.Achieve10_Index = 2;
            All_Save.Achieve_10[0].gameObject.SetActive(false);
            All_Save.Achieve_10[1].gameObject.SetActive(false);
            All_Save.Achieve_10[2].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Achieve_10", All_Save.Achieve10_Index);

            //11 ( 4�� ���� )
            All_Save.Achieve11_Index = 2;
            All_Save.Achieve_11[0].gameObject.SetActive(false);
            All_Save.Achieve_11[1].gameObject.SetActive(false);
            All_Save.Achieve_11[2].gameObject.SetActive(true);

            PlayerPrefs.SetInt("Achieve_11", All_Save.Achieve11_Index);
        }
    }


    public IEnumerator Wait_4_Second_Achivement()
    {
        yield return new WaitForSeconds(5.0f);

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
        yield return new WaitForSeconds(6.0f);
        Achieve_Obj.SetActive(false);
    }

    public IEnumerator Between_0_1()
    {
        yield return new WaitForSeconds(2.5f);
        //Line_1.SetActive(true);
        //0

        
        //Go_Black.SetActive(false);//���̵� �����

        TextContainer1.offsetMin = new Vector2(0, -2342.113f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 0.02746582f);    //(��, ��)



    }




    public IEnumerator WaitSecond_1()
    {
        yield return new WaitForSeconds(3.0f);
        //Line_1.SetActive(true);
        //0

        // *** �ڵ����� ���� ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);



        Line_0_Index = 0;
        inside_Line_0[0].gameObject.SetActive(true);

        



        /*FadeObject.Fade_Index = 8;

        FadeObject.fadeObject[8].gameObject.SetActive(false);*/
        //FadeObject.fadeObject[12].gameObject.SetActive(false);


        //Go_Black.SetActive(false);//���̵� �����

        TextContainer1.offsetMin = new Vector2(0, -2342.113f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 0.02746582f);    //(��, ��)

        

    }

    


    public IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(4.5f);
        //Line_2.SetActive(true);
        //1

        

        Line_0_Index = 1;
        inside_Line_0[1].gameObject.SetActive(true);


        TextContainer1.offsetMin = new Vector2(0, -2342.113f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 0.02746582f);    //(��, ��)

        


    }

    public IEnumerator WaitSecond_3()
    {
        yield return new WaitForSeconds(6.0f);
        //Line_3.SetActive(true);

        //2

        Line_0_Index = 2;
        inside_Line_0[2].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2342.113f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 0.02746582f);    //(��, ��)

        
    }

    public IEnumerator WaitSecond_4()
    {
        yield return new WaitForSeconds(7.5f);
       // Line_4.SetActive(true);
        //3
        Line_0_Index = 3;
        inside_Line_0[3].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2334.173f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 7.917236f);    //(��, ��)

        

    }

    public IEnumerator WaitSecond_5()
    {
        yield return new WaitForSeconds(9.0f);
       // Line_5.SetActive(true);
        //4
        Line_0_Index = 4;
        inside_Line_0[4].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2038.702f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 303.3876f);    //(��, ��)

        

    }

    public IEnumerator WaitSecond_6()
    {
        yield return new WaitForSeconds(10.5f);
        //Line_6.SetActive(true);
        //5
        Line_0_Index = 5;
        inside_Line_0[5].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -1896.324f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 445.7661f);    //(��, ��)

        

    }

    public IEnumerator WaitSecond_7()
    {
        yield return new WaitForSeconds(12.0f);
       // Line_7.SetActive(true);
        //6
        Line_0_Index = 6;
        inside_Line_0[6].gameObject.SetActive(true);

        // *** ù ��° ������ �ٹ� ��Ʈ �����ֱ� ***
        
        if(All_Save.Achieve_1[2].gameObject.activeSelf==true)
        {
            All_Save.Achieve1_Index = 2;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(true);
        }
        //�ڹ��踸 ���̴� ���¸� ��Ʈ����
        else if (All_Save.Achieve_1[0].gameObject.activeSelf == true)
        {
            All_Save.Achieve1_Index = 1;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(true);
            All_Save.Achieve_1[2].gameObject.SetActive(false);
        }
        
        //��Ʈ�� ���̴� ���¸� ��Ʈ �״��
        else if (All_Save.Achieve_1[1].gameObject.activeSelf == true)
        {
            All_Save.Achieve1_Index = 1;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(true);
            All_Save.Achieve_1[2].gameObject.SetActive(false);
        }

        // *** ������ �ٹ� ������ �� �ڵ����� ***
        PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

        



        TextContainer1.offsetMin = new Vector2(0, -1598.066f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 744.024f);    //(��, ��)

        

    }

    public IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(13.5f);
        //Line_8.SetActive(true);
        //7

        Line_0_Index = 7;
        inside_Line_0[7].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -1316.533f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 1025.557f);    //(��, ��)

        

    }

    public IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(15.0f);
       // Line_9.SetActive(true);
        //8

        Line_0_Index = 8;
        inside_Line_0[8].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0,-1127.607f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 1214.483f);    //(��, ��)

        

    }

    public IEnumerator WaitSecond_10()
    {
        yield return new WaitForSeconds(16.5f);
       // Line_10.SetActive(true);
        //9

        Line_0_Index = 9;
        inside_Line_0[9].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -932.8553f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 1409.234f);    //(��, ��)

        

    }

    public IEnumerator WaitSecond_11()
    {
        yield return new WaitForSeconds(18.0f);
        //Line_11.SetActive(true);
        //10
        Line_0_Index = 10;
        inside_Line_0[10].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -612.2979f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 1729.792f);    //(��, ��)

        

    }

    public IEnumerator WaitSecond_12()
    {
        yield return new WaitForSeconds(19.5f);
        //Line_12.SetActive(true);
        //11
        Line_0_Index = 11;
        inside_Line_0[11].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -425.5383f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 1916.552f);    //(��, -��)

        FadeObject.Fade_Index = 8;

        FadeObject.fadeObject[8].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_13()
    {
        yield return new WaitForSeconds(21.0f);
       // Line_13.SetActive(true);
        //12
        Line_0_Index = 12;
        inside_Line_0[12].gameObject.SetActive(true);

        inside_1.Line_1_Index = 0;
        inside_1.inside_Line_1[0].gameObject.SetActive(false);
        inside_1.inside_Line_1[1].gameObject.SetActive(false);
        inside_1.inside_Line_1[2].gameObject.SetActive(false);
        inside_1.inside_Line_1[3].gameObject.SetActive(false);
        inside_1.inside_Line_1[4].gameObject.SetActive(false);
        inside_1.inside_Line_1[5].gameObject.SetActive(false);
        inside_1.inside_Line_1[6].gameObject.SetActive(false);
        inside_1.inside_Line_1[7].gameObject.SetActive(false);
        inside_1.inside_Line_1[8].gameObject.SetActive(false);
        inside_1.inside_Line_1[9].gameObject.SetActive(false);
        inside_1.inside_Line_1[10].gameObject.SetActive(false);
        inside_1.inside_Line_1[11].gameObject.SetActive(false);
        inside_1.inside_Line_1[12].gameObject.SetActive(false);

        inside_2.Line_2_Index = 0;
        inside_2.inside_Line_2[0].gameObject.SetActive(false);
        inside_2.inside_Line_2[1].gameObject.SetActive(false);
        inside_2.inside_Line_2[2].gameObject.SetActive(false);
        inside_2.inside_Line_2[3].gameObject.SetActive(false);
        inside_2.inside_Line_2[4].gameObject.SetActive(false);
        inside_2.inside_Line_2[5].gameObject.SetActive(false);
        inside_2.inside_Line_2[6].gameObject.SetActive(false);
        inside_2.inside_Line_2[7].gameObject.SetActive(false);
        inside_2.inside_Line_2[8].gameObject.SetActive(false);
        inside_2.inside_Line_2[9].gameObject.SetActive(false);
        inside_2.inside_Line_2[10].gameObject.SetActive(false);
        inside_2.inside_Line_2[11].gameObject.SetActive(false);
        inside_2.inside_Line_2[12].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.05053711f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 2342.142f);    //(��, -��)

        

    }

}
