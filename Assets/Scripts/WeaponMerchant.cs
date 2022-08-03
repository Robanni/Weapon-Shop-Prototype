using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class WeaponMerchant : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI weaponName;
    [SerializeField]
    private Image icon;
    [SerializeField]
    private TextMeshProUGUI goldCost;
    [SerializeField]
    private TextMeshProUGUI attackDamage;

    public void UpdateDisplayUI(WeaponData weaponData)
    {
        weaponName.text = weaponData.WeaponName;
        icon.sprite = weaponData.Icon;
        goldCost.text = "Cost: " + weaponData.GoldCost.ToString();
        attackDamage.text = "Damage: " + weaponData.AttackDamage.ToString();
    }
}
