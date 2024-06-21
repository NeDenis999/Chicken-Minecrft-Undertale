using System;
using UnityEngine;

namespace Game
{
    public class HerobrinePicture : MonoBehaviour
    {
        [SerializeField]
        private Sprite[] _sprites;

        [SerializeField] private SpriteRenderer _spriteRenderer;
        
        private void Start()
        {
            _spriteRenderer.sprite = (GameData.NumberGame % 4) switch
            {
                2 => _sprites[0],
                3 => _sprites[1],
                _ => _spriteRenderer.sprite
            };
        }
    }
}