using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamesManager : MonoBehaviour
{
    public Text txt_StageNum;
   
    public void NextScene()
    {
        SceneManager.LoadScene("4_Market_Scene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("���� ��������" + MainData.cur_stage);
        ShowUI();
    }

    void ShowUI()
    {
        txt_StageNum.text = ""+MainData.cur_stage; // ���ڸ� text(����)�� ��ȯ 
    }
}
