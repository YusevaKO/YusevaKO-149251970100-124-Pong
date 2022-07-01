using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftscore;
    public int maxScore;

    public bola ball;
   
    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBall();

        if (rightScore >= maxScore)
        {
            GameOver();
        }
    }
    public void AddLeftScore (int increment)
    {
        leftscore += increment;
        ball.ResetBall();
        if (leftscore>= maxScore)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("main menu");
    }
}
