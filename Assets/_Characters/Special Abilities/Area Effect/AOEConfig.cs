using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    [CreateAssetMenu(menuName = ("RPG/Special Ability/Area Effect"))]
    public class AOEConfig : SpecialAbility
    {

        [Header("Area Effect Specific")]
        [SerializeField]
        float damageToEachTarget = 10f;
        [SerializeField] float radius = 5f;

        public override void AttachComponentTo(GameObject gameObjectToattachTo)
        {
            var behaviourComponent = gameObjectToattachTo.AddComponent<AreaOfEffectBehaviour>();
            behaviourComponent.SetConfig(this);
            behaviour = behaviourComponent;
        }

        public float DamageToEachTarget()
        {
            return damageToEachTarget;
        }
    }
}