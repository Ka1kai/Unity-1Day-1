using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour
{
    [SerializeField]
    public float speed = 1.0f;

    private Text text;
    private float time;
    
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.color = BlinkTextColor(text.color);
    }

    private Color BlinkTextColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}
