using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    private Image image;
    private bool isFadeOut;
    private float alpha;

    [SerializeField]
    private float speed = 0.1f;

    void Start()
    {
        image = GetComponent<Image>();
        isFadeOut = false;
        alpha = image.color.a; 
    }

    void Update()
    {
        if (isFadeOut) {
            FadeOut();
        }
    }

    public void StartFadeOut()
    {
        isFadeOut = true;
    }

    public void FadeOut()
    {
        alpha += speed;
        image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);

        if (alpha >= 1)
        {
            isFadeOut = false;
        }
    }

    public bool FadeEnd()
    {
        return alpha >= 1 ? true : false;
    }
}
