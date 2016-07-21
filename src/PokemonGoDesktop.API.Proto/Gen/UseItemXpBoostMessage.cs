// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/UseItemXpBoostMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/UseItemXpBoostMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UseItemXpBoostMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/UseItemXpBoostMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemXpBoostMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhOZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1VzZUl0ZW1YcEJvb3N0",
            "TWVzc2FnZS5wcm90bxIcTmV0d29ya2luZy5SZXF1ZXN0cy5NZXNzYWdlcxoW",
            "SW52ZW50b3J5L0l0ZW1JZC5wcm90byI7ChVVc2VJdGVtWHBCb29zdE1lc3Nh",
            "Z2USIgoHaXRlbV9pZBgBIAEoDjIRLkludmVudG9yeS5JdGVtSWRiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Inventory.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Requests.Messages.UseItemXpBoostMessage), global::Networking.Requests.Messages.UseItemXpBoostMessage.Parser, new[]{ "ItemId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UseItemXpBoostMessage : pb::IMessage<UseItemXpBoostMessage> {
    private static readonly pb::MessageParser<UseItemXpBoostMessage> _parser = new pb::MessageParser<UseItemXpBoostMessage>(() => new UseItemXpBoostMessage());
    public static pb::MessageParser<UseItemXpBoostMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Requests.Messages.UseItemXpBoostMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UseItemXpBoostMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UseItemXpBoostMessage(UseItemXpBoostMessage other) : this() {
      itemId_ = other.itemId_;
    }

    public UseItemXpBoostMessage Clone() {
      return new UseItemXpBoostMessage(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::Inventory.ItemId itemId_ = 0;
    public global::Inventory.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UseItemXpBoostMessage);
    }

    public bool Equals(UseItemXpBoostMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      return size;
    }

    public void MergeFrom(UseItemXpBoostMessage other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
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
            itemId_ = (global::Inventory.ItemId) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
