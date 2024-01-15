using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    public float energyBar = 100;
    private int diamonds = 0;

    [SerializeField] private Slider slider;
    [SerializeField] private Text diamondText;

    private void Update()
    {
        energyBar -= 0.01f;
        slider.value = energyBar;
        diamondText.text = "Diamonds : " + diamonds;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnergyPack"))
        {
            energyBar += 5;
            Destroy(collision.gameObject);
            slider.value = energyBar;
        }
        if (collision.gameObject.CompareTag("Diamonds"))
        {
            diamonds += 1;
            Destroy(collision.gameObject);
            diamondText.text = "Diamonds : " + diamonds;
        }
    }
}
