using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject menu;
    public GameObject tuto;
    public GameObject credit;
    public GameObject duel;
    public void Quit()
    {
        Application.Quit();
    }

    public void Duel()
    {
        duel.SetActive(true);
        menu.SetActive(false);
    }

    public void DQuit()
    {
        duel.SetActive(false);
        menu.SetActive(true);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Tutorial()
    {
        tuto.SetActive(true);
        menu.SetActive(false);
    }

    public void TMenu()
    {
        menu.SetActive(true);
        tuto.SetActive(false);
    }

    public void Credit()
    {
        credit.SetActive(true);
        menu.SetActive(false);
    }

    public void CMenu()
    {
        menu.SetActive(true);
        credit.SetActive(false);
    }
}
