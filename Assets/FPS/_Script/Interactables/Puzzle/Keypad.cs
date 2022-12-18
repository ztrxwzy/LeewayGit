using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keypad : Interactable
{

    public GameObject door;
    public Card card;
    public TextMeshProUGUI promptText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //this function is where we will desing our interaction using code
    protected override void Interact()
    {

        if (card.addCard == true)
        {

            door.GetComponent<Animator>().Play("OpenDoor");
            promptText.color = Color.green;
        }
        else
        {

            promptText.color = Color.red;

        }

    }
}
