using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonReadWrite : MonoBehaviour
{
    public GameObject menuObject;
    public bool initial;
    public GameObject playerProfileObject;
    public void SaveToJSONGeneral()
    {
        GeneralSave general = new GeneralSave();
        general.initialSetupCompleted = initial;

        string json = JsonUtility.ToJson(general, true);
        File.WriteAllText(Application.dataPath + "/GeneralSave.json", json);
        Debug.Log("Saved! (General)");
    }
    public void SaveToJSONProfile(int number)
    {
        ProfileSave profile = new ProfileSave();
        profile.name = playerProfileObject.GetComponent<Profile>().name;
        profile.tag = playerProfileObject.GetComponent<Profile>().tag;
        profile.bio = playerProfileObject.GetComponent<Profile>().bio;
        profile.primaryColor = playerProfileObject.GetComponent<Profile>().primaryColor;
        profile.secondaryColor = playerProfileObject.GetComponent<Profile>().secondaryColor;
        string json = JsonUtility.ToJson(profile, true);
        File.WriteAllText(Application.dataPath + $"/Profile_{number}.json", json);
        Debug.Log($"Saved! (Profile {number})!");
    }

    private void Start()
    {
        LoadFromJSONGeneral();
    }

    public void LoadFromJSONGeneral()
    {
        string json = File.ReadAllText(Application.dataPath + "/GeneralSave.json");
        GeneralSave general = JsonUtility.FromJson<GeneralSave>(json);

        initial = general.initialSetupCompleted;
    }

    public void LoadFromJSONProfile(int number)
    {

    }
}
