using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace AmazingTrack
{
    public class PlayingUI : MonoBehaviour
    {
        [SerializeField] Text scoreText;
        [SerializeField] Text highScoreText;
        [SerializeField] Text levelText;
        
        private int score;
        private int highScore;
        private int level;

        [Inject] private PlayerStatService playerStatService;
        
        private void Update()
        {
            ref var playerStatComponent = ref playerStatService.GetPlayerStat();
            
            if (playerStatComponent.Score != score)
            {
                scoreText.text = "Pontuação: " + playerStatComponent.Score;
                score = playerStatComponent.Score;
            }

            if (playerStatComponent.HighScore != highScore)
            {
                highScoreText.text = "Mais alta: " + playerStatComponent.HighScore;
                highScore = playerStatComponent.HighScore;
            }

            if (playerStatComponent.Level != level)
            {
                levelText.text = "Nível: " + playerStatComponent.Level;
                level = playerStatComponent.Level;
            }
        }
    }
}