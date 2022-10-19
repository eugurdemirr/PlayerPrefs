using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardManager : MonoBehaviour
{
    public Card card;

    public TMP_Text cardName;
    public TMP_Text cardDescription;
    public TMP_Text cardMana;
    public TMP_Text cardHealth;
    public TMP_Text cardAttack;

    public Image cardHeroimage;
    void Start()
    {
        cardName.text = card.name;
        cardDescription.text = card.description;
        cardHeroimage.sprite = card.heroimage;
        cardMana.text = card.mana.ToString();
        cardAttack.text = card.attack.ToString();
        cardHealth.text = card.health.ToString();
    }

    
}
