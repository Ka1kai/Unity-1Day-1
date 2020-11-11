using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer player;

    [SerializeField]
    private Image fade;

    bool isStart;
    bool isStartLoad;

    private Fade fadeScript;

    void Start()
    {
        fadeScript = fade.GetComponent<Fade>();
        isStart = false;
        isStartLoad = false;
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && isStartLoad == false)
        {
            isStartLoad = true;
            StartGame();
        }

        if (isStartLoad && fadeScript.FadeEnd() && isStart == false)
        {
           isStart = true;
           SceneManager.LoadScene("Main");
        }
    }

    private void StartGame()
    {
        var animator = player.GetComponent<Animator>();
        animator.Play("Cindy_Run");

        fadeScript.StartFadeOut();

    }
}
