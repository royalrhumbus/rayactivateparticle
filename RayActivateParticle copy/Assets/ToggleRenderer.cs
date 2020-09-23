using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRenderer : MonoBehaviour
{

    Renderer renderer;
    bool isInView;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    public void Toggle(bool enabled)
    {
        isInView = enabled;
        renderer.enabled = enabled;
    }

    private void LateUpdate()
    {
        if (!isInView && renderer.enabled)
        {
            Toggle(false);
        }
        else isInView = false;
    }
}