using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new WeaponData", menuName = "WeaponData", order = 51)]
public class WeaponData : ScriptableObject
{
    [SerializeField]
    private string weaponName;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int goldCost;
    [SerializeField]
    private int attackDamage;

    public string WeaponName { get { return weaponName; }}
    public Sprite Icon { get { return icon; }}
    public int GoldCost { get { return goldCost; }}
    public int AttackDamage { get { return attackDamage; }}
}
