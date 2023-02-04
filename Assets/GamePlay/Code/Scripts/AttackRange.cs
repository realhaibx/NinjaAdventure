using System;
using UnityEngine;

namespace GamePlay.Code.Scripts
{
    public class AttackRange : MonoBehaviour
    {
        private const string PREFAB_PLAYER_TAG = "Player";
        private const string PREFAB_ENEMY_TAG = "Enemy";
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag(PREFAB_PLAYER_TAG))
            {
                Player player = col.GetComponent<Character>() as Player;
                if (player != null)
                {
                    player.OnHit(30.0f);
                }
            }
            if (col.CompareTag(PREFAB_PLAYER_TAG) || col.CompareTag(PREFAB_ENEMY_TAG))
            {
                Enemy enemy = col.GetComponent<Character>() as Enemy;
                if (enemy != null)
                {
                    enemy.OnHit(30.0f);
                }                
            }
        }
    }
}