// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data/Battle/BattleParticipant.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Data.Battle {

  /// <summary>Holder for reflection information generated from Data/Battle/BattleParticipant.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class BattleParticipantReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/Battle/BattleParticipant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleParticipantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNEYXRhL0JhdHRsZS9CYXR0bGVQYXJ0aWNpcGFudC5wcm90bxILRGF0YS5C",
            "YXR0bGUaI0RhdGEvQmF0dGxlL0JhdHRsZVBva2Vtb25JbmZvLnByb3RvGiVE",
            "YXRhL1BsYXllci9QbGF5ZXJQdWJsaWNQcm9maWxlLnByb3RvIoACChFCYXR0",
            "bGVQYXJ0aWNpcGFudBI2Cg5hY3RpdmVfcG9rZW1vbhgBIAEoCzIeLkRhdGEu",
            "QmF0dGxlLkJhdHRsZVBva2Vtb25JbmZvEkAKFnRyYWluZXJfcHVibGljX3By",
            "b2ZpbGUYAiABKAsyIC5EYXRhLlBsYXllci5QbGF5ZXJQdWJsaWNQcm9maWxl",
            "EjcKD3JldmVyc2VfcG9rZW1vbhgDIAMoCzIeLkRhdGEuQmF0dGxlLkJhdHRs",
            "ZVBva2Vtb25JbmZvEjgKEGRlZmVhdGVkX3Bva2Vtb24YBCADKAsyHi5EYXRh",
            "LkJhdHRsZS5CYXR0bGVQb2tlbW9uSW5mb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Data.Battle.BattlePokemonInfoReflection.Descriptor, global::Data.Player.PlayerPublicProfileReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.Battle.BattleParticipant), global::Data.Battle.BattleParticipant.Parser, new[]{ "ActivePokemon", "TrainerPublicProfile", "ReversePokemon", "DefeatedPokemon" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class BattleParticipant : pb::IMessage<BattleParticipant> {
    private static readonly pb::MessageParser<BattleParticipant> _parser = new pb::MessageParser<BattleParticipant>(() => new BattleParticipant());
    public static pb::MessageParser<BattleParticipant> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.Battle.BattleParticipantReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public BattleParticipant() {
      OnConstruction();
    }

    partial void OnConstruction();

    public BattleParticipant(BattleParticipant other) : this() {
      ActivePokemon = other.activePokemon_ != null ? other.ActivePokemon.Clone() : null;
      TrainerPublicProfile = other.trainerPublicProfile_ != null ? other.TrainerPublicProfile.Clone() : null;
      reversePokemon_ = other.reversePokemon_.Clone();
      defeatedPokemon_ = other.defeatedPokemon_.Clone();
    }

    public BattleParticipant Clone() {
      return new BattleParticipant(this);
    }

    /// <summary>Field number for the "active_pokemon" field.</summary>
    public const int ActivePokemonFieldNumber = 1;
    private global::Data.Battle.BattlePokemonInfo activePokemon_;
    public global::Data.Battle.BattlePokemonInfo ActivePokemon {
      get { return activePokemon_; }
      set {
        activePokemon_ = value;
      }
    }

    /// <summary>Field number for the "trainer_public_profile" field.</summary>
    public const int TrainerPublicProfileFieldNumber = 2;
    private global::Data.Player.PlayerPublicProfile trainerPublicProfile_;
    public global::Data.Player.PlayerPublicProfile TrainerPublicProfile {
      get { return trainerPublicProfile_; }
      set {
        trainerPublicProfile_ = value;
      }
    }

    /// <summary>Field number for the "reverse_pokemon" field.</summary>
    public const int ReversePokemonFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Data.Battle.BattlePokemonInfo> _repeated_reversePokemon_codec
        = pb::FieldCodec.ForMessage(26, global::Data.Battle.BattlePokemonInfo.Parser);
    private readonly pbc::RepeatedField<global::Data.Battle.BattlePokemonInfo> reversePokemon_ = new pbc::RepeatedField<global::Data.Battle.BattlePokemonInfo>();
    public pbc::RepeatedField<global::Data.Battle.BattlePokemonInfo> ReversePokemon {
      get { return reversePokemon_; }
    }

    /// <summary>Field number for the "defeated_pokemon" field.</summary>
    public const int DefeatedPokemonFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Data.Battle.BattlePokemonInfo> _repeated_defeatedPokemon_codec
        = pb::FieldCodec.ForMessage(34, global::Data.Battle.BattlePokemonInfo.Parser);
    private readonly pbc::RepeatedField<global::Data.Battle.BattlePokemonInfo> defeatedPokemon_ = new pbc::RepeatedField<global::Data.Battle.BattlePokemonInfo>();
    public pbc::RepeatedField<global::Data.Battle.BattlePokemonInfo> DefeatedPokemon {
      get { return defeatedPokemon_; }
    }

    public override bool Equals(object other) {
      return Equals(other as BattleParticipant);
    }

    public bool Equals(BattleParticipant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ActivePokemon, other.ActivePokemon)) return false;
      if (!object.Equals(TrainerPublicProfile, other.TrainerPublicProfile)) return false;
      if(!reversePokemon_.Equals(other.reversePokemon_)) return false;
      if(!defeatedPokemon_.Equals(other.defeatedPokemon_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (activePokemon_ != null) hash ^= ActivePokemon.GetHashCode();
      if (trainerPublicProfile_ != null) hash ^= TrainerPublicProfile.GetHashCode();
      hash ^= reversePokemon_.GetHashCode();
      hash ^= defeatedPokemon_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (activePokemon_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ActivePokemon);
      }
      if (trainerPublicProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TrainerPublicProfile);
      }
      reversePokemon_.WriteTo(output, _repeated_reversePokemon_codec);
      defeatedPokemon_.WriteTo(output, _repeated_defeatedPokemon_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (activePokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ActivePokemon);
      }
      if (trainerPublicProfile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TrainerPublicProfile);
      }
      size += reversePokemon_.CalculateSize(_repeated_reversePokemon_codec);
      size += defeatedPokemon_.CalculateSize(_repeated_defeatedPokemon_codec);
      return size;
    }

    public void MergeFrom(BattleParticipant other) {
      if (other == null) {
        return;
      }
      if (other.activePokemon_ != null) {
        if (activePokemon_ == null) {
          activePokemon_ = new global::Data.Battle.BattlePokemonInfo();
        }
        ActivePokemon.MergeFrom(other.ActivePokemon);
      }
      if (other.trainerPublicProfile_ != null) {
        if (trainerPublicProfile_ == null) {
          trainerPublicProfile_ = new global::Data.Player.PlayerPublicProfile();
        }
        TrainerPublicProfile.MergeFrom(other.TrainerPublicProfile);
      }
      reversePokemon_.Add(other.reversePokemon_);
      defeatedPokemon_.Add(other.defeatedPokemon_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (activePokemon_ == null) {
              activePokemon_ = new global::Data.Battle.BattlePokemonInfo();
            }
            input.ReadMessage(activePokemon_);
            break;
          }
          case 18: {
            if (trainerPublicProfile_ == null) {
              trainerPublicProfile_ = new global::Data.Player.PlayerPublicProfile();
            }
            input.ReadMessage(trainerPublicProfile_);
            break;
          }
          case 26: {
            reversePokemon_.AddEntriesFrom(input, _repeated_reversePokemon_codec);
            break;
          }
          case 34: {
            defeatedPokemon_.AddEntriesFrom(input, _repeated_defeatedPokemon_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
