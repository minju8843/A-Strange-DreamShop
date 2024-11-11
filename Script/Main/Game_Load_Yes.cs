using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Game_Load_Yes : MonoBehaviour
{
    //public GameObject Ticket_Count_Panel;

    public Save_Collection save;

    public Fast_2023 Setting_fast;
    public SFX_2023 sfx_Manager;
    public Bgm_2023 bgm;

    public GameObject Game_Data_Load;
    public GameObject Successful_Load;

    public Only_Line questObject;//é��1 ���� ��Ƴ��� ��
    //public GameObject Go_Black;
    //public GameObject Go_Empty;

    public Fade_Collect FadeObject;

    public IEnumerator m_Coroutine;

    public GameObject Setting;

    public R_Wait1 inside_0;
    public Sum_1_1_1 inside_1;
    public Sum_1_1_2 inside_2;

    public R_Wait1_2_1 inside_5;
    public R_Wait1_2_4 inside_8;
    public R_Wait1_3_1 inside_9;
    public R_Wait1_3_2 inside_13;
    public R_Wait1_3_5 inside_15;
    public R_Wait1_3_6 inside_11;

    //������� ������
    public Next_1_3_1 inside_17;
    public Next_1_3_2 inside_21;
    public Next_1_3_5 inside_23;
    public Next_1_3_6 inside_19;

    public R_Wait1_4_1 inside_25;
    public R_Wait1_4_3 inside_29;
    public R_Wait1_4_9 inside_34;
    public R_Wait1_4_11 inside_37;

    public R_Wait1_5_1 inside_41;
    public R_Wait1_5_2 inside_57;
    public R_Wait1_5_5 inside_45;
    public R_Wait1_5_6 inside_61;
    public R_Wait1_5_17 inside_49;
    public R_Wait1_5_18 inside_65;
    public R_Wait1_5_21 inside_53;
    public R_Wait1_5_22 inside_69;




    //������ʹ� ����
    public R_Wait1_6_1 inside1_6_1;//1-6-1 �ȿ� �ִ� �� ���� �� �����Ϸ��� ����
    public R_Wait_1_6_2 inside1_6_2;//1-6-1 �ȿ� �ִ� �� ���� �� �����Ϸ��� ����
    public R_Wait1_6_3 inside1_6_3;
    public R_Wait1_6_4 inside1_6_4;
    public R_Wait1_6_9 inside1_6_9;
    public R_Wait1_6_30 inside1_6_30;
    public R_Wait1_6_11 inside1_6_11;
    public R_Wait1_6_12 inside1_6_12;
    public R_Wait1_6_33 inside1_6_33;
    public R_Wait1_6_34 inside1_6_34;
    public R_Wait1_6_35 inside1_6_35;
    public R_Wait1_6_36 inside1_6_36;
    public R_Wait1_6_41 inside1_6_41;
    public R_Wait_1_6_42 inside1_6_42;
    public R_Wait1_6_43 inside1_6_43;
    public R_Wait1_6_44 inside1_6_44;

    public Like_1_4_11 like_1_4_11;
    public Line_141 inside_141;
    public Line_142 inside_142;
    public Line_143 inside_143;
    public Line_144 inside_144;
    public Line_145 inside_145;
    public Line_146 inside_146;


    //���ߴ°� fix�� �ְ� ���� �ε��ϴ� �� �� ��ũ��Ʈ�� update�� ������
    //->���ڱ� �׳� ȭ���� ��������. �װ� ����� ������

    //���ߴ°� fix�� �ְ� ���� �ε��ϴ� �� �� ��ũ��Ʈ�� fix�� ������
    //->���ڱ� �׳� ȭ���� ��������. �װ� ����� ������


    //���߰� ����ϴ� �� update�� �ְ� ���� �ε��ϴ� �� �� ��ũ��Ʈ�� ������
    //�̶� ������Ʈ�� true �� ���� �����ߴ�.
    //=>����

    //���߰� ����ϴ� �� update�� �ְ� ���� �ε��ϴ� �� �� ��ũ��Ʈ�� ������
    //=>�̤�

    //Game_Load_Yes_Ok() �ٷ� �ؿ� ������
    //=>�����


    //void Update()
    //{
        /*if (Successful_Load.activeSelf == true&&SceneManager.GetActiveScene().name == "Setting")
        {

            Time.timeScale = 1;
            Debug.Log("���� �ε� Ÿ�� ��������"+Time.timeScale+"�̴�.");
            //�Լ��� �ƴ϶� �� �ε忡 �����߽��ϴ�
            //��� ������ �� �Լ� ����� ���ÿ� Ÿ�ӽ����� 1�� �ϸ� ��

        }

        if (Successful_Load.activeSelf == true && questObject.questObject[0].gameObject.activeSelf==true)
        {

            Time.timeScale = 1;
            Debug.Log("���� �ε� Ÿ�� ��������" + Time.timeScale + "�̴�.");

        }

        if (Successful_Load.activeSelf == true && questObject.questObject[3].gameObject.activeSelf == true)
        {

            Time.timeScale = 1;
            Debug.Log("���� �ε� Ÿ�� ��������" + Time.timeScale + "�̴�.");

        }

        if (Successful_Load.activeSelf == true && questObject.questObject[4].gameObject.activeSelf == true)
        {

            Time.timeScale = 1;
            Debug.Log("���� �ε� Ÿ�� ��������" + Time.timeScale + "�̴�.");

        }*/
    //}

    public void Game_Load_Yes_Ok()
    {//���� ������ �ε� Ŭ���ϰ� Ȯ�� ������ ���������� �ҷ������� ���

        /*if (Successful_Load.activeSelf == true && SceneManager.GetActiveScene().name == "Setting")
        {

            Time.timeScale = 1;
            Debug.Log("���� �ε� Ÿ�� ��������" + Time.timeScale + "�̴�.");
            //�Լ��� �ƴ϶� �� �ε忡 �����߽��ϴ�
            //��� ������ �� �Լ� ����� ���ÿ� Ÿ�ӽ����� 1�� �ϸ� ��

        }*/

        

        StartCoroutine(WaitSecond_1());
        StartCoroutine(WaitSecond_2());

        

        IEnumerator WaitSecond_1()
        {
            yield return new WaitForSeconds(0.0f);
            

            Game_Data_Load.SetActive(false);
            Successful_Load.SetActive(false);

            FadeObject.Fade_Index = 12;

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
            FadeObject.fadeObject[12].gameObject.SetActive(true);
            FadeObject.fadeObject[13].gameObject.SetActive(false);
            FadeObject.fadeObject[14].gameObject.SetActive(false);


        }

        IEnumerator WaitSecond_2()
        {
            

            yield return new WaitForSeconds(1.5f);
            
            /*if (Successful_Load.activeSelf == true && SceneManager.GetActiveScene().name == "Setting")
            {

                Time.timeScale = 1;
                Debug.Log("���� �ε� Ÿ�� ��������" + Time.timeScale + "�̴�.");
                //�Լ��� �ƴ϶� �� �ε忡 �����߽��ϴ�
                //��� ������ �� �Լ� ����� ���ÿ� Ÿ�ӽ����� 1�� �ϸ� ��

            }*/

            //���� �ε��� �͵�...
            Debug.Log("���� �ε�");

            //SFX 
            /*float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
            sfx_Manager.back_SFX_Vol = SFX_Sd;
            Debug.Log(SFX_Sd + "�� ������ ȿ���� ũ��");


            //BGM
            float BGM_Sound = PlayerPrefs.GetFloat("backvol");
            bgm.backVol = BGM_Sound;
            Debug.Log(BGM_Sound + "�� ������ ����� ũ��");

            //���ǵ�
            float Auto_Speed = PlayerPrefs.GetFloat("Speed");
            Setting_fast.Speed = Auto_Speed;
            Debug.Log(Auto_Speed + "�� ������ ���ǵ�");*/

            //����1
            int Ending_1 = PlayerPrefs.GetInt("First_Ending");
            save.Ending1_Index = Ending_1;
            save.Ending1[Ending_1].gameObject.SetActive(true);


            //����2
            int Ending_2 = PlayerPrefs.GetInt("Second_Ending");
            save.Ending2_Index = Ending_2;
            save.Ending2[Ending_2].gameObject.SetActive(true);

            //����3
            int Ending_3 = PlayerPrefs.GetInt("Thrid_Ending");
            save.Ending3_Index = Ending_3;
            save.Ending3[Ending_3].gameObject.SetActive(true);


            //����4
            int Ending_4 = PlayerPrefs.GetInt("Fourth_Ending");
            save.Ending4_Index = Ending_4;
            save.Ending4[Ending_4].gameObject.SetActive(true);


            //����
            int Auto_Boss = PlayerPrefs.GetInt("Boss");
            save.Boss_Index = Auto_Boss;
            save.Boss[Auto_Boss].gameObject.SetActive(true);

            //�Ҹ�
            int Auto_Sori = PlayerPrefs.GetInt("Sori");
            save.Sori_Index = Auto_Sori;
            save.Sori[Auto_Sori].gameObject.SetActive(true);

            //��¥ ����
            int Auto_Fake_Boss = PlayerPrefs.GetInt("Fake_Boss");
            save.Fake_Boss_Index = Auto_Fake_Boss;
            save.Fake_Boss[Auto_Fake_Boss].gameObject.SetActive(true);


            //������
            int Auto_Black_Face_Man = PlayerPrefs.GetInt("Black_Face_Man");
            save.Black_Face_Man_Index = Auto_Black_Face_Man;
            save.Black_Face_Man[Auto_Black_Face_Man].gameObject.SetActive(true);


            //Ÿ�Ӷ��� ū �׸�
            int Auto_TimeLine_1 = PlayerPrefs.GetInt("TimeLine");
            save.Time_Line_Open_Index = Auto_TimeLine_1;
            save.Time_Line_Open[Auto_TimeLine_1].gameObject.SetActive(true);

            //Ÿ�Ӷ��� �߰����� ����
            int Auto_Time_Run = PlayerPrefs.GetInt("TimeLine_Run");
            save.Time_Run_Index = Auto_Time_Run;
            save.Time_Run[Auto_Time_Run].gameObject.SetActive(true);


            //Ÿ�Ӷ��� �ȿ� ���׶��1
            int Auto_Circle_1 = PlayerPrefs.GetInt("Time_Circle_1");
            save.Time_Circle_1_Index = Auto_Circle_1;
            save.Time_Circle_1[Auto_Circle_1].gameObject.SetActive(true);

            //Ÿ�Ӷ��� �ȿ� ���׶��2
            int Auto_Circle_2 = PlayerPrefs.GetInt("Time_Circle_2");
            save.Time_Circle_2_Index = Auto_Circle_2;
            save.Time_Circle_2[Auto_Circle_2].gameObject.SetActive(true);


            //1�� ����
            int Auto_Achieve_1 = PlayerPrefs.GetInt("Achieve_1");
            save.Achieve1_Index = Auto_Achieve_1;
            save.Achieve_1[Auto_Achieve_1].gameObject.SetActive(true);

            //2�� ����
            int Auto_Achieve_2 = PlayerPrefs.GetInt("Achieve_2");
            save.Achieve2_Index = Auto_Achieve_2;
            save.Achieve_2[Auto_Achieve_2].gameObject.SetActive(true);

            //3�� ����
            //��� ������
            int Auto_Achieve_3 = PlayerPrefs.GetInt("Achieve_3");
            save.Achieve3_Index = Auto_Achieve_3;
            save.Achieve_3[Auto_Achieve_3].gameObject.SetActive(true);

            //4�� ����
            //��� ������
            int Auto_Achieve_4 = PlayerPrefs.GetInt("Achieve_4");
            save.Achieve4_Index = Auto_Achieve_4;
            save.Achieve_4[Auto_Achieve_4].gameObject.SetActive(true);

            //5�� ����
            int Auto_Achieve_5 = PlayerPrefs.GetInt("Achieve_5");
            save.Achieve5_Index = Auto_Achieve_5;
            save.Achieve_5[Auto_Achieve_5].gameObject.SetActive(true);

            //6�� ����
            int Auto_Achieve_6 = PlayerPrefs.GetInt("Achieve_6");
            save.Achieve6_Index = Auto_Achieve_6;
            save.Achieve_6[Auto_Achieve_6].gameObject.SetActive(true);

            //7�� ����
            int Auto_Achieve_7 = PlayerPrefs.GetInt("Achieve_7");
            save.Achieve7_Index = Auto_Achieve_7;
            save.Achieve_7[Auto_Achieve_7].gameObject.SetActive(true);

            //8�� ����
            int Auto_Achieve_8 = PlayerPrefs.GetInt("Achieve_8");
            save.Achieve8_Index = Auto_Achieve_8;
            save.Achieve_8[Auto_Achieve_8].gameObject.SetActive(true);

            //9�� ����
            int Auto_Achieve_9 = PlayerPrefs.GetInt("Achieve_9");
            save.Achieve9_Index = Auto_Achieve_9;
            save.Achieve_9[Auto_Achieve_9].gameObject.SetActive(true);

            //10�� ����
            int Auto_Achieve_10 = PlayerPrefs.GetInt("Achieve_10");
            save.Achieve10_Index = Auto_Achieve_10;
            save.Achieve_10[Auto_Achieve_10].gameObject.SetActive(true);

            //11�� ����
            int Auto_Achieve_11 = PlayerPrefs.GetInt("Achieve_11");
            save.Achieve11_Index = Auto_Achieve_11;
            save.Achieve_11[Auto_Achieve_11].gameObject.SetActive(true);

            //12�� ����
            //��� ������
            int Auto_Achieve_12 = PlayerPrefs.GetInt("Achieve_12");
            save.Achieve12_Index = Auto_Achieve_12;
            save.Achieve_12[Auto_Achieve_12].gameObject.SetActive(true);


            //1�� �ٹ�
            int Auto_Album_1 = PlayerPrefs.GetInt("Album_1");
            save.Album1_Index = Auto_Album_1;
            save.Album_1[Auto_Album_1].gameObject.SetActive(true);

            //2�� �ٹ�
            int Auto_Album_2 = PlayerPrefs.GetInt("Album_2");
            save.Album2_Index = Auto_Album_2;
            save.Album_2[Auto_Album_2].gameObject.SetActive(true);

            //3�� �ٹ�
            int Auto_Album_3 = PlayerPrefs.GetInt("Album_3");
            save.Album3_Index = Auto_Album_3;
            save.Album_3[Auto_Album_3].gameObject.SetActive(true);

            //4�� �ٹ�
            int Auto_Album_4 = PlayerPrefs.GetInt("Album_4");
            save.Album4_Index = Auto_Album_4;
            save.Album_4[Auto_Album_4].gameObject.SetActive(true);

            //5�� �ٹ�
            int Auto_Album_5 = PlayerPrefs.GetInt("Album_5");
            save.Album5_Index = Auto_Album_5;
            save.Album_5[Auto_Album_5].gameObject.SetActive(true);

            //6�� �ٹ�
            int Auto_Album_6 = PlayerPrefs.GetInt("Album_6");
            save.Album6_Index = Auto_Album_6;
            save.Album_6[Auto_Album_6].gameObject.SetActive(true);

            //7�� �ٹ�
            int Auto_Album_7 = PlayerPrefs.GetInt("Album_7");
            save.Album7_Index = Auto_Album_7;
            save.Album_7[Auto_Album_7].gameObject.SetActive(true);

            //8�� �ٹ�
            int Auto_Album_8 = PlayerPrefs.GetInt("Album_8");
            save.Album8_Index = Auto_Album_8;
            save.Album_8[Auto_Album_8].gameObject.SetActive(true);

            //9�� �ٹ�
            int Auto_Album_9 = PlayerPrefs.GetInt("Album_9");
            save.Album9_Index = Auto_Album_9;
            save.Album_9[Auto_Album_9].gameObject.SetActive(true);

            //10�� �ٹ�
            int Auto_Album_10 = PlayerPrefs.GetInt("Album_10");
            save.Album10_Index = Auto_Album_10;
            save.Album_10[Auto_Album_10].gameObject.SetActive(true);

            //11�� �ٹ�
            int Auto_Album_11 = PlayerPrefs.GetInt("Album_11");
            save.Album11_Index = Auto_Album_11;
            save.Album_11[Auto_Album_11].gameObject.SetActive(true);

            //12�� �ٹ�
            int Auto_Album_12 = PlayerPrefs.GetInt("Album_12");
            save.Album12_Index = Auto_Album_12;
            save.Album_12[Auto_Album_12].gameObject.SetActive(true);




            //1��° ���� ����
            inside_0.Line_0_Index = 0;
            inside_0.inside_Line_0[0].gameObject.SetActive(false);
            inside_0.inside_Line_0[1].gameObject.SetActive(false);
            inside_0.inside_Line_0[2].gameObject.SetActive(false);
            inside_0.inside_Line_0[3].gameObject.SetActive(false);
            inside_0.inside_Line_0[4].gameObject.SetActive(false);
            inside_0.inside_Line_0[5].gameObject.SetActive(false);
            inside_0.inside_Line_0[6].gameObject.SetActive(false);
            inside_0.inside_Line_0[7].gameObject.SetActive(false);
            inside_0.inside_Line_0[8].gameObject.SetActive(false);
            inside_0.inside_Line_0[9].gameObject.SetActive(false);
            inside_0.inside_Line_0[10].gameObject.SetActive(false);
            inside_0.inside_Line_0[11].gameObject.SetActive(false);
            inside_0.inside_Line_0[12].gameObject.SetActive(false);


            //int BGM_Index = PlayerPrefs.GetInt("BGM_Index");
            int Line_Index = PlayerPrefs.GetInt("Index");
            Debug.Log(Line_Index + "�ҷ�����");

            

            questObject.Line_Index = Line_Index;
            questObject.questObject[Line_Index].gameObject.SetActive(true);

            /*questObject.BGM_Index = BGM_Index;
            questObject.Audio_Object[BGM_Index].gameObject.SetActive(true);*/

    


            if (Line_Index == 0)
            {
                

                inside_0.m_Coroutine = inside_0.NewCoroutine();
                StartCoroutine(inside_0.m_Coroutine);
                Debug.Log("0 ��������");





            }

            if (Line_Index == 3)
            {
                questObject.Go_Thrid_Line();
                inside_1.m_Coroutine = inside_1.NewCoroutine();
                StartCoroutine(inside_1.m_Coroutine);
                Debug.Log("1���� 3 ��������");
            }

            if (Line_Index == 4)
            {
                questObject.Go_Fourth_Line();
                inside_2.m_Coroutine = inside_2.NewCoroutine();
                StartCoroutine(inside_2.m_Coroutine);
                Debug.Log("2���� 4 ��������");
            }

            if (Line_Index == 5)
            {
                questObject.Go_Fifth_Line();

                inside_5.m_Coroutine = inside_5.NewCoroutine();
                StartCoroutine(inside_5.m_Coroutine);
                Debug.Log("5��° ��������");
            }

            if (Line_Index == 6)
            {
                questObject.Go_Six_Line();

                inside_8.m_Coroutine = inside_8.NewCoroutine();
                StartCoroutine(inside_8.m_Coroutine);
                Debug.Log("6��° ��������");
            }

            if (Line_Index == 7)
            {
                questObject.Go_Seven_Line();
                inside_5.m_Coroutine = inside_5.NewCoroutine();
                StartCoroutine(inside_5.m_Coroutine);
                Debug.Log("7��° ��������");
            }

            if (Line_Index == 8)
            {
                //8��° ������ ���� �� ��

                questObject.Go_Eight_Line();
                inside_8.m_Coroutine = inside_8.NewCoroutine();
                StartCoroutine(inside_8.m_Coroutine);
                Debug.Log("8��° ��������");
            }

            if (Line_Index == 9)
            {
                questObject.Go_Nine_Line();
                inside_9.m_Coroutine = inside_9.NewCoroutine();
                StartCoroutine(inside_9.m_Coroutine);
                Debug.Log("9��° ��������");
            }

            if (Line_Index == 10)
            {
                questObject.Go_Ten_Line();
                inside_9.m_Coroutine = inside_9.NewCoroutine();
                StartCoroutine(inside_9.m_Coroutine);
                Debug.Log("10��° ��������");
            }

            if (Line_Index == 11)
            {
                questObject.Go_Eleven_Line();
                inside_11.m_Coroutine = inside_11.NewCoroutine();
                StartCoroutine(inside_11.m_Coroutine);
                Debug.Log("11��° ��������");
            }

            if (Line_Index == 12)
            {
                questObject.Go_Twelve_Line();
                inside_11.m_Coroutine = inside_11.NewCoroutine();
                StartCoroutine(inside_11.m_Coroutine);
                Debug.Log("12��° ��������");
            }

            if (Line_Index == 13)
            {
                questObject.Go_Thirteen_Line();
                inside_13.m_Coroutine = inside_13.NewCoroutine();
                StartCoroutine(inside_13.m_Coroutine);
                Debug.Log("13��° ��������");
            }

            if (Line_Index == 14)
            {
                questObject.Go_Fourteen_Line();
                inside_13.m_Coroutine = inside_13.NewCoroutine();
                StartCoroutine(inside_13.m_Coroutine);
                Debug.Log("14��° ��������");
            }

            if (Line_Index == 15)
            {
                questObject.Go_Fifteen_Line();
                inside_15.m_Coroutine = inside_15.NewCoroutine();
                StartCoroutine(inside_15.m_Coroutine);
                Debug.Log("15��° ��������");
            }

            if (Line_Index == 16)
            {
                questObject.Go_Sixteen_Line();
                inside_15.m_Coroutine = inside_15.NewCoroutine();
                StartCoroutine(inside_15.m_Coroutine);
                Debug.Log("16��° ��������");
            }

            if (Line_Index == 17)
            {
                questObject.Go_Seventeen_Line();
                inside_17.m_Coroutine = inside_17.NewCoroutine();
                StartCoroutine(inside_17.m_Coroutine);
                Debug.Log("17��° ��������");
            }

            if (Line_Index == 18)
            {
                questObject.Go_Eighteen_Line();
                inside_17.m_Coroutine = inside_17.NewCoroutine();
                StartCoroutine(inside_17.m_Coroutine);
                Debug.Log("18��° ��������");
            }

            if (Line_Index == 19)
            {
                questObject.Go_Nineteen_Line();
                inside_19.m_Coroutine = inside_19.NewCoroutine();
                StartCoroutine(inside_19.m_Coroutine);
                Debug.Log("19��° ��������");
            }

            if (Line_Index == 20)
            {
                questObject.Go_Twenty_Line();
                inside_19.m_Coroutine = inside_19.NewCoroutine();
                StartCoroutine(inside_19.m_Coroutine);
                Debug.Log("20��° ��������");
            }

            if (Line_Index == 21)
            {
                questObject.Go_TwentyOne_Line();
                inside_21.m_Coroutine = inside_21.NewCoroutine();
                StartCoroutine(inside_21.m_Coroutine);
                Debug.Log("21��° ��������");
            }

            if (Line_Index == 22)
            {
                questObject.Go_TwentyTwo_Line();
                inside_21.m_Coroutine = inside_21.NewCoroutine();
                StartCoroutine(inside_21.m_Coroutine);
                Debug.Log("22��° ��������");
            }

            if (Line_Index == 23)
            {
                questObject.Go_TwentyThree_Line();
                inside_23.m_Coroutine = inside_23.NewCoroutine();
                StartCoroutine(inside_23.m_Coroutine);
                Debug.Log("23��° ��������");
            }

            if (Line_Index == 24)
            {
                questObject.Go_TwentyFour_Line();
                inside_23.m_Coroutine = inside_23.NewCoroutine();
                StartCoroutine(inside_23.m_Coroutine);
                Debug.Log("24��° ��������");
            }

            if (Line_Index == 25)
            {
                questObject.Go_TwentyFive_Line();
                inside_25.m_Coroutine = inside_25.NewCoroutine();
                StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("25��° ��������");
            }

            if (Line_Index == 26)
            {
                questObject.Go_TwentySix_Line();
                inside_25.m_Coroutine = inside_25.NewCoroutine();
                StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("26��° ��������");
            }

            if (Line_Index == 27)
            {
                questObject.Go_TwentySeven_Line();
                inside_25.m_Coroutine = inside_25.NewCoroutine();
                StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("27��° ��������");
            }

            if (Line_Index == 28)
            {
                questObject.Go_TwentyEight_Line();
                inside_25.m_Coroutine = inside_25.NewCoroutine();
                StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("28��° ��������");
            }

            if (Line_Index == 29)
            {
                questObject.Go_TwentyNine_Line();
                inside_29.m_Coroutine = inside_29.NewCoroutine();
                StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("29��° ��������");
            }

            if (Line_Index == 30)
            {
                questObject.Go_Thirty_Line();
                inside_29.m_Coroutine = inside_29.NewCoroutine();
                StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("30��° ��������");
            }

            if (Line_Index == 31)
            {
                questObject.Go_ThirtyOne_Line();
                inside_29.m_Coroutine = inside_29.NewCoroutine();
                StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("31��° ��������");
            }

            if (Line_Index == 32)
            {
                questObject.Go_ThirtyTwo_Line();
                inside_29.m_Coroutine = inside_29.NewCoroutine();
                StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("32��° ��������");
            }

            if (Line_Index == 33)
            {
                questObject.Go_ThirtyThree_Line();
                inside_34.m_Coroutine = inside_34.NewCoroutine();
                StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("33��° ��������");
            }

            if (Line_Index == 34)
            {
                questObject.Go_ThirtyFour_Line();
                inside_34.m_Coroutine = inside_34.NewCoroutine();
                StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("34��° ��������");
            }

            if (Line_Index == 35)
            {
                questObject.Go_ThirtyFive_Line();
                inside_34.m_Coroutine = inside_34.NewCoroutine();
                StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("35��° ��������");
            }

            if (Line_Index == 36)
            {
                questObject.Go_ThirtySix_Line();
                inside_34.m_Coroutine = inside_34.NewCoroutine();
                StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("36��° ��������");
            }

            if (Line_Index == 37)
            {
                questObject.Go_ThirtySeven_Line();
                inside_37.m_Coroutine = inside_37.NewCoroutine();
                StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("37��° ��������");
            }

            if (Line_Index == 38)
            {
                questObject.Go_ThirtyEight_Line();
                inside_37.m_Coroutine = inside_37.NewCoroutine();
                StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("38��° ��������");
            }

            if (Line_Index == 39)
            {
                questObject.Go_ThirtyNine_Line();
                inside_37.m_Coroutine = inside_37.NewCoroutine();
                StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("39��° ��������");
            }

            if (Line_Index == 40)
            {
                questObject.Go_Forty_Line();
                inside_37.m_Coroutine = inside_37.NewCoroutine();
                StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("40��° ��������");
            }

            if (Line_Index == 41)
            {
                questObject.Go_41_Line();
                inside_41.m_Coroutine = inside_41.NewCoroutine();
                StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("41��° ��������");
            }

            if (Line_Index == 42)
            {
                questObject.Go_42_Line();
                inside_41.m_Coroutine = inside_41.NewCoroutine();
                StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("42��° ��������");
            }

            if (Line_Index == 43)
            {
                questObject.Go_43_Line();
                inside_41.m_Coroutine = inside_41.NewCoroutine();
                StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("43��° ��������");
            }

            if (Line_Index == 44)
            {
                questObject.Go_44_Line();
                inside_41.m_Coroutine = inside_41.NewCoroutine();
                StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("44��° ��������");
            }

            if (Line_Index == 45)
            {
                questObject.Go_45_Line();
                inside_45.m_Coroutine = inside_45.NewCoroutine();
                StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("45��° ��������");
            }

            if (Line_Index == 46)
            {
                questObject.Go_46_Line();
                inside_45.m_Coroutine = inside_45.NewCoroutine();
                StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("46��° ��������");
            }

            if (Line_Index == 47)
            {
                questObject.Go_47_Line();
                inside_45.m_Coroutine = inside_45.NewCoroutine();
                StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("47��° ��������");
            }

            if (Line_Index == 48)
            {
                questObject.Go_48_Line();
                inside_45.m_Coroutine = inside_45.NewCoroutine();
                StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("48��° ��������");
            }

            if (Line_Index == 49)
            {
                questObject.Go_49_Line();
                inside_49.m_Coroutine = inside_49.NewCoroutine();
                StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("49��° ��������");
            }

            if (Line_Index == 50)
            {
                questObject.Go_50_Line();
                inside_49.m_Coroutine = inside_49.NewCoroutine();
                StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("50��° ��������");
            }

            if (Line_Index == 51)
            {
                questObject.Go_51_Line();
                inside_49.m_Coroutine = inside_49.NewCoroutine();
                StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("51��° ��������");
            }

            if (Line_Index == 52)
            {
                questObject.Go_52_Line();
                inside_49.m_Coroutine = inside_49.NewCoroutine();
                StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("52��° ��������");
            }


            if (Line_Index == 53)
            {
                questObject.Go_53_Line();
                inside_53.m_Coroutine = inside_53.NewCoroutine();
                StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("53��° ��������");
            }

            if (Line_Index == 54)
            {
                questObject.Go_54_Line();
                inside_53.m_Coroutine = inside_53.NewCoroutine();
                StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("54��° ��������");
            }

            if (Line_Index == 55)
            {
                questObject.Go_55_Line();
                inside_53.m_Coroutine = inside_53.NewCoroutine();
                StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("55��° ��������");
            }

            if (Line_Index == 56)
            {
                questObject.Go_56_Line();
                inside_53.m_Coroutine = inside_53.NewCoroutine();
                StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("56��° ��������");
            }

            if (Line_Index == 57)
            {
                questObject.Go_57_Line();
                inside_57.m_Coroutine = inside_57.NewCoroutine();
                StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("57��° ��������");
            }

            if (Line_Index == 58)
            {
                questObject.Go_58_Line();
                inside_57.m_Coroutine = inside_57.NewCoroutine();
                StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("58��° ��������");
            }

            if (Line_Index == 59)
            {
                questObject.Go_59_Line();
                inside_57.m_Coroutine = inside_57.NewCoroutine();
                StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("59��° ��������");
            }

            if (Line_Index == 60)
            {
                questObject.Go_60_Line();
                inside_57.m_Coroutine = inside_57.NewCoroutine();
                StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("60��° ��������");
            }

            if (Line_Index == 61)
            {
                questObject.Go_61_Line();
                inside_61.m_Coroutine = inside_61.NewCoroutine();
                StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("61��° ��������");
            }

            if (Line_Index == 62)
            {
                questObject.Go_62_Line();
                inside_61.m_Coroutine = inside_61.NewCoroutine();
                StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("62��° ��������");
            }

            if (Line_Index == 63)
            {
                questObject.Go_63_Line();
                inside_61.m_Coroutine = inside_61.NewCoroutine();
                StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("63��° ��������");
            }

            if (Line_Index == 64)
            {
                questObject.Go_64_Line();
                inside_61.m_Coroutine = inside_61.NewCoroutine();
                StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("64��° ��������");
            }

            if (Line_Index == 65)
            {
                questObject.Go_65_Line();
                inside_65.m_Coroutine = inside_65.NewCoroutine();
                StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("65��° ��������");
            }

            if (Line_Index == 66)
            {
                questObject.Go_66_Line();
                inside_65.m_Coroutine = inside_65.NewCoroutine();
                StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("66��° ��������");
            }

            if (Line_Index == 67)
            {
                questObject.Go_67_Line();
                inside_65.m_Coroutine = inside_65.NewCoroutine();
                StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("67��° ��������");
            }

            if (Line_Index == 68)
            {
                questObject.Go_68_Line();
                inside_65.m_Coroutine = inside_65.NewCoroutine();
                StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("68��° ��������");
            }

            if (Line_Index == 69)
            {
                questObject.Go_69_Line();
                inside_69.m_Coroutine = inside_69.NewCoroutine();
                StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("69��° ��������");
            }

            if (Line_Index == 70)
            {
                questObject.Go_70_Line();
                inside_69.m_Coroutine = inside_69.NewCoroutine();
                StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("70��° ��������");
            }

            if (Line_Index == 71)
            {
                questObject.Go_71_Line();
                inside_69.m_Coroutine = inside_69.NewCoroutine();
                StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("71��° ��������");
            }

            if (Line_Index == 72)
            {
                questObject.Go_72_Line();
                inside_69.m_Coroutine = inside_69.NewCoroutine();
                StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("72��° ��������");
            }

            if (Line_Index == 73)
            {
                questObject.Go_73_Line();
                inside1_6_1.m_Coroutine = inside1_6_1.WaitSecond_0();
                StartCoroutine(inside1_6_1.m_Coroutine);
                Debug.Log("73��° ��������");
            }

            if (Line_Index == 74)
            {
                questObject.Go_74_Line();
                inside1_6_1.m_Coroutine = inside1_6_1.WaitSecond_0();
                StartCoroutine(inside1_6_1.m_Coroutine);
                Debug.Log("74��° ��������");
            }

            if (Line_Index == 75)
            {
                questObject.Go_75_Line();
                inside1_6_1.m_Coroutine = inside1_6_1.WaitSecond_0();
                StartCoroutine(inside1_6_1.m_Coroutine);
                Debug.Log("75��° ��������");
            }

            if (Line_Index == 76)
            {
                questObject.Go_76_Line();
                inside1_6_1.m_Coroutine = inside1_6_1.WaitSecond_0();
                StartCoroutine(inside1_6_1.m_Coroutine);
                Debug.Log("76��° ��������");
            }

            if (Line_Index == 77)
            {
                questObject.Go_77_Line();
                inside1_6_2.m_Coroutine = inside1_6_2.WaitSecond_0();
                StartCoroutine(inside1_6_2.m_Coroutine);
                Debug.Log("77��° ��������");
            }

            if (Line_Index == 78)
            {
                questObject.Go_78_Line();
                inside1_6_2.m_Coroutine = inside1_6_2.WaitSecond_0();
                StartCoroutine(inside1_6_2.m_Coroutine);
                Debug.Log("78��° ��������");
            }

            if (Line_Index == 79)
            {
                questObject.Go_79_Line();
                inside1_6_2.m_Coroutine = inside1_6_2.WaitSecond_0();
                StartCoroutine(inside1_6_2.m_Coroutine);
                Debug.Log("79��° ��������");
            }

            if (Line_Index == 80)
            {
                questObject.Go_80_Line();
                inside1_6_2.m_Coroutine = inside1_6_2.WaitSecond_0();
                StartCoroutine(inside1_6_2.m_Coroutine);
                Debug.Log("80��° ��������");
            }

            if (Line_Index == 81)
            {
                questObject.Go_81_Line();
                inside1_6_3.m_Coroutine = inside1_6_3.WaitSecond_0();
                StartCoroutine(inside1_6_3.m_Coroutine);
                Debug.Log("81��° ��������");
            }

            if (Line_Index == 82)
            {
                questObject.Go_82_Line();
                inside1_6_3.m_Coroutine = inside1_6_3.WaitSecond_0();
                StartCoroutine(inside1_6_3.m_Coroutine);
                Debug.Log("82��° ��������");
            }

            if (Line_Index == 83)
            {
                questObject.Go_83_Line();
                inside1_6_3.m_Coroutine = inside1_6_3.WaitSecond_0();
                StartCoroutine(inside1_6_3.m_Coroutine);
                Debug.Log("83��° ��������");
            }

            if (Line_Index == 84)
            {
                questObject.Go_84_Line();
                inside1_6_3.m_Coroutine = inside1_6_3.WaitSecond_0();
                StartCoroutine(inside1_6_3.m_Coroutine);
                Debug.Log("84��° ��������");
            }

            if (Line_Index == 85)
            {
                questObject.Go_85_Line();
                inside1_6_4.m_Coroutine = inside1_6_4.WaitSecond_0();
                StartCoroutine(inside1_6_4.m_Coroutine);
                Debug.Log("85��° ��������");
            }

            if (Line_Index == 86)
            {
                questObject.Go_86_Line();
                inside1_6_4.m_Coroutine = inside1_6_4.WaitSecond_0();
                StartCoroutine(inside1_6_4.m_Coroutine);
                Debug.Log("86��° ��������");
            }

            if (Line_Index == 87)
            {
                questObject.Go_87_Line();
                inside1_6_4.m_Coroutine = inside1_6_4.WaitSecond_0();
                StartCoroutine(inside1_6_4.m_Coroutine);
                Debug.Log("87��° ��������");
            }

            if (Line_Index == 88)
            {
                questObject.Go_88_Line();
                inside1_6_4.m_Coroutine = inside1_6_4.WaitSecond_0();
                StartCoroutine(inside1_6_4.m_Coroutine);
                Debug.Log("88��° ��������");
            }

            if (Line_Index == 89)
            {
                questObject.Go_89_Line();
                inside1_6_9.m_Coroutine = inside1_6_9.WaitSecond_0();
                StartCoroutine(inside1_6_9.m_Coroutine);
                Debug.Log("89��° ��������"); ;
            }

            if (Line_Index == 90)
            {
                questObject.Go_90_Line();
                inside1_6_9.m_Coroutine = inside1_6_9.WaitSecond_0();
                StartCoroutine(inside1_6_9.m_Coroutine);
                Debug.Log("90��° ��������");
            }

            if (Line_Index == 91)
            {
                questObject.Go_91_Line();
                inside1_6_9.m_Coroutine = inside1_6_9.WaitSecond_0();
                StartCoroutine(inside1_6_9.m_Coroutine);
                Debug.Log("91��° ��������");
            }

            if (Line_Index == 92)
            {
                questObject.Go_92_Line();
                inside1_6_9.m_Coroutine = inside1_6_9.WaitSecond_0();
                StartCoroutine(inside1_6_9.m_Coroutine);
                Debug.Log("92��° ��������");
            }

            if (Line_Index == 93)
            {
                questObject.Go_93_Line();
                inside1_6_30.m_Coroutine = inside1_6_30.WaitSecond_0();
                StartCoroutine(inside1_6_30.m_Coroutine);
                Debug.Log("93��° ��������");
            }

            if (Line_Index == 94)
            {
                questObject.Go_94_Line();
                inside1_6_30.m_Coroutine = inside1_6_30.WaitSecond_0();
                StartCoroutine(inside1_6_30.m_Coroutine);
                Debug.Log("94��° ��������");
            }

            if (Line_Index == 95)
            {
                questObject.Go_95_Line();
                inside1_6_30.m_Coroutine = inside1_6_30.WaitSecond_0();
                StartCoroutine(inside1_6_30.m_Coroutine);
                Debug.Log("95��° ��������");
            }

            if (Line_Index == 96)
            {
                questObject.Go_96_Line();
                inside1_6_30.m_Coroutine = inside1_6_30.WaitSecond_0();
                StartCoroutine(inside1_6_30.m_Coroutine);
                Debug.Log("96��° ��������");
            }

            if (Line_Index == 97)
            {
                questObject.Go_97_Line();
                inside1_6_11.m_Coroutine = inside1_6_11.WaitSecond_0();
                StartCoroutine(inside1_6_11.m_Coroutine);
                Debug.Log("97��° ��������");
            }

            if (Line_Index == 98)
            {
                questObject.Go_98_Line();
                inside1_6_11.m_Coroutine = inside1_6_11.WaitSecond_0();
                StartCoroutine(inside1_6_11.m_Coroutine);
                Debug.Log("98��° ��������");
            }

            if (Line_Index == 99)
            {
                questObject.Go_99_Line();
                inside1_6_11.m_Coroutine = inside1_6_11.WaitSecond_0();
                StartCoroutine(inside1_6_11.m_Coroutine);
                Debug.Log("99��° ��������");
            }

            if (Line_Index == 100)
            {
                questObject.Go_100_Line();
                inside1_6_11.m_Coroutine = inside1_6_11.WaitSecond_0();
                StartCoroutine(inside1_6_11.m_Coroutine);
                Debug.Log("100��° ��������");
            }

            if (Line_Index == 101)
            {
                questObject.Go_101_Line();
                inside1_6_12.m_Coroutine = inside1_6_12.WaitSecond_0();
                StartCoroutine(inside1_6_12.m_Coroutine);
                Debug.Log("101��° ��������");
            }

            if (Line_Index == 102)
            {
                questObject.Go_102_Line();
                inside1_6_12.m_Coroutine = inside1_6_12.WaitSecond_0();
                StartCoroutine(inside1_6_12.m_Coroutine);
                Debug.Log("102��° ��������");
            }

            if (Line_Index == 103)
            {
                questObject.Go_103_Line();
                inside1_6_12.m_Coroutine = inside1_6_12.WaitSecond_0();
                StartCoroutine(inside1_6_12.m_Coroutine);
                Debug.Log("103��° ��������");
            }

            if (Line_Index == 104)
            {
                questObject.Go_104_Line();
                inside1_6_12.m_Coroutine = inside1_6_12.WaitSecond_0();
                StartCoroutine(inside1_6_12.m_Coroutine);
                Debug.Log("104��° ��������");
            }

            if (Line_Index == 105)
            {
                questObject.Go_105_Line();
                inside1_6_33.m_Coroutine = inside1_6_33.WaitSecond_0();
                StartCoroutine(inside1_6_33.m_Coroutine);
                Debug.Log("105��° ��������");
            }

            if (Line_Index == 106)
            {
                questObject.Go_106_Line();
                inside1_6_33.m_Coroutine = inside1_6_33.WaitSecond_0();
                StartCoroutine(inside1_6_33.m_Coroutine);
                Debug.Log("106��° ��������");
            }

            if (Line_Index == 107)
            {
                questObject.Go_107_Line();
                inside1_6_33.m_Coroutine = inside1_6_33.WaitSecond_0();
                StartCoroutine(inside1_6_33.m_Coroutine);
                Debug.Log("107��° ��������");
            }

            if (Line_Index == 108)
            {
                questObject.Go_108_Line();
                inside1_6_33.m_Coroutine = inside1_6_33.WaitSecond_0();
                StartCoroutine(inside1_6_33.m_Coroutine);
                Debug.Log("108��° ��������");
            }

            if (Line_Index == 109)
            {
                questObject.Go_109_Line();
                inside1_6_34.m_Coroutine = inside1_6_34.WaitSecond_0();
                StartCoroutine(inside1_6_34.m_Coroutine);
                Debug.Log("109��° ��������");
            }

            if (Line_Index == 110)
            {
                questObject.Go_110_Line();
                inside1_6_34.m_Coroutine = inside1_6_34.WaitSecond_0();
                StartCoroutine(inside1_6_34.m_Coroutine);
                Debug.Log("110��° ��������");
            }

            if (Line_Index == 111)
            {
                questObject.Go_111_Line();
                inside1_6_34.m_Coroutine = inside1_6_34.WaitSecond_0();
                StartCoroutine(inside1_6_34.m_Coroutine);
                Debug.Log("111��° ��������");
            }

            if (Line_Index == 112)
            {
                questObject.Go_112_Line();
                inside1_6_34.m_Coroutine = inside1_6_34.WaitSecond_0();
                StartCoroutine(inside1_6_34.m_Coroutine);
                Debug.Log("112��° ��������");
            }

            if (Line_Index == 113)
            {
                questObject.Go_113_Line();
                inside1_6_35.m_Coroutine = inside1_6_35.WaitSecond_0();
                StartCoroutine(inside1_6_35.m_Coroutine);
                Debug.Log("113��° ��������");
            }

            if (Line_Index == 114)
            {
                questObject.Go_114_Line();
                inside1_6_35.m_Coroutine = inside1_6_35.WaitSecond_0();
                StartCoroutine(inside1_6_35.m_Coroutine);
                Debug.Log("114��° ��������");
            }

            if (Line_Index == 115)
            {
                questObject.Go_115_Line();
                inside1_6_35.m_Coroutine = inside1_6_35.WaitSecond_0();
                StartCoroutine(inside1_6_35.m_Coroutine);
                Debug.Log("115��° ��������");
            }

            if (Line_Index == 116)
            {
                questObject.Go_116_Line();
                inside1_6_35.m_Coroutine = inside1_6_35.WaitSecond_0();
                StartCoroutine(inside1_6_35.m_Coroutine);
                Debug.Log("116��° ��������");
            }

            if (Line_Index == 117)
            {
                questObject.Go_117_Line();
                inside1_6_36.m_Coroutine = inside1_6_36.WaitSecond_0();
                StartCoroutine(inside1_6_36.m_Coroutine);
                Debug.Log("117��° ��������");
            }

            if (Line_Index == 118)
            {
                questObject.Go_118_Line();
                inside1_6_36.m_Coroutine = inside1_6_36.WaitSecond_0();
                StartCoroutine(inside1_6_36.m_Coroutine);
                Debug.Log("118��° ��������");
            }

            if (Line_Index == 119)
            {
                questObject.Go_119_Line();
                inside1_6_36.m_Coroutine = inside1_6_36.WaitSecond_0();
                StartCoroutine(inside1_6_36.m_Coroutine);
                Debug.Log("119��° ��������");
            }

            if (Line_Index == 120)
            {
                questObject.Go_120_Line();
                inside1_6_36.m_Coroutine = inside1_6_36.WaitSecond_0();
                StartCoroutine(inside1_6_36.m_Coroutine);
                Debug.Log("120��° ��������");
            }

            if (Line_Index == 121)
            {
                questObject.Go_121_Line();
                inside1_6_41.m_Coroutine = inside1_6_41.WaitSecond_0();
                StartCoroutine(inside1_6_41.m_Coroutine);
                Debug.Log("121��° ��������");
            }

            if (Line_Index == 122)
            {
                questObject.Go_122_Line();
                inside1_6_41.m_Coroutine = inside1_6_41.WaitSecond_0();
                StartCoroutine(inside1_6_41.m_Coroutine);
                Debug.Log("122��° ��������");
            }

            if (Line_Index == 123)
            {
                questObject.Go_123_Line();
                inside1_6_41.m_Coroutine = inside1_6_41.WaitSecond_0();
                StartCoroutine(inside1_6_41.m_Coroutine);
                Debug.Log("123��° ��������");
            }

            if (Line_Index == 124)
            {
                questObject.Go_124_Line();
                inside1_6_41.m_Coroutine = inside1_6_41.WaitSecond_0();
                StartCoroutine(inside1_6_41.m_Coroutine);
                Debug.Log("124��° ��������");
            }

            if (Line_Index == 125)
            {
                questObject.Go_125_Line();
                inside1_6_42.m_Coroutine = inside1_6_42.WaitSecond_0();
                StartCoroutine(inside1_6_42.m_Coroutine);
                Debug.Log("125��° ��������");
            }

            if (Line_Index == 126)
            {
                questObject.Go_126_Line();
                inside1_6_42.m_Coroutine = inside1_6_42.WaitSecond_0();
                StartCoroutine(inside1_6_42.m_Coroutine);
                Debug.Log("126��° ��������");
            }

            if (Line_Index == 127)
            {
                questObject.Go_127_Line();
                inside1_6_42.m_Coroutine = inside1_6_42.WaitSecond_0();
                StartCoroutine(inside1_6_42.m_Coroutine);
                Debug.Log("127��° ��������");
            }

            if (Line_Index == 128)
            {
                questObject.Go_128_Line();
                inside1_6_42.m_Coroutine = inside1_6_42.WaitSecond_0();
                StartCoroutine(inside1_6_42.m_Coroutine);
                Debug.Log("128��° ��������");
            }

            if (Line_Index == 129)
            {
                questObject.Go_129_Line();
                inside1_6_43.m_Coroutine = inside1_6_43.WaitSecond_0();
                StartCoroutine(inside1_6_43.m_Coroutine);
                Debug.Log("129��° ��������");
            }

            if (Line_Index == 130)
            {
                questObject.Go_130_Line();
                inside1_6_43.m_Coroutine = inside1_6_43.WaitSecond_0();
                StartCoroutine(inside1_6_43.m_Coroutine);
                Debug.Log("130��° ��������");
            }

            if (Line_Index == 131)
            {
                questObject.Go_131_Line();
                inside1_6_43.m_Coroutine = inside1_6_43.WaitSecond_0();
                StartCoroutine(inside1_6_43.m_Coroutine);
                Debug.Log("131��° ��������");
            }

            if (Line_Index == 132)
            {
                questObject.Go_132_Line();
                inside1_6_43.m_Coroutine = inside1_6_43.WaitSecond_0();
                StartCoroutine(inside1_6_43.m_Coroutine);
                Debug.Log("132��° ��������");
            }

            if (Line_Index == 133)
            {
                questObject.Go_133_Line();
                inside1_6_44.m_Coroutine = inside1_6_44.WaitSecond_0();
                StartCoroutine(inside1_6_44.m_Coroutine);
                Debug.Log("133��° ��������");
            }

            if (Line_Index == 134)
            {
                questObject.Go_134_Line();
                inside1_6_44.m_Coroutine = inside1_6_44.WaitSecond_0();
                StartCoroutine(inside1_6_44.m_Coroutine);
                Debug.Log("134��° ��������");
            }

            if (Line_Index == 135)
            {
                questObject.Go_135_Line();
                inside1_6_44.m_Coroutine = inside1_6_44.WaitSecond_0();
                StartCoroutine(inside1_6_44.m_Coroutine);
                Debug.Log("135��° ��������");
            }

            if (Line_Index == 136)
            {
                questObject.Go_136_Line();
                inside1_6_44.m_Coroutine = inside1_6_44.WaitSecond_0();
                StartCoroutine(inside1_6_44.m_Coroutine);
                Debug.Log("136��° ��������");
            }

            if (Line_Index == 140)
            {
                like_1_4_11.m_Coroutine = like_1_4_11.WaitSecond_0();
                StartCoroutine(like_1_4_11.m_Coroutine);
                Debug.Log("140��° ��������");
            }

            if (Line_Index == 141)
            {
                questObject.True_Go_141();

                inside_141.m_Coroutine = inside_141.WaitSecond_0();
                StartCoroutine(inside_141.m_Coroutine);
                Debug.Log("141 ��������");
            }

            if (Line_Index == 142)
            {
                questObject.Lie_Go_142();

                inside_142.m_Coroutine = inside_142.WaitSecond_0();
                StartCoroutine(inside_142.m_Coroutine);
                Debug.Log("142 ��������");
            }

            if (Line_Index == 143)
            {
                questObject.Witch_Go_143();

                inside_143.m_Coroutine = inside_143.WaitSecond_0();
                StartCoroutine(inside_143.m_Coroutine);
                Debug.Log("143 ��������");
            }

            if (Line_Index == 144)
            {
                questObject.See_Go_144();

                inside_144.m_Coroutine = inside_144.WaitSecond_0();
                StartCoroutine(inside_144.m_Coroutine);
                Debug.Log("144 ��������");
            }

            if (Line_Index == 145)
            {
                questObject.Witch_Go_145();
                inside_145.m_Coroutine = inside_145.WaitSecond_0();
                StartCoroutine(inside_145.m_Coroutine);
                Debug.Log("145 ��������");
            }

            if (Line_Index == 146)
            {
                questObject.See_Go_146();

                inside_146.m_Coroutine = inside_146.WaitSecond_0();
                StartCoroutine(inside_146.m_Coroutine);
                Debug.Log("146 ��������");
            }

      
        

            FadeObject.Fade_Index = 8;

            FadeObject.fadeObject[1].gameObject.SetActive(false);
            FadeObject.fadeObject[2].gameObject.SetActive(false);
            FadeObject.fadeObject[3].gameObject.SetActive(false);
            FadeObject.fadeObject[4].gameObject.SetActive(false);
            FadeObject.fadeObject[5].gameObject.SetActive(false);
            FadeObject.fadeObject[6].gameObject.SetActive(false);
            FadeObject.fadeObject[7].gameObject.SetActive(false);
            FadeObject.fadeObject[8].gameObject.SetActive(true);
            FadeObject.fadeObject[9].gameObject.SetActive(false);
            FadeObject.fadeObject[10].gameObject.SetActive(false);
            FadeObject.fadeObject[11].gameObject.SetActive(false);
            FadeObject.fadeObject[12].gameObject.SetActive(false);
            FadeObject.fadeObject[13].gameObject.SetActive(false);
            FadeObject.fadeObject[14].gameObject.SetActive(false);


            //���� �� 2�� �̾���
            Setting.SetActive(false);
            

            Debug.Log(Time.timeScale);
;            SceneManager.LoadScene("Line");
            //Ticket_Count_Panel.SetActive(true);

        }

    }

}
