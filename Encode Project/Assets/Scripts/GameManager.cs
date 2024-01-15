using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject EndGameText;
    [SerializeField] private GameObject GameObj;
    [SerializeField] private GameObject Pl;

    private TMP_Text endGameText;
    private FinishShipLine gameObj;
    private int count = 0;
    private PlayerLife pl;

    private void Start()
    {
        gameObj = GameObj.GetComponent<FinishShipLine>();
        pl = Pl.GetComponent<PlayerLife>();
        endGameText = EndGameText.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObj.isWon)
        {
            panel.SetActive(true);
            endGameText.text = "You Won!!";
        }
        if (pl.isDead && count == 0)
        {
            pl.Die();
            count++;
            panel.SetActive(true);
        }
    }
}
