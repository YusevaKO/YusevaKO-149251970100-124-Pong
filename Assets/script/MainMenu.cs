using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject DisplayMisi;
    public GameObject menu;
    public GameObject DisplayCredit;
    public void PlayGame()
    {
        SceneManager.LoadScene("game");
    }
    public void Menucredit()
    {
        menu.SetActive(false);
        DisplayCredit.SetActive(true);
        Debug.Log("Created by Yuseva-149251970100-124");
    }
    public void backmenu1()
    {
        DisplayCredit.SetActive(false);
        menu.SetActive(true);
    }
    public void MenuMisi()
    {
        menu.SetActive(false);
        DisplayMisi.SetActive(true);
    }
    public void backmenu2()
    {
        DisplayMisi.SetActive(false);
        menu.SetActive(true);
    }
}
