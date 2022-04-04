using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCanvas : MonoBehaviour
{
    public GameObject playerObject;
    public CustomColor primColor;
    public CustomColor secoColor;

    public Image reticle;


    public void Update()
    {
        primColor = playerObject.GetComponent<Profile>().ReturnPrimaryCustomColor();

        reticle.color = new Color(primColor.color.r, primColor.color.g, primColor.color.b);
    }
}
