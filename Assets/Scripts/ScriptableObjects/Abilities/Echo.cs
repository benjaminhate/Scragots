using UnityEngine;

namespace ScriptableObjects.Abilities
{
    [CreateAssetMenu(menuName = "Assets/Abilities/Echo")]
    public class Echo : Ability
    {
        public override void Use()
        {
            Debug.Log($"Use Echo Ability : {abilityName}");
        }
    }
}