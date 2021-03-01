using UnityEngine;

public class DelegatorAdd : MonoBehaviour
{
    QuickInventoryObject inventoryObject;
    public QuickInventoryObject InventoryObject { set => inventoryObject = value; }

    public void Add()
    {
        if (inventoryObject.ItemInHand != null)
        {
            GameObject lastHolder = GetComponent<CircleManager>().
                                    HolderList[GetComponent<CircleManager>().HolderList.Count - 1];
            inventoryObject.InventoryList.Add(inventoryObject.ItemInHand);
            inventoryObject.ItemInHand.GetComponent<ItemInventoryMode>().ActivateInventoryMode(lastHolder);
        }
        GetComponent<CircleRotator>().ResetRotator();
    }
}
