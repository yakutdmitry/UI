using System;
using TMPro;
using UnityEngine;
using UnityEngine.LowLevelPhysics2D;

public class UIController : MonoBehaviour
{
    public DataLoader selectedCharacter;
    public TextMeshProUGUI shortDescriptionUI;
    public TextMeshProUGUI characterNameUI;

    [Header("Stats")]
    public TextMeshProUGUI attackUI;
    public TextMeshProUGUI defenseUI;
    public TextMeshProUGUI healthUI;
    public TextMeshProUGUI ultimateUI;
    [Header("Stats Descriptions")]
    public TextMeshProUGUI attackDesctiptionUI;
    public TextMeshProUGUI defenseDesctiptionUI;
    public TextMeshProUGUI speedDesctiptionUI;
    public TextMeshProUGUI ultimateDesctiptionUI;

    public GameObject[] menusToHide;



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
        attackUI.text = selectedCharacter.data.attack.ToString();
        defenseUI.text = selectedCharacter.data.defence.ToString();
        healthUI.text = selectedCharacter.data.health.ToString();
        ultimateUI.text = selectedCharacter.data.ultimate.ToString();

        attackDesctiptionUI.text = selectedCharacter.data.attackDescription;
        defenseDesctiptionUI.text = selectedCharacter.data.defenseDescription;
        speedDesctiptionUI.text = selectedCharacter.data.speedDescription;
        ultimateDesctiptionUI.text = selectedCharacter.data.ultimateDescription;

        characterNameUI.text = selectedCharacter.data.characterName;
        shortDescriptionUI.text = selectedCharacter.data.shortDescription;
    }

    public void Hide()
    {
        foreach (var obj in menusToHide)
        {
            obj.SetActive(false);
        }
    }
}
