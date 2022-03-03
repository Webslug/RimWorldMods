﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace EckTechGames.PlagueGun
{
    /// <summary>
    /// Plague Bullet stores the data for the infection chance
    /// and disease to add.
    /// </summary>
    public class ThingDef_PlagueBullet : ThingDef
    {
        public float AddHediffChance = 1f; //The default chance of adding a hediff.
        public HediffDef HediffToAdd;

        public override void ResolveReferences()
        {
            base.ResolveReferences();
            HediffToAdd = HediffDefOf.Plague;
        }
    }
}
