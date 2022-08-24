using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystemRenderer _particleSystemRenderer;

    public void UpdateReactionButton(ReactionButton reactionButton)
    {
        _particleSystemRenderer.material = reactionButton.ParticlesMaterial;
    }
}