using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoCanvasScript : MonoBehaviour
{

    public GameObject OptionCanvas;
    public GameObject InfoCanvas;
    public GameObject ResetButton;
    public GameObject MainMenuButton;
    public float Timer;
    public float Limit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer++;

        if (Timer >= Limit)
        {
            OptionCanvas.SetActive(true);
            ResetButton.SetActive(true);
            MainMenuButton.SetActive(true);
            InfoCanvas.SetActive(false);
        }
    }
}
