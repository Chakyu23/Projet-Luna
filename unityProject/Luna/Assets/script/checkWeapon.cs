using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkWeapon : MonoBehaviour
{
    private int weaponId;

    public List<GameObject> weaponList = new List<GameObject>();

    void Update()
    {
        if (transform.childCount > 0)
        {
            weaponId = gameObject.GetComponentInChildren<ItemOnObject>().item.itemID;
        }
        else
        {
            weaponId = 0;
            for (int i = 0; i < weaponList.Count; i++)
            {
                weaponList[i].SetActive(false);
            }
        }

        if (weaponId == 1 && transform.childCount > 0)
        {
            for (int i = 0; i < weaponList.Count; i++)
            {
                if (i == 0)
                {
                    weaponList[i].SetActive(true);
                }
            }
        }
    }
}
