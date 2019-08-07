using System.Collections.Generic;
using ScriptableObjects.Abilities;
using UnityEngine;

namespace ScriptableObjects.Cards
{
    [CreateAssetMenu(menuName = "Assets/Cards/Card", fileName = "Card")]
    public class Card : ScriptableObject
    {
        public string cardName;
        public int health;
        public int attack;
        public List<Ability> abilities;

        public void UseAbilities()
        {
            foreach (var ability in abilities)
            {
                ability.Use();
            }
        }

        public void UseAbility(int index)
        {
            var ability = abilities[index];
            ability.Use();
        }
    }
}
