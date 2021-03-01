using UnityEngine;

[RequireComponent(typeof(DelegatorMakeChosen))]
[RequireComponent(typeof(DelegatorTake))]
[RequireComponent(typeof(DelegatorAdd))]
public class CircleItemDelegator : MonoBehaviour
{
    QuickInventoryObject inventoryObject;
    DelegatorMakeChosen makeChosen;
    DelegatorTake take;
    DelegatorAdd add;

    private void Awake()
    {
        inventoryObject = gameObject.GetComponent<CircleManager>().InventoryObject;
        makeChosen = gameObject.GetComponent<DelegatorMakeChosen>();
        take = gameObject.GetComponent<DelegatorTake>();
        add = gameObject.GetComponent<DelegatorAdd>();
        makeChosen.InventoryObject = inventoryObject;
        take.InventoryObject = inventoryObject;
        add.InventoryObject = inventoryObject;
    }
    public void DelegateFromHandToHolder()
    {
        if (inventoryObject.InventoryList.Count < inventoryObject.MaxItemAmount)
        {
            add.Add();
            makeChosen.MakeChosenAfterAdding();
        }
    }
    public void MakeChosenAfterRotation(int direction)
    {
        makeChosen.MakeChosenAfterRotation(direction);
    }
    public void TakeChosenObject()
    {
        if (inventoryObject.ItemInHand == null)
        {
            take.Take();
        }
        else
        {
            take.Switch();
        }
    }
}
