using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory potions = new Inventory();
        Inventory elixirs = new Inventory();
        Inventory combinedinventory = new Inventory();

        potions.AddItem("Healing Potion");
        potions.AddItem("Strength Potion");
        elixirs.AddItem("Elixir");
        elixirs.AddItem("Dark Elixir");

        combinedinventory = potions + elixirs;
        combinedinventory.ShowItem();

    }


}
