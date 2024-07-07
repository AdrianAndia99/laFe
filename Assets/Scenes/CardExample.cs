using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cards", menuName = "New card")]
public class CardExample : ScriptableObject
{
    public string neim;
    public string description;

    public Sprite sprite;

    public int mana;
    public int atack;
    public int health;
}
