using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Characters;

namespace RPG.Characters
{
	public class AreaOfEffectBehaviour : MonoBehaviour, ISpecialAbility 
	{
        AOEConfig config;


        public void SetConfig(AOEConfig configToSet)
        {
            this.config = configToSet;
        }

		// Use this for initialization
		void Start ()
        {
            print("Area Effect Behaviour attached to " + gameObject.name);
        }
			
		public void Use(AbilityUseParams useParams)
        {
            print("Area Effect Used By " + gameObject.name);
        }
	}
}