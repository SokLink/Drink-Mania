using UnityEngine;

public class DrinkParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem playerDrinkParticleSystem;

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
                break;

            case 21:
                playerDrinkParticleSystem.startColor = new Color(0.25f, 0.1f, 0f);
                break;

            case 31:
                playerDrinkParticleSystem.startColor = new Color(0.75f, 0.95f, 1f, 0.1f);
                break;

            case 41:
                playerDrinkParticleSystem.startColor = new Color(0.75f, 0.95f, 1f, 0.1f);
                break;
        }
    }
}
