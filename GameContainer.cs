using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class GameContainer<T>
{
    T item;
    public void SetItem(T items)
    {
        item = items;
    }
    public T GetItem()
    {
        return item;
    }
}
