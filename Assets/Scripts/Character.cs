using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Characters/Stats")]
public class Character : ScriptableObject
{
    [Header("Name & Stats")]
    public string characterName;
    public int health;
    public int attack;
    public int defence;
    public int ultimate;
    public int speed;
    
    [Header("Stats desctiption")]
    public string attackDescription;
    public string defenseDescription;
    public string speedDescription;
    public string ultimateDescription;   
    
    [Header("Story")] 
    [TextArea(3, 6)]
    public string story;
    [TextArea(3, 6)]
    public string shortDescription;
    
    [Header("Upgrade lvls")]
    public int attackLVL;
    public int defenseLVL;
    public int ultimateLVL;
    public int speedLVL;
    public int healthLvl;
}
