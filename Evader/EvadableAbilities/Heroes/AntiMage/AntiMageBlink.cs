﻿namespace Evader.EvadableAbilities.Heroes.AntiMage
{
    using Base;

    using Ensage;

    using static Data.AbilityNames;

    internal class AntiMageCounterspell : NoObstacleAbility
    {
        public AntiMageCounterspell(Ability ability)
            : base(ability)
        {
            DisableAbilities.AddRange(DisableAbilityNames);
        }
    }
}
