using UnityEngine;

public class BgParallax : MonoBehaviour
{
    private Material material;
    [SerializeField]
    private float parallaxSpeed = 0.2f;
    private float offset;

    private void OnEnable()
    {
        ThemeSelectionManager.onThemeSelected += UpdateMaterial;
    }

    private void OnDisable()
    {
        ThemeSelectionManager.onThemeSelected -= UpdateMaterial;
    }

    private void UpdateMaterial()
    {
        material = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        Parallax();
    }

    private void Parallax()
    {
        if (material != null)
        {
            offset += Time.deltaTime * parallaxSpeed;
            material.mainTextureOffset = new Vector2(offset, 0);
        }
    }
}
