// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Master/PokemonUpgradeSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Settings.Master {

  /// <summary>Holder for reflection information generated from Settings/Master/PokemonUpgradeSettings.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokemonUpgradeSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Master/PokemonUpgradeSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonUpgradeSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixTZXR0aW5ncy9NYXN0ZXIvUG9rZW1vblVwZ3JhZGVTZXR0aW5ncy5wcm90",
            "bxIPU2V0dGluZ3MuTWFzdGVyIoQBChZQb2tlbW9uVXBncmFkZVNldHRpbmdz",
            "EhoKEnVwZ3JhZGVzX3Blcl9sZXZlbBgBIAEoBRIjChthbGxvd2VkX2xldmVs",
            "c19hYm92ZV9wbGF5ZXIYAiABKAUSEgoKY2FuZHlfY29zdBgDIAMoBRIVCg1z",
            "dGFyZHVzdF9jb3N0GAQgAygFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Settings.Master.PokemonUpgradeSettings), global::Settings.Master.PokemonUpgradeSettings.Parser, new[]{ "UpgradesPerLevel", "AllowedLevelsAbovePlayer", "CandyCost", "StardustCost" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PokemonUpgradeSettings : pb::IMessage<PokemonUpgradeSettings> {
    private static readonly pb::MessageParser<PokemonUpgradeSettings> _parser = new pb::MessageParser<PokemonUpgradeSettings>(() => new PokemonUpgradeSettings());
    public static pb::MessageParser<PokemonUpgradeSettings> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Settings.Master.PokemonUpgradeSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PokemonUpgradeSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PokemonUpgradeSettings(PokemonUpgradeSettings other) : this() {
      upgradesPerLevel_ = other.upgradesPerLevel_;
      allowedLevelsAbovePlayer_ = other.allowedLevelsAbovePlayer_;
      candyCost_ = other.candyCost_.Clone();
      stardustCost_ = other.stardustCost_.Clone();
    }

    public PokemonUpgradeSettings Clone() {
      return new PokemonUpgradeSettings(this);
    }

    /// <summary>Field number for the "upgrades_per_level" field.</summary>
    public const int UpgradesPerLevelFieldNumber = 1;
    private int upgradesPerLevel_;
    public int UpgradesPerLevel {
      get { return upgradesPerLevel_; }
      set {
        upgradesPerLevel_ = value;
      }
    }

    /// <summary>Field number for the "allowed_levels_above_player" field.</summary>
    public const int AllowedLevelsAbovePlayerFieldNumber = 2;
    private int allowedLevelsAbovePlayer_;
    public int AllowedLevelsAbovePlayer {
      get { return allowedLevelsAbovePlayer_; }
      set {
        allowedLevelsAbovePlayer_ = value;
      }
    }

    /// <summary>Field number for the "candy_cost" field.</summary>
    public const int CandyCostFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_candyCost_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> candyCost_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> CandyCost {
      get { return candyCost_; }
    }

    /// <summary>Field number for the "stardust_cost" field.</summary>
    public const int StardustCostFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_stardustCost_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> stardustCost_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> StardustCost {
      get { return stardustCost_; }
    }

    public override bool Equals(object other) {
      return Equals(other as PokemonUpgradeSettings);
    }

    public bool Equals(PokemonUpgradeSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UpgradesPerLevel != other.UpgradesPerLevel) return false;
      if (AllowedLevelsAbovePlayer != other.AllowedLevelsAbovePlayer) return false;
      if(!candyCost_.Equals(other.candyCost_)) return false;
      if(!stardustCost_.Equals(other.stardustCost_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (UpgradesPerLevel != 0) hash ^= UpgradesPerLevel.GetHashCode();
      if (AllowedLevelsAbovePlayer != 0) hash ^= AllowedLevelsAbovePlayer.GetHashCode();
      hash ^= candyCost_.GetHashCode();
      hash ^= stardustCost_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (UpgradesPerLevel != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UpgradesPerLevel);
      }
      if (AllowedLevelsAbovePlayer != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(AllowedLevelsAbovePlayer);
      }
      candyCost_.WriteTo(output, _repeated_candyCost_codec);
      stardustCost_.WriteTo(output, _repeated_stardustCost_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (UpgradesPerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UpgradesPerLevel);
      }
      if (AllowedLevelsAbovePlayer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AllowedLevelsAbovePlayer);
      }
      size += candyCost_.CalculateSize(_repeated_candyCost_codec);
      size += stardustCost_.CalculateSize(_repeated_stardustCost_codec);
      return size;
    }

    public void MergeFrom(PokemonUpgradeSettings other) {
      if (other == null) {
        return;
      }
      if (other.UpgradesPerLevel != 0) {
        UpgradesPerLevel = other.UpgradesPerLevel;
      }
      if (other.AllowedLevelsAbovePlayer != 0) {
        AllowedLevelsAbovePlayer = other.AllowedLevelsAbovePlayer;
      }
      candyCost_.Add(other.candyCost_);
      stardustCost_.Add(other.stardustCost_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UpgradesPerLevel = input.ReadInt32();
            break;
          }
          case 16: {
            AllowedLevelsAbovePlayer = input.ReadInt32();
            break;
          }
          case 26:
          case 24: {
            candyCost_.AddEntriesFrom(input, _repeated_candyCost_codec);
            break;
          }
          case 34:
          case 32: {
            stardustCost_.AddEntriesFrom(input, _repeated_stardustCost_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
