using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Comment : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject comm;
    public GameObject dialogueBox;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moving")
        {
            dialogueBox.SetActive(true);
            text.text = "Oops, my friends and I missed each other. It seems that they ran away in right direction. I can move on the A and D keys.";
        }

        if (collision.gameObject.tag == "Touch")
        {
            dialogueBox.SetActive(true);
            text.text = "What a beautiful forest. Let's keep moving.";
        }


        if (collision.gameObject.tag == "Chest tp")
        {
            dialogueBox.SetActive(true);
            text.text = "Wow, there's a passage here. Press E.";
        }

        if (collision.gameObject.tag == "Drawing")
        {
            dialogueBox.SetActive(true);
            text.text = " What is this place? Strange drawings....";
        }
       

        if (collision.gameObject.tag == "Item")
        {
            dialogueBox.SetActive(true);
            text.text = "Hmm, an interesting thing. I'll take her with me. Press E.";
        }

        if (collision.gameObject.tag == "Tab")
        {
            dialogueBox.SetActive(true);
            text.text = "Seems, I can open the inventory now. Press Tab.";
        }


        if (collision.gameObject.tag == "LesTP")
        {
            dialogueBox.SetActive(true);
            text.text = "Let's go back to the forest. Press E.";
        }

        if (collision.gameObject.tag == "ToGorod")
        {
            dialogueBox.SetActive(true);
            text.text = "The city is in the left direction. Let's go.";
        }

        if (collision.gameObject.tag == "CityTP")
        {
            dialogueBox.SetActive(true);
            comm.SetActive(true);
            text.text = "To the city! Press E.";

        }

        if (collision.gameObject.tag == "ForestTP")
        {
            dialogueBox.SetActive(true);
            text.text = "I don't think I should go back to the forest. Let's keep moving.";
        }

        if (collision.gameObject.tag == "LakeTP")
        {
            dialogueBox.SetActive(true);
            text.text = "Oh, I've seen this bridge somewhere! I think we should go to the lake. Press E.";
        }

        if (collision.gameObject.tag == "RuinsTP")
        {
            dialogueBox.SetActive(true);
            text.text = "Does it seem to be a ruin? I think I need to go check it out. Press E.";
        }

        if (collision.gameObject.tag == "MountTP")
        {
            dialogueBox.SetActive(true);
            text.text = "It seems that this is the last location. Does it look like a mountain? I wonder what awaits me there. Press E.";
        }

        //if (collision.gameObject.tag == "Stone")
        //{
        //    dialogueBox.SetActive(true);
        //    text.text = "To move this stone - Press E.";
        //}

        if (collision.gameObject.tag == "Ebanina")
        {
            dialogueBox.SetActive(true);
            text.text = "Let's move this vines away. Press E.";
        }

        if (collision.gameObject.tag == "Num")
        {
            dialogueBox.SetActive(true);
            text.text = "Let's open this strange door. Press E.";


        }
        if (collision.gameObject.tag == "Stones")
        {
            dialogueBox.SetActive(true);
            text.text = "I think I can move these stones. Press E.";
        }
        if (collision.gameObject.tag == "NumNorm")
        {
            dialogueBox.SetActive(true);
            text.text = "Is it 6 or 9?";
        }
        if (collision.gameObject.tag == "BunkerCom")
        {
            dialogueBox.SetActive(true);
            text.text = "Wow... Has anyone lived here before? Who are these creatures?";
        }

        if (collision.gameObject.tag == "Paper")
        {
            dialogueBox.SetActive(true);
            text.text = "Is that a new note? Let's take and read it in my inventory!";
        }

        //if (collision.gameObject.tag == "Stone3")
        //{
        //    dialogueBox.SetActive(true);
        //    text.text = "To move this stone - Press E.";
        //}
        //if (collision.gameObject.tag == "")
        //{
        //    dialogueBox.SetActive(true);
        //    text.text = "  ";
        //}
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        text.text = " ";
    //    }
    //}
    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogueBox.SetActive(false);
        text.text = " ";
    }
}