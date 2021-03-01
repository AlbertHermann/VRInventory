using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryObject", menuName = "QuickInventoryObject", order = 1)]
public class QuickInventoryObject : ScriptableObject
{
    [SerializeField] float dragSpeed, rotationSpeed, circleRadius;
    [SerializeField] int  chosenObjectNumber, maxItemAmount;
    [SerializeField] List<GameObject> inventoryList= new List<GameObject>();
    [SerializeField] GameObject itemInHand;
    public float DragSpeed { get => dragSpeed;}
    public List<GameObject> InventoryList { get => inventoryList; set => inventoryList = value; }
    public float RotationSpeed { get => rotationSpeed;}
    public float CircleRadius { get => circleRadius;}
    public int MaxItemAmount { get => maxItemAmount;}
    public GameObject ItemInHand { get => itemInHand; set => itemInHand = value; }
    public int ChosenObjectNumber { get => chosenObjectNumber; set => chosenObjectNumber = value; }
}
