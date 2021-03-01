using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ItemManager : MonoBehaviour
{
    [SerializeField] QuickInventoryObject inventoryObject;
    GameObject selectedItem;
    private void Awake()
    {
        inventoryObject.ItemInHand = null;
        inventoryObject.ChosenObjectNumber = 0;
        inventoryObject.InventoryList.Clear();
    }
    public void FillHand(GameObject newSelected)
    {
        selectedItem = newSelected;
        inventoryObject.ItemInHand = selectedItem; 
    }
    public void EmptyHand()
    {
        inventoryObject.ItemInHand = null;
    }

    public GameObject GetItemInHand()
    {
        return selectedItem;
    }
}
