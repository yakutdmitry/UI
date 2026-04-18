using System;
using TMPro;
using UnityEngine;
using UnityEngine.LowLevelPhysics2D;

public class UIController : MonoBehaviour
{
    public Character selectedCharacter;
    public TextMeshProUGUI shortDescription;
    public TextMeshProUGUI characterName;

    [Header("Stats")]
    public TextMeshProUGUI attack;
    public TextMeshProUGUI defense;
    public TextMeshProUGUI health;
    public TextMeshProUGUI ultimate;
    [Header("Stats Descriptions")]
    public TextMeshProUGUI attackDesctiption;
    public TextMeshProUGUI defenseDesctiption;
    public TextMeshProUGUI speedDesctiption;
    public TextMeshProUGUI ultimateDesctiption;

    public GameObject[] menusToHide;

    private void Start()
    {
        selectedCharacter = GameObject.FindWithTag("Player").GetComponent<Character>();
        Show();
    }

    public void Show()
    {
        attack.text = selectedCharacter.attack.ToString();
        defense.text = selectedCharacter.defence.ToString();
        health.text = selectedCharacter.health.ToString();
        ultimate.text = selectedCharacter.ultimate.ToString();

        attackDesctiption.text = selectedCharacter.attackDescription;
        defenseDesctiption.text = selectedCharacter.defenseDescription;
        speedDesctiption.text = selectedCharacter.speedDescription;
        ultimateDesctiption.text = selectedCharacter.ultimateDescription;

        characterName.text = selectedCharacter.characterName;
        shortDescription.text = selectedCharacter.shortDescription;
    }

    public void Hide()
    {
        foreach (var obj in menusToHide)
        {
            obj.SetActive(false);
        }
    }
}
