// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Enums/BadgeType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Enums {

  /// <summary>Holder for reflection information generated from Enums/BadgeType.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class BadgeTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums/BadgeType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BadgeTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVFbnVtcy9CYWRnZVR5cGUucHJvdG8SBUVudW1zKqEHCglCYWRnZVR5cGUS",
            "DwoLQkFER0VfVU5TRVQQABITCg9CQURHRV9UUkFWRUxfS00QARIZChVCQURH",
            "RV9QT0tFREVYX0VOVFJJRVMQAhIXChNCQURHRV9DQVBUVVJFX1RPVEFMEAMS",
            "FwoTQkFER0VfREVGRUFURURfRk9SVBAEEhcKE0JBREdFX0VWT0xWRURfVE9U",
            "QUwQBRIXChNCQURHRV9IQVRDSEVEX1RPVEFMEAYSGwoXQkFER0VfRU5DT1VO",
            "VEVSRURfVE9UQUwQBxIbChdCQURHRV9QT0tFU1RPUFNfVklTSVRFRBAIEhoK",
            "FkJBREdFX1VOSVFVRV9QT0tFU1RPUFMQCRIZChVCQURHRV9QT0tFQkFMTF9U",
            "SFJPV04QChIWChJCQURHRV9CSUdfTUFHSUtBUlAQCxIYChRCQURHRV9ERVBM",
            "T1lFRF9UT1RBTBAMEhsKF0JBREdFX0JBVFRMRV9BVFRBQ0tfV09OEA0SHQoZ",
            "QkFER0VfQkFUVExFX1RSQUlOSU5HX1dPThAOEhsKF0JBREdFX0JBVFRMRV9E",
            "RUZFTkRfV09OEA8SGQoVQkFER0VfUFJFU1RJR0VfUkFJU0VEEBASGgoWQkFE",
            "R0VfUFJFU1RJR0VfRFJPUFBFRBAREhUKEUJBREdFX1RZUEVfTk9STUFMEBIS",
            "FwoTQkFER0VfVFlQRV9GSUdIVElORxATEhUKEUJBREdFX1RZUEVfRkxZSU5H",
            "EBQSFQoRQkFER0VfVFlQRV9QT0lTT04QFRIVChFCQURHRV9UWVBFX0dST1VO",
            "RBAWEhMKD0JBREdFX1RZUEVfUk9DSxAXEhIKDkJBREdFX1RZUEVfQlVHEBgS",
            "FAoQQkFER0VfVFlQRV9HSE9TVBAZEhQKEEJBREdFX1RZUEVfU1RFRUwQGhIT",
            "Cg9CQURHRV9UWVBFX0ZJUkUQGxIUChBCQURHRV9UWVBFX1dBVEVSEBwSFAoQ",
            "QkFER0VfVFlQRV9HUkFTUxAdEhcKE0JBREdFX1RZUEVfRUxFQ1RSSUMQHhIW",
            "ChJCQURHRV9UWVBFX1BTWUNISUMQHxISCg5CQURHRV9UWVBFX0lDRRAgEhUK",
            "EUJBREdFX1RZUEVfRFJBR09OECESEwoPQkFER0VfVFlQRV9EQVJLECISFAoQ",
            "QkFER0VfVFlQRV9GQUlSWRAjEhcKE0JBREdFX1NNQUxMX1JBVFRBVEEQJBIR",
            "Cg1CQURHRV9QSUtBQ0hVECViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Enums.BadgeType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum BadgeType {
    [pbr::OriginalName("BADGE_UNSET")] BadgeUnset = 0,
    [pbr::OriginalName("BADGE_TRAVEL_KM")] BadgeTravelKm = 1,
    [pbr::OriginalName("BADGE_POKEDEX_ENTRIES")] BadgePokedexEntries = 2,
    [pbr::OriginalName("BADGE_CAPTURE_TOTAL")] BadgeCaptureTotal = 3,
    [pbr::OriginalName("BADGE_DEFEATED_FORT")] BadgeDefeatedFort = 4,
    [pbr::OriginalName("BADGE_EVOLVED_TOTAL")] BadgeEvolvedTotal = 5,
    [pbr::OriginalName("BADGE_HATCHED_TOTAL")] BadgeHatchedTotal = 6,
    [pbr::OriginalName("BADGE_ENCOUNTERED_TOTAL")] BadgeEncounteredTotal = 7,
    [pbr::OriginalName("BADGE_POKESTOPS_VISITED")] BadgePokestopsVisited = 8,
    [pbr::OriginalName("BADGE_UNIQUE_POKESTOPS")] BadgeUniquePokestops = 9,
    [pbr::OriginalName("BADGE_POKEBALL_THROWN")] BadgePokeballThrown = 10,
    [pbr::OriginalName("BADGE_BIG_MAGIKARP")] BadgeBigMagikarp = 11,
    [pbr::OriginalName("BADGE_DEPLOYED_TOTAL")] BadgeDeployedTotal = 12,
    [pbr::OriginalName("BADGE_BATTLE_ATTACK_WON")] BadgeBattleAttackWon = 13,
    [pbr::OriginalName("BADGE_BATTLE_TRAINING_WON")] BadgeBattleTrainingWon = 14,
    [pbr::OriginalName("BADGE_BATTLE_DEFEND_WON")] BadgeBattleDefendWon = 15,
    [pbr::OriginalName("BADGE_PRESTIGE_RAISED")] BadgePrestigeRaised = 16,
    [pbr::OriginalName("BADGE_PRESTIGE_DROPPED")] BadgePrestigeDropped = 17,
    [pbr::OriginalName("BADGE_TYPE_NORMAL")] Normal = 18,
    [pbr::OriginalName("BADGE_TYPE_FIGHTING")] Fighting = 19,
    [pbr::OriginalName("BADGE_TYPE_FLYING")] Flying = 20,
    [pbr::OriginalName("BADGE_TYPE_POISON")] Poison = 21,
    [pbr::OriginalName("BADGE_TYPE_GROUND")] Ground = 22,
    [pbr::OriginalName("BADGE_TYPE_ROCK")] Rock = 23,
    [pbr::OriginalName("BADGE_TYPE_BUG")] Bug = 24,
    [pbr::OriginalName("BADGE_TYPE_GHOST")] Ghost = 25,
    [pbr::OriginalName("BADGE_TYPE_STEEL")] Steel = 26,
    [pbr::OriginalName("BADGE_TYPE_FIRE")] Fire = 27,
    [pbr::OriginalName("BADGE_TYPE_WATER")] Water = 28,
    [pbr::OriginalName("BADGE_TYPE_GRASS")] Grass = 29,
    [pbr::OriginalName("BADGE_TYPE_ELECTRIC")] Electric = 30,
    [pbr::OriginalName("BADGE_TYPE_PSYCHIC")] Psychic = 31,
    [pbr::OriginalName("BADGE_TYPE_ICE")] Ice = 32,
    [pbr::OriginalName("BADGE_TYPE_DRAGON")] Dragon = 33,
    [pbr::OriginalName("BADGE_TYPE_DARK")] Dark = 34,
    [pbr::OriginalName("BADGE_TYPE_FAIRY")] Fairy = 35,
    [pbr::OriginalName("BADGE_SMALL_RATTATA")] BadgeSmallRattata = 36,
    [pbr::OriginalName("BADGE_PIKACHU")] BadgePikachu = 37,
  }

  #endregion

}

#endregion Designer generated code
