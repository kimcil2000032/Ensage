﻿namespace Evader.EvadableAbilities.Heroes.Visage
{
    using Ensage;

    using static Data.AbilityNames;

    using Projectile = Base.Projectile;

    internal class SoulAssumption : Projectile
    {
        #region Constructors and Destructors

        public SoulAssumption(Ability ability)
            : base(ability)
        {
            IsDisjointable = false;

            CounterAbilities.Add(PhaseShift);
            CounterAbilities.Add(BallLightning);
            CounterAbilities.Add(SleightOfFist);
            CounterAbilities.Add(Eul);
            CounterAbilities.AddRange(VsDamage);
            CounterAbilities.AddRange(VsMagic);
            CounterAbilities.Add(Bloodstone);
            CounterAbilities.Add(Armlet);
            CounterAbilities.Add(Lotus);
        }

        #endregion
    }
}