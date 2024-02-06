using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingScript : MonoBehaviour
{
    //lager 
    public PlayerController playerController;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("GalleryInside");
    } 

}


