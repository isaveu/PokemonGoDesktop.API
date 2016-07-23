// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/LevelUpRewardsMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/LevelUpRewardsMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class LevelUpRewardsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/LevelUpRewardsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LevelUpRewardsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhOZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0xldmVsVXBSZXdhcmRz",
            "TWVzc2FnZS5wcm90bxIcTmV0d29ya2luZy5SZXF1ZXN0cy5NZXNzYWdlcyIm",
            "ChVMZXZlbFVwUmV3YXJkc01lc3NhZ2USDQoFbGV2ZWwYASABKAVCHaoCGlBv",
            "a2Vtb25Hb0Rlc2t0b3AuQVBJLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.LevelUpRewardsMessage), global::PokemonGoDesktop.API.Proto.LevelUpRewardsMessage.Parser, new[]{ "Level" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class LevelUpRewardsMessage : pb::IMessage<LevelUpRewardsMessage> {
    private static readonly pb::MessageParser<LevelUpRewardsMessage> _parser = new pb::MessageParser<LevelUpRewardsMessage>(() => new LevelUpRewardsMessage());
    public static pb::MessageParser<LevelUpRewardsMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.LevelUpRewardsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public LevelUpRewardsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public LevelUpRewardsMessage(LevelUpRewardsMessage other) : this() {
      level_ = other.level_;
    }

    public LevelUpRewardsMessage Clone() {
      return new LevelUpRewardsMessage(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private int level_;
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as LevelUpRewardsMessage);
    }

    public bool Equals(LevelUpRewardsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Level);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      return size;
    }

    public void MergeFrom(LevelUpRewardsMessage other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
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
            Level = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
