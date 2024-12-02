using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOn : MonoBehaviour
{
    public InputField startNumber;
    public InputField deathRange;
    public void Game()
    {
        int startNumberData;
        int deathRangeData;
        if (!int.TryParse(startNumber.text, out startNumberData))
        {
            startNumberData = 100;
        }
        if (!int.TryParse(deathRange.text, out deathRangeData))
        {
            deathRangeData = 1;
        }
        PlayerPrefs.SetInt("startNumber", startNumberData);
        PlayerPrefs.SetInt("deathRange", deathRangeData);
        SceneManager.LoadScene(1);
    }
}
