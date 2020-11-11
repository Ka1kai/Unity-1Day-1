using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{


    [SerializeField]
    bool GimmickStage;

    [SerializeField]
    bool NormalStage;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-GameSystem.GameSpeed, 0, 0);
        if (transform.position.x < -GameSystem.repeatPosition.x)
        {
            transform.position = GameSystem.repeatPosition;

            // Gimmick Stage repeat
            if (GimmickStage)
            {
                GameSystem.isNextGimmickStage = true;
            }
            // Normal Stage repeat
            if (NormalStage)
            {
                GameSystem.isNextNormalStage = true;
            }
        }
    }
}
