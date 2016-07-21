// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data/Player/EquippedBadge.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Data.Player {

  /// <summary>Holder for reflection information generated from Data/Player/EquippedBadge.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class EquippedBadgeReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/Player/EquippedBadge.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EquippedBadgeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9EYXRhL1BsYXllci9FcXVpcHBlZEJhZGdlLnByb3RvEgtEYXRhLlBsYXll",
            "choVRW51bXMvQmFkZ2VUeXBlLnByb3RvInQKDUVxdWlwcGVkQmFkZ2USJAoK",
            "YmFkZ2VfdHlwZRgBIAEoDjIQLkVudW1zLkJhZGdlVHlwZRINCgVsZXZlbBgC",
            "IAEoBRIuCiZuZXh0X2VxdWlwX2NoYW5nZV9hbGxvd2VkX3RpbWVzdGFtcF9t",
            "cxgDIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Enums.BadgeTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.Player.EquippedBadge), global::Data.Player.EquippedBadge.Parser, new[]{ "BadgeType", "Level", "NextEquipChangeAllowedTimestampMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class EquippedBadge : pb::IMessage<EquippedBadge> {
    private static readonly pb::MessageParser<EquippedBadge> _parser = new pb::MessageParser<EquippedBadge>(() => new EquippedBadge());
    public static pb::MessageParser<EquippedBadge> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.Player.EquippedBadgeReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public EquippedBadge() {
      OnConstruction();
    }

    partial void OnConstruction();

    public EquippedBadge(EquippedBadge other) : this() {
      badgeType_ = other.badgeType_;
      level_ = other.level_;
      nextEquipChangeAllowedTimestampMs_ = other.nextEquipChangeAllowedTimestampMs_;
    }

    public EquippedBadge Clone() {
      return new EquippedBadge(this);
    }

    /// <summary>Field number for the "badge_type" field.</summary>
    public const int BadgeTypeFieldNumber = 1;
    private global::Enums.BadgeType badgeType_ = 0;
    public global::Enums.BadgeType BadgeType {
      get { return badgeType_; }
      set {
        badgeType_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private int level_;
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "next_equip_change_allowed_timestamp_ms" field.</summary>
    public const int NextEquipChangeAllowedTimestampMsFieldNumber = 3;
    private long nextEquipChangeAllowedTimestampMs_;
    public long NextEquipChangeAllowedTimestampMs {
      get { return nextEquipChangeAllowedTimestampMs_; }
      set {
        nextEquipChangeAllowedTimestampMs_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as EquippedBadge);
    }

    public bool Equals(EquippedBadge other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BadgeType != other.BadgeType) return false;
      if (Level != other.Level) return false;
      if (NextEquipChangeAllowedTimestampMs != other.NextEquipChangeAllowedTimestampMs) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (BadgeType != 0) hash ^= BadgeType.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (NextEquipChangeAllowedTimestampMs != 0L) hash ^= NextEquipChangeAllowedTimestampMs.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (BadgeType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) BadgeType);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Level);
      }
      if (NextEquipChangeAllowedTimestampMs != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(NextEquipChangeAllowedTimestampMs);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (BadgeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BadgeType);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (NextEquipChangeAllowedTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextEquipChangeAllowedTimestampMs);
      }
      return size;
    }

    public void MergeFrom(EquippedBadge other) {
      if (other == null) {
        return;
      }
      if (other.BadgeType != 0) {
        BadgeType = other.BadgeType;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.NextEquipChangeAllowedTimestampMs != 0L) {
        NextEquipChangeAllowedTimestampMs = other.NextEquipChangeAllowedTimestampMs;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            badgeType_ = (global::Enums.BadgeType) input.ReadEnum();
            break;
          }
          case 16: {
            Level = input.ReadInt32();
            break;
          }
          case 24: {
            NextEquipChangeAllowedTimestampMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
