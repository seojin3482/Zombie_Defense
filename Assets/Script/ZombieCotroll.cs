using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 좀비 상태를 위해 enum 을 이용한 자료형을 만들자
public enum ActionType { init,idle,walk,run,contack} // 생성되자마자 목표를 향해 걷다 뛰다 하면서 목표물에 닿으면 닿았다 상태로 변경


public class ZombieCotroll : MonoBehaviour
{
    ActionType my_act;

    //상태의 변환은 시간으로 세팅하자
    float action_time;

    // Start is called before the first frame update
    void Start()
    {
        my_act = ActionType.init;
    }

    // Update is called once per frame
    void Update()
    {
        print("상태"+my_act);
        Enemy_Action();
    }



    void Enemy_Action()
    {
        switch(my_act)
        {
            case ActionType.init:
                my_act = ActionType.idle;
                break;
            case ActionType.idle:   // 1초간 아이들상태
                action_time += Time.deltaTime;
                if (action_time >= 1.4f)
                {
                    action_time = 0;
                    my_act = ActionType.walk;
                }
                break; 
            case ActionType.walk: // 걷는다
                action_time += Time.deltaTime;
                this.transform.Translate(Vector3.forward * Time.deltaTime * 1.5f);
                if (action_time >= 3.0f)
                {
                    my_act = ActionType.run;
                }
                break; 
            case ActionType.run: // 뛴다
                this.transform.Translate(Vector3.forward * Time.deltaTime * 5f);
                break;

            case ActionType.contack: // 목표물에 접촉되었으면
                break;
        }
    }
}
