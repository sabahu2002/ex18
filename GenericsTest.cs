using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> something = new GameContainer<string>();
        something.SetItem("Healing Potion");
        GameUtils.DescribeItem("Stored item: " + something.GetItem());
        GameUtils.DescribeItem("This item is " + something.GetItem());


    }


}
