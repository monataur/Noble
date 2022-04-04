using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class OpeningAnimation : MonoBehaviour
{
    static Vector2 nobleStartPos = new Vector2(950, 570f);
    static Vector2 nobleEndPos = new Vector2(950, 640f);
    public Transform noble;
    public Image blackout;
    public GameObject blackoutObj;

    public GameObject menuObject;
    public GameObject musicObject;
    public GameObject nobleObject;
    public GameObject pressObject;
    public GameObject initialObject;
    public GameObject jsonObject;
    public GameObject menuInputObject;

    

    public bool isSlowOpening = true;

    public float ticky = 0f;

    public Color fadeOutColor;

    public Vector2 velocity = Vector2.zero;
    public float sdampSpeed = 1f;

    public ButtonPrompts pc;
    public ButtonPrompts xbox;
    public ButtonPrompts playstation;

    public bool isClosed = false;

    public InputActionAsset action;

    public object[] test = new object[999];

    private void Start()
    {
        gameObject.SetActive(true);
    }

    private void OnEnable()
    {
        nobleObject.SetActive(true);
        pressObject.SetActive(true);
        StartAnimation();
        Debug.Log("Animation started.");
    }

    public void StartAnimation()
    {
        blackoutObj.SetActive(true);
        noble.position = nobleStartPos;
        StartCoroutine(FadeOut());
    }

    public void InputPC()
    {
        if (isClosed == false)
        {
            menuObject.GetComponent<MenuObject>().buttonPrompts = pc;
            CloseStartMenu();
        }
    }

    public void InputXbox()
    {
        if (isClosed == false)
        {
            menuObject.GetComponent<MenuObject>().buttonPrompts = xbox;
            CloseStartMenu();
        }
    }

    public void InputPlaystation()
    {
        if(isClosed == false)
        {
            menuObject.GetComponent<MenuObject>().buttonPrompts = playstation;
            CloseStartMenu();
        }
    }

    public void CloseStartMenu()
    {
        if(isClosed == false)
        {
            nobleObject.SetActive(false);
            pressObject.SetActive(false);
            SkipAnimation();
            menuObject.GetComponent<MenuObject>().confirm.Play();
            isClosed = true;
            menuInputObject.GetComponent<MenuInput>().isStarting = false;
            switch (jsonObject.GetComponent<JsonReadWrite>().initial)
            {
                case true:
                    menuInputObject.GetComponent<MenuInput>().selectedMenu = Enums.SelectedMenu.Main;
                    break;

                case false:
                    initialObject.SetActive(true);
                    menuInputObject.GetComponent<MenuInput>().selectedMenu = Enums.SelectedMenu.Initial;
                    break;
            }
        }
    }

    private void LateUpdate()
    {
        switch (isSlowOpening)
        {
            case true:
                if (ticky >= 1f)
                {
                    noble.position = Vector2.SmoothDamp(noble.position, nobleEndPos, ref velocity, sdampSpeed);
                }
                break;

            case false:
                noble.position = nobleEndPos;
                break;
        }
    }

    public void SkipAnimation()
    {
        isSlowOpening = false;
    }

    public IEnumerator FadeOut()
    {
        switch (isSlowOpening)
        {
            case true:
                yield return new WaitForSeconds(0.0375f);
                blackout.color = Color.Lerp(Color.black, fadeOutColor, ticky);
                ticky += 0.01f;
                StartCoroutine(FadeOut());
                break;

            case false:
                yield return new WaitForSeconds(0f);
                blackout.color = fadeOutColor;
                break;
        }
    }
}
