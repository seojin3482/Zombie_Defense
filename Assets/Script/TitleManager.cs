using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// UI ��ü�� ������ ��� ó��

class MainData
{
    static public int cur_stage = 1;
}

public class TitleManager : MonoBehaviour
{
    // exit ��ư ������ ���� ����
    public void Exit_Game()
    {

    }

    public void NewGame()
    {
        SceneManager.LoadScene("2_Game_Scene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("���� ��������" + MainData.cur_stage);
    }
}
