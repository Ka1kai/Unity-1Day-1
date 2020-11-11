using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    private BaseAction nowAction;

    void Start()
    {
        nowAction = GetComponent<JumpAction>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            ChangeAction(this.GetComponent<StopAction>());
        }
    }

    public void ChangeAction(BaseAction nextAction)
    {
        nowAction.enabled = false;
            
        nowAction = nextAction;
        nowAction.enabled = true;
    }
}
