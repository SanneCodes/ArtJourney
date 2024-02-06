using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingExitScript : MonoBehaviour
{
    public PlayerController playerController;
   

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();

    }

    
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked");


        if (playerController != null)
        {
            playerController.x = -255.5f;
            playerController.y = -57;
            playerController.check = false;
        }
    }
}
