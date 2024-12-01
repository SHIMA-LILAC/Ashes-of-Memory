using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberToText : MonoBehaviour
{
    public TextMeshProUGUI inputField;
    public string i;
    public void EnterNumber()
    {
        inputField.text += i;
    }
}
