using UnityEngine;

public class QuickInventoryInput : MonoBehaviour
{
    [SerializeField] GameObject leftCircle, rightCircle;
    QuickinventoryInputActions input;

    private void Awake()
    {
        input = new QuickinventoryInputActions();
        input.Enable();
        input.LeftCircle.Disable();
        input.RightCircle.Disable();
        input.LeftHand.Open.performed += context => OpenCircle(true);
        input.RightHand.Open.performed += context => OpenCircle(false);
        input.LeftCircle.RotateLeft.performed += context => Rotate(leftCircle, -1);
        input.LeftCircle.RotateRight.performed += context => Rotate(leftCircle, 1);
        input.RightCircle.RotateLeft.performed += context => Rotate(rightCircle, -1);
        input.RightCircle.RotateRight.performed += context => Rotate(rightCircle, 1);
        input.LeftCircle.FillInventory.performed += context => FillInventory(leftCircle);
        input.RightCircle.FillInventory.performed += context => FillInventory(rightCircle);
        input.LeftCircle.GrabChosenItem.performed += context => TakeChosenObject(leftCircle);
        input.RightCircle.GrabChosenItem.performed += context => TakeChosenObject(rightCircle);
    }
    void OpenCircle(bool leftController)
    {
        if (leftController)
        {
            ActivateLeftController();
        }
        else
        {
            ActivateRightController();
        }
    }
    void Rotate(GameObject circle, int direction)
    {
        circle.GetComponent<CircleManager>().Rotate(direction);
    }
    void FillInventory(GameObject circle)
    {
        circle.GetComponent<CircleManager>().FillInventory();
    }
    void TakeChosenObject(GameObject circle)
    {
        circle.GetComponent<CircleManager>().TakeChosenObject();
    }
    private void ActivateLeftController()
    {
        if (!leftCircle.activeSelf)
        {
            leftCircle.SetActive(true);
            rightCircle.SetActive(false);
            input.LeftCircle.Enable();
            input.RightCircle.Disable();
        }
        else
        {
            leftCircle.SetActive(false);
            input.LeftCircle.Disable();
        }
    }
    private void ActivateRightController()
    {
        if (!rightCircle.activeSelf)
        {
            rightCircle.SetActive(true);
            leftCircle.SetActive(false);
            input.RightCircle.Enable();
            input.LeftCircle.Disable();
        }
        else
        {
            rightCircle.SetActive(false);
            input.RightCircle.Disable();
        }
    }
}
