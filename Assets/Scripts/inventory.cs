using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class inventory : MonoBehaviour
{

    //public string env1;
    public List<string> envanter;
    private int sizeOfList;
    public Image env1Image;
    public Image env2Image;
    public Image env3Image;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public Sprite mama;
    public Sprite bowl;
    public Sprite invis;
    public Sprite milk;
    public Sprite readyMeal;
    public Sprite diaper;
    public Sprite banana;
    public Sprite wrench;
    public Sprite book;
    private GameObject collect;
    private bool keyDown;

    //Show the inventory images on top of the screen
    void SetImage()
    {

        if (sizeOfList == 0)
        {
            env1Image.sprite = invis;
            env2Image.sprite = invis;
            env3Image.sprite = invis;
        }
        else if (sizeOfList == 1)
        {

            env1Image.sprite = AssignSprite(envanter[0]);
            env2Image.sprite = invis;
            env3Image.sprite = invis;
        }
        else if (sizeOfList == 2)
        {
            env1Image.sprite = AssignSprite(envanter[0]);
            env2Image.sprite = AssignSprite(envanter[1]);
            env3Image.sprite = invis;
        }
        else if (sizeOfList == 3)
        {
      
            env1Image.sprite = AssignSprite(envanter[0]);
            env2Image.sprite = AssignSprite(envanter[1]);
            env3Image.sprite = AssignSprite(envanter[2]);
        }


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
            case "Diaper":
                return diaper;
                break;
            case "Banana":
                return banana;
            case "Wrench":
                return wrench;
                break;
            case "Book":
                return book;
                break;
            default:
                return invis;
                break;

        }

    }


    private void Start()
    {
        sizeOfList = envanter.Count;
        SetImage();
       

    }
    void Update()
    {
        sizeOfList = envanter.Count;

        if (sizeOfList > 3)
        {
            envanter[0] = envanter[1];
            envanter[1] = envanter[2];
            envanter[2] = envanter[3];
            envanter.RemoveAt(3);

        }

        SetImage();


        if (Input.GetKeyDown(KeyCode.Space) && keyDown&& collect.CompareTag("food")) 
        {
            envanter.Add("Banana");
            Destroy(collect);
        }

        if (Input.GetKeyDown(KeyCode.Space) && keyDown && collect.CompareTag("tool"))
        {
            envanter.Add("Wrench");
            Destroy(collect);
        }
        if (Input.GetKeyDown(KeyCode.Space) && keyDown && collect.CompareTag("book"))
        {
            envanter.Add("Book");
            Destroy(collect);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("food")|| other.gameObject.CompareTag("tool") || other.gameObject.CompareTag("book"))
        {
            collect= other.gameObject;
            keyDown = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        keyDown = false;
    }


}
