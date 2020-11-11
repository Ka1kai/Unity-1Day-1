using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultScene : MonoBehaviour
{
    [SerializeField]
    GameObject fade;

    [SerializeField]
    Text phaseCount;

    bool isReturn;
    bool isReturnLoad;

    void Start()
    {
        isReturn = false;
        isReturnLoad = false;

        phaseCount.text = GameSystem.GetPhaseScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && isReturnLoad == false)
        {
            isReturnLoad = true;
            ReturnTitle();
        }

        if (isReturnLoad && fade.GetComponent<Fade>().FadeEnd())
        {
            SceneManager.LoadScene("Title");
        }
    }

    private void ReturnTitle()
    {
        fade.GetComponent<Fade>().StartFadeOut();
    }
}
