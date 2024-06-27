using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace AmazingTrack
{
    public class GameEndUI : MonoBehaviour
    {
        [SerializeField] Text scoreText;

        [Inject] private PlayerStatService playerStatService;
        
        private void OnEnable()
        {
            ref var playerStatComponent = ref playerStatService.GetPlayerStat();
            
            string text = "Sua pontação: " + playerStatComponent.Score;
            bool newRecord = playerStatComponent.Score == playerStatComponent.HighScore;
            if (newRecord)
                text += "\nNovo recorde !";

            scoreText.text = text;
        }
    }
}