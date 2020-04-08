using System;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public double alpha;
    public double omega;
    public double alphaClickValue;
    public double alphaPerSecond;

    public Text currencyText;
    public Text alphaPerSecText;
    public Text clickUpgradeText;
    public Text productionUpgradeText;
    public Text omegaText;

    public double clickUpgradeCost;
    public double productionUpgradeCost;

    public void Start()
    {
        alpha = Math.Floor(alpha);
        alphaPerSecond = 0;
        alphaClickValue = 1;
        clickUpgradeCost = 10;
        productionUpgradeCost = 25;
        omega = 0;
    }
    public void Update()
    {
        currencyText.text = "Alpha: " + alpha.ToString("F0");
        alphaPerSecText.text = alphaPerSecond.ToString("F0") + " /s";
        clickUpgradeText.text = "Click Better\n" + clickUpgradeCost.ToString("F0") + " alpha";
        productionUpgradeText.text = "Alpha Forever\n" + productionUpgradeCost.ToString("F0") + " alpha";
        omegaText.text = "Omega: " + omega.ToString("F0") + "\n+0% click power";

        alpha += alphaPerSecond * Time.deltaTime;
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
    public void ClickForeverUpgrade()
    {
        if (alpha >= productionUpgradeCost)
        {
            alpha -= productionUpgradeCost;
            productionUpgradeCost *= 1.07;
            alphaPerSecond++;
        }
    }
}