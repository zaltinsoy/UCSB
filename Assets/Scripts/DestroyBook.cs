using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBook : MonoBehaviour
{
    public inventory playerInv;
    public List<string> fridgeInv;
    private bool isClose;
    private int sizeOfList;


    //Check whether player is close and press the correct key according to her inventory
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) && isClose && playerInv.envanter[0] == "Book")
        {
            fridgeInv.Add(playerInv.envanter[0]);
            Debug.Log(fridgeInv);
            playerInv.envanter.RemoveAt(0);
        }


        if (Input.GetKeyDown(KeyCode.Keypad2) && isClose && playerInv.envanter[1]== "Book")
        {
            fridgeInv.Add(playerInv.envanter[1]);
            Debug.Log(fridgeInv);
            playerInv.envanter.RemoveAt(1);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) && isClose && playerInv.envanter[2] == "Book")
        {
            fridgeInv.Add(playerInv.envanter[2]);
            Debug.Log(fridgeInv);
            playerInv.envanter.RemoveAt(2);
        }

        sizeOfList = fridgeInv.Count;

        if (sizeOfList > 0)
        {
            fridgeInv.RemoveAt(0);
        }


    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
        playerInv = other.gameObject.GetComponent<inventory>();
        isClose = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isClose = false;
        }
    }
}
