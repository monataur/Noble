using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuInput : MonoBehaviour
{
    public GameObject jsonReadWrite;
    public Enums.SelectedMenu selectedMenu;
    public Enums.SelectedEdge selectedEdge;

    public AudioSource confirm;
    public AudioSource start;

    public GameObject startMenuInput;

    public GameObject initMenu;
    public GameObject profileMenu;

    public GameObject menuInput;
    public GameObject playerProfileObject;

    public int verticalSelect = 0;

    public int selectedProfile = 0;

    public bool isStarting = true;

    public GameObject[] lightBars = new GameObject[8];
    public GameObject[] edgeIcons = new GameObject[5];
    public GameObject[] edgeMenus = new GameObject[5];

    public void EdgeMenuSwitch(bool isLeft)
    {
        switch (isLeft)
        {
            case true:
                switch (selectedEdge)
                {
                    case Enums.SelectedEdge.Social:
                        break;

                    case Enums.SelectedEdge.Matchmaking:
                        selectedEdge = Enums.SelectedEdge.Social;
                        break;

                    case Enums.SelectedEdge.Quickmenu:
                        selectedEdge = Enums.SelectedEdge.Matchmaking;
                        break;

                    case Enums.SelectedEdge.Creative:
                        selectedEdge = Enums.SelectedEdge.Quickmenu;
                        break;

                    case Enums.SelectedEdge.Settings:
                        selectedEdge = Enums.SelectedEdge.Creative;
                        break;
                }
                break;

            case false:
                switch (selectedEdge)
                {
                    case Enums.SelectedEdge.Social:
                        selectedEdge = Enums.SelectedEdge.Matchmaking;
                        break;

                    case Enums.SelectedEdge.Matchmaking:
                        selectedEdge = Enums.SelectedEdge.Quickmenu;
                        break;

                    case Enums.SelectedEdge.Quickmenu:
                        selectedEdge = Enums.SelectedEdge.Creative;
                        break;

                    case Enums.SelectedEdge.Creative:
                        selectedEdge = Enums.SelectedEdge.Settings;
                        break;

                    case Enums.SelectedEdge.Settings:
                        break;
                }
                break;
        }
    }

    public void Update()
    {
        switch (isStarting)
        {
            case true:
                startMenuInput.GetComponent<PlayerInput>().enabled = true;
                menuInput.GetComponent<PlayerInput>().enabled = false;
                break;

            case false:
                startMenuInput.GetComponent<PlayerInput>().enabled = false;
                menuInput.GetComponent<PlayerInput>().enabled = true;
                break;
        }

        switch (selectedEdge)
        {
            case Enums.SelectedEdge.Social:
                //LightBar enabling/disabling
                lightBars[0].SetActive(true);
                lightBars[1].SetActive(false);
                lightBars[2].SetActive(true);
                lightBars[3].SetActive(true);
                lightBars[4].SetActive(true);
                lightBars[5].SetActive(false);
                lightBars[6].SetActive(true);
                lightBars[7].SetActive(false);
                lightBars[8].SetActive(true);
                lightBars[9].SetActive(false);
                //edge icon repositioning
                edgeIcons[0].transform.position = new Vector2(825, 360);
                edgeIcons[1].transform.position = new Vector2(725, 360);
                edgeIcons[2].transform.position = new Vector2(-825, 360);
                edgeIcons[3].transform.position = new Vector2(525, 360);
                edgeIcons[4].transform.position = new Vector2(625, 360);
                break;

            case Enums.SelectedEdge.Matchmaking:
                //LightBar enabling/disabling
                lightBars[0].SetActive(true);
                lightBars[1].SetActive(true);
                lightBars[2].SetActive(true);
                lightBars[3].SetActive(true);
                lightBars[4].SetActive(true);
                lightBars[5].SetActive(false);
                lightBars[6].SetActive(true);
                lightBars[7].SetActive(false);
                lightBars[8].SetActive(false);
                lightBars[9].SetActive(false);
                //edge icon repositioning
                edgeIcons[0].transform.position = new Vector2(825, 360);
                edgeIcons[1].transform.position = new Vector2(725, 360);
                edgeIcons[2].transform.position = new Vector2(-825, 360);
                edgeIcons[3].transform.position = new Vector2(-725, 360);
                edgeIcons[4].transform.position = new Vector2(625, 360);
                break;

            case Enums.SelectedEdge.Quickmenu:
                //LightBar enabling/disabling
                lightBars[0].SetActive(true);
                lightBars[1].SetActive(true);
                lightBars[2].SetActive(true);
                lightBars[3].SetActive(true);
                lightBars[4].SetActive(true);
                lightBars[5].SetActive(true);
                lightBars[6].SetActive(false);
                lightBars[7].SetActive(false);
                lightBars[8].SetActive(false);
                lightBars[9].SetActive(false);
                //edge icon repositioning
                edgeIcons[0].transform.position = new Vector2(825, 360);
                edgeIcons[1].transform.position = new Vector2(725, 360);
                edgeIcons[2].transform.position = new Vector2(-825, 360);
                edgeIcons[3].transform.position = new Vector2(-725, 360);
                edgeIcons[4].transform.position = new Vector2(0, 360);
                break;

            case Enums.SelectedEdge.Creative:
                //LightBar enabling/disabling
                lightBars[0].SetActive(false);
                lightBars[1].SetActive(true);
                lightBars[2].SetActive(true);
                lightBars[3].SetActive(true);
                lightBars[4].SetActive(true);
                lightBars[5].SetActive(true);
                lightBars[6].SetActive(false);
                lightBars[7].SetActive(true);
                lightBars[8].SetActive(false);
                lightBars[9].SetActive(false);
                //edge icon repositioning
                edgeIcons[0].transform.position = new Vector2(825, 360);
                edgeIcons[1].transform.position = new Vector2(725, 360);
                edgeIcons[2].transform.position = new Vector2(-825, 360);
                edgeIcons[3].transform.position = new Vector2(-725, 360);
                edgeIcons[4].transform.position = new Vector2(625, 360);
                break;

            case Enums.SelectedEdge.Settings:
                //LightBar enabling/disabling
                lightBars[0].SetActive(false);
                lightBars[1].SetActive(true);
                lightBars[2].SetActive(true);
                lightBars[3].SetActive(true);
                lightBars[4].SetActive(true);
                lightBars[5].SetActive(true);
                lightBars[6].SetActive(false);
                lightBars[7].SetActive(true);
                lightBars[8].SetActive(false);
                lightBars[9].SetActive(false);
                //edge icon repositioning
                edgeIcons[0].transform.position = new Vector2(825, 360);
                edgeIcons[1].transform.position = new Vector2(725, 360);
                edgeIcons[2].transform.position = new Vector2(-825, 360);
                edgeIcons[3].transform.position = new Vector2(-725, 360);
                edgeIcons[4].transform.position = new Vector2(625, 360);
                break;
        }
    }

    private void LateUpdate()
    {
        
    }

    public void MenuSelectReset()
    {

    }

    public void RightBumper()
    {

    }

    public void StartButton()
    {
        start.Play();
        switch (selectedMenu)
        {
            case Enums.SelectedMenu.Initial:
                jsonReadWrite.GetComponent<JsonReadWrite>().initial = true;
                jsonReadWrite.GetComponent<JsonReadWrite>().SaveToJSONGeneral();
                initMenu.SetActive(false);
                profileMenu.SetActive(true);
                Debug.Log("Passed init");
                selectedMenu = Enums.SelectedMenu.Profile;
                break;

            case Enums.SelectedMenu.Profile:
                jsonReadWrite.GetComponent<JsonReadWrite>().SaveToJSONProfile(selectedProfile);
                Debug.Log("Saved profile.");
                break;
        }
    }
}
