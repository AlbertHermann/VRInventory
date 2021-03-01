using UnityEngine;
public class Graber : MonoBehaviour
{
    [SerializeField] bool rightHand, leftHand;
    GraberControls graberControls;
    GameObject inHand;
    GameObject hand;
    ItemManager itemManager;
    bool isGrabing = false;
    bool handFilled = false;

    private void Awake()
    {
        graberControls = new GraberControls();
        graberControls.Enable();
        ActivateHand();
        itemManager = GetComponent<ItemManager>();
    }
    public void ItemInInventory()
    {
        EmptyHand();
    }
    public void FillHand(GameObject newInHand)
    {
        inHand = newInHand;
        inHand.gameObject.transform.SetParent(gameObject.transform);
        SetRigidbody(false, inHand);
        inHand.transform.rotation = gameObject.transform.rotation;
        inHand.transform.localPosition = new Vector3(0, 0, 0);
        hand = gameObject.GetComponentInChildren<Rigidbody>().gameObject; // Hand could be disabled on gamestart
        hand.SetActive(false);
        handFilled = true;
        itemManager.FillHand(inHand);
    }
    public void SetGrabState(bool active)
    {
        if(active)
        {
            graberControls.Enable();
        }
        else
        {
            graberControls.Disable();
        }
    }
    private void SetIsGrabing(bool value)
    {
        if (handFilled &&isGrabing) 
        {
            EmptyHand();
            value = false;
        }
        isGrabing = value;
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Grabable"))
        {
            
            if(isGrabing&&!handFilled)
            {
                FillHand(other.gameObject.transform.parent.gameObject);
                isGrabing = false;
            }
        }
    }
    private void EmptyHand()
    {
        inHand.transform.SetParent(null);
        SetRigidbody(true, inHand);
        hand.SetActive(true);
        inHand = null;
        handFilled = false;
        itemManager.EmptyHand();
    }
    private void SetRigidbody(bool active, GameObject bodyOwner)
    {
        Rigidbody rigidbody = bodyOwner.GetComponent<Rigidbody>();
        rigidbody.useGravity = active;
        rigidbody.isKinematic = !active;
        rigidbody.detectCollisions = active;
    }
    private void ActivateHand()
    {
        if(leftHand)
        {
            graberControls.LeftHand.Grab.performed += context => SetIsGrabing(true);
            graberControls.LeftHand.Grab.canceled += context => SetIsGrabing(false);
        }else if(rightHand)
        {
            graberControls.RightHand.Grab.performed += context => SetIsGrabing(true);
            graberControls.RightHand.Grab.canceled += context => SetIsGrabing(false);
        }
    }
}
