// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Master/EncounterSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Settings/Master/EncounterSettings.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class EncounterSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Master/EncounterSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTZXR0aW5ncy9NYXN0ZXIvRW5jb3VudGVyU2V0dGluZ3MucHJvdG8SD1Nl",
            "dHRpbmdzLk1hc3RlciKuAQoRRW5jb3VudGVyU2V0dGluZ3MSHAoUc3Bpbl9i",
            "b251c190aHJlc2hvbGQYASABKAISIQoZZXhjZWxsZW50X3Rocm93X3RocmVz",
            "aG9sZBgCIAEoAhIdChVncmVhdF90aHJvd190aHJlc2hvbGQYAyABKAISHAoU",
            "bmljZV90aHJvd190aHJlc2hvbGQYBCABKAISGwoTbWlsZXN0b25lX3RocmVz",
            "aG9sZBgFIAEoBUIdqgIaUG9rZW1vbkdvRGVza3RvcC5BUEkuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.EncounterSettings), global::PokemonGoDesktop.API.Proto.EncounterSettings.Parser, new[]{ "SpinBonusThreshold", "ExcellentThrowThreshold", "GreatThrowThreshold", "NiceThrowThreshold", "MilestoneThreshold" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class EncounterSettings : pb::IMessage<EncounterSettings> {
    private static readonly pb::MessageParser<EncounterSettings> _parser = new pb::MessageParser<EncounterSettings>(() => new EncounterSettings());
    public static pb::MessageParser<EncounterSettings> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.EncounterSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public EncounterSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    public EncounterSettings(EncounterSettings other) : this() {
      spinBonusThreshold_ = other.spinBonusThreshold_;
      excellentThrowThreshold_ = other.excellentThrowThreshold_;
      greatThrowThreshold_ = other.greatThrowThreshold_;
      niceThrowThreshold_ = other.niceThrowThreshold_;
      milestoneThreshold_ = other.milestoneThreshold_;
    }

    public EncounterSettings Clone() {
      return new EncounterSettings(this);
    }

    /// <summary>Field number for the "spin_bonus_threshold" field.</summary>
    public const int SpinBonusThresholdFieldNumber = 1;
    private float spinBonusThreshold_;
    public float SpinBonusThreshold {
      get { return spinBonusThreshold_; }
      set {
        spinBonusThreshold_ = value;
      }
    }

    /// <summary>Field number for the "excellent_throw_threshold" field.</summary>
    public const int ExcellentThrowThresholdFieldNumber = 2;
    private float excellentThrowThreshold_;
    public float ExcellentThrowThreshold {
      get { return excellentThrowThreshold_; }
      set {
        excellentThrowThreshold_ = value;
      }
    }

    /// <summary>Field number for the "great_throw_threshold" field.</summary>
    public const int GreatThrowThresholdFieldNumber = 3;
    private float greatThrowThreshold_;
    public float GreatThrowThreshold {
      get { return greatThrowThreshold_; }
      set {
        greatThrowThreshold_ = value;
      }
    }

    /// <summary>Field number for the "nice_throw_threshold" field.</summary>
    public const int NiceThrowThresholdFieldNumber = 4;
    private float niceThrowThreshold_;
    public float NiceThrowThreshold {
      get { return niceThrowThreshold_; }
      set {
        niceThrowThreshold_ = value;
      }
    }

    /// <summary>Field number for the "milestone_threshold" field.</summary>
    public const int MilestoneThresholdFieldNumber = 5;
    private int milestoneThreshold_;
    public int MilestoneThreshold {
      get { return milestoneThreshold_; }
      set {
        milestoneThreshold_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as EncounterSettings);
    }

    public bool Equals(EncounterSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpinBonusThreshold != other.SpinBonusThreshold) return false;
      if (ExcellentThrowThreshold != other.ExcellentThrowThreshold) return false;
      if (GreatThrowThreshold != other.GreatThrowThreshold) return false;
      if (NiceThrowThreshold != other.NiceThrowThreshold) return false;
      if (MilestoneThreshold != other.MilestoneThreshold) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SpinBonusThreshold != 0F) hash ^= SpinBonusThreshold.GetHashCode();
      if (ExcellentThrowThreshold != 0F) hash ^= ExcellentThrowThreshold.GetHashCode();
      if (GreatThrowThreshold != 0F) hash ^= GreatThrowThreshold.GetHashCode();
      if (NiceThrowThreshold != 0F) hash ^= NiceThrowThreshold.GetHashCode();
      if (MilestoneThreshold != 0) hash ^= MilestoneThreshold.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SpinBonusThreshold != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(SpinBonusThreshold);
      }
      if (ExcellentThrowThreshold != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(ExcellentThrowThreshold);
      }
      if (GreatThrowThreshold != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(GreatThrowThreshold);
      }
      if (NiceThrowThreshold != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(NiceThrowThreshold);
      }
      if (MilestoneThreshold != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MilestoneThreshold);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SpinBonusThreshold != 0F) {
        size += 1 + 4;
      }
      if (ExcellentThrowThreshold != 0F) {
        size += 1 + 4;
      }
      if (GreatThrowThreshold != 0F) {
        size += 1 + 4;
      }
      if (NiceThrowThreshold != 0F) {
        size += 1 + 4;
      }
      if (MilestoneThreshold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MilestoneThreshold);
      }
      return size;
    }

    public void MergeFrom(EncounterSettings other) {
      if (other == null) {
        return;
      }
      if (other.SpinBonusThreshold != 0F) {
        SpinBonusThreshold = other.SpinBonusThreshold;
      }
      if (other.ExcellentThrowThreshold != 0F) {
        ExcellentThrowThreshold = other.ExcellentThrowThreshold;
      }
      if (other.GreatThrowThreshold != 0F) {
        GreatThrowThreshold = other.GreatThrowThreshold;
      }
      if (other.NiceThrowThreshold != 0F) {
        NiceThrowThreshold = other.NiceThrowThreshold;
      }
      if (other.MilestoneThreshold != 0) {
        MilestoneThreshold = other.MilestoneThreshold;
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
            SpinBonusThreshold = input.ReadFloat();
            break;
          }
          case 21: {
            ExcellentThrowThreshold = input.ReadFloat();
            break;
          }
          case 29: {
            GreatThrowThreshold = input.ReadFloat();
            break;
          }
          case 37: {
            NiceThrowThreshold = input.ReadFloat();
            break;
          }
          case 40: {
            MilestoneThreshold = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
