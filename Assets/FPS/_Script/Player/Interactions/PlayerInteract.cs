using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerInteract : MonoBehaviour
{

    //Input
    private InputManager inputManager;


    //Variable RayCast
    private Camera cam;
    [SerializeField] private float distance = 3f;
    [SerializeField] private LayerMask layerMask;
    private RaycastHit hitInfo; //Variable to store our collision information
    
    //UI
    private PlayerUI playerUI;
   





    // Start is called before the first frame update
    void Awake()
    {

        cam = GetComponent<PlayerLook>().cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {


        playerUI.UpdateText(string.Empty);

        //create a ray at the center of the camera, shooting outwards
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(cam.transform.position, cam.transform.forward * distance, Color.red);
        if (Physics.Raycast(ray, out hitInfo, distance, layerMask))
        {


            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {

                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {

                    interactable.BaseInteract();

                }
            }



        }


    }

    public void Interact()
    {

        

        

    }

}
