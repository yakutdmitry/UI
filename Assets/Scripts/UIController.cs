using System;
using TMPro;
using UnityEngine;
using UnityEngine.LowLevelPhysics2D;

public class UIController : MonoBehaviour
{
    [Header("Main")]
    public DataLoader selectedCharacter;
    public TextMeshProUGUI shortDescriptionUI;
    public TextMeshProUGUI characterNameUI;
    public TextMeshProUGUI selectedGameMode;
    public GameObject[] menusToHide;
    public GameObject[] characters;
    public int currentIndex;
    public int modeIndex;
    
    
    [Header("Stats")] public TextMeshProUGUI attackUI;
    public TextMeshProUGUI defenseUI;
    public TextMeshProUGUI healthUI;
    public TextMeshProUGUI ultimateUI;
    public TextMeshProUGUI speedUI;
    [Header("Stats Descriptions")] public TextMeshProUGUI attackDesctiptionUI;
    public TextMeshProUGUI defenseDesctiptionUI;
    public TextMeshProUGUI speedDesctiptionUI;
    public TextMeshProUGUI ultimateDesctiptionUI;
    [Header("Story")] public TextMeshProUGUI storyUI;

    [Header("Lvls")] public TextMeshProUGUI attackLVLUI;
    public TextMeshProUGUI defenseLVLUI;
    public TextMeshProUGUI ultimateLVLUI;
    public TextMeshProUGUI speedLVLUI;



    private void OnEnable()
    {
        selectedCharacter = GameObject.FindWithTag("Character").GetComponent<DataLoader>();
        Debug.Log("attackUI: " + attackUI);
        Debug.Log("attackUI.text: " + (attackUI == null ? "NULL" : "OK"));
        Debug.Log(selectedCharacter.data);
        Debug.Log("DATA TYPE: " + selectedCharacter.data.GetType());
        Debug.Log("SO attack: " + selectedCharacter.data.attack);
        ResetLvls();
    }

    public void Show()
    {
        selectedCharacter = GameObject.FindWithTag("Character").GetComponent<DataLoader>();
        attackUI.text = "Attack: " + selectedCharacter.data.attack.ToString();
        defenseUI.text = "Defense: " + selectedCharacter.data.defence.ToString();
        healthUI.text = "Health: " + selectedCharacter.data.health.ToString();
        ultimateUI.text = "Ultimate: " + selectedCharacter.data.ultimate.ToString();
        speedUI.text = "Speed: " + selectedCharacter.data.speed;
        //Descriptions
        attackDesctiptionUI.text = selectedCharacter.data.attackDescription;
        defenseDesctiptionUI.text = selectedCharacter.data.defenseDescription;
        speedDesctiptionUI.text = selectedCharacter.data.speedDescription;
        ultimateDesctiptionUI.text = selectedCharacter.data.ultimateDescription;

        characterNameUI.text = selectedCharacter.data.characterName;
        shortDescriptionUI.text = selectedCharacter.data.shortDescription;
        //Story
        storyUI.text = selectedCharacter.data.story;

        //Lvls
        attackLVLUI.text = "Attack Level: " + selectedCharacter.data.attackLVL;
        defenseLVLUI.text = "Defense Level: " + selectedCharacter.data.defenseLVL;
        ultimateLVLUI.text = "Ultimate Level: " + selectedCharacter.data.ultimateLVL;
        speedLVLUI.text = "Speed Level: " + selectedCharacter.data.speedLVL;

    }

    public void Hide()
    {
        foreach (var obj in menusToHide)
        {
            obj.SetActive(false);
        }
    }

    public void Upgrade(UpgradeType type)
    {
        UpgradeType upgradeType = (UpgradeType)type;

        switch (upgradeType)
        {
            case UpgradeType.health:
                selectedCharacter.data.healthLvl += 1;
                break;

            case UpgradeType.attack:
                selectedCharacter.data.attackLVL += 1;
                break;

            case UpgradeType.speed:
                selectedCharacter.data.speedLVL += 1;
                break;

            case UpgradeType.defense:
                selectedCharacter.data.defenseLVL += 1;
                break;

            case UpgradeType.ultimate:
                selectedCharacter.data.ultimateLVL += 1;
                break;
        }

        Show();
    }

    public void UpgradeInt(int type)
    {
        Upgrade((UpgradeType)type);
    }

    public enum UpgradeType
    {
        health,
        attack,
        speed,
        defense,
        ultimate
    }

    public void ResetLvls()
    {
        selectedCharacter.data.attackLVL = 0;
        selectedCharacter.data.healthLvl = 0;
        selectedCharacter.data.defenseLVL = 0;
        selectedCharacter.data.ultimateLVL = 0;
        selectedCharacter.data.speedLVL = 0;

        Show();

    }
    
    public void SwitchCharacter(int direction)
    {
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
        
        currentIndex += direction;
        
        if (currentIndex >= characters.Length)
        {
            currentIndex = 0;
        }
        else if (currentIndex < 0)
        {
            currentIndex = characters.Length - 1;
        }
        
        characters[currentIndex].SetActive(true);
        selectedCharacter = characters[currentIndex].GetComponent<DataLoader>();
        Show();
    }

    public void SwitchGameMode(int direction)
    {

        modeIndex += direction;

        if (modeIndex > 1)
            modeIndex = 0;
        else if (modeIndex < 0)
            modeIndex = 1;

        switch (modeIndex)
        {
            case 0:
                selectedGameMode.text = "Arenas";
                break;

            case 1:
                selectedGameMode.text = "Duel";
                break;

                Show();
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
