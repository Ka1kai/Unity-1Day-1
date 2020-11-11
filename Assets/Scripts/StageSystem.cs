using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSystem : MonoBehaviour
{
    private const int GimmickKindNormalBox = 0;
    private const int GimmickKindUpDownBox = 1;

    private const int GimmickKindMin = GimmickKindNormalBox;
    private const int GimmickKindMax = GimmickKindUpDownBox + 1;

    private int normalBoxGimmickSize;
    private int upDownGimmickSize;

    [SerializeField]
    GameObject NormalBox;

    [SerializeField]
    GameObject UpDownBox;

    [SerializeField]
    GameObject player;

    void Start()
    {
        normalBoxGimmickSize = 1;
        upDownGimmickSize = 1;
    }


    void Update()
    {
        
    }

    public void NormalStage()
    {
    }

    public void GimmickStage()
    {
        var rand = Random.RandomRange(GimmickKindMin, GimmickKindMax);

        switch (rand) {
            case GimmickKindNormalBox:
                NormalBoxGimmick();
                break;
            case GimmickKindUpDownBox:
                UpDownBoxGimmick();
                break;
        }
    }

    public void NormalBoxGimmick()
    {
        int num = System.Convert.ToInt32(GameSystem.gameMode);

        for (int i = 0; i < num + 1; ++i)
        {
            GameObject obj = Instantiate(NormalBox);
            var xPos = Random.RandomRange(-8.0f, 8.0f);
            var yPos = Random.RandomRange(0.0f, 6.0f);

            obj.transform.position = new Vector3(xPos + GameSystem.repeatPosition.x, yPos, 0.0f);
        }
        player.GetComponent<GamePlayer>().ChangeAction(player.GetComponent<JumpAction>());
    }

    public void UpDownBoxGimmick()
    {
        int num = System.Convert.ToInt32(GameSystem.gameMode);

        for (int i = 0; i < num; ++i)
        {
            GameObject obj = Instantiate(UpDownBox);
            var xPos = Random.RandomRange(-7.0f, 7.0f);
            var yPos = Random.RandomRange(3.0f, 6.0f);

            obj.transform.position = new Vector3(xPos + GameSystem.repeatPosition.x, yPos, 0.0f);

        }
        player.GetComponent<GamePlayer>().ChangeAction(player.GetComponent<StopAction>());
    }
}
