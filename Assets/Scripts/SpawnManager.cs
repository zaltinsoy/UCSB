using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject projectilePrefab;
    private Vector3 newPosition;
    private Quaternion newRotation;
    private Vector3 rotAxis;
    public Transform cam;
    private bool isCatGone;
    public CatMoves catMoves;
    private int tempInt;
    private int randomPathInt;


    void Update()
    {
        // Spawn a tool if cat is touch and gone
        if (isCatGone == true)
        {
            newPosition = transform.position;
            newPosition.y = 2f;

            newRotation = transform.rotation;

            rotAxis.x = 0;
            rotAxis.y = 0;
            rotAxis.z = 1;

            newRotation = Quaternion.Euler(0, -90, 0);
            Instantiate(projectilePrefab, newPosition, newRotation);
            isCatGone = false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("cat"))
        {
            tempInt = catMoves.randomInt;
            randomPathInt = Random.Range(0, 2);

            switch (tempInt)
            {
                case 0:
                    switch (randomPathInt)
                    {
                        case 0:
                            catMoves.randomInt = 1;
                            break;
                        case 1:
                            catMoves.randomInt = 2;
                            break;
                    }
                    break;
                case 1:
                    switch (randomPathInt)
                    {
                        case 0:
                            catMoves.randomInt = 0;
                            break;
                        case 1:
                            catMoves.randomInt = 2;
                            break;
                    }
                    break;
                case 2:
                    switch (randomPathInt)
                    {
                        case 0:
                            catMoves.randomInt = 0;
                            break;
                        case 1:
                            catMoves.randomInt = 1;
                            break;
                    }
                    break;

            }
        }
    }
    private void OnTriggerExit(Collider other)

    {
        if (other.gameObject.CompareTag("cat"))
        {
            isCatGone = true;
        }
    }

}
