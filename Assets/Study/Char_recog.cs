using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char_recog : MonoBehaviour
{
    // 1 ĳ���Ͱ� �ִ� ȭ���� Ŭ���ϸ� 
    // 2 pc, ȭ�鿡 ���콺�� Ŭ������ ��
    // �����, ȭ���� ��ġ���� ��

    // ������ ȭ�鿡 ǥ�� 
    public Text info1;
    int input_state;

    // 3 ĳ���͸� �ν��Ѵ�


    // Start is called before the first frame update
    void Start()
    {
        input_state = 0;
        info1.text = "����";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        { // 0 : ��, 1 : �߰�, 2 : ��

            input_state = 1;
            //��ư ������ �� 3D ��ü�� �ν�
            // RayCast �� �ν� 
            // ��ġ�� ������ ���� => �ϳ��� �ڷ� type (Ray)
            // print("��ġ"+Input.mousePosition);
            // ��ġ -> 2d ��ġ ��ũ���� ��ġ
            // ī�޶� ���� ������ ���� ray �� ��ȯ
            Ray screenray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit other;
            if (Physics.Raycast(screenray,out other,20f) == true)
            {
                print("����" + other.transform.name); // ���� ��ü�� ������ raycasthit �� ����.
                if(other.transform.tag == "Enemy")
                {
                    Destroy(other.transform.gameObject);
                }
            }
            else
            {
                print("�ȸ���");
            }
        }
        if(Input.GetMouseButtonUp(0) == true)
        {
            input_state = 2;
        }
        ShowInputState(input_state);

        // RayCast
        // �浹 - �浹ü�� ���� ��, Rigidbody(����)�� ���Ե� ��
        // ���� ���� Ŭ���� physics
        //Physics.Raycast()  // ������ ��� �Լ�����, ����� �� (���� ��ü�� �ִ�) ����(���� ��ü�� ����)

    }
    void ShowInputState(int state)
    {
        if(state == 1) {
            info1.text = "������";
        }
        if (state == 2)
        {
            info1.text = "��������";
        }
    }
}

/*
// �Է� ������ ������ class - Input 
// �پ��� �Է� ��� ����
// ���� : Set ���� ��� : Get
Input.GetKeyDown(); // Ű������ ������ ���
Input.GetTouch();  // pc ��� �Ұ� ����� ��밡��
����� ���� ���콺 �����ϸ� -> ���콺 �����Ͱ� ����� -> pc / mobile ���� �������� ��� ����
*/