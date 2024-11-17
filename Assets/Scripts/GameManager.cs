using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

using TMPro;

public class GameManager: MonoBehaviour
{
    public GameObject gameoverText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI recordText;
    private float surviveTime;
    private bool isGameover;

    private void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    private void Update()
    {
        if(!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + (int)surviveTime;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame()
    {

       if (!isGameover)
        {
            isGameover = true;
            gameoverText.SetActive(true);

            float bestTime = PlayerPrefs.GetFloat("BestTime");

            if (surviveTime > bestTime)
            {
                bestTime = surviveTime;
                PlayerPrefs.SetFloat("BestTime", bestTime);
            }

            recordText.text = "Best Time: " + (int)bestTime;
        }
    }
}
