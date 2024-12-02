using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public InputField player1;
    public InputField player2;
    public Text chatBox1;
    public Text chatBox2;
    public int turn = 1;
    public Text turnText;
    public int lastDivisor;
    public Text lastDivisorText;
    public int deathRange;
    public Text deathRangeText;
    public int currentNumber;
    public Text currentNumberText;
}
