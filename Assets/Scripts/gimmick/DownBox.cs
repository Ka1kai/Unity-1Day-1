using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownBox : BaseGimmick
{

    [SerializeField]
    BoxCollider2D collision;

    private GameObject player;
    private BoxCollider2D playerCollider;

    private GameObject ground;
    private BoxCollider2D groundCollider;

    private Rigidbody2D boxRigidBody2D;

    private bool isDown;

    void Start()
    {
        player = GameObject.Find("player");
        playerCollider = player.GetComponent<BoxCollider2D>();

        ground = GameObject.Find("GroundCollider");
        groundCollider = ground.GetComponent<BoxCollider2D>();

        // 重力を0にして落下しない
        boxRigidBody2D = this.GetComponent<Rigidbody2D>();
        boxRigidBody2D.gravityScale = 0;
    }

    void Update()
    {
        if (player.transform.position.x > transform.position.x - 2.0f && isDown == false)
        {
            isDown = true;
            boxRigidBody2D.gravityScale = Random.Range(0.0f, 20.0f);
        }

        if (collision.IsTouching(groundCollider))
        {
            collision.isTrigger = true;
        }

        if (collision.IsTouching(playerCollider))
        {
            player.GetComponent<GamePlayer>().ChangeAction(player.GetComponent<DamageAction>());
            GameSystem.EndGame();
        }
    }
}
