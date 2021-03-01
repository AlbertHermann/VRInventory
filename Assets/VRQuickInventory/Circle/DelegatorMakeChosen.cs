using UnityEngine;

public class DelegatorMakeChosen : MonoBehaviour 
{
    QuickInventoryObject inventoryObject;
    int lastChosen;

    public QuickInventoryObject InventoryObject {set => inventoryObject = value; }
    public void MakeChosenAfterRotation(int direction)
    {
        int newChosenNumber = lastChosen + -direction;
        newChosenNumber = CheckIfOutOfRange(newChosenNumber);
        MakeChosen(newChosenNumber);
    }
    public void MakeChosenAfterTaking()
    {
        inventoryObject.ChosenObjectNumber = 0;
        inventoryObject.InventoryList[0].GetComponent<ItemInventoryMode>().MakeChosen(true, gameObject);
        lastChosen = 0;
    }
    public void MakeChosenAfterAdding()
    {
        MakeChosen(0);
    }
    public void MakeUnchosen()
    {
        inventoryObject.InventoryList[lastChosen].GetComponent<ItemInventoryMode>()
            .MakeChosen(false, GetComponent<CircleManager>().HolderList[lastChosen]);
    }
    public void MakeChosenAfterSwitching()
    {
        MakeChosen(inventoryObject.ChosenObjectNumber);
    }
    private void MakeChosen(int newChosenNumber)
    {
        inventoryObject.ChosenObjectNumber = newChosenNumber;
        if(inventoryObject.InventoryList.Count > 0)
        {
            MakeUnchosen();
        }
        inventoryObject.InventoryList[newChosenNumber].GetComponent<ItemInventoryMode>().MakeChosen(true, gameObject);
        lastChosen = newChosenNumber;
    }
    private int CheckIfOutOfRange(int chosenNumber)
    {
        if (chosenNumber < 0)
        {
            chosenNumber = inventoryObject.InventoryList.Count - 1;
        }
        else if (chosenNumber > inventoryObject.InventoryList.Count - 1)
        {
            chosenNumber = 0;
        }
        return chosenNumber;
    }
}
