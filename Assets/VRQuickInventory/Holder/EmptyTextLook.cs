using UnityEngine;

public class EmptyTextLook : MonoBehaviour
{
    GameObject playerCam;
    private void Start()
    {
        playerCam = Camera.main.gameObject;
    }
    void Update()
    {
        gameObject.transform.LookAt(playerCam.transform);
        gameObject.transform.Rotate(0,180, 0);
    }
}
