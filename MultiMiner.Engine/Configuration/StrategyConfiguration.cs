﻿namespace MultiMiner.Engine.Configuration
{
    public class StrategyConfiguration
    {
        //generic
        public Coin.Api.BaseCoin BaseCoin { get; set; }
        public bool AutomaticallyMineCoins { get; set; }
        public enum CoinMiningBasis
        {
            Profitability = 0,
            Difficulty = 1,
            Price = 2
        }
        public CoinMiningBasis MiningBasis { get; set; }
        public enum CoinSwitchStrategy
        {
            SingleMost = 0,
            AllMost = 1
        }
        public CoinSwitchStrategy SwitchStrategy { get; set; }
        public string MinimumThresholdSymbol { get; set; }
        public double? MinimumThresholdValue { get; set; }
        public double? MineSingleMostOverrideValue { get; set; }

        //all specific to profitability
        public enum CoinProfitabilityKind
        {
            AdjustedProfitability = 0,
            AverageProfitability = 1,
            StraightProfitability = 2
        }
        public CoinProfitabilityKind ProfitabilityKind { get; set; }
    }
}
