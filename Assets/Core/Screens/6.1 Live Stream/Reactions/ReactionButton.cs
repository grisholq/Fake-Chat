using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactionButton : MonoBehaviour
{
    [SerializeField] private Texture _activeTexture;
    [SerializeField] private Texture _unactiveTexture;
    [SerializeField] private Material _particlesMaterial;

    [SerializeField] private RawImage _display;

    public bool Active => _active;
    private bool _active;

    public Material ParticlesMaterial => _particlesMaterial;

    private void OnEnable()
    {
        Deactivate();
    }

    public void Activate()
    {
        _active = true;
        _display.texture = _activeTexture;
    }

    public void Deactivate()
    {
        _active = false;
        _display.texture = _unactiveTexture;
    }
}