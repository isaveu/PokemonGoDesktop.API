// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Master/GymBattleSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Settings/Master/GymBattleSettings.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GymBattleSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Master/GymBattleSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymBattleSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTZXR0aW5ncy9NYXN0ZXIvR3ltQmF0dGxlU2V0dGluZ3MucHJvdG8SD1Nl",
            "dHRpbmdzLk1hc3RlciLGAwoRR3ltQmF0dGxlU2V0dGluZ3MSFgoOZW5lcmd5",
            "X3Blcl9zZWMYASABKAISGQoRZG9kZ2VfZW5lcmd5X2Nvc3QYAiABKAISGAoQ",
            "cmV0YXJnZXRfc2Vjb25kcxgDIAEoAhIdChVlbmVteV9hdHRhY2tfaW50ZXJ2",
            "YWwYBCABKAISHgoWYXR0YWNrX3NlcnZlcl9pbnRlcnZhbBgFIAEoAhIeChZy",
            "b3VuZF9kdXJhdGlvbl9zZWNvbmRzGAYgASgCEiMKG2JvbnVzX3RpbWVfcGVy",
            "X2FsbHlfc2Vjb25kcxgHIAEoAhIkChxtYXhpbXVtX2F0dGFja2Vyc19wZXJf",
            "YmF0dGxlGAggASgFEikKIXNhbWVfdHlwZV9hdHRhY2tfYm9udXNfbXVsdGlw",
            "bGllchgJIAEoAhIWCg5tYXhpbXVtX2VuZXJneRgKIAEoBRIkChxlbmVyZ3lf",
            "ZGVsdGFfcGVyX2hlYWx0aF9sb3N0GAsgASgCEhkKEWRvZGdlX2R1cmF0aW9u",
            "X21zGAwgASgFEhwKFG1pbmltdW1fcGxheWVyX2xldmVsGA0gASgFEhgKEHN3",
            "YXBfZHVyYXRpb25fbXMYDiABKAVCHaoCGlBva2Vtb25Hb0Rlc2t0b3AuQVBJ",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.GymBattleSettings), global::PokemonGoDesktop.API.Proto.GymBattleSettings.Parser, new[]{ "EnergyPerSec", "DodgeEnergyCost", "RetargetSeconds", "EnemyAttackInterval", "AttackServerInterval", "RoundDurationSeconds", "BonusTimePerAllySeconds", "MaximumAttackersPerBattle", "SameTypeAttackBonusMultiplier", "MaximumEnergy", "EnergyDeltaPerHealthLost", "DodgeDurationMs", "MinimumPlayerLevel", "SwapDurationMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GymBattleSettings : pb::IMessage<GymBattleSettings> {
    private static readonly pb::MessageParser<GymBattleSettings> _parser = new pb::MessageParser<GymBattleSettings>(() => new GymBattleSettings());
    public static pb::MessageParser<GymBattleSettings> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.GymBattleSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GymBattleSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GymBattleSettings(GymBattleSettings other) : this() {
      energyPerSec_ = other.energyPerSec_;
      dodgeEnergyCost_ = other.dodgeEnergyCost_;
      retargetSeconds_ = other.retargetSeconds_;
      enemyAttackInterval_ = other.enemyAttackInterval_;
      attackServerInterval_ = other.attackServerInterval_;
      roundDurationSeconds_ = other.roundDurationSeconds_;
      bonusTimePerAllySeconds_ = other.bonusTimePerAllySeconds_;
      maximumAttackersPerBattle_ = other.maximumAttackersPerBattle_;
      sameTypeAttackBonusMultiplier_ = other.sameTypeAttackBonusMultiplier_;
      maximumEnergy_ = other.maximumEnergy_;
      energyDeltaPerHealthLost_ = other.energyDeltaPerHealthLost_;
      dodgeDurationMs_ = other.dodgeDurationMs_;
      minimumPlayerLevel_ = other.minimumPlayerLevel_;
      swapDurationMs_ = other.swapDurationMs_;
    }

    public GymBattleSettings Clone() {
      return new GymBattleSettings(this);
    }

    /// <summary>Field number for the "energy_per_sec" field.</summary>
    public const int EnergyPerSecFieldNumber = 1;
    private float energyPerSec_;
    public float EnergyPerSec {
      get { return energyPerSec_; }
      set {
        energyPerSec_ = value;
      }
    }

    /// <summary>Field number for the "dodge_energy_cost" field.</summary>
    public const int DodgeEnergyCostFieldNumber = 2;
    private float dodgeEnergyCost_;
    public float DodgeEnergyCost {
      get { return dodgeEnergyCost_; }
      set {
        dodgeEnergyCost_ = value;
      }
    }

    /// <summary>Field number for the "retarget_seconds" field.</summary>
    public const int RetargetSecondsFieldNumber = 3;
    private float retargetSeconds_;
    public float RetargetSeconds {
      get { return retargetSeconds_; }
      set {
        retargetSeconds_ = value;
      }
    }

    /// <summary>Field number for the "enemy_attack_interval" field.</summary>
    public const int EnemyAttackIntervalFieldNumber = 4;
    private float enemyAttackInterval_;
    public float EnemyAttackInterval {
      get { return enemyAttackInterval_; }
      set {
        enemyAttackInterval_ = value;
      }
    }

    /// <summary>Field number for the "attack_server_interval" field.</summary>
    public const int AttackServerIntervalFieldNumber = 5;
    private float attackServerInterval_;
    public float AttackServerInterval {
      get { return attackServerInterval_; }
      set {
        attackServerInterval_ = value;
      }
    }

    /// <summary>Field number for the "round_duration_seconds" field.</summary>
    public const int RoundDurationSecondsFieldNumber = 6;
    private float roundDurationSeconds_;
    public float RoundDurationSeconds {
      get { return roundDurationSeconds_; }
      set {
        roundDurationSeconds_ = value;
      }
    }

    /// <summary>Field number for the "bonus_time_per_ally_seconds" field.</summary>
    public const int BonusTimePerAllySecondsFieldNumber = 7;
    private float bonusTimePerAllySeconds_;
    public float BonusTimePerAllySeconds {
      get { return bonusTimePerAllySeconds_; }
      set {
        bonusTimePerAllySeconds_ = value;
      }
    }

    /// <summary>Field number for the "maximum_attackers_per_battle" field.</summary>
    public const int MaximumAttackersPerBattleFieldNumber = 8;
    private int maximumAttackersPerBattle_;
    public int MaximumAttackersPerBattle {
      get { return maximumAttackersPerBattle_; }
      set {
        maximumAttackersPerBattle_ = value;
      }
    }

    /// <summary>Field number for the "same_type_attack_bonus_multiplier" field.</summary>
    public const int SameTypeAttackBonusMultiplierFieldNumber = 9;
    private float sameTypeAttackBonusMultiplier_;
    public float SameTypeAttackBonusMultiplier {
      get { return sameTypeAttackBonusMultiplier_; }
      set {
        sameTypeAttackBonusMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "maximum_energy" field.</summary>
    public const int MaximumEnergyFieldNumber = 10;
    private int maximumEnergy_;
    public int MaximumEnergy {
      get { return maximumEnergy_; }
      set {
        maximumEnergy_ = value;
      }
    }

    /// <summary>Field number for the "energy_delta_per_health_lost" field.</summary>
    public const int EnergyDeltaPerHealthLostFieldNumber = 11;
    private float energyDeltaPerHealthLost_;
    public float EnergyDeltaPerHealthLost {
      get { return energyDeltaPerHealthLost_; }
      set {
        energyDeltaPerHealthLost_ = value;
      }
    }

    /// <summary>Field number for the "dodge_duration_ms" field.</summary>
    public const int DodgeDurationMsFieldNumber = 12;
    private int dodgeDurationMs_;
    public int DodgeDurationMs {
      get { return dodgeDurationMs_; }
      set {
        dodgeDurationMs_ = value;
      }
    }

    /// <summary>Field number for the "minimum_player_level" field.</summary>
    public const int MinimumPlayerLevelFieldNumber = 13;
    private int minimumPlayerLevel_;
    public int MinimumPlayerLevel {
      get { return minimumPlayerLevel_; }
      set {
        minimumPlayerLevel_ = value;
      }
    }

    /// <summary>Field number for the "swap_duration_ms" field.</summary>
    public const int SwapDurationMsFieldNumber = 14;
    private int swapDurationMs_;
    public int SwapDurationMs {
      get { return swapDurationMs_; }
      set {
        swapDurationMs_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GymBattleSettings);
    }

    public bool Equals(GymBattleSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnergyPerSec != other.EnergyPerSec) return false;
      if (DodgeEnergyCost != other.DodgeEnergyCost) return false;
      if (RetargetSeconds != other.RetargetSeconds) return false;
      if (EnemyAttackInterval != other.EnemyAttackInterval) return false;
      if (AttackServerInterval != other.AttackServerInterval) return false;
      if (RoundDurationSeconds != other.RoundDurationSeconds) return false;
      if (BonusTimePerAllySeconds != other.BonusTimePerAllySeconds) return false;
      if (MaximumAttackersPerBattle != other.MaximumAttackersPerBattle) return false;
      if (SameTypeAttackBonusMultiplier != other.SameTypeAttackBonusMultiplier) return false;
      if (MaximumEnergy != other.MaximumEnergy) return false;
      if (EnergyDeltaPerHealthLost != other.EnergyDeltaPerHealthLost) return false;
      if (DodgeDurationMs != other.DodgeDurationMs) return false;
      if (MinimumPlayerLevel != other.MinimumPlayerLevel) return false;
      if (SwapDurationMs != other.SwapDurationMs) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (EnergyPerSec != 0F) hash ^= EnergyPerSec.GetHashCode();
      if (DodgeEnergyCost != 0F) hash ^= DodgeEnergyCost.GetHashCode();
      if (RetargetSeconds != 0F) hash ^= RetargetSeconds.GetHashCode();
      if (EnemyAttackInterval != 0F) hash ^= EnemyAttackInterval.GetHashCode();
      if (AttackServerInterval != 0F) hash ^= AttackServerInterval.GetHashCode();
      if (RoundDurationSeconds != 0F) hash ^= RoundDurationSeconds.GetHashCode();
      if (BonusTimePerAllySeconds != 0F) hash ^= BonusTimePerAllySeconds.GetHashCode();
      if (MaximumAttackersPerBattle != 0) hash ^= MaximumAttackersPerBattle.GetHashCode();
      if (SameTypeAttackBonusMultiplier != 0F) hash ^= SameTypeAttackBonusMultiplier.GetHashCode();
      if (MaximumEnergy != 0) hash ^= MaximumEnergy.GetHashCode();
      if (EnergyDeltaPerHealthLost != 0F) hash ^= EnergyDeltaPerHealthLost.GetHashCode();
      if (DodgeDurationMs != 0) hash ^= DodgeDurationMs.GetHashCode();
      if (MinimumPlayerLevel != 0) hash ^= MinimumPlayerLevel.GetHashCode();
      if (SwapDurationMs != 0) hash ^= SwapDurationMs.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (EnergyPerSec != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(EnergyPerSec);
      }
      if (DodgeEnergyCost != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(DodgeEnergyCost);
      }
      if (RetargetSeconds != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(RetargetSeconds);
      }
      if (EnemyAttackInterval != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(EnemyAttackInterval);
      }
      if (AttackServerInterval != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(AttackServerInterval);
      }
      if (RoundDurationSeconds != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(RoundDurationSeconds);
      }
      if (BonusTimePerAllySeconds != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(BonusTimePerAllySeconds);
      }
      if (MaximumAttackersPerBattle != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(MaximumAttackersPerBattle);
      }
      if (SameTypeAttackBonusMultiplier != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(SameTypeAttackBonusMultiplier);
      }
      if (MaximumEnergy != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(MaximumEnergy);
      }
      if (EnergyDeltaPerHealthLost != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(EnergyDeltaPerHealthLost);
      }
      if (DodgeDurationMs != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(DodgeDurationMs);
      }
      if (MinimumPlayerLevel != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(MinimumPlayerLevel);
      }
      if (SwapDurationMs != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(SwapDurationMs);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (EnergyPerSec != 0F) {
        size += 1 + 4;
      }
      if (DodgeEnergyCost != 0F) {
        size += 1 + 4;
      }
      if (RetargetSeconds != 0F) {
        size += 1 + 4;
      }
      if (EnemyAttackInterval != 0F) {
        size += 1 + 4;
      }
      if (AttackServerInterval != 0F) {
        size += 1 + 4;
      }
      if (RoundDurationSeconds != 0F) {
        size += 1 + 4;
      }
      if (BonusTimePerAllySeconds != 0F) {
        size += 1 + 4;
      }
      if (MaximumAttackersPerBattle != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaximumAttackersPerBattle);
      }
      if (SameTypeAttackBonusMultiplier != 0F) {
        size += 1 + 4;
      }
      if (MaximumEnergy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaximumEnergy);
      }
      if (EnergyDeltaPerHealthLost != 0F) {
        size += 1 + 4;
      }
      if (DodgeDurationMs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DodgeDurationMs);
      }
      if (MinimumPlayerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinimumPlayerLevel);
      }
      if (SwapDurationMs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SwapDurationMs);
      }
      return size;
    }

    public void MergeFrom(GymBattleSettings other) {
      if (other == null) {
        return;
      }
      if (other.EnergyPerSec != 0F) {
        EnergyPerSec = other.EnergyPerSec;
      }
      if (other.DodgeEnergyCost != 0F) {
        DodgeEnergyCost = other.DodgeEnergyCost;
      }
      if (other.RetargetSeconds != 0F) {
        RetargetSeconds = other.RetargetSeconds;
      }
      if (other.EnemyAttackInterval != 0F) {
        EnemyAttackInterval = other.EnemyAttackInterval;
      }
      if (other.AttackServerInterval != 0F) {
        AttackServerInterval = other.AttackServerInterval;
      }
      if (other.RoundDurationSeconds != 0F) {
        RoundDurationSeconds = other.RoundDurationSeconds;
      }
      if (other.BonusTimePerAllySeconds != 0F) {
        BonusTimePerAllySeconds = other.BonusTimePerAllySeconds;
      }
      if (other.MaximumAttackersPerBattle != 0) {
        MaximumAttackersPerBattle = other.MaximumAttackersPerBattle;
      }
      if (other.SameTypeAttackBonusMultiplier != 0F) {
        SameTypeAttackBonusMultiplier = other.SameTypeAttackBonusMultiplier;
      }
      if (other.MaximumEnergy != 0) {
        MaximumEnergy = other.MaximumEnergy;
      }
      if (other.EnergyDeltaPerHealthLost != 0F) {
        EnergyDeltaPerHealthLost = other.EnergyDeltaPerHealthLost;
      }
      if (other.DodgeDurationMs != 0) {
        DodgeDurationMs = other.DodgeDurationMs;
      }
      if (other.MinimumPlayerLevel != 0) {
        MinimumPlayerLevel = other.MinimumPlayerLevel;
      }
      if (other.SwapDurationMs != 0) {
        SwapDurationMs = other.SwapDurationMs;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            EnergyPerSec = input.ReadFloat();
            break;
          }
          case 21: {
            DodgeEnergyCost = input.ReadFloat();
            break;
          }
          case 29: {
            RetargetSeconds = input.ReadFloat();
            break;
          }
          case 37: {
            EnemyAttackInterval = input.ReadFloat();
            break;
          }
          case 45: {
            AttackServerInterval = input.ReadFloat();
            break;
          }
          case 53: {
            RoundDurationSeconds = input.ReadFloat();
            break;
          }
          case 61: {
            BonusTimePerAllySeconds = input.ReadFloat();
            break;
          }
          case 64: {
            MaximumAttackersPerBattle = input.ReadInt32();
            break;
          }
          case 77: {
            SameTypeAttackBonusMultiplier = input.ReadFloat();
            break;
          }
          case 80: {
            MaximumEnergy = input.ReadInt32();
            break;
          }
          case 93: {
            EnergyDeltaPerHealthLost = input.ReadFloat();
            break;
          }
          case 96: {
            DodgeDurationMs = input.ReadInt32();
            break;
          }
          case 104: {
            MinimumPlayerLevel = input.ReadInt32();
            break;
          }
          case 112: {
            SwapDurationMs = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
