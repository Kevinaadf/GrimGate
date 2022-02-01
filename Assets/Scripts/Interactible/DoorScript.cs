using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour, IInteractible
{
    public string levelName;


    void IInteractible.Interact()
    {
        Debug.Log("Opened Door");
        //UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);
    }

}
