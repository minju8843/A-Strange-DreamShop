using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Data_Reset : MonoBehaviour
{
    public Save_Collection All_Save;
    public GameObject Game_ReSet;
    public GameObject Game_ReSet_Successful;


    public Only_Line questObject;//é��1 ���� ��Ƴ��� ��
    public Fade_Collect FadeObject;

    public IEnumerator m_Coroutine;
    public GameObject Setting;
    public R_Wait1 Wait1;

    //��� Ÿ�� ������ ������ ����
    public Fast_2023 speed;
    public Fast_2023_2 speed1;

    public SFX_2023 sfx;
    public Bgm_2023 bgm;



    public void Go_ReStart()
    {

       
        


        StartCoroutine(WaitSecond_3());
        StartCoroutine(WaitSecond_4());

        //StartCoroutine(WaitSecond_0());
        //�ڷ�ƾ�� �̷��� ���� �ű� �����?: ����
        IEnumerator WaitSecond_3()
        {
            yield return new WaitForSeconds(0.0f);


            Game_ReSet.SetActive(false);
            Game_ReSet_Successful.SetActive(false);

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


        }

        //Black_EningCradit.SetActive(true);//����ũ���� ���� ���� �˰�





        //StartCoroutine(WaitSecond_0());

        IEnumerator WaitSecond_4()
        {

            //m_IsCoroutineing = true;

            yield return new WaitForSeconds(1.5f);
            //Ƽ�� �� ����
            Tiket.Total = 10;


            questObject.Line_Index = 0;

            questObject.questObject[0].gameObject.SetActive(true);
            questObject.questObject[1].gameObject.SetActive(false);
            questObject.questObject[2].gameObject.SetActive(false);

            questObject.questObject[3].gameObject.SetActive(false);
            questObject.questObject[4].gameObject.SetActive(false);
            questObject.questObject[5].gameObject.SetActive(false);
            questObject.questObject[6].gameObject.SetActive(false);
            questObject.questObject[7].gameObject.SetActive(false);
            questObject.questObject[8].gameObject.SetActive(false);
            questObject.questObject[9].gameObject.SetActive(false);

            questObject.questObject[10].gameObject.SetActive(false);
            questObject.questObject[11].gameObject.SetActive(false);
            questObject.questObject[12].gameObject.SetActive(false);
            questObject.questObject[13].gameObject.SetActive(false);
            questObject.questObject[14].gameObject.SetActive(false);
            questObject.questObject[15].gameObject.SetActive(false);
            questObject.questObject[16].gameObject.SetActive(false);
            questObject.questObject[17].gameObject.SetActive(false);
            questObject.questObject[18].gameObject.SetActive(false);
            questObject.questObject[19].gameObject.SetActive(false);
            questObject.questObject[20].gameObject.SetActive(false);
            questObject.questObject[21].gameObject.SetActive(false);
            questObject.questObject[22].gameObject.SetActive(false);
            questObject.questObject[23].gameObject.SetActive(false);
            questObject.questObject[24].gameObject.SetActive(false);
            questObject.questObject[25].gameObject.SetActive(false);
            questObject.questObject[26].gameObject.SetActive(false);
            questObject.questObject[27].gameObject.SetActive(false);
            questObject.questObject[28].gameObject.SetActive(false);
            questObject.questObject[29].gameObject.SetActive(false);
            questObject.questObject[30].gameObject.SetActive(false);
            questObject.questObject[31].gameObject.SetActive(false);
            questObject.questObject[32].gameObject.SetActive(false);
            questObject.questObject[33].gameObject.SetActive(false);
            questObject.questObject[34].gameObject.SetActive(false);
            questObject.questObject[35].gameObject.SetActive(false);
            questObject.questObject[36].gameObject.SetActive(false);
            questObject.questObject[37].gameObject.SetActive(false);
            questObject.questObject[38].gameObject.SetActive(false);
            questObject.questObject[39].gameObject.SetActive(false);
            questObject.questObject[40].gameObject.SetActive(false);
            questObject.questObject[41].gameObject.SetActive(false);
            questObject.questObject[42].gameObject.SetActive(false);
            questObject.questObject[43].gameObject.SetActive(false);
            questObject.questObject[44].gameObject.SetActive(false);
            questObject.questObject[45].gameObject.SetActive(false);
            questObject.questObject[46].gameObject.SetActive(false);
            questObject.questObject[47].gameObject.SetActive(false);
            questObject.questObject[48].gameObject.SetActive(false);
            questObject.questObject[49].gameObject.SetActive(false);
            questObject.questObject[50].gameObject.SetActive(false);
            questObject.questObject[51].gameObject.SetActive(false);
            questObject.questObject[52].gameObject.SetActive(false);
            questObject.questObject[53].gameObject.SetActive(false);
            questObject.questObject[54].gameObject.SetActive(false);
            questObject.questObject[55].gameObject.SetActive(false);
            questObject.questObject[56].gameObject.SetActive(false);
            questObject.questObject[57].gameObject.SetActive(false);
            questObject.questObject[58].gameObject.SetActive(false);
            questObject.questObject[59].gameObject.SetActive(false);
            questObject.questObject[60].gameObject.SetActive(false);
            questObject.questObject[61].gameObject.SetActive(false);
            questObject.questObject[62].gameObject.SetActive(false);
            questObject.questObject[63].gameObject.SetActive(false);
            questObject.questObject[64].gameObject.SetActive(false);
            questObject.questObject[65].gameObject.SetActive(false);
            questObject.questObject[66].gameObject.SetActive(false);
            questObject.questObject[67].gameObject.SetActive(false);
            questObject.questObject[68].gameObject.SetActive(false);
            questObject.questObject[69].gameObject.SetActive(false);
            questObject.questObject[70].gameObject.SetActive(false);
            questObject.questObject[71].gameObject.SetActive(false);
            questObject.questObject[72].gameObject.SetActive(false);
            questObject.questObject[73].gameObject.SetActive(false);
            questObject.questObject[74].gameObject.SetActive(false);
            questObject.questObject[75].gameObject.SetActive(false);
            questObject.questObject[76].gameObject.SetActive(false);
            questObject.questObject[77].gameObject.SetActive(false);
            questObject.questObject[78].gameObject.SetActive(false);
            questObject.questObject[79].gameObject.SetActive(false);
            questObject.questObject[80].gameObject.SetActive(false);
            questObject.questObject[81].gameObject.SetActive(false);
            questObject.questObject[82].gameObject.SetActive(false);
            questObject.questObject[83].gameObject.SetActive(false);
            questObject.questObject[84].gameObject.SetActive(false);
            questObject.questObject[85].gameObject.SetActive(false);
            questObject.questObject[86].gameObject.SetActive(false);
            questObject.questObject[87].gameObject.SetActive(false);
            questObject.questObject[88].gameObject.SetActive(false);
            questObject.questObject[89].gameObject.SetActive(false);
            questObject.questObject[90].gameObject.SetActive(false);
            questObject.questObject[91].gameObject.SetActive(false);
            questObject.questObject[92].gameObject.SetActive(false);
            questObject.questObject[93].gameObject.SetActive(false);
            questObject.questObject[94].gameObject.SetActive(false);
            questObject.questObject[95].gameObject.SetActive(false);
            questObject.questObject[96].gameObject.SetActive(false);
            questObject.questObject[97].gameObject.SetActive(false);
            questObject.questObject[98].gameObject.SetActive(false);
            questObject.questObject[99].gameObject.SetActive(false);


            questObject.questObject[100].gameObject.SetActive(false);
            questObject.questObject[101].gameObject.SetActive(false);
            questObject.questObject[102].gameObject.SetActive(false);
            questObject.questObject[103].gameObject.SetActive(false);
            questObject.questObject[104].gameObject.SetActive(false);
            questObject.questObject[105].gameObject.SetActive(false);
            questObject.questObject[106].gameObject.SetActive(false);
            questObject.questObject[107].gameObject.SetActive(false);
            questObject.questObject[108].gameObject.SetActive(false);
            questObject.questObject[109].gameObject.SetActive(false);
            questObject.questObject[110].gameObject.SetActive(false);
            questObject.questObject[111].gameObject.SetActive(false);
            questObject.questObject[112].gameObject.SetActive(false);
            questObject.questObject[113].gameObject.SetActive(false);
            questObject.questObject[114].gameObject.SetActive(false);
            questObject.questObject[115].gameObject.SetActive(false);
            questObject.questObject[116].gameObject.SetActive(false);
            questObject.questObject[117].gameObject.SetActive(false);
            questObject.questObject[118].gameObject.SetActive(false);
            questObject.questObject[119].gameObject.SetActive(false);
            questObject.questObject[120].gameObject.SetActive(false);
            questObject.questObject[121].gameObject.SetActive(false);
            questObject.questObject[122].gameObject.SetActive(false);
            questObject.questObject[123].gameObject.SetActive(false);
            questObject.questObject[124].gameObject.SetActive(false);
            questObject.questObject[125].gameObject.SetActive(false);
            questObject.questObject[126].gameObject.SetActive(false);
            questObject.questObject[127].gameObject.SetActive(false);
            questObject.questObject[128].gameObject.SetActive(false);
            questObject.questObject[129].gameObject.SetActive(false);
            questObject.questObject[130].gameObject.SetActive(false);
            questObject.questObject[131].gameObject.SetActive(false);
            questObject.questObject[132].gameObject.SetActive(false);
            questObject.questObject[133].gameObject.SetActive(false);
            questObject.questObject[134].gameObject.SetActive(false);
            questObject.questObject[135].gameObject.SetActive(false);
            questObject.questObject[136].gameObject.SetActive(false);
            questObject.questObject[137].gameObject.SetActive(false);
            questObject.questObject[138].gameObject.SetActive(false);
            questObject.questObject[139].gameObject.SetActive(false);
            questObject.questObject[140].gameObject.SetActive(false);
            questObject.questObject[141].gameObject.SetActive(false);
            questObject.questObject[142].gameObject.SetActive(false);
            questObject.questObject[143].gameObject.SetActive(false);
            questObject.questObject[144].gameObject.SetActive(false);
            questObject.questObject[145].gameObject.SetActive(false);
            questObject.questObject[146].gameObject.SetActive(false);

            questObject.questObject[147].gameObject.SetActive(false);
            questObject.questObject[148].gameObject.SetActive(false);
            questObject.questObject[149].gameObject.SetActive(false);

            questObject.BGM_Index = 0;
            questObject.Audio_Object[0].gameObject.SetActive(true);
            questObject.Audio_Object[1].gameObject.SetActive(false);
            questObject.Audio_Object[2].gameObject.SetActive(false);

            /*Wait1.m_Coroutine = Wait1.NewCoroutine();
            StartCoroutine(Wait1.m_Coroutine);
            Debug.Log("ó������ ��������");

            Debug.Log("���� ����");
            Debug.Log("���� �����ϴµ� Ÿ�� ��������" + Time.timeScale + "�̴�.");*/

            //é�� 1 Ÿ�Ӷ��� �ݱ�
            All_Save.Time_Line_Open_Index = 0;
            All_Save.Time_Line_Open[0].gameObject.SetActive(true);
            All_Save.Time_Line_Open[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("TimeLine", All_Save.Time_Line_Open_Index);

            //é�� 1 Ÿ�Ӷ��� �߰����� ���� �ݱ�
            All_Save.Time_Run_Index = 0;
            All_Save.Time_Run[0].gameObject.SetActive(true);
            All_Save.Time_Run[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("TimeLine_Run", All_Save.Time_Run_Index);



            //Ÿ�Ӷ��� �ȿ� ���׶��1 �ݱ�
            All_Save.Time_Circle_1_Index = 0;
            All_Save.Time_Circle_1[0].gameObject.SetActive(true);
            All_Save.Time_Circle_1[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Time_Circle_1", All_Save.Time_Circle_1_Index);


            //Ÿ�Ӷ��� �ȿ� ���׶�� 2 �ݱ�
            All_Save.Time_Circle_2_Index = 0;
            All_Save.Time_Circle_2[0].gameObject.SetActive(true);
            All_Save.Time_Circle_2[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Time_Circle_2", All_Save.Time_Circle_2_Index);



            //������ �����Ѵ�.
            All_Save.Boss_Index = 0;
            All_Save.Boss[0].gameObject.SetActive(true);
            All_Save.Boss[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Boss", All_Save.Boss_Index);

            //�Ҹ��� �����Ѵ�.
            All_Save.Sori_Index = 0;
            All_Save.Sori[0].gameObject.SetActive(true);
            All_Save.Sori[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Sori", All_Save.Sori_Index);

            //��¥ ������ �����Ѵ�.
            All_Save.Fake_Boss_Index = 0;
            All_Save.Fake_Boss[0].gameObject.SetActive(true);
            All_Save.Fake_Boss[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Fake_Boss", All_Save.Fake_Boss_Index);

            //�����ڸ� �����Ѵ�.
            All_Save.Black_Face_Man_Index = 0;
            All_Save.Black_Face_Man[0].gameObject.SetActive(true);
            All_Save.Black_Face_Man[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Black_Face_Man", All_Save.Black_Face_Man_Index);

            //1�� ���� �׸�
            All_Save.Ending1_Index = 0;
            All_Save.Ending1[0].gameObject.SetActive(true);
            All_Save.Ending1[1].gameObject.SetActive(false);

            PlayerPrefs.SetInt("First_Ending", All_Save.Ending1_Index);

            //2�� ���� �׸�
            All_Save.Ending2_Index = 0;
            All_Save.Ending2[0].gameObject.SetActive(true);
            All_Save.Ending2[1].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Second_Ending", All_Save.Ending2_Index);

            //3�� ���� �׸�
            All_Save.Ending3_Index = 0;
            All_Save.Ending3[0].gameObject.SetActive(true);
            All_Save.Ending3[1].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Thrid_Ending", All_Save.Ending3_Index);

            //4�� ���� �׸�
            All_Save.Ending4_Index = 0;
            All_Save.Ending4[0].gameObject.SetActive(true);
            All_Save.Ending4[1].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Fourth_Ending", All_Save.Ending4_Index);

            //1�� ������ �����Ѵ�.
            All_Save.Achieve1_Index = 0;
            All_Save.Achieve_1[0].gameObject.SetActive(true);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(false);

            //2�� ������ �����Ѵ�.
            All_Save.Achieve2_Index = 0;
            All_Save.Achieve_2[0].gameObject.SetActive(true);
            All_Save.Achieve_2[1].gameObject.SetActive(false);
            All_Save.Achieve_2[2].gameObject.SetActive(false);

            //3�� ������ �����Ѵ�.
            All_Save.Achieve3_Index = 0;
            All_Save.Achieve_3[0].gameObject.SetActive(true);
            All_Save.Achieve_3[1].gameObject.SetActive(false);
            All_Save.Achieve_3[2].gameObject.SetActive(false);

            //4�� ������ �����Ѵ�.
            All_Save.Achieve4_Index = 0;
            All_Save.Achieve_4[0].gameObject.SetActive(true);
            All_Save.Achieve_4[1].gameObject.SetActive(false);
            All_Save.Achieve_4[2].gameObject.SetActive(false);

            //5�� ������ �����Ѵ�.
            All_Save.Achieve5_Index = 0;
            All_Save.Achieve_5[0].gameObject.SetActive(true);
            All_Save.Achieve_5[1].gameObject.SetActive(false);
            All_Save.Achieve_5[2].gameObject.SetActive(false);

            //6�� ������ �����Ѵ�.
            All_Save.Achieve6_Index = 0;
            All_Save.Achieve_6[0].gameObject.SetActive(true);
            All_Save.Achieve_6[1].gameObject.SetActive(false);
            All_Save.Achieve_6[2].gameObject.SetActive(false);

            //7�� ������ �����Ѵ�.
            All_Save.Achieve7_Index = 0;
            All_Save.Achieve_7[0].gameObject.SetActive(true);
            All_Save.Achieve_7[1].gameObject.SetActive(false);
            All_Save.Achieve_7[2].gameObject.SetActive(false);

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
            All_Save.Achieve8_Index = 0;
            All_Save.Achieve_8[0].gameObject.SetActive(true);
            All_Save.Achieve_8[1].gameObject.SetActive(false);
            All_Save.Achieve_8[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_8", All_Save.Achieve8_Index);

            //9 ( 2�� ���� )
            All_Save.Achieve9_Index = 0;
            All_Save.Achieve_9[0].gameObject.SetActive(true);
            All_Save.Achieve_9[1].gameObject.SetActive(false);
            All_Save.Achieve_9[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_9", All_Save.Achieve9_Index);

            //10 ( 3�� ���� )
            All_Save.Achieve10_Index = 0;
            All_Save.Achieve_10[0].gameObject.SetActive(true);
            All_Save.Achieve_10[1].gameObject.SetActive(false);
            All_Save.Achieve_10[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_10", All_Save.Achieve10_Index);

            //11 ( 4�� ���� )
            All_Save.Achieve11_Index = 0;
            All_Save.Achieve_11[0].gameObject.SetActive(true);
            All_Save.Achieve_11[1].gameObject.SetActive(false);
            All_Save.Achieve_11[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_11", All_Save.Achieve11_Index);

            //12 ( ���� �� ����� �� )
            All_Save.Achieve12_Index = 0;
            All_Save.Achieve_12[0].gameObject.SetActive(true);
            All_Save.Achieve_12[1].gameObject.SetActive(false);
            All_Save.Achieve_12[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_12", All_Save.Achieve12_Index);

            //1��° �ٹ� ���
            All_Save.Album1_Index = 0;
            All_Save.Album_1[0].gameObject.SetActive(true);
            All_Save.Album_1[1].gameObject.SetActive(false);
            All_Save.Album_1[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_1", All_Save.Album1_Index);


            //2��° �ٹ� ���
            All_Save.Album2_Index = 0;
            All_Save.Album_2[0].gameObject.SetActive(true);
            All_Save.Album_2[1].gameObject.SetActive(false);
            All_Save.Album_2[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_2", All_Save.Album2_Index);

            //3��° �ٹ� ���
            All_Save.Album3_Index = 0;
            All_Save.Album_3[0].gameObject.SetActive(true);
            All_Save.Album_3[1].gameObject.SetActive(false);
            All_Save.Album_3[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_3", All_Save.Album3_Index);

            //4��° �ٹ� ���
            All_Save.Album4_Index = 0;
            All_Save.Album_4[0].gameObject.SetActive(true);
            All_Save.Album_4[1].gameObject.SetActive(false);
            All_Save.Album_4[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_4", All_Save.Album4_Index);

            //5��° �ٹ� ���
            All_Save.Album5_Index = 0;
            All_Save.Album_5[0].gameObject.SetActive(true);
            All_Save.Album_5[1].gameObject.SetActive(false);
            All_Save.Album_5[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);

            //6��° �ٹ� ���
            All_Save.Album6_Index = 0;
            All_Save.Album_6[0].gameObject.SetActive(true);
            All_Save.Album_6[1].gameObject.SetActive(false);
            All_Save.Album_6[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_6", All_Save.Album6_Index);

            //7��° �ٹ� ���
            All_Save.Album7_Index = 0;
            All_Save.Album_7[0].gameObject.SetActive(true);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);

            //8��° �ٹ� ���
            All_Save.Album8_Index = 0;
            All_Save.Album_8[0].gameObject.SetActive(true);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);

            //9��° �ٹ� ���
            All_Save.Album9_Index = 0;
            All_Save.Album_9[0].gameObject.SetActive(true);
            All_Save.Album_9[1].gameObject.SetActive(false);
            All_Save.Album_9[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_9", All_Save.Album9_Index);

            //10��° �ٹ� ���
            All_Save.Album10_Index = 0;
            All_Save.Album_10[0].gameObject.SetActive(true);
            All_Save.Album_10[1].gameObject.SetActive(false);
            All_Save.Album_10[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_10", All_Save.Album10_Index);

            //11��° �ٹ� ���
            All_Save.Album11_Index = 0;
            All_Save.Album_11[0].gameObject.SetActive(true);
            All_Save.Album_11[1].gameObject.SetActive(false);
            All_Save.Album_11[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_11", All_Save.Album11_Index);

            //12��° �ٹ� ���
            All_Save.Album12_Index = 0;
            All_Save.Album_12[0].gameObject.SetActive(true);
            All_Save.Album_12[1].gameObject.SetActive(false);
            All_Save.Album_12[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_12", All_Save.Album12_Index);


            //�Ҹ� �ΰ� �� 0.5�� ����

            //SFX
            /*sfx.back_SFX_Vol = 0.5001f;

            sfx.back_SFX_Volume.value = sfx.back_SFX_Vol;
            sfx.back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);


            sfx.sfx1.volume = sfx.back_SFX_Volume.value;
            sfx.sfx2.volume = sfx.back_SFX_Volume.value;
            sfx.sfx3.volume = sfx.back_SFX_Volume.value;
            sfx.sfx4.volume = sfx.back_SFX_Volume.value;
            sfx.sfx5.volume = sfx.back_SFX_Volume.value;
            sfx.sfx6.volume = sfx.back_SFX_Volume.value;
            Debug.Log("ȿ���� ������" + sfx.back_SFX_Vol + "�̴�.");*/

            sfx.back_SFX_Vol = 0.5001f;
            sfx.back_SFX_Volume.value = sfx.back_SFX_Vol;
            sfx.back_SFX_Vol = sfx.back_SFX_Volume.value;
            sfx.sfx1.volume = sfx.back_SFX_Volume.value;
            sfx.sfx2.volume = sfx.back_SFX_Volume.value;
            sfx.sfx3.volume = sfx.back_SFX_Volume.value;
            sfx.sfx4.volume = sfx.back_SFX_Volume.value;
            sfx.sfx5.volume = sfx.back_SFX_Volume.value;
            sfx.sfx6.volume = sfx.back_SFX_Volume.value;

            PlayerPrefs.SetFloat("back_SFX_Vol", sfx.back_SFX_Vol);
            sfx.SFX_Sound.text = sfx.back_SFX_Vol.ToString();

            Debug.Log(sfx.back_SFX_Vol + "�� SFX �ʱ�ȭ �Ұ�����");

            //SFX //������ ���ǵ� ���� �� ���� �Ǵ� �� ���� �ѵ� �־
            /*float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
            sfx.back_SFX_Vol = SFX_Sd;
            Debug.Log(SFX_Sd + "�� �ʱ�ȭ �Ұ�����");*/


            //BGM
            /*bgm.backVol = 0.5001f;

            bgm.backVolume.value = bgm.backVol;
            bgm.backVol = PlayerPrefs.GetFloat("backvol", 0.5001f);
            bgm.audio1.volume = bgm.backVolume.value;
            bgm.audio2.volume = bgm.backVolume.value;
            bgm.audio3.volume = bgm.backVolume.value;
            bgm.audio4.volume = bgm.backVolume.value;
            bgm.audio5.volume = bgm.backVolume.value;

            Debug.Log("������� ������"+bgm.backVol+"�̴�.");*/

            bgm.backVol = 0.5001f;
            bgm.backVolume.value = bgm.backVol;
            bgm.backVol = bgm.backVolume.value;
            bgm.audio1.volume = bgm.backVolume.value;
            bgm.audio2.volume = bgm.backVolume.value;
            bgm.audio3.volume = bgm.backVolume.value;
            bgm.audio4.volume = bgm.backVolume.value;
            bgm.audio5.volume = bgm.backVolume.value;


            PlayerPrefs.SetFloat("backvol", bgm.backVol);
            bgm.BGM_Sound.text = bgm.backVol.ToString();

            Debug.Log(bgm.BGM_Sound + "�� BGM �ʱ�ȭ �Ұ�����");




            //Ƽ�� �� ����
            Tiket.Total = 10;


            //���ǵ�� �Ҹ��� �����غ���
            //���ǵ� 0.6���� ����
            speed.Speed = 0.6001f;
            
            Time.timeScale= speed.Speed;

            speed.back_Speed.value = speed.Speed;
            //�̰� �ϸ� ��� ���� 5����� �����
   
            
            PlayerPrefs.SetFloat("Speed", 0.60001f);
            Debug.Log("�ʱ�ȭ�ϰ� ���� ���ǵ��" + speed.Speed + "�̴�.");



            //���ǵ� (�ӵ� ������ �� �Ǽ� ����)
            /*float Auto_Speed = PlayerPrefs.GetFloat("Speed");
            speed.Speed = Auto_Speed;
            Debug.Log(Auto_Speed + "�� �ʱ�ȭ����");*/


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
            //FadeObject.fadeObject[12].gameObject.SetActive(false);
            FadeObject.fadeObject[13].gameObject.SetActive(false);
            FadeObject.fadeObject[14].gameObject.SetActive(false);

            Setting.SetActive(false);


            


            //speed.Speed = speed.back_Speed.value;
            //PlayerPrefs.SetFloat("Speed", speed.Speed);
            //speed.Fast.text = speed.Speed.ToString();
            

            //�ӵ��� �Ǵµ� ���׶���ϰ� ���ڰ� ������ ����


            
            SceneManager.LoadScene("Line");

            


            Wait1.m_Coroutine = Wait1.NewCoroutine();
            StartCoroutine(Wait1.m_Coroutine);
            Debug.Log("ó������ ��������");

            Debug.Log("���� ����");
            Debug.Log("���� �����ϴµ� Ÿ�� ��������" + Time.timeScale + "�̴�.");


            //�� �Ʒ� 3���� ���� �־��� ����
            /*Wait1.m_Coroutine = Wait1.NewCoroutine();
            StartCoroutine(Wait1.m_Coroutine);
            Debug.Log("ó������ ��������");*/






        }
    }
}
