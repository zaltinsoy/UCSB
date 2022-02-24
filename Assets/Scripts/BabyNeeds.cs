using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabyNeeds : MonoBehaviour
{
    public inventory playerInv;
    public List<string> babyInv;
    private bool isClose;
    private int sizeOfList;
    public float diaperNeed;
    private float diaperTime;
    public Slider diaperSlider;
    public Timer timer;


    public float foodNeed;
    private float foodTime;
    public Slider foodSlider;

    public float sleepNeed;
    private float sleepTime;
    public Slider sleepSlider;

    private float totalNeed;

    private int numBook;
    private int numFood;
    private int numTool;
    private int numThings;
    


    void Start()
    {
        diaperNeed = 100f;
        diaperTime = 0;
        diaperSlider.maxValue = 100f;
        diaperSlider.value = diaperNeed;

        foodNeed = 100f;
        foodTime = 0;
        foodSlider.maxValue = 100f;
        foodSlider.value = foodNeed;


        sleepNeed = 100f;
        sleepTime = 0;
        sleepSlider.maxValue = 100f;
        sleepSlider.value = sleepNeed;
    }

    void Update()
    {

        diaperSlider.value = diaperNeed;
        foodSlider.value = foodNeed;
        sleepSlider.value = sleepNeed;

        diaperTime += Time.deltaTime;
        foodTime += Time.deltaTime;


        if (diaperTime > 5)
        {
            diaperNeed -= 4.5f;
            diaperTime = 0;
        }


        if (foodTime > 4.5)
        {
            foodNeed -= 5f;
            foodTime = 0;
        }

        numBook = GameObject.FindGameObjectsWithTag("book").Length;
        numTool = GameObject.FindGameObjectsWithTag("tool").Length;
        numFood = GameObject.FindGameObjectsWithTag("food").Length;
        numThings = numBook + numTool + numTool;

        sleepNeed = 100 - 10 * numThings;
        Debug.Log(sleepNeed);


        if (foodNeed < 0 || diaperNeed < 0 || sleepNeed < 0)
        {
            timer.RestartDelay();
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) && isClose)
        {
            babyInv.Add(playerInv.envanter[0]);
            Debug.Log(babyInv);
            playerInv.envanter.RemoveAt(0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) && isClose)
        {
            babyInv.Add(playerInv.envanter[1]);
            Debug.Log(babyInv);
            playerInv.envanter.RemoveAt(1);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) && isClose)
        {
            babyInv.Add(playerInv.envanter[2]);
            Debug.Log(babyInv);
            playerInv.envanter.RemoveAt(2);
        }
        sizeOfList = babyInv.Count;
        if (sizeOfList > 1)
        {
            babyInv[0] = babyInv[1];
            babyInv.RemoveAt(1);
        }

        if (babyInv[0] == "Diaper")
        {
            babyInv.RemoveAt(0);
            diaperNeed += 20;
            diaperTime = 0;
            if (diaperNeed > 100)
            {
                diaperNeed = 100;
            }
        }

        if (babyInv[0] == "ReadyMeal")
        {
            babyInv.RemoveAt(0);
            foodNeed += 25;
            foodTime = 0;
            if (foodNeed > 100)
            {
                foodNeed = 100;
            }
        }
        totalNeed = foodNeed + sleepNeed + diaperNeed;
        PlayerPrefs.SetFloat("TotalNeed", totalNeed);
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
}
