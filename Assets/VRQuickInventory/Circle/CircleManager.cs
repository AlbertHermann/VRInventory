using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleHolderCreator))]
[RequireComponent(typeof(CircleRotator))]
[RequireComponent(typeof(CircleItemDelegator))]
public class CircleManager : MonoBehaviour
{
    [SerializeField] QuickInventoryObject inventoryObject;
    [SerializeField] GameObject holderPrefab;
    CircleHolderCreator holderCreator;
    CircleRotator rotator;
    CircleItemDelegator itemDelegator;
    private List<GameObject> holderList = new List<GameObject>();
    bool isClosing = false;

    public List<GameObject> HolderList { get => holderList; set => holderList = value; }
    public QuickInventoryObject InventoryObject { get => inventoryObject; set => inventoryObject = value; }

    private void Awake()
    {
        holderCreator = gameObject.GetComponent<CircleHolderCreator>();
        holderCreator.ActivateCircle(holderPrefab);
        rotator = gameObject.GetComponent<CircleRotator>();
        itemDelegator = gameObject.GetComponent<CircleItemDelegator>();
    }
    public void FillInventory()
    {
        if (inventoryObject.ItemInHand != null)
        {
            if (inventoryObject.InventoryList.Count < inventoryObject.MaxItemAmount)
            {
                MakeTransparent(false);
            }

            holderCreator.CreateHolder();
            itemDelegator.DelegateFromHandToHolder();
        }
    }
    public void TakeChosenObject()
    {
        MakeTransparent(false);
        itemDelegator.TakeChosenObject();
        MakeTransparent(true);
    }
    public void Rotate(int direction)
    {
        rotator.Rotate(direction);
    }
    private void OnDisable()
    {
        MakeTransparent(false);
        if (!isClosing) //Quiting app also queries the list (ScriptableObject survives Application.Quit)
        {
            gameObject.GetComponentInParent<Graber>().SetGrabState(true);
            foreach (GameObject element in inventoryObject.InventoryList)
            {
                element.SetActive(false);
            }
        }
    }
    private void OnEnable()
    {
        StartInCenter();
        MakeTransparent(true);
        gameObject.GetComponentInParent<Graber>().SetGrabState(false);
        foreach (GameObject element in inventoryObject.InventoryList)
        {
            element.SetActive(true);
        }
    }
    private void OnApplicationQuit()
    {
        isClosing = true;
    }
    private void MakeTransparent(bool active)
    {
        if (inventoryObject.ItemInHand != null)
        {
            inventoryObject.ItemInHand.GetComponent<InHandMode>().ActivateInHandMode(active);
        }
    }
    private void StartInCenter()
    {
        foreach(GameObject element in inventoryObject.InventoryList)
        {
            element.transform.position = transform.position;
        }
    }
}
