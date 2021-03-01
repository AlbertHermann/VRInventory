using System.Collections;
using UnityEngine;

public class CircleRotator : MonoBehaviour
{
    private float rotationSpeed = 0.01f;
    private float rotationDistance = 0;
    private bool isRotating = false;
    private Vector3 rotationStep = new Vector3(0, 0, 0);
    private Vector3 correctRotation = new Vector3(0, 0, 0);
    private int count;
    private CircleManager circleManager;

    private void Awake()
    {
        circleManager = gameObject.GetComponent<CircleManager>();
    }
    public void Rotate(int direction)
    {
        if (circleManager.HolderList.Count > 1)
        {
            AdjustRotator();
            if (!isRotating)
            {
                StartCoroutine(Rotation(direction));
            }
        }
    }
    public void ResetRotator()
    {
        gameObject.transform.localRotation = new Quaternion(0, 0, 0, 0);
        count = 0;
    }
    IEnumerator Rotation(int direction)
    {
        isRotating = true;

        rotationStep.y = rotationDistance * 0.1f * direction;
        float rotationValue = 0;

        while (rotationValue < rotationDistance)
        {
            yield return new WaitForSeconds(rotationSpeed);
            gameObject.transform.Rotate(rotationStep);
            rotationValue += rotationStep.y * direction;
        }
        count += 1 * direction;
        CorrectRotation();
        GetComponent<CircleItemDelegator>().MakeChosenAfterRotation(direction);
        isRotating = false;
    }
    private void CorrectRotation()
    {
        if (count >= circleManager.HolderList.Count || count <= -circleManager.HolderList.Count)
        {
            count = 0;
        }
        correctRotation.y = rotationDistance * count;
        gameObject.transform.localEulerAngles = correctRotation;
    }
    private void AdjustRotator()
    {
        rotationDistance = 2 * Mathf.PI / circleManager.HolderList.Count * Mathf.Rad2Deg;
    }
}
