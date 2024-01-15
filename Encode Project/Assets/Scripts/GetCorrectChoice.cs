using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCorrectChoice : MonoBehaviour
{
    private ControllerAction ca;
    private ItemCollector ic;
    internal GameObject plat;
    private Questions qsPlat;

    [SerializeField] internal GameObject Player;
    [SerializeField] private GameObject panel;

    private void Update()
    {
        ca = Player.GetComponent<ControllerAction>();
        ic = Player.GetComponent<ItemCollector>();
        qsPlat = ca.Platform.GetComponent<Questions>();
    }

    public void GetOption1()
    {
        if (qsPlat.OptionsBool1)
        {
            ic.energyBar += 25;
        }
        else
        {
            Debug.Log("Decrease");
            ic.energyBar -= 10;
        }
        Debug.Log("Option1");
        panel.SetActive(false);
        ca.enabled = true;
        ic.enabled = true;
    }

    public void GetOption2()
    {
        if (qsPlat.OptionsBool2)
        {
            ic.energyBar += 25;
        }
        else
        {
            Debug.Log("Decrease");
            ic.energyBar -= 10;
        }
        Debug.Log("Option2");
        panel.SetActive(false);
        ca.enabled = true;
        ic.enabled = true;
    }

    public void GetOption3()
    {
        if (qsPlat.OptionsBool3)
        {
            ic.energyBar += 25;
        }
        else
        {
            Debug.Log("Decrease");
            ic.energyBar -= 10;
        }
        Debug.Log("Option3");
        panel.SetActive(false);
        ca.enabled = true;
        ic.enabled = true;
    }

    public void GetOption4()
    {
        if (qsPlat.OptionsBool4)
        {
            ic.energyBar += 25;
        }
        else
        {
            Debug.Log("Decrease");
            ic.energyBar -= 10;
        }
        Debug.Log("Option4");
        panel.SetActive(false);
        ca.enabled = true;
        ic.enabled = true;
    }
}