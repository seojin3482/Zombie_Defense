using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// UI 객체가 눌리면 명령 처리

class MainData
{
    static public int cur_stage = 1;
}

public class TitleManager : MonoBehaviour
{
    // exit 버튼 누르면 게임 종료
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
        print("현재 스테이지" + MainData.cur_stage);
    }
}
