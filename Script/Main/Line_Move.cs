using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Line_Move : MonoBehaviour
{
    //public GameObject Main_Canvas;

    //public GameObject Ch1_Picture;
    //public GameObject Main_Go_Black;//���� ���� ȭ�� ������ ���� ������ ���̵�

    public SFX_2023 sfx1;//ĵ�� Ű ������ �߰���

    public GameObject EndingCradit;
    public GameObject ReStart;
    public GameObject Album;

    //������� ��� ����Կ�
    //public GameObject Line_1;//ù��° �����Ŀ� ������ ��
    //public GameObject Line_2;
    //������� ��� ����Կ�
    
    public GameObject Achievements;
    public GameObject Character;
    public GameObject Timeline;
    public GameObject Ticket;//�ؿ� Button�� �Ǹ� �ٽ� ���󺹱�
    public GameObject Setting;
    public GameObject No_More_Ticket;
    public GameObject menuSet;

    public GameObject Ticket_Count_Panel;

    public Only_Line questObject;//LineObject��ũ��Ʈ �ҷ����� ����
    public Fade_Collect fadeObject;//���̵� ��ũ��Ʈ �ҷ�������


    //public B_1_2 One;
    //public B_5_6 Five;



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

    public GameObject Go_Black;//���ν��۶����� ����
    public GameObject Go_Empty;//���ν��۶����� ����

    //public Only_Line Audio_Object;//BGMObject��ũ��Ʈ �ҷ����� ����


    //public Tiket Ticket_Count;//Ƽ�� ī��Ʈ ����


    //public GameObject Main;

    //public GameObject Main_audio;
    //public AudioSource audio1;


    //public GameObject audio1;//���߿� ������ �� ��� �ٲܶ� ����
    //public GameObject audio2;

    int Scene_index;//�� ���嶧���� ����
    int Saved_scene;//�� ���嶧���� ����

    public GameObject Line;
    public R_Wait1 Wait1;//���� ������ ����
    public Fade_Collect FadeObject;//���� ������ ����

    void Start()//Ƽ�� �� ������ �������. �� �Ǹ� �����
    {
        

        //GameLoad();//���� �ε�
    }


    void Update()
    {

        


        //���� �޴�
        if (Input.GetButtonDown("Cancel"))//ESC������ �޴� ���̵���
        {
            if(menuSet.activeSelf)//�޴��� ���� �ִٸ�
                menuSet.SetActive(false);//�ٽ� ��������
            else
                menuSet.SetActive(true);
        }


        if (Input.GetButtonDown("Cancel"))//ESC������ �޴� ���̵���
        {
            if (SceneManager.GetActiveScene().name == "Album")
            {
                sfx1.SFX_Line_Button();
                SceneManager.LoadScene("Line");
                //�������� �̵�
            }

            else if (SceneManager.GetActiveScene().name == "Achievements")
            {
                sfx1.SFX_Line_Button();
                SceneManager.LoadScene("Line");
                //�������� �̵�
            }

            else if (SceneManager.GetActiveScene().name == "Character")
            {
                sfx1.SFX_Line_Button();
                SceneManager.LoadScene("Line");
                //�������� �̵�
            }

            else if (SceneManager.GetActiveScene().name == "Timeline")
            {
                sfx1.SFX_Line_Button();
                SceneManager.LoadScene("Line");
                //�������� �̵�
            }

            else if (SceneManager.GetActiveScene().name == "Ticket")
            {
                sfx1.SFX_Line_Button();
                //������ �����ߴ� ������ �̵�
                Saved_scene = PlayerPrefs.GetInt("Saved");

                if (Saved_scene != 0)
                    SceneManager.LoadSceneAsync(Saved_scene);
                else
                    return;


            }

            else if (SceneManager.GetActiveScene().name == "Setting")
            {
                sfx1.SFX_Line_Button();
                //������ �����ߴ� ������ �̵�
                Saved_scene = PlayerPrefs.GetInt("Saved");

                if (Saved_scene != 0)
                    SceneManager.LoadSceneAsync(Saved_scene);
                else
                    return;
            }
        }



        if (SceneManager.GetActiveScene().name == "Main")
        {
            //Main.SetActive(false);
            //Line.SetActive(false);
            //EndingCradit.SetActive(false);
            Timeline.SetActive(false);
            Character.SetActive(false);
            Achievements.SetActive(false);
            Album.SetActive(false);
            Ticket.SetActive(false);
            Setting.SetActive(false);
            No_More_Ticket.SetActive(false);
            ReStart.SetActive(false);
            //Main_Canvas.SetActive(true);   
        }


        if (SceneManager.GetActiveScene().name == "Line")
        {
            //audio1.SetActive(true);
            //Line.SetActive(true);
            //Main.SetActive(false);
            //EndingCradit.SetActive(false);
            Album.SetActive(false);
            Character.SetActive(false);
            Timeline.SetActive(false);
            Achievements.SetActive(false);
            Ticket.SetActive(false);
            Setting.SetActive(false);

            //Ticket_Count_Panel.SetActive(true);


            //Main_Go_Black.SetActive(false);

            //ReStart.SetActive(false);
            //menuSet.SetActive(false);
            //No_More_Ticket.SetActive(false);
            //Main_Canvas.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Album")
        {
            //Line.SetActive(true);
            //Main.SetActive(false);
            EndingCradit.SetActive(false);
            Album.SetActive(true);
            Character.SetActive(false);
            Timeline.SetActive(false);
            Achievements.SetActive(false);
      
            Ticket.SetActive(false);
            Setting.SetActive(false);
            No_More_Ticket.SetActive(false);
            menuSet.SetActive(false);

            Ticket_Count_Panel.SetActive(true);
            //Main_Canvas.SetActive(false);

            //Main_Go_Black.SetActive(false);
            //ReStart.SetActive(false);

        }

        if (SceneManager.GetActiveScene().name == "Achievements")
        {
            //Line.SetActive(true);
            //Main.SetActive(false);
            EndingCradit.SetActive(false);
            Achievements.SetActive(true);
            Character.SetActive(false);
            Timeline.SetActive(false);
            Album.SetActive(false);
            Ticket.SetActive(false);
            Setting.SetActive(false);
            No_More_Ticket.SetActive(false);
            menuSet.SetActive(false);

            Ticket_Count_Panel.SetActive(true);
            //ReStart.SetActive(false);
            //Main_Canvas.SetActive(false);

            //Main_Go_Black.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Character")
        {
            //Line.SetActive(true);
            EndingCradit.SetActive(false);
            Character.SetActive(true);
            Timeline.SetActive(false);
            Achievements.SetActive(false);
            Album.SetActive(false);
            Ticket.SetActive(false);
            Setting.SetActive(false);
            No_More_Ticket.SetActive(false);
            menuSet.SetActive(false);

            Ticket_Count_Panel.SetActive(true);
            //ReStart.SetActive(false);

            //Main_Canvas.SetActive(false);
            //Main_Go_Black.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Timeline")
        {
            //Line.SetActive(true);
            //Main.SetActive(false);
            EndingCradit.SetActive(false);
            Timeline.SetActive(true);
            Character.SetActive(false);
            Achievements.SetActive(false);
            Album.SetActive(false);
            Ticket.SetActive(false);
            Setting.SetActive(false);
            No_More_Ticket.SetActive(false);
            menuSet.SetActive(false);

            Ticket_Count_Panel.SetActive(true);
            //ReStart.SetActive(false);
            //Main_Canvas.SetActive(false);

            //Main_Go_Black.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Ticket")
        {
            //Line.SetActive(true);
            //Main.SetActive(false);
            EndingCradit.SetActive(false);
            Timeline.SetActive(true);//Ÿ�Ӷ���
            Character.SetActive(true);//�ι�
            Achievements.SetActive(true);//����
            Album.SetActive(true);//�ٹ�
            Ticket.SetActive(true);//Ƽ��
            Setting.SetActive(false);
            No_More_Ticket.SetActive(false);
            menuSet.SetActive(false);

            Ticket_Count_Panel.SetActive(true);
            //ReStart.SetActive(false);

            //Main_Canvas.SetActive(false);
            //Main_Go_Black.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Setting")
        {
            //Line.SetActive(true);
            //Main.SetActive(false);
            EndingCradit.SetActive(false);
            Timeline.SetActive(true);//Ÿ�Ӷ���
            Character.SetActive(true);//�ι�
            Achievements.SetActive(true);//����
            Album.SetActive(true);//�ٹ�
            Ticket.SetActive(false);
            Setting.SetActive(true);
            No_More_Ticket.SetActive(false);
            menuSet.SetActive(false);

            Ticket_Count_Panel.SetActive(true);
            //ReStart.SetActive(false);

            //Main_Canvas.SetActive(false);
            // Main_Go_Black.SetActive(false);
        }


        /*if (SceneManager.GetActiveScene().name == "Ch1_End_Picture")
        {
            //ReStart.SetActive(false);
            EndingCradit.SetActive(false);
            Timeline.SetActive(false);
            Character.SetActive(false);
            Achievements.SetActive(false);
            Album.SetActive(false);
            Ticket.SetActive(false);
            Setting.SetActive(false);
            No_More_Ticket.SetActive(false);
            menuSet.SetActive(false);
            //Ch1_Picture.SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "EndingCradit")
        {
            //Line.SetActive(true);
            EndingCradit.SetActive(true);
            Timeline.SetActive(false);
            Character.SetActive(false);
            Achievements.SetActive(false);
            Album.SetActive(false);
            Ticket.SetActive(false);
            Setting.SetActive(false);
            No_More_Ticket.SetActive(false);
            menuSet.SetActive(false);
            ReStart.SetActive(false);
            
        }*/

        if (SceneManager.GetActiveScene().name == "ReStart")
        {
            ReStart.SetActive(true);
            EndingCradit.SetActive(false);
            Timeline.SetActive(false);
            Character.SetActive(false);
            Achievements.SetActive(false);
            Album.SetActive(false);
            Ticket.SetActive(false);
            Setting.SetActive(false);
            No_More_Ticket.SetActive(false);
            menuSet.SetActive(false);
            Ticket_Count_Panel.SetActive(false);

            //Main_Canvas.SetActive(false);
            //Main_Go_Black.SetActive(false);

        }
    }

    public void Go_Album()
    {
        //StartCoroutine(Scene1());
        
        SceneManager.LoadScene("Album");   
    }

    /*IEnumerator Scene1()
    {
        yield return null;

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Album");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }*/

    public void Go_Line()
    {
        //StartCoroutine(Scene2());
        SceneManager.LoadScene("Line");
        
    }

    /*IEnumerator Scene2()
    {
        yield return null;

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Line");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }*/


    public void Go_Achievements()
    {
        //StartCoroutine(Scene3());
        
        SceneManager.LoadScene("Achievements");
    }

    /*IEnumerator Scene3()
    {
        yield return null;

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Achievements");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }*/

    public void Go_Character()
    {
        //StartCoroutine(Scene4());
        

        SceneManager.LoadScene("Character");
    }

    /*IEnumerator Scene4()
    {
        yield return null;

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Character");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }*/

    public void Go_Timeline()
    {
        //StartCoroutine(Scene5());
        

        SceneManager.LoadScene("Timeline");
    }

    /*IEnumerator Scene5()
    {
        yield return null;

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Timeline");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }*/



    public void Go_Setting()//���̺�
    {
        //StartCoroutine(Scene6());
        

        Scene_index = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Saved", Scene_index);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Setting");
    }

    /*IEnumerator Scene6()
    {
        yield return null;

        Scene_index = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Saved", Scene_index);
        PlayerPrefs.Save();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Setting");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }*/

    public void Go_SavedScene()//�ε�
    {
        

        Saved_scene = PlayerPrefs.GetInt("Saved");

        if (Saved_scene != 0)
            SceneManager.LoadSceneAsync(Saved_scene);
        else
            return;

        

    }


    public void Go_Ticket()//���̺�
    {
        //StartCoroutine(Scene7());

        Scene_index = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Saved", Scene_index);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Ticket");
    }

    /*IEnumerator Scene7()
    {
        yield return null;

        Scene_index = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Saved", Scene_index);
        PlayerPrefs.Save();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Ticket");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }*/

    public void Go_Back_Line()
    {
        No_More_Ticket.SetActive(false);
    }


    public void End_Game()
    {


#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // ���ø����̼� ����
#endif
    }


    public void Game_ReSet()
    {
        Debug.Log("���� ����");
        PlayerPrefs.DeleteKey("Index");
        PlayerPrefs.DeleteKey("Fade_Index");
        PlayerPrefs.DeleteKey("BGM_Index");
        //PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Line");

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

        questObject.BGM_Index = 0;
        questObject.Audio_Object[0].gameObject.SetActive(true);
        questObject.Audio_Object[1].gameObject.SetActive(false);
        questObject.Audio_Object[2].gameObject.SetActive(false);

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
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);


        Wait1.m_Coroutine = Wait1.NewCoroutine();
        StartCoroutine(Wait1.m_Coroutine);
        Debug.Log("1 ��������");

    }


    //���� �� ��. ���� ã��!
    public void GameSave()//���� ����

        //Ƽ�� ���� ������ ����â, ��ȭâ�� ���� �������� ��ġ ���� �����ϰ�
        //�ҷ��� �� �ֵ��� �ؾ� ��.
    {
        Debug.Log("���� ����");
        // PlayerPrefs.SetInt("Count", Tiket.Total);



        PlayerPrefs.SetInt("BGM_Index", questObject.BGM_Index);//�� �Ǹ� �����
        //PlayerPrefs.SetInt("Count", Tiket.Total);
        PlayerPrefs.SetInt("Index", questObject.Line_Index);
        Debug.Log(questObject.Line_Index + "����");

        //0��° �� �ȿ� �ִ� �͵�

        PlayerPrefs.Save();//�������丮�� ���� ������ �͵��� �����
        





    }

    //���� �ȵ�. ����ã��!
    public void GameLoad()//���� �ҷ�����
    {



        Debug.Log("���� �ε�");
        //int Total = PlayerPrefs.GetInt("Count");




        //questObject[Line_Index].gameObject.SetActive(true);
        //Audio_Object[BGM_Index].gameObject.SetActive(true);
        if (!PlayerPrefs.HasKey("Index"))
            return;

        //Tiket.Total = PlayerPrefs.GetInt("Count");
        //int BGM_Index = PlayerPrefs.GetInt("BGM_Index");
        //int Line_Index = PlayerPrefs.GetInt("Index");
        //int Fade_Index = PlayerPrefs.GetInt("Fade_Index");//���̵� �ε���





        int BGM_Index = PlayerPrefs.GetInt("BGM_Index");
        int Line_Index = PlayerPrefs.GetInt("Index");

        Debug.Log(Line_Index + "�ҷ�����");
        //fadeObject.Fade_Index = PlayerPrefs.GetInt("Fade_Index");

        //int Line_0_Index = PlayerPrefs.GetInt("Line_0_Index");//0��° �� �ȿ� �ִ� �͵�


        //questObject.Line_Index = Line_Index;
        //fadeObject.Fade_Index = Fade_Index;//���̵�

        questObject.Line_Index = Line_Index;
        questObject.questObject[Line_Index].gameObject.SetActive(true);


        questObject.BGM_Index = BGM_Index;
        questObject.Audio_Object[BGM_Index].gameObject.SetActive(true);

        //fadeObject.Fade_Index = Fade_Index;
        //fadeObject.fadeObject[Fade_Index].gameObject.SetActive(true);



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
            questObject.Go_Six_Line();

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

    }





}
