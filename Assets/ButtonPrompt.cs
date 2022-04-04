using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPrompt : MonoBehaviour
{
    public Enums.PromptType promptType;
    public GameObject menuObject;
    public Image selfRenderer;

    private void Update()
    {
        switch (promptType)
        {
            case Enums.PromptType.ButtonN:
                selfRenderer.sprite = menuObject.GetComponent<MenuObject>().buttonPrompts.buttonN;
                break;

            case Enums.PromptType.ButtonE:
                selfRenderer.sprite = menuObject.GetComponent<MenuObject>().buttonPrompts.buttonE;
                break;

            case Enums.PromptType.ButtonS:
                selfRenderer.sprite = menuObject.GetComponent<MenuObject>().buttonPrompts.buttonS;
                break;

            case Enums.PromptType.ButtonW:
                selfRenderer.sprite = menuObject.GetComponent<MenuObject>().buttonPrompts.buttonW;
                break;

            case Enums.PromptType.LookInput:
                selfRenderer.sprite = menuObject.GetComponent<MenuObject>().buttonPrompts.lookInput;
                break;

            case Enums.PromptType.Start:
                selfRenderer.sprite = menuObject.GetComponent<MenuObject>().buttonPrompts.start;
                break;

            case Enums.PromptType.Select:
                selfRenderer.sprite = menuObject.GetComponent<MenuObject>().buttonPrompts.select;
                break;

            case Enums.PromptType.LeftBumper:
                selfRenderer.sprite = menuObject.GetComponent<MenuObject>().buttonPrompts.leftBumper;
                break;

            case Enums.PromptType.RightBumper:
                selfRenderer.sprite = menuObject.GetComponent<MenuObject>().buttonPrompts.rightBumper;
                break;
        }
    }
}
