using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Inventory
{
    List<string> l1 = new List<string>();

    public void AddItem(string item)
    {
        l1.Add(item);
    }
    public void ShowItem()
    {
        for (int i = 0; i < l1.Count; i++)
        {
            Debug.Log(l1[i]);
        }
    }
    public static Inventory operator +(Inventory inv1, Inventory inv2)
    {
        Inventory combinedInventory = new Inventory();
        combinedInventory.l1.AddRange(inv1.l1);
        combinedInventory.l1.AddRange(inv2.l1);

        return combinedInventory;
    }
}
