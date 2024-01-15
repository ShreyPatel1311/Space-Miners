using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private Animator anim;
    private ControllerAction ca;
    private ItemCollector ic;
    private int count = 0;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ca = GetComponent<ControllerAction>();
        ic = GetComponent<ItemCollector>();
    }

    private void FixedUpdate()
    {
        if(ic.energyBar <= 0 && count == 0)
        {
            ic.energyBar = 0;
            Die();
            count++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Crystal Spike"))
        {
            Die();
        }
    }
    internal void Die()
    {
        ca.enabled = false;
        anim.SetTrigger("Death");
        isDead = true;
    }

    private void RestartLevel()
    {
        panel.SetActive(true);
        count = 0;
    }
}