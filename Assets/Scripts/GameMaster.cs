using System;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public double alpha;
    public double alphaProducers;
    public double betaProducers;
    public double gammaProducers;
    public double deltaProducers;
    public double omega;
    public double alphaClickValue;
    public double alphaPerSecond;

    public Text currencyText;
    public Text alphaPerSecText;
    public Text clickUpgradeText;
    public Text productionUpgradeText;
    public Text betaUpgradeText;
    public Text gammaUpgradeText;
    public Text deltaUpgradeText;
    public Text omegaText;

    public double clickUpgradeCost;
    public double productionUpgradeCost;
    public double betaUpgradeCost;
    public double gammaUpgradeCost;
    public double deltaUpgradeCost;

    public void Start()
    {
        alpha = 0;
        alphaProducers = 0;
        betaProducers = 0;
        gammaProducers = 0;
        deltaProducers = 0;
        alphaPerSecond = alphaProducers;
        alphaClickValue = 1;
        clickUpgradeCost = 10;
        productionUpgradeCost = 25;
        betaUpgradeCost = 1000;
        gammaUpgradeCost = 40000;
        deltaUpgradeCost = 160000;
        omega = 0;
    }
    public void Update()
    {
        currencyText.text = "Alpha: " + alpha.ToString("F0");
        alphaPerSecText.text = alphaProducers.ToString("F0") + " /s";
        clickUpgradeText.text = "Click Better\n" + clickUpgradeCost.ToString("F0") + " alpha";
        productionUpgradeText.text = alphaProducers.ToString("F0") + " Alpha Creators\n" + productionUpgradeCost.ToString("F0") + " alpha";
        betaUpgradeText.text = betaProducers.ToString("F0") + " Beta Creators\n" + betaUpgradeCost.ToString("F0") + " alpha";
        gammaUpgradeText.text = gammaProducers.ToString("F0") + " Gamma Creators\n" + gammaUpgradeCost.ToString("F0") + " alpha";
        deltaUpgradeText.text = deltaProducers.ToString("F0") + " Delta Creators\n" + deltaUpgradeCost.ToString("F0") + " alpha";
        omegaText.text = "Omega: " + omega.ToString("F0") + "\n+0% click power";

        alpha += alphaProducers * Time.deltaTime;
        alphaProducers += betaProducers * Time.deltaTime;
        betaProducers += gammaProducers * Time.deltaTime;
        gammaProducers += deltaProducers * Time.deltaTime;
    }
    public void Click()
    {
        alpha += alphaClickValue;
    }
    public void ClickBetterUpgrade()
    {
        if (alpha >= clickUpgradeCost)
        {
            alpha -= clickUpgradeCost;
            clickUpgradeCost *= 1.07;
            alphaClickValue++;
        }
    }
    public void AlphaGenerateUpgrade()
    {
        if (alpha >= productionUpgradeCost)
        {
            alpha -= productionUpgradeCost;
            productionUpgradeCost *= 1.07;
            alphaPerSecond++;
            alphaProducers++;
        }
    }
    public void BetaGenerateUpgrade()
    {
        if (alpha >= betaUpgradeCost)
        {
            alpha -= betaUpgradeCost;
            betaUpgradeCost *= 1.07;
            betaProducers++;
        }
    }
    public void GammeGenerateUpgrade()
    {
        if (alpha >= gammaUpgradeCost)
        {
            alpha -= gammaUpgradeCost;
            gammaUpgradeCost *= 1.07;
            gammaProducers++;
        }
    }
    public void DeltaGenerateUpgrade()
    {
        if (alpha >= deltaUpgradeCost)
        {
            alpha -= deltaUpgradeCost;
            deltaUpgradeCost *= 1.07;
            deltaProducers++;
        }
    }
}