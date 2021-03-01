using System.Collections.Generic;
using UnityEngine;

public class InHandMode : MonoBehaviour
{
    [SerializeField] private Material inHandMaterial;
    List<Renderer> childRenderer = new List<Renderer>();
    List<Material> oldMaterials = new List<Material>();
    private void Start()
    {
        GetChildRenderer();
        GetChildOldMaterial();
    }
    public void ActivateInHandMode(bool active)
    {
        if (active)
        {
            foreach (Renderer element in childRenderer)
            {
                element.material = inHandMaterial;
            }
        }
        else
        {
            for (int i = 0; i<childRenderer.Count; i++)
            {
                childRenderer[i].material = oldMaterials[i];
            }
        }
    }
    private void GetChildOldMaterial()
    {
        foreach (Renderer element in GetComponentsInChildren<Renderer>())
        {
            oldMaterials.Add(element.material);
        }
    }
    private void GetChildRenderer()
    {
        foreach (Renderer element in GetComponentsInChildren<Renderer>())
        {
            childRenderer.Add(element);
        }
    }
}
