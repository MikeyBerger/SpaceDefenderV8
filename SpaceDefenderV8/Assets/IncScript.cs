using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class IncScript : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D RB;
    private bool IsMoving = true;
    public bool ChangeScene;
    public AudioSource AS;
    private OOPsScript OOPs;

    // Start is called before the first frame update
    void Start()
    {
        AS.enabled = false;
        RB = GetComponent<Rigidbody2D>();
        AS = GameObject.FindGameObjectWithTag("Ship").GetComponent<AudioSource>();
        OOPs = GameObject.FindGameObjectWithTag("OOPs").GetComponent<OOPsScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsMoving)
        {
            RB.velocity = new Vector2(Speed, 0) * Time.deltaTime;
        }
        else if (!IsMoving)
        {
            RB.velocity = Vector2.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsMoving = false;
        ChangeScene = true;
        if (OOPs.IsGrounded)
        {
            AS.enabled = true;
        }
    }
}
