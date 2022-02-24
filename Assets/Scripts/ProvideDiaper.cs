using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProvideDiaper : MonoBehaviour
{
    public inventory playerInv;
    private bool keyDown;
    // Provide diaper if player is close and press the space
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && keyDown)
        {
            playerInv.envanter.Add("Diaper");
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