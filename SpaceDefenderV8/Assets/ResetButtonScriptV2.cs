using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonScriptV2 : MonoBehaviour
{
    public bool ResetIsPressed = false;
    private Color ColorWhite = Color.white;
    private Color ColorRed = Color.red;
    private SpriteRenderer SR;
    public GameObject OptionCanvas;
    public GameObject InfoCanvas;
    public GameObject ResetButton;
    public GameObject MainMenuButton;
    public float Timer;
    public float Limit;
    public bool SwitchMenus;

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (ResetIsPressed)
        {
            OptionCanvas.SetActive(false);
            InfoCanvas.SetActive(true);
            ResetButton.SetActive(false);
            MainMenuButton.SetActive(false);
            ResetIsPressed = false;
        }
        */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.tag == "Cursor")
        {
            ResetIsPressed = true;
            SR.material.color = Color.green;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.gameObject.tag == "Cursor")
        {
            ResetIsPressed = false;
            SR.material.color = ColorWhite;
           
        }
    }
}
