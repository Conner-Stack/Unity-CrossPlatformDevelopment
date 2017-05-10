using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBackpack : MonoBehaviour {
    [SerializeField]
    public List<MyItem>inventory = new List<MyItem>();
    public ScriptableBackpack Backpack;
    public int slots;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(Backpack.slots);
        if(other.GetComponent<MyBackpack>())
        {
            other.GetComponent<MyBackpack>().AddItem(GetComponent<MyItem>());
        }
    }

    void AddItem(MyItem item)
    {
        if (inventory.Count < Backpack.slots)
            inventory.Add(item);
        else
            Debug.Log("not enough slots in inventory");    
    }


}
