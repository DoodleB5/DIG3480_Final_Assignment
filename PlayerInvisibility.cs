using UnityEngine;

// new script
public class PlayerInvisibility : MonoBehaviour
{
    [Header("Settings")]
    public KeyCode invisibilityKey = KeyCode.E;
    public float invisDuration = 5f;         
    public float cooldownDuration = 5f;      

    [Header("Renderers")]
    public Renderer[] normalRenderers;       
    public Renderer outlineRenderer;         

    [Header("Layers")]
    public string visibleLayerName = "Player";
    public string invisibleLayerName = "Invisibility";

    public bool IsInvisible { get; private set; }

    float invisTimer;
    float cooldownTimer;
    int visibleLayer;
    int invisibleLayer;

    void Awake()
    {
        visibleLayer = LayerMask.NameToLayer(visibleLayerName);
        invisibleLayer = LayerMask.NameToLayer(invisibleLayerName);

        
        SetInvisible(false, true);
    }

    void Update()
    {
        HandleInput();
        UpdateTimers();
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(invisibilityKey))
        {
            TryActivateInvisibility();
        }
    }

    void UpdateTimers()
    {
        if (IsInvisible)
        {
            invisTimer -= Time.deltaTime;
            if (invisTimer <= 0f)
            {
                SetInvisible(false);
                cooldownTimer = cooldownDuration;
            }
        }
        else
        {
            if (cooldownTimer > 0f)
                cooldownTimer -= Time.deltaTime;
        }
    }

    void TryActivateInvisibility()
    {
        if (!IsInvisible && cooldownTimer <= 0f)
        {
            invisTimer = invisDuration;
            SetInvisible(true);
        }
    }

    void SetInvisible(bool invisible, bool force = false)
    {
        if (!force && IsInvisible == invisible)
            return;

        IsInvisible = invisible;

        
        SetLayerRecursively(gameObject, invisible ? invisibleLayer : visibleLayer);

        
        if (normalRenderers != null)
        {
            foreach (var r in normalRenderers)
                if (r != null) r.enabled = !invisible;
        }

        if (outlineRenderer != null)
            outlineRenderer.enabled = invisible;
    }

    void SetLayerRecursively(GameObject obj, int newLayer)
    {
        obj.layer = newLayer;
        foreach (Transform child in obj.transform)
        {
            SetLayerRecursively(child.gameObject, newLayer);
        }
    }
}
