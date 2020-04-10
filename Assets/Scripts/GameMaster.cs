using System;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    // Where main values are stored
    public double alpha;
    public double alphaProducers;
    public double betaProducers;
    public double gammaProducers;
    public double deltaProducers;
    public double epsilonProducers;
    public double zetaProducers;
    public double etaProducers;
    public double thetaProducers;
    public double omega;
    public double alphaClickValue;
    public double alphaPerSecond;

    // Delcaring the text to manipulate
    public Text currencyText;
    public Text alphaPerSecText;
    public Text clickUpgradeText;
    public Text productionUpgradeText;
    public Text betaUpgradeText;
    public Text gammaUpgradeText;
    public Text deltaUpgradeText;
    public Text epsilonUpgradeText;
    public Text zetaUpgradeText;
    public Text etaUpgradeText;
    public Text thetaUpgradeText;
    public Text omegaText;

    // Also main values, but are costs of different things. This is so I can seperate a different section for upgrading.
    public double clickUpgradeCost;
    public double productionUpgradeCost;
    public double betaUpgradeCost;
    public double gammaUpgradeCost;
    public double deltaUpgradeCost;
    public double epsilonUpgradeCost;
    public double zetaUpgradeCost;
    public double etaUpgradeCost;
    public double thetaUpgradeCost;

    public void Start()
    {
        // Probably don't need to give these things values of 0, but I did it anyways. The rest are the base values.
        alpha = 0;
        alphaProducers = 0;
        betaProducers = 0;
        gammaProducers = 0;
        deltaProducers = 0;
        epsilonProducers = 0;
        zetaProducers = 0;
        etaProducers = 0;
        thetaProducers = 0;
        alphaPerSecond = alphaProducers;
        alphaClickValue = 1;
        clickUpgradeCost = 10;
        productionUpgradeCost = 25;
        betaUpgradeCost = 1000;
        gammaUpgradeCost = 40000;
        deltaUpgradeCost = 160000;
        epsilonUpgradeCost = 640000;
        zetaUpgradeCost = 25600000;
        etaUpgradeCost = 1024000000;
        thetaUpgradeCost = 40960000000;
        omega = 0;
    }
    public void Update()
    {
        //Convert Alpha to scientific notation.
        if (alpha > 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(alpha))));
            var mantissa = (alpha / System.Math.Pow(10, exponent));
            currencyText.text = "Alpha: " + mantissa.ToString("F2") + "e" + exponent;
        }
        else
            currencyText.text = "Alpha: " + alpha.ToString("F0");

        //Convert Alpha per second into scienfitic notation (Currently broken and I don't know why)
        if (alphaPerSecond > 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(alphaPerSecond))));
            var mantissa = (alphaPerSecond / System.Math.Pow(10, exponent));
            alphaPerSecText.text = mantissa.ToString("F2") + "e" + exponent + " /s";
        }
        else
            alphaPerSecText.text = alphaProducers.ToString("F0") + " /s";

        //Convert Alpha Producers into scientific notation
        if (alphaProducers > 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(alphaProducers))));
            var mantissa = (alphaProducers / System.Math.Pow(10, exponent));
            productionUpgradeText.text = mantissa.ToString("F2") + "e" + exponent + " Alpha Creators\n" + productionUpgradeCost.ToString("F0") + " alpha";
        }
        else
            productionUpgradeText.text = alphaProducers.ToString("F0") + " Alpha Creators\n" + productionUpgradeCost.ToString("F0") + " alpha";

        //Convert Beta Producers into scientific notation
        if (betaProducers > 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(betaProducers))));
            var mantissa = (betaProducers / System.Math.Pow(10, exponent));
            betaUpgradeText.text = mantissa.ToString("F2") + "e" + exponent + " Beta Creators\n" + betaUpgradeCost.ToString("F0") + " alpha";
        }
        else
            betaUpgradeText.text = betaProducers.ToString("F0") + " Beta Creators\n" + betaUpgradeCost.ToString("F0") + " alpha";

        if (gammaProducers > 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(betaProducers))));
            var mantissa = (betaProducers / System.Math.Pow(10, exponent));
            gammaUpgradeText.text = mantissa.ToString("F2") + "e" + exponent + " Gamma Creators\n" + gammaUpgradeCost.ToString("F0") + " alpha";
        }
        else
            gammaUpgradeText.text = gammaProducers.ToString("F0") + " Gamma Creators\n" + gammaUpgradeCost.ToString("F0") + " alpha";

        clickUpgradeText.text = "Click Better\n" + clickUpgradeCost.ToString("F0") + " alpha";
        deltaUpgradeText.text = deltaProducers.ToString("F0") + " Delta Creators\n" + deltaUpgradeCost.ToString("F0") + " alpha";
        epsilonUpgradeText.text = epsilonProducers.ToString("F0") + " Epsilon Creators\n" + epsilonUpgradeCost.ToString("F0") + " alpha";
        zetaUpgradeText.text = zetaProducers.ToString("F0") + " Zeta Creators\n" + zetaUpgradeCost.ToString("F0") + " alpha";
        etaUpgradeText.text = etaProducers.ToString("F0") + " Eta Creators\n" + etaUpgradeCost.ToString("F0") + " alpha";
        thetaUpgradeText.text = thetaProducers.ToString("F0") + " Theta Creators\n" + thetaUpgradeCost.ToString("F0") + " alpha";
        omegaText.text = "Omega: " + omega.ToString("F0") + "\n+0% click power";

        alpha += alphaProducers * Time.deltaTime;
        alphaProducers += betaProducers * Time.deltaTime;
        betaProducers += gammaProducers * Time.deltaTime;
        gammaProducers += deltaProducers * Time.deltaTime;
        deltaProducers += epsilonProducers * Time.deltaTime;
        epsilonProducers += zetaProducers * Time.deltaTime;
        zetaProducers += etaProducers * Time.deltaTime;
        etaProducers += thetaProducers * Time.deltaTime;
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
    public void EpsilonGenerateUpgrade()
    {
        if (alpha >= epsilonUpgradeCost)
        {
            alpha -= epsilonUpgradeCost;
            epsilonUpgradeCost *= 1.07;
            epsilonProducers++;
        }
    }
    public void ZetaGenerateUpgrade()
    {
        if (alpha >= zetaUpgradeCost)
        {
            alpha -= zetaUpgradeCost;
            zetaUpgradeCost *= 1.07;
            zetaProducers++;
        }
    }
    public void EtaGenerateUpgrade()
    {
        if (alpha >= etaUpgradeCost)
        {
            alpha -= etaUpgradeCost;
            etaUpgradeCost *= 1.07;
            etaProducers++;
        }
    }
    public void ThetaGenerateUpgrade()
    {
        if (alpha >= thetaUpgradeCost)
        {
            alpha -= thetaUpgradeCost;
            thetaUpgradeCost *= 1.07;
            thetaProducers++;
        }
    }
}