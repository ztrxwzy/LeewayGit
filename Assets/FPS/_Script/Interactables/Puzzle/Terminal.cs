using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Terminal : Interactable
{

    public int code;

    public GameObject bedMedical;
    public GameObject door;

    public TextMeshProUGUI promptText;
    public TextMeshProUGUI task;
    public string newTask;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(code);

    }

    protected override void Interact()
    {

        if (code == 3)
        {

            bedMedical.GetComponent<Animator>().SetBool("Ready", true);
            door.GetComponent<Animator>().SetBool("Ready", true);

            Debug.Log("Terminal Ready");

            promptText.color = Color.green;
            task.color = Color.green;
            task.text = newTask;
        }
        else
        {

            promptText.color = Color.red;
            task.color = Color.red;
            task.text = newTask;
        }

    }
}
