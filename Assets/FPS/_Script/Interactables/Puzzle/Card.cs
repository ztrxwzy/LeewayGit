using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : Interactable
{

    public bool addCard;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {

        addCard = true;
        Debug.Log("Card Interact");
        Destroy(gameObject);

    }
}
