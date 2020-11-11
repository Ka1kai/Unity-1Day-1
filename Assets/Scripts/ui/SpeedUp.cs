using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedUp : MonoBehaviour
{
    private bool isFadeIn;
    private bool isFadeOut;

    float alpha;

    [SerializeField]
    public Text text;

    void Start()
    {
        text = text.GetComponent<Text>();
    }

    void Update()
    {
        if (isFadeIn)
        {
            alpha += 0.1f;
            ChangeColor(alpha);

            if (alpha >= 1.0f)
            {
                isFadeIn = false;
                isFadeOut = true;
            }
        }
        if (isFadeOut)
        {
            alpha -= 0.02f;
            ChangeColor(alpha);

            if (alpha <= 0.0f)
            {
                isFadeOut = false;
            }
        }
    }   

    public void StartFadeIn()
    {
        isFadeIn = true;
        alpha = 0.0f;
    }

    private void ChangeColor(float alpha)
    {
        text.color = new Color(255.0f, 255.0f, 255.0f, alpha);
    }
}
