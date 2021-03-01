using UnityEngine;

public class CircleHolderCreator : MonoBehaviour
{
    private GameObject holderPrefab;
    private CircleManager circleManager;
    private GameObject empty;
    private bool inventoryFull;
    public void ActivateCircle(GameObject newHolderPrefab)
    {
        holderPrefab = newHolderPrefab;
        circleManager = gameObject.GetComponent<CircleManager>();
        empty = Instantiate(holderPrefab);
        empty.transform.SetParent(gameObject.transform, false);

        ShowEmptyText();
    }
    public void CreateHolder()
    {
        CreateNewHolder();
        if (!inventoryFull)
        {
            HideEmptyText();
            SetHolderPosition();
        }
    }
    public void DestroyChosenHolder()
    {
        if(circleManager.HolderList.Count > 0)
        {
            GameObject toDestroy = circleManager.HolderList[circleManager.InventoryObject.ChosenObjectNumber];
            circleManager.HolderList.Remove(toDestroy);
            Destroy(toDestroy);
            inventoryFull = false;
            if(circleManager.HolderList.Count == 0)
            {
                ShowEmptyText();
            }
            SetHolderPosition();
        }
        else
        {
            print("No Holders");
        }
    }
    private void CreateNewHolder()
    {
        if (circleManager.HolderList.Count < circleManager.InventoryObject.MaxItemAmount)
        {
            GameObject child = Instantiate(holderPrefab);
            child.transform.SetParent(gameObject.transform, false);
            circleManager.HolderList.Add(child);
        }
        else
        {
            inventoryFull = true;
        }
    }
    private void SetHolderPosition()
    {
        float radiant = 0;

        for (int i = 0; i < circleManager.HolderList.Count; i++)
        {
            float xPosition = Mathf.Sin(radiant) * circleManager.InventoryObject.CircleRadius;
            float zPosition = Mathf.Cos(radiant) * circleManager.InventoryObject.CircleRadius;
            circleManager.HolderList[i].transform.localPosition = new Vector3(xPosition, 0, zPosition);
            radiant = 2 * Mathf.PI / circleManager.HolderList.Count * (i + 1);
        }
    }
    private void ShowEmptyText()
    {
        empty.transform.GetChild(0).gameObject.SetActive(true);
    }
    private void HideEmptyText()
    {
        empty.transform.GetChild(0).gameObject.SetActive(false);
    }
}
