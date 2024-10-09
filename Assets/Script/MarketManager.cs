using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarketManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("현재 스테이지" + MainData.cur_stage);
    }

    public void NextScene()
    {
       
    }

    public void GoNextStage() // 다음 스테이지로 이동함
    {
        MainData.cur_stage += 1;
        SceneManager.LoadScene("2_Game_Scene");
    }
}
