using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMaster : MonoBehaviour
{
    public string OptionsScene;
    public float Timer;
    public float Limit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= Limit)
        {
            SceneManager.LoadScene(5);
        }
    }
}
