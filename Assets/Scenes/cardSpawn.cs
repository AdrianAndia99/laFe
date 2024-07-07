using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class cardSpawn : MonoBehaviour
{
    public CardExample card;

    public TextMeshProUGUI neim;
    public TextMeshProUGUI description;
    public TextMeshProUGUI manaT;
    public TextMeshProUGUI atackT;
    public TextMeshProUGUI lifeT;
    public Image imagen;
    void Start()
    {
        neim.text = card.neim;
        description.text = card.description;
        imagen.sprite = card.sprite;
        manaT.text = card.mana.ToString();
        atackT.text = card.atack.ToString();
        lifeT.text = card.health.ToString();
    }

}
