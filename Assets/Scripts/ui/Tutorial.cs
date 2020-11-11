using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    private bool isFadeOut;
    private bool isFadeIn;

    [SerializeField]
    public Text text;

    float alpha;

    void Start()
    {
        isFadeIn = true;
    }

    void Update()
    {
        if (isFadeIn)
        {
            alpha+= 0.02f;
            ChangeColor(alpha);

            if (text.color.a >= 1.0f)
            {
                isFadeIn = false;
            }
        }

        if (isFadeOut)
        {
            alpha -= 0.05f;
            ChangeColor(alpha);

            if (text.color.a <= 0.0f)
            {
                isFadeOut = false;
            }
        }
    }

    private void ChangeColor(float alpha)
    {
        text.color = new Color(text.color.a, text.color.g, text.color.b, alpha);
    }

    public void EndTutorial()
    {
        isFadeOut = true;
    }
}
