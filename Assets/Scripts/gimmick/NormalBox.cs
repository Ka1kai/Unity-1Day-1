using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBox : BaseGimmick
{

    [SerializeField]
    BoxCollider2D collision;

    private GameObject player;
    private BoxCollider2D playerCollision;

    void Start()
    {
        player = GameObject.Find("player");
        playerCollision = player.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (collision.IsTouching(playerCollision))
        {
            player.GetComponent<GamePlayer>().ChangeAction(player.GetComponent<DamageAction>());
            GameSystem.EndGame();
        }
    }
}
