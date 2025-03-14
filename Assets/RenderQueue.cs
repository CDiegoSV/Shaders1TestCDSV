using UnityEngine;

public class RenderQueue : MonoBehaviour
{
    [SerializeField] protected Material m_Material;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Material.renderQueue = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
