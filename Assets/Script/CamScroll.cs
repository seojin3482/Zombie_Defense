using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카메라의 정보를 얻어서 스크롤.

public class CamScroll : MonoBehaviour
{
    public Camera mycam;
    public float speed=15f;
    public int dir_x;
    // Start is called before the first frame update
    void Start()
    {
        dir_x = 0;
    }

    void Scroll_Cam()
    {
        mycam.transform.Translate(Vector3.right * speed * Time.deltaTime*dir_x);
        //if (mycam.transform.position.x <= -30)
        //{
        //    mycam.transform.position = new Vector3(-30, 3, 1 - 15);
        //}

        //if (mycam.transform.position.x >= 30)
        //{
        //    mycam.transform.position = new Vector3(30, 3, 1 - 15);
        //}

        Vector3 temppos = mycam.transform.position;
        temppos.x=Mathf.Clamp(mycam.transform.position.x, -30, 30); // 두값 내에서만 위치하도록 변수값을 제한을 두는 함수
        mycam.transform.position = temppos;
    }
    // Update is called once per frame
    void Update()
    {
        Scroll_Cam();
    }
    public void Btn_Scroll_L()
    {
        dir_x = -1;
    }

    public void Btn_Scroll_R()
    {
        dir_x = 1;
    }

    public void Btn_Scroll_UP()
    {
        dir_x = 0;
    }
}
