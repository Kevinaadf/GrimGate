using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    [SerializeField]
    private BoxCollider2D interactArea;

    private IInteractible currentInteractibleToInteractWith;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Interact();
        }

        if (currentInteractibleToInteractWith != null)
        {
            //Debug.Log("I have an interactible to interact with");
        }
        else
        {
            //Debug.Log("I dont have an interactible to interact");
        }
        
    }

    private void Interact()
    {
        if (currentInteractibleToInteractWith != null)
        {
            currentInteractibleToInteractWith.Interact();
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");

        if (collision.GetComponent<IInteractible>() != null)
        {
            Debug.Log("Collision with interactible");
            currentInteractibleToInteractWith = collision.GetComponent<IInteractible>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<IInteractible>() != null && collision.GetComponent<IInteractible>() == currentInteractibleToInteractWith)
        {
            Debug.Log("CurrentInteractible Left Interactible Range");
            currentInteractibleToInteractWith = null;
        }
    }

}
