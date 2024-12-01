using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CheckProgress : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public string rightNumbers;
    public bool win;
    public Button b;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(myText.text == rightNumbers && !win)
        {
            myText.text = "CORRECT";
            win = true;
            b.enabled = true;
        }
        if (myText.text != rightNumbers && !win)
        {
            int _charCount = myText.GetParsedText().Length;
            if (_charCount >= 4)
            {
                myText.text = "INCORRECT";
            }
        }

        if(myText.text == "INCORRECT" && Input.anyKey)
        {
            myText.text = "";
        }

        if (win)
        {
            myText.text = "CORRECT";
        }


    }
}
