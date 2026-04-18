using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Characters/Stats")]
public class Character : ScriptableObject
{
    [Header("Name & Stats")]
    public string characterName;
    public int health;
    public int attack;
    public int defence;
    public string ultimate;
    public int ultimateDamage;
    [Header("Story")] 
    public string story;
    public string description;
    
}
