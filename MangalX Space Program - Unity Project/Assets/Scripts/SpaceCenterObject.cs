using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceCenterObject : MonoBehaviour
{
    private string myName;

    void Awake()
    {
        myName = this.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (myName == "VAB")
        {
            GameHandler.SwitchGameScene(myName);
        }
    }
}
