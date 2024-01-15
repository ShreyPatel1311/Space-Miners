using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Questions : MonoBehaviour
{
    public int platformID;

    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject Quest;
    [SerializeField] private GameObject Option1;
    [SerializeField] private GameObject Option2;
    [SerializeField] private GameObject Option3;
    [SerializeField] private GameObject Option4;
    [SerializeField] private GameObject Player;
    [SerializeField] private string questions;
    [SerializeField] private string options1;
    [SerializeField] private string options2;
    [SerializeField] private string options3;
    [SerializeField] private string options4;
    [SerializeField] private bool optionsBool1;
    [SerializeField] private bool optionsBool2;
    [SerializeField] private bool optionsBool3;
    [SerializeField] private bool optionsBool4;

    public bool OptionsBool1 
    {
        get
        {
            return optionsBool1;
        }
    }

    public bool OptionsBool2
    {
        get
        {
            return optionsBool2;
        }
    }

    public bool OptionsBool3 
    {
        get
        {
            return optionsBool3;
        }
    }

    public bool OptionsBool4
    {
        get
        {
            return optionsBool4;
        }
    }

    private TMP_Text quest;
    private Text option1;
    private Text option2;
    private Text option3;
    private Text option4;
    private int count = 0;
    private ControllerAction ca;
    private ItemCollector ic;

    // Start is called before the first frame update
    void Start()
    {
        ca = Player.GetComponent<ControllerAction>();
        ic = Player.GetComponent<ItemCollector>();
        quest = Quest.GetComponent<TMP_Text>();
        option1 = Option1.GetComponent<Text>();
        option2 = Option2.GetComponent<Text>();
        option3 = Option3.GetComponent<Text>();
        option4 = Option4.GetComponent<Text>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && count == 0)
        {
            GenerateUIQuestions();
        }
    }

    private void GenerateUIQuestions() 
    {
        count++;
        panel.SetActive(true);
        ca.enabled = false;
        ic.enabled = false;
        quest.text = questions;
        option1.text = options1;
        option2.text = options2;
        option3.text = options3;
        option4.text = options4;
    }
}
