using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card",menuName ="Card/New Card")]
public class Card : ScriptableObject
{
    public new string name;

    public string description;


    public Sprite heroimage;


    public int mana;

    public int attack;

    public int health;

}
