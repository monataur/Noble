using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    Transform cam;

    [SerializeField] float range = 50f;
    [SerializeField] float damage = 10f;

    public void Shoot()
    {
       // switch (weapon.weaponType)
        {
       //     case Enums.WeaponType.Hitscan:
      //          break;
//
      //      case Enums.WeaponType.Projectile:
      //          break;
//
     //       case Enums.WeaponType.Melee:
    //            break;
        }
        RaycastHit hit;
        if(Physics.Raycast(cam.position, cam.forward, out hit, range))
        {
            print(hit.collider.name);
        }
    }
}
