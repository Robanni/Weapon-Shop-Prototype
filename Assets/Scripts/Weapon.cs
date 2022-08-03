using UnityEngine;

public class Weapon : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = weaponData.Icon;
    }

    [SerializeField]
    private WeaponData weaponData; 

    [SerializeField]
    private GameEvent OnWeaponSelected; 
    private void OnMouseDown() 
    {
        OnWeaponSelected.Rise();
    }
}
