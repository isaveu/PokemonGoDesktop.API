// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/GetInventoryMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/GetInventoryMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GetInventoryMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/GetInventoryMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetInventoryMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZOZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0dldEludmVudG9yeU1l",
            "c3NhZ2UucHJvdG8SHE5ldHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMiSAoT",
            "R2V0SW52ZW50b3J5TWVzc2FnZRIZChFsYXN0X3RpbWVzdGFtcF9tcxgBIAEo",
            "AxIWCg5pdGVtX2JlZW5fc2VlbhgCIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Requests.Messages.GetInventoryMessage), global::Networking.Requests.Messages.GetInventoryMessage.Parser, new[]{ "LastTimestampMs", "ItemBeenSeen" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetInventoryMessage : pb::IMessage<GetInventoryMessage> {
    private static readonly pb::MessageParser<GetInventoryMessage> _parser = new pb::MessageParser<GetInventoryMessage>(() => new GetInventoryMessage());
    public static pb::MessageParser<GetInventoryMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Requests.Messages.GetInventoryMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetInventoryMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetInventoryMessage(GetInventoryMessage other) : this() {
      lastTimestampMs_ = other.lastTimestampMs_;
      itemBeenSeen_ = other.itemBeenSeen_;
    }

    public GetInventoryMessage Clone() {
      return new GetInventoryMessage(this);
    }

    /// <summary>Field number for the "last_timestamp_ms" field.</summary>
    public const int LastTimestampMsFieldNumber = 1;
    private long lastTimestampMs_;
    public long LastTimestampMs {
      get { return lastTimestampMs_; }
      set {
        lastTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "item_been_seen" field.</summary>
    public const int ItemBeenSeenFieldNumber = 2;
    private int itemBeenSeen_;
    /// <summary>
    ///  TODO: Find out what this is.
    /// </summary>
    public int ItemBeenSeen {
      get { return itemBeenSeen_; }
      set {
        itemBeenSeen_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetInventoryMessage);
    }

    public bool Equals(GetInventoryMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LastTimestampMs != other.LastTimestampMs) return false;
      if (ItemBeenSeen != other.ItemBeenSeen) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (LastTimestampMs != 0L) hash ^= LastTimestampMs.GetHashCode();
      if (ItemBeenSeen != 0) hash ^= ItemBeenSeen.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (LastTimestampMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(LastTimestampMs);
      }
      if (ItemBeenSeen != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ItemBeenSeen);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (LastTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastTimestampMs);
      }
      if (ItemBeenSeen != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ItemBeenSeen);
      }
      return size;
    }

    public void MergeFrom(GetInventoryMessage other) {
      if (other == null) {
        return;
      }
      if (other.LastTimestampMs != 0L) {
        LastTimestampMs = other.LastTimestampMs;
      }
      if (other.ItemBeenSeen != 0) {
        ItemBeenSeen = other.ItemBeenSeen;
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
            LastTimestampMs = input.ReadInt64();
            break;
          }
          case 16: {
            ItemBeenSeen = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
