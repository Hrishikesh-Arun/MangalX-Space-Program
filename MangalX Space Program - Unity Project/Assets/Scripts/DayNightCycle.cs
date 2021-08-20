using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField]
    private float cycleTimer;

    void Awake()
    {
        cycleTimer = 180;
    }

    // Update is called once per frame
    void Update()
    {
        cycleTimer -= Time.deltaTime;
        transform.Rotate(-(Time.deltaTime * 2), 0, 0);
        if (cycleTimer <= 0)
        {
            cycleTimer = 180;
        }
    }
}
