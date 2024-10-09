using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char_recog : MonoBehaviour
{
    // 1 캐릭터가 있는 화면을 클릭하면 
    // 2 pc, 화면에 마우스를 클릭했을 때
    // 모바일, 화면을 터치했을 때

    // 정보를 화면에 표시 
    public Text info1;
    int input_state;

    // 3 캐릭터를 인식한다


    // Start is called before the first frame update
    void Start()
    {
        input_state = 0;
        info1.text = "없음";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        { // 0 : 좌, 1 : 중간, 2 : 우

            input_state = 1;
            //버튼 눌렸을 때 3D 객체를 인식
            // RayCast 로 인식 
            // 위치와 방향을 세팅 => 하나의 자료 type (Ray)
            // print("위치"+Input.mousePosition);
            // 터치 -> 2d 위치 스크린의 위치
            // 카메라가 보는 방향을 가진 ray 로 변환
            Ray screenray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit other;
            if (Physics.Raycast(screenray,out other,20f) == true)
            {
                print("맞음" + other.transform.name); // 맞은 객체의 정보는 raycasthit 에 있음.
                if(other.transform.tag == "Enemy")
                {
                    Destroy(other.transform.gameObject);
                }
            }
            else
            {
                print("안맞음");
            }
        }
        if(Input.GetMouseButtonUp(0) == true)
        {
            input_state = 2;
        }
        ShowInputState(input_state);

        // RayCast
        // 충돌 - 충돌체가 있을 때, Rigidbody(물리)가 포함될 때
        // 물리 관련 클래스 physics
        //Physics.Raycast()  // 광선을 쏘는 함수에선, 결과가 참 (맞은 객체가 있다) 거짓(맞은 객체가 없다)

    }
    void ShowInputState(int state)
    {
        if(state == 1) {
            info1.text = "눌렸음";
        }
        if (state == 2)
        {
            info1.text = "떼어졌음";
        }
    }
}

/*
// 입력 정보를 가지는 class - Input 
// 다양한 입력 기능 정보
// 세팅 : Set 정보 얻기 : Get
Input.GetKeyDown(); // 키보드의 정보를 얻다
Input.GetTouch();  // pc 사용 불가 모바일 사용가능
모바일 폰에 마우스 연결하면 -> 마우스 포인터가 생긴다 -> pc / mobile 에서 공통으로 사용 가능
*/