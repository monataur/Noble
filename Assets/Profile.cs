using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profile : MonoBehaviour
{
    public new string name;
    public string bio;
    public new string tag;
    public Enums.Color primaryColor;
    public Enums.Color secondaryColor;

    public GameObject playerObject;
    public GameObject playerModel;

    public CustomColor[] colorArray = new CustomColor[17];

    public CustomColor ReturnPrimaryCustomColor()
    {
        switch (primaryColor)
        {
            default:
                return colorArray[0];

            case Enums.Color.Light:
                return colorArray[0];

            case Enums.Color.LightGray:
                return colorArray[1];

            case Enums.Color.Gray:
                return colorArray[2];

            case Enums.Color.Dark:
                return colorArray[3];

            case Enums.Color.Brick:
                return colorArray[4];

            case Enums.Color.Vermillion:
                return colorArray[5];

            case Enums.Color.Gold:
                return colorArray[6];

            case Enums.Color.Electric:
                return colorArray[7];

            case Enums.Color.Peridot:
                return colorArray[8];

            case Enums.Color.Lime:
                return colorArray[9];

            case Enums.Color.Clover:
                return colorArray[10];

            case Enums.Color.Jade:
                return colorArray[11];

            case Enums.Color.Mint:
                return colorArray[12];

            case Enums.Color.Blue:
                return colorArray[13];

            case Enums.Color.Indigo:
                return colorArray[14];

            case Enums.Color.Violet:
                return colorArray[15];

            case Enums.Color.Purple:
                return colorArray[16];
        }
    }

    public Material ReturnPrimaryColorMaterial()
    {
        switch (primaryColor)
        {
            default:
                return colorArray[0].mat;

            case Enums.Color.Light:
                return colorArray[0].mat;

            case Enums.Color.LightGray:
                return colorArray[1].mat;

            case Enums.Color.Gray:
                return colorArray[2].mat;

            case Enums.Color.Dark:
                return colorArray[3].mat;

            case Enums.Color.Brick:
                return colorArray[4].mat;

            case Enums.Color.Vermillion:
                return colorArray[5].mat;

            case Enums.Color.Gold:
                return colorArray[6].mat;

            case Enums.Color.Electric:
                return colorArray[7].mat;

            case Enums.Color.Peridot:
                return colorArray[8].mat;

            case Enums.Color.Lime:
                return colorArray[9].mat;

            case Enums.Color.Clover:
                return colorArray[10].mat;

            case Enums.Color.Jade:
                return colorArray[11].mat;

            case Enums.Color.Mint:
                return colorArray[12].mat;

            case Enums.Color.Blue:
                return colorArray[13].mat;

            case Enums.Color.Indigo:
                return colorArray[14].mat;

            case Enums.Color.Violet:
                return colorArray[15].mat;

            case Enums.Color.Purple:
                return colorArray[16].mat;
        }
    }

    private void Update()
    {
        playerModel.GetComponent<Renderer>().material = ReturnPrimaryColorMaterial();
    }
}
