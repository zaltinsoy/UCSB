using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class provideBowl : MonoBehaviour
{
    public inventory playerInv;
    private bool keyDown;
    // Provide bowl if player is close and press the space
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&keyDown)
        {
            playerInv.envanter.Add("Bowl");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        playerInv = other.gameObject.GetComponent<inventory>();
        keyDown = true;
    }
    private void OnTriggerExit(Collider other)
    {
        keyDown = false;
    }
}
