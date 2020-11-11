using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhaseText : MonoBehaviour
{
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = GameSystem.GetPhaseScore().ToString();
    }
}
