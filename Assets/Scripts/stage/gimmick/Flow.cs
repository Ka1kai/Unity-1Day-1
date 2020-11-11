using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-GameSystem.GameSpeed, -0.0f, 0);
        if (transform.position.x < GameSystem.GimmickDestoryPosition)
        {
            Destroy(this.gameObject);
        }
    }
}
