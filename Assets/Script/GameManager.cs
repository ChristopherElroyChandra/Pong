using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int PlayerScore1;
    public int PlayerScore2;
    public int MaxScore;
    public int AddScore;
    public string Winner = "";
    public GameObject End;

    public TMP_Text txtPlayerScore1;
    public TMP_Text txtPlayerScore2;
    public TMP_Text PlayerWinner;
    
    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        txtPlayerScore1.text = PlayerScore1.ToString();
        txtPlayerScore2.text = PlayerScore2.ToString();
        PlayerWinner.text = Winner.ToString();
    }

    void Update()
    {
        if (PlayerScore1 == MaxScore)
        {
            Winner = "Player 1 Wins!";
            PlayerWinner.text = Winner.ToString();
            End.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (PlayerScore2 == MaxScore)
        {
            Winner = "Player 2 Wins!";
            PlayerWinner.text = Winner.ToString();
            End.SetActive(true);
            Time.timeScale = 0f;
        }
    }


    public void Score(string wallID)
    {
        if (wallID == "Goal 1")
        {
            PlayerScore2 = PlayerScore2 + AddScore;
            txtPlayerScore2.text = PlayerScore2.ToString();
        }
        else
        {
            PlayerScore1 = PlayerScore1 + AddScore;
            txtPlayerScore1.text = PlayerScore1.ToString();
           
        }
    }

}