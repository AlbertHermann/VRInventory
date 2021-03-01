using UnityEngine;

public class DelegatorTake : MonoBehaviour
{
    QuickInventoryObject inventoryObject;
    public QuickInventoryObject InventoryObject { set => inventoryObject = value; }

    public void Take()
    {
        if (inventoryObject.InventoryList.Count > 0)
        {
            GameObject chosenObject = inventoryObject.InventoryList[inventoryObject.ChosenObjectNumber];
            gameObject.GetComponent<DelegatorMakeChosen>().MakeUnchosen();
            RemoveChosenObject(chosenObject);
            if(inventoryObject.InventoryList.Count>0)
            {
                gameObject.GetComponent<DelegatorMakeChosen>().MakeChosenAfterTaking();
            }
            GetComponent<CircleRotator>().ResetRotator();
            Graber graber = GetComponentInParent<Graber>();
            graber.FillHand(chosenObject);
        }
    }
    public void Switch()
    {
        if (inventoryObject.InventoryList.Count > 0)
        {
            GameObject chosenObject = inventoryObject.InventoryList[inventoryObject.ChosenObjectNumber];
            GameObject newItem = inventoryObject.ItemInHand;
            Graber graber = GetComponentInParent<Graber>();
            GameObject chosenHolder = GetComponent<CircleManager>().HolderList[inventoryObject.ChosenObjectNumber];

            inventoryObject.InventoryList[inventoryObject.ChosenObjectNumber] = newItem;
            chosenObject.GetComponent<ItemInventoryMode>().DeactivateInventoryMode();
            newItem.GetComponent<ItemInventoryMode>().ActivateInventoryMode(chosenHolder);
            gameObject.GetComponent<DelegatorMakeChosen>().MakeChosenAfterSwitching();
            graber.FillHand(chosenObject);
        }
    }
    private void RemoveChosenObject(GameObject chosenObject)
    {
        inventoryObject.InventoryList.Remove(chosenObject);
        chosenObject.GetComponent<ItemInventoryMode>().DeactivateInventoryMode();
        GetComponent<CircleHolderCreator>().DestroyChosenHolder();
    }
}
