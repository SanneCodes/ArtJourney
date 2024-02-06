using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse Clicked");
        ChangeScene(); // Call the method to change the scene
    }

    private void ChangeScene()
    {
        // Replace "Scenes/GalleryInside" with the name of the scene you want to load
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

