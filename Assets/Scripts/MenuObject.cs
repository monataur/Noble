using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MenuObject : MonoBehaviour
{
    public int playerCount;
    public PlayerSO[] players = new PlayerSO[4];
    public GameObject[] playerList = new GameObject[4];
    public Text[] playerNames = new Text[4];
    public Image[] playerBanners = new Image[4];
    public GameObject[] playerAvatarRender = new GameObject[4];

    public AudioSource confirm;
    public AudioSource start;

    public ButtonPrompts buttonPrompts;

    public Color ColorButTransparentForMenuKibyThums1;

    private void Update()
    {
        playerNames[0].text = players[0].name;

        ColorButTransparentForMenuKibyThums1 = new Color(players[0].primaryColor.color.r, players[0].primaryColor.color.g, players[0].primaryColor.color.b, 0.6f);
        playerBanners[0].color = ColorButTransparentForMenuKibyThums1;

        playerAvatarRender[0].GetComponent<Image>().sprite = players[0].icon;
    }

    public void DefaultFunction()
    {
        Debug.LogError("Menu error occurred.");
    }

    public void FunctionTest()
    {

    }

    public void CallMenuFunction(int id)
    {
        switch (id)
        {
            default:
                FunctionTest();
                break;

            case 0:
                FunctionTest();
                break;

        }
    }
}