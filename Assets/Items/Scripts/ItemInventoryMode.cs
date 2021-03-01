using UnityEngine;

public class ItemInventoryMode : MonoBehaviour
{
    [SerializeField] float dragSpeed = 0.04f;
    [SerializeField] float inventoryScale = 0.3f;
    [SerializeField] float chosenScale = 1;
    [SerializeField] Vector3 inventoryCorrection;
    GameObject playerCam;
    GameObject parent;
    bool inventoryModeActive = false;

    private void Awake()
    {
        playerCam = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Update()
    {
        if (parent != null && inventoryModeActive)
        {
            MoveTowardsParent();
            transform.LookAt(playerCam.transform);
            transform.Rotate(inventoryCorrection);
        }
    }
    public void ActivateInventoryMode(GameObject newparent)
    {
        SetParent(newparent);
        ChangeGrabableState(false);
        inventoryModeActive = true;
    }
    public void DeactivateInventoryMode()
    {
        SetParent(null);
        inventoryModeActive = false;
        ChangeGrabableState(true);
    }
    public GameObject GetParent()
    {
        return parent;
    }
    public void MakeChosen(bool chosen, GameObject newParent)
    {
        parent = newParent;
        if (chosen)
        {
            gameObject.transform.localScale = new Vector3(chosenScale, chosenScale, chosenScale);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(inventoryScale, inventoryScale, inventoryScale);
        }
    }
    private void SetParent(GameObject newParent)
    {
        parent = newParent;
    }
    private void MoveTowardsParent()
    {
        Vector3 velocity = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, parent.transform.position, ref velocity, dragSpeed);
    }
    private void ChangeGrabableState(bool isActive)
    {
        if (!isActive)
        {
            gameObject.GetComponentInParent<Graber>().ItemInInventory();
            gameObject.transform.localScale = new Vector3(inventoryScale, inventoryScale, inventoryScale);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        gameObject.GetComponent<Rigidbody>().detectCollisions = isActive;
        gameObject.GetComponent<Rigidbody>().useGravity = isActive;
        gameObject.GetComponent<Rigidbody>().isKinematic = !isActive;
    }
}
