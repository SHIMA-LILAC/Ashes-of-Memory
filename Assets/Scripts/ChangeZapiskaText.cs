using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeZapiskaText : MonoBehaviour, ISelectHandler 
{
    public TextMeshProUGUI text;
    public string muText;
    public Button button;
    private void Start()
    {
        button = GetComponent<Button>();
    }

    private void Update()
    {
        
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log(this.gameObject.name + " was selected");
        text.text = muText;
    }
}
