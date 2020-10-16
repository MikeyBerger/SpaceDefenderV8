using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionCursorScript : MonoBehaviour
{

    Vector2 Movement;
    public float Speed;
    private MainMenuButtonScriptV2 MMBS;
    private ResetButtonScriptV2 RBS;
    private SaveSystemV2 SSV2;
    private Rigidbody2D RB;
    public string MainMenu;
    public bool ButtonIsPressed = false;
    /*
    public GameObject OptionCanvas;
    public GameObject InfoCanvas;
    public GameObject ResetButton;
    public GameObject MainMenuButton;
    public float Timer;
    public float Limit;
    public bool SwitchMenus;
    */
    public string HiScoreChangeScene;




    // Start is called before the first frame update
    void Start()
    {
        MMBS = GameObject.FindGameObjectWithTag("MainMenuButton").GetComponent<MainMenuButtonScriptV2>();
        RBS = GameObject.FindGameObjectWithTag("ResetButton").GetComponent<ResetButtonScriptV2>();
        SSV2 = new SaveSystemV2();
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (ButtonIsPressed)
        {
            Timer += Time.deltaTime;
            if (Timer >= Limit)
            {
                ButtonIsPressed = false;
                Timer = 0;
            }
        }
        */

        RB.velocity = new Vector2(Movement.x, Movement.y) * Speed * Time.deltaTime;

        if (RBS.ResetIsPressed && ButtonIsPressed)
        {
            PlayerPrefs.DeleteKey("HiScore");

            SSV2.HiScore = 0;

            SceneManager.LoadScene(HiScoreChangeScene);



            //StartCoroutine(ResetHiScore());

            //StopCoroutine(ResetHiScore());

            
            //OptionCanvas.SetActive(false);
            //ResetButton.SetActive(false);
            //MainMenuButton.SetActive(false);
            //InfoCanvas.SetActive(true);
            //Time.timeScale = 0;
         

            



        }

        if (MMBS.MenuIsPressed && ButtonIsPressed)
        {
            SceneManager.LoadScene(MainMenu);
        }

    }


    public void OnMove(InputAction.CallbackContext ctx)
    {
        Movement = ctx.ReadValue<Vector2>();
    }

    public void OnPlayPress(InputAction.CallbackContext ctx)
    {
        if (ctx.phase == InputActionPhase.Performed)
        {
            ButtonIsPressed = true;
            
        }
    }
}
