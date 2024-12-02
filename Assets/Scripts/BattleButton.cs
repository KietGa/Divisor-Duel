using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleButton : MonoBehaviour
{
    public Data data;

    private void Awake()
    {
        data.deathRange = PlayerPrefs.GetInt("deathRange");
        data.deathRangeText.text = "1 - " + data.deathRange;
        data.currentNumber = PlayerPrefs.GetInt("startNumber");
        data.currentNumberText.text = data.currentNumber.ToString();
    }

    public void Divide()
    {
        int num;
        switch (data.turn)
        {
            case 1:
                data.turnText.text = "Player 2's Turn";
                if (!int.TryParse(data.player1.text, out num))
                {
                    data.chatBox1.text = "Invalid Input! Lost Turn!";
                }
                else
                {
                    if (data.currentNumber % num == 0 && num != data.currentNumber)
                    {
                        data.lastDivisor = num;
                        data.lastDivisorText.text = num.ToString();
                        data.currentNumber -= num;
                        data.currentNumberText.text = data.currentNumber.ToString();
                        if (data.currentNumber >= 1 && data.currentNumber <= data.deathRange)
                        {
                            data.chatBox1.text = "I Win!";
                            data.chatBox2.text = "No way!";
                            Invoke("Menu", 2);
                            break;
                        }
                    }
                    else
                    {
                        data.chatBox1.text = "Not a divisor! Lost Turn!";
                    } 
                }
                data.turn = 2;
                break;
            case 2:
                data.turnText.text = "Player 1's Turn";
                if (!int.TryParse(data.player2.text, out num))
                {
                    data.chatBox2.text = "Invalid Input! Lost Turn!";
                }
                else
                {
                    if (data.currentNumber % num == 0 && num != data.currentNumber)
                    {
                        data.lastDivisor = num;
                        data.lastDivisorText.text = num.ToString();
                        data.currentNumber -= num;
                        data.currentNumberText.text = data.currentNumber.ToString();
                        if (data.currentNumber >= 1 && data.currentNumber <= data.deathRange)
                        {
                            data.chatBox1.text = "What!";
                            data.chatBox2.text = "I Win!";
                            Invoke("Menu", 2);
                            break;
                        }
                    }
                    else
                    {
                        data.chatBox2.text = "Not a divisor! Lost Turn!";
                    }
                }
                data.turn = 1;
                break;
        }
    }

    public void GiveUp()
    {
        switch (data.turn)
        {
            case 1:
                data.chatBox1.text = "I Give Up!";
                data.chatBox2.text = "GG!";
                Invoke("Menu", 2);
                break;
            case 2:
                data.chatBox2.text = "I Lost!";
                data.chatBox1.text = "Ez Game!";
                Invoke("Menu", 2);
                break;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Talk()
    {
        int ran = Random.Range(1, 6);
        switch (data.turn)
        {
            case 1:
                if (ran == 1)
                {
                    data.chatBox1.text = "Smart Move!";
                }
                if (ran == 2)
                {
                    data.chatBox1.text = "I think the end is near!";
                }
                if (ran == 3)
                {
                    data.chatBox1.text = "Boring!";
                }
                if (ran == 4)
                {
                    data.chatBox1.text = "ez peasy lemon squeezy!";
                }
                if (ran == 5)
                {
                    data.chatBox1.text = "Noob!";
                }
                break;
            case 2:
                if (ran == 1)
                {
                    data.chatBox2.text = "Victory is mine!";
                }
                if (ran == 2)
                {
                    data.chatBox2.text = "Good luck!";
                }
                if (ran == 3)
                {
                    data.chatBox2.text = "Get your game on!";
                }
                if (ran == 4)
                {
                    data.chatBox2.text = "Wow!";
                }
                if (ran == 5)
                {
                    data.chatBox2.text = "I'm just use 50% my brain!";
                }
                break;
        }
    }
}
