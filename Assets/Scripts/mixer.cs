using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mixer : MonoBehaviour
{

    public inventory playerInv;
    public List<string> mixInv;
    private bool isClose;

    public Sprite mama;
    public Sprite bowl;
    public Sprite invis;
    public Sprite milk;
    public Sprite readyMeal;

    public Image mix1Image;
    public Image mix2Image;
    public Image mix3Image;

    private int sizeOfList;


    private void Start()
    {
        SetImage();
    }
    private void Update()
    {
        //Check whether player gave an object to mixer
        if (Input.GetKeyDown(KeyCode.Keypad1) && isClose)
        {
            mixInv.Add(playerInv.envanter[0]);
            Debug.Log(mixInv);
            playerInv.envanter.RemoveAt(0);
        }


        if (Input.GetKeyDown(KeyCode.Keypad2) && isClose)
        {
            mixInv.Add(playerInv.envanter[1]);
            Debug.Log(mixInv);
            playerInv.envanter.RemoveAt(1);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) && isClose)
        {

            mixInv.Add(playerInv.envanter[2]);
            Debug.Log(mixInv);
            playerInv.envanter.RemoveAt(2);
        }

        sizeOfList = mixInv.Count;

        //Remove excess objects
        if (sizeOfList > 3)
        {
            mixInv[0] = mixInv[1];
            mixInv[1] = mixInv[2];
            mixInv[2] = mixInv[3];
            mixInv.RemoveAt(3);
        }
        SetImage();

        if (Input.GetKeyDown(KeyCode.Space) && isClose && mixInv[0] != "ReadyMeal")
        {
            mixInv = prepareMeal(mixInv);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isClose && mixInv[0] == "ReadyMeal")
        {
            mixInv.Clear();
            playerInv.envanter.Add("ReadyMeal");
        }

    }

    private void OnTriggerStay(Collider other)
    {
        playerInv = other.gameObject.GetComponent<inventory>();
        isClose = true;

    }
    private void OnTriggerExit(Collider other)
    {
        isClose = false;
    }
    private Sprite AssignSprite(string envName)
    {
        switch (envName)
        {
            case "Mama":
                return mama;
                break;
            case "Bowl":
                return bowl;
                break;
            case "Milk":
                return milk;
                break;
            case "ReadyMeal":
                return readyMeal;
                break;
            default:
                return invis;
                break;
        }

    }
    void SetImage()
    {

        if (sizeOfList == 0)
        {
            mix1Image.sprite = invis;
            mix2Image.sprite = invis;
            mix3Image.sprite = invis;
        }
        else if (sizeOfList == 1)
        {

            mix1Image.sprite = AssignSprite(mixInv[0]);
            mix2Image.sprite = invis;
            mix3Image.sprite = invis;
        }
        else if (sizeOfList == 2)
        {
            mix1Image.sprite = AssignSprite(mixInv[0]);
            mix2Image.sprite = AssignSprite(mixInv[1]);
            mix3Image.sprite = invis;
        }
        else if (sizeOfList == 3)
        {
            mix1Image.sprite = AssignSprite(mixInv[0]);
            mix2Image.sprite = AssignSprite(mixInv[1]);
            mix3Image.sprite = AssignSprite(mixInv[2]);
        }


    }
    public List<string> prepareMeal(List<string> invList)
    {
        if (invList[0] == "Bowl" && (invList[1] == "Milk" && invList[2] == "Mama") || (invList[1] == "Mama" && invList[2] == "Milk"))

        {
            StartCoroutine(invClean(invList));
        }
        return invList;
    }

    private IEnumerator invClean(List<string> invList)
    {
        yield return new WaitForSeconds(2f);
        invList.Clear();
        invList.Add("ReadyMeal");
    }


}
