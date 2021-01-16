using UnityEngine;

namespace ScriptableObjects.Abilities
{
    public abstract class Ability : ScriptableObject
    {
        public string abilityName;

        public abstract void Use();
    }
}