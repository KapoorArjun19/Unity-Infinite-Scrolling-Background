using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scrollSpeed;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float x = Time.time * scrollSpeed;
        Vector2 offset = new Vector2(x, 0);
        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}