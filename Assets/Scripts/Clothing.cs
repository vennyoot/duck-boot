﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clothing", menuName = "Clothing")]
public class Clothing : ScriptableObject
{
    // Objects have a name by default, so now we're telling it to go by this 'new' name instead
    public new string name;

    // How COOL something is
    public int coolness;
    // How CUTE something is
    public int cuteness;

    // How STRONG something is
    public int strength;
    // How FAST something can attack
    public int speed;

    // What something looks like
    public Sprite artwork;

    public void Print()
    {
        Debug.Log(name + " - " + "This item is this cool: " + coolness + " this cute:" + cuteness + " this strong:" + strength + " this fast:" + speed);
    }
}
