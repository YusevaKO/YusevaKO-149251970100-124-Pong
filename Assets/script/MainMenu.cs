using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject textDisplay;
    public void PlayGame()
    {
        SceneManager.LoadScene("game");
    }
    public void OpenAuthor()
    {
        Debug.Log("Created by Yuseva-149251970100-124");
    }
    public void Misi()
    {
        string misi;
        misi = "Dalam permainan ini kamu akan menggunakan \n"+
            "tombol S dan W untuk menggerakan Padel Kanan ! \n" +
            "tombol A dan Q untuk menggerakan Padel Kiri ! \n"

            ;
        Debug.Log(misi);
        textDisplay.GetComponent<Text>().text = "" + misi;
    }

}
