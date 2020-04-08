using System;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public double alpha;
    public double alphaProducers;
    public double betaProducers;
    public double omega;
    public double alphaClickValue;
    public double alphaPerSecond;

    public Text currencyText;
    public Text alphaPerSecText;
    public Text clickUpgradeText;
    public Text productionUpgradeText;
    public Text betaUpgradeText;
    public Text omegaText;

    public double clickUpgradeCost;
    public double productionUpgradeCost;
    public double betaUpgradeCost;

    public void Start()
    {
        alpha = 0;
        alphaProducers = 0;
        betaProducers = 0;
        alphaPerSecond = alphaProducers;
        alphaClickValue = 1;
        clickUpgradeCost = 10;
        productionUpgradeCost = 25;
        betaUpgradeCost = 10;
        omega = 0;
    }
    public void Update()
    {
        currencyText.text = "Alpha: " + alpha.ToString("F0");
        alphaPerSecText.text = alphaPerSecond.ToString("F0") + " /s";
        clickUpgradeText.text = "Click Better\n" + clickUpgradeCost.ToString("F0") + " alpha";
        productionUpgradeText.text = alphaProducers.ToString("F0") + " Alpha Creators\n" + productionUpgradeCost.ToString("F0") + " alpha";
        betaUpgradeText.text = betaProducers.ToString("F0") + " Beta Creators\n" + betaUpgradeCost.ToString("F0") + " alpha";
        omegaText.text = "Omega: " + omega.ToString("F0") + "\n+0% click power";

        alpha += alphaPerSecond + alphaProducers * Time.deltaTime;
        alphaProducers += betaProducers * Time.deltaTime;
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
}