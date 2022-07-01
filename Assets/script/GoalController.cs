using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public scoreManager Manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision == ball)
        {
            if (isRight)
            {
                Manager.AddRightScore(1);
            }
            else
            {
                Manager.AddLeftScore(1);
            }
        }
    }

}
