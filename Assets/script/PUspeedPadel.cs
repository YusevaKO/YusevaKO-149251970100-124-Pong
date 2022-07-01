using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUspeedPadel : MonoBehaviour
{
    public PUManager manager;
    public Collider2D ball;
    public float magnitude;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<padelControl>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
