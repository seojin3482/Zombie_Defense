using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OverManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Btn_Continue()
    {
        SceneManager.LoadScene("2_Game_Scene");
    }
    public void Btn_GoTitle()
    {
        SceneManager.LoadScene("1_Title_Scene");
    }
}
