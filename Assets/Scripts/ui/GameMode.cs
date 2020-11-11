using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    [SerializeField]
    private Text text; 

    void Start()
    {
        
    }

    void Update()
    {
        switch (GameSystem.gameMode)
        {
            case GameSystem.GameMode.VeryEasy:
                text.text = "VeryEasy";
                break;
            case GameSystem.GameMode.Easy:
                text.text = "Easy";
                break;
            case GameSystem.GameMode.Normal:
                text.text = "Normal";
                break;
            case GameSystem.GameMode.Hard:
                text.text = "Hard";
                break;
            case GameSystem.GameMode.VeryHard:
                text.text = "VeryHard";
                break;
        }
    }
}
