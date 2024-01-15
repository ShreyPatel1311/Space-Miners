using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishShipLine : MonoBehaviour
{
    [SerializeField] private GameObject Pl;
    public bool isWon = false;

    private PlayerLife pl;

    private void Start()
    {
        pl = Pl.GetComponent<PlayerLife>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && pl.isDead == false)
        {
            isWon = true;
        }
    }
}
