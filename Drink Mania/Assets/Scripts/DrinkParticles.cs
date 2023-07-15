using UnityEngine;

public class DrinkParticles : MonoBehaviour
{
    [SerializeField] private GameObject drinkParticlesGO;
    [SerializeField] private ParticleSystem drinkParticleSystem;

    public void EnableAndDisableDrinkParticles(int rate)
    {
        drinkParticleSystem.emissionRate = rate;
    }

    public void SwapDrinkParticles(int nextLvl)
    {
        switch (nextLvl)
        {
            case 11:
                drinkParticleSystem.startColor = new Color(0.65f, 0.25f, 0.13f);
                break;

            case 21:
                drinkParticleSystem.startColor = new Color(0.25f, 0.1f, 0f);
                break;

            case 31:
                drinkParticleSystem.startColor = new Color(0.75f, 0.95f, 1f, 0.1f);
                break;

            case 41:
                drinkParticleSystem.startColor = new Color(0.75f, 0.95f, 1f, 0.1f);
                break;
        }
    }
}
