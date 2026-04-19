using System;
using TMPro;
using UnityEngine;
using UnityEngine.LowLevelPhysics2D;

public class UIController : MonoBehaviour
{
    public DataLoader selectedCharacter;
    public TextMeshProUGUI shortDescriptionUI;
    public TextMeshProUGUI characterNameUI;
    public GameObject[] menusToHide;
    
    [Header("Stats")]
    public TextMeshProUGUI attackUI;
    public TextMeshProUGUI defenseUI;
    public TextMeshProUGUI healthUI;
    public TextMeshProUGUI ultimateUI;
    public TextMeshProUGUI speedUI;
    [Header("Stats Descriptions")]
    public TextMeshProUGUI attackDesctiptionUI;
    public TextMeshProUGUI defenseDesctiptionUI;
    public TextMeshProUGUI speedDesctiptionUI;
    public TextMeshProUGUI ultimateDesctiptionUI;
    [Header("Story")]
    public TextMeshProUGUI storyUI;
    



    private void OnEnable()
    {
        selectedCharacter = GameObject.FindWithTag("Character").GetComponent<DataLoader>();
        Debug.Log("attackUI: " + attackUI);
        Debug.Log("attackUI.text: " + (attackUI == null ? "NULL" : "OK"));
        Debug.Log(selectedCharacter.data);
        Debug.Log("DATA TYPE: " + selectedCharacter.data.GetType());
        Debug.Log("SO attack: " + selectedCharacter.data.attack);
        Show();
    }

    public void Show()
    {
        attackUI.text = "Attack: " + selectedCharacter.data.attack.ToString();
        defenseUI.text = "Defense: " + selectedCharacter.data.defence.ToString();
        healthUI.text = "Health: " + selectedCharacter.data.health.ToString();
        ultimateUI.text = "Ultimate: " + selectedCharacter.data.ultimate.ToString();
        speedUI.text = "Speed: " + selectedCharacter.data.speed;
        
        attackDesctiptionUI.text = selectedCharacter.data.attackDescription;
        defenseDesctiptionUI.text = selectedCharacter.data.defenseDescription;
        speedDesctiptionUI.text = selectedCharacter.data.speedDescription;
        ultimateDesctiptionUI.text = selectedCharacter.data.ultimateDescription;

        characterNameUI.text = selectedCharacter.data.characterName;
        shortDescriptionUI.text = selectedCharacter.data.shortDescription;

        storyUI.text = selectedCharacter.data.story;

    }

    public void Hide()
    {
        foreach (var obj in menusToHide)
        {
            obj.SetActive(false);
        }
    }
}
