using Game.Cards;
using UnityEngine;

namespace ScriptableObjects.Cards
{
    [CreateAssetMenu(menuName = "Assets/Cards/Card", fileName = "Card")]
    public class Card : ScriptableObject
    {
        public string cardName;
        public int power;
        public int resistance;
        public CardType type;
        public CardRarity rarity;
    }
}
