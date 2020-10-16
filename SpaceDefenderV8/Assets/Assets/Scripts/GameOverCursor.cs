using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameOverCursor : MonoBehaviour
{
    public string Menu;
    public string PlayAgain;
    public Transform AudioSource;
    private bool PlaySound = true;

    IEnumerator StartPlaying()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(AudioSource, transform.position, transform.rotation);
        PlaySound = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlaySound)
        {
            //StartCoroutine(StartPlaying());
            //StopAllCoroutines();
        }

    }

    public void OnPlayAgain(InputAction.CallbackContext ctx)
    {
        if (ctx.phase == InputActionPhase.Performed)
        {
            SceneManager.LoadScene(PlayAgain);
        }
    }

    public void OnReturn(InputAction.CallbackContext ctx)
    {
        if(ctx.phase == InputActionPhase.Performed)
        {
            SceneManager.LoadScene(Menu);
        }
    }
}
