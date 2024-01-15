using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float projectileSpeed;
    private Rigidbody2D rb2;
    [SerializeField] private GameObject ca;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        ControllerAction ca1 = ca.GetComponent<ControllerAction>();
        if(ca1 == null)
        {
            Debug.Log("Component Not Found!");
        }
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        rb2.velocity = transform.right * projectileSpeed;
        sr.flipX = ca1.flip;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy") || collision.CompareTag("Terrain"))
        {
            Destroy(gameObject);
        }
    }

}
