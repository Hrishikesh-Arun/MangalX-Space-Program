using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public GameObject bluePrint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlueprintShow()
    {
        if (bluePrint.activeInHierarchy)
        {
            bluePrint.SetActive(false);
        }
        else
        {
            bluePrint.SetActive(true);
        }
    }

    public static void SwitchGameScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName + "Scene");
    }
}
