using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New ButtonPrompts", menuName = "ButtonPrompts")]
public class ButtonPrompts : ScriptableObject
{
    public new string name;
    public bool isController;

    public Sprite buttonN;
    public Sprite buttonE;
    public Sprite buttonS;
    public Sprite buttonW;
    public Sprite lookInput;
    public Sprite start;
    public Sprite select;

    public Sprite rightBumper;
    public Sprite leftBumper;

    public Sprite fullController;

}
