using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Gun : ScriptableObject
{
    public new string name;
    public Enums.WeaponType weaponType;
    public Enums.FireType fireType;
    public float damage;
    public float meleeDamage;
    public int maxAmmo;
    public float fireDelay;
    public float swapTime;
    public bool canBeThrown;
    public Sprite reticle;
    public Sprite display;
}
