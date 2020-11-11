using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    private const float StartGameSpeed = 0.1f;
    public static float BeforeGameSpeed;
    public static float GameSpeed;
    public static float GimmickDestoryPosition = -15.0f;

    public static Vector3 repeatPosition = new Vector3(20.0f, 3.3f, 0.0f);
    public static bool isEndGame;
    private int endCount;

    public static bool isNextGimmickStage;
    public static bool isNextNormalStage;
    public bool isFirstPhase;

    private static int phaseCount = 1;

    public enum GameMode {
        VeryEasy = 1,
        Easy,
        Normal,
        Hard,
        VeryHard,
    }

    public static GameMode gameMode;
     
    [SerializeField]
    GameObject fade;

    [SerializeField]
    GameObject StageSystem;

    [SerializeField]
    GameObject SpeedUpText;

    [SerializeField]
    public GameObject PhaseText;
    [SerializeField]
    public GameObject PhaseCountText;
    [SerializeField]
    public GameObject GameModeText;

    [SerializeField]
    public GameObject TutorialText;

    void Start()
    {
        GameSpeed = StartGameSpeed;
        BeforeGameSpeed = GameSpeed;
        endCount = 0;
        phaseCount = 0;
        isEndGame = false;
        isNextGimmickStage = false;
        isNextNormalStage = false;
        isFirstPhase = false;

        gameMode = GameMode.VeryEasy;
    }

    void Update()
    {
        if (isNextGimmickStage)
        {
            UpdateNextGimmickStage();
    
            if (isFirstPhase)
            {
                PhaseText.GetComponent<Text>().enabled = true;
                PhaseCountText.GetComponent<Text>().enabled = true;
                GameModeText.GetComponent<Text>().enabled = true;
                isFirstPhase = false;

                TutorialText.GetComponent<Tutorial>().EndTutorial();
            }
            isNextGimmickStage = false;
        }

        if (isNextNormalStage)
        {
            UpdateNextNormalStage();
            isNextNormalStage = false;
        }

        if (isEndGame)
        {
            endCount++;

            if (endCount >= 120)
            {
                fade.GetComponent<Fade>().StartFadeOut();
            }
            if (fade.GetComponent<Fade>().FadeEnd())
            {
                SceneManager.LoadScene("Result");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            EndGame();
        }

    }

    public static void Stop()
    {
        BeforeGameSpeed = GameSpeed;
        GameSpeed = 0.0f;
    }

    public static void Restart()
    {
        GameSpeed = BeforeGameSpeed;
    }

    public static void EndGame()
    {
        Stop();

        isEndGame = true;
    }

    public void UpdateNextGimmickStage()
    {


        phaseCount++;

        if (phaseCount == 1)
        {
            isFirstPhase = true;
        }
        else
        {
            GameSpeed += 0.005f;
            SpeedUpText.GetComponent<SpeedUp>().StartFadeIn();

            if (phaseCount % 2 == 0)
            {
                if (gameMode == GameMode.VeryHard)
                {
                    gameMode = GameMode.VeryEasy;
                }
                else
                {
                    gameMode++;
                }
            }
        }

        // stege create
        StageSystem.GetComponent<StageSystem>().GimmickStage();

    }

    public void UpdateNextNormalStage()
    {
        StageSystem.GetComponent<StageSystem>().NormalStage();
    }

    public static int GetPhaseScore()
    {
        return phaseCount;
    }
}
