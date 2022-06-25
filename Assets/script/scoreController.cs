using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{
    public Text skorKiri;
    public Text skorKanan;

    public scoreManager manager;
    private void Update()
    {
        skorKiri.text = manager.leftscore.ToString();
        skorKanan.text = manager.rightScore.ToString();
    }
}
