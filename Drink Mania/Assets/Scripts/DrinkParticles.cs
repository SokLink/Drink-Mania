using UnityEngine;

public class DrinkParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem playerDrinkParticleSystem;
    [SerializeField] private ParticleSystem enemyDrinkParticleSystem;

    [SerializeField] private Transform enemyParticlesTransform;

    private Vector2 CowboyParticelsPos = new Vector2 (0, -1.1f);
    private Vector2 PiratParticelsPos = new Vector2(0, -0.9f);
    private Vector2 MexicanParticelsPos = new Vector2(0, -0.65f);
    private Vector2 RussianParticelsPos = new Vector2(0, -0.6f);

    public void EnableAndDisableDrinkParticles(int rate)
    {
        playerDrinkParticleSystem.emissionRate = rate;
    }

    public void SwapDrinkParticles(int nextLvl)
    {
        switch (nextLvl)
        {
            case 11:
                playerDrinkParticleSystem.startColor = new Color(0.65f, 0.25f, 0.13f);
                enemyDrinkParticleSystem.startColor = new Color(0.65f, 0.25f, 0.13f);

                enemyParticlesTransform.localPosition = CowboyParticelsPos;
                break;

            case 21:
                playerDrinkParticleSystem.startColor = new Color(0.25f, 0.1f, 0f);
                enemyDrinkParticleSystem.startColor = new Color(0.25f, 0.1f, 0f);

                enemyParticlesTransform.localPosition = PiratParticelsPos;
                break;

            case 31:
                playerDrinkParticleSystem.startColor = new Color(0.75f, 0.95f, 1f, 0.1f);
                enemyDrinkParticleSystem.startColor = new Color(0.75f, 0.95f, 1f, 0.1f);

                enemyParticlesTransform.localPosition = MexicanParticelsPos;
                break;

            case 41:
                playerDrinkParticleSystem.startColor = new Color(0.75f, 0.95f, 1f, 0.1f);
                enemyDrinkParticleSystem.startColor = new Color(0.75f, 0.95f, 1f, 0.05f);

                enemyParticlesTransform.localPosition = RussianParticelsPos;
                break;
        }
    }
}
