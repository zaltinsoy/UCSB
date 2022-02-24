using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProvideMilk : MonoBehaviour
{
    public inventory playerInv;
    private bool keyDown;
    // Provide milk if player is close and press the space

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && keyDown)
        {
            playerInv.envanter.Add("Milk");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //Define the inventory from the other object
        playerInv = other.gameObject.GetComponent<inventory>();
        keyDown = true;
    }
    private void OnTriggerExit(Collider other)
    {
        keyDown = false;
    }
}