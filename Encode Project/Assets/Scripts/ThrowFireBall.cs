using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFireBall : MonoBehaviour
{
    private ControllerAction ca;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;

    [SerializeField] private GameObject fireBall;
    
    public Transform firePos;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ca = GetComponent<ControllerAction>();
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Instantiate(fireBall, firePos.position, firePos.rotation);
        }
    }
}
