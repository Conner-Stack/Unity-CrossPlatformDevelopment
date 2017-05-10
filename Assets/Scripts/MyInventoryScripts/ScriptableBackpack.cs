using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
[CreateAssetMenu(fileName = "BackPackConfig", menuName ="Inventory/Backpack")]
public class ScriptableBackpack : ScriptableObject {
    public int slots;
}
