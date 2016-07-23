// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/Item.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Inventory/Item.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ItemReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/Item.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRJbnZlbnRvcnkvSXRlbS5wcm90bxIJSW52ZW50b3J5GhZJbnZlbnRvcnkv",
            "SXRlbUlkLnByb3RvIkkKBEl0ZW0SIgoHaXRlbV9pZBgBIAEoDjIRLkludmVu",
            "dG9yeS5JdGVtSWQSDQoFY291bnQYAiABKAUSDgoGdW5zZWVuGAMgASgIQh2q",
            "AhpQb2tlbW9uR29EZXNrdG9wLkFQSS5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.Item), global::PokemonGoDesktop.API.Proto.Item.Parser, new[]{ "ItemId", "Count", "Unseen" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Item : pb::IMessage<Item> {
    private static readonly pb::MessageParser<Item> _parser = new pb::MessageParser<Item>(() => new Item());
    public static pb::MessageParser<Item> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.ItemReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Item() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Item(Item other) : this() {
      itemId_ = other.itemId_;
      count_ = other.count_;
      unseen_ = other.unseen_;
    }

    public Item Clone() {
      return new Item(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.ItemId itemId_ = 0;
    public global::PokemonGoDesktop.API.Proto.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 2;
    private int count_;
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "unseen" field.</summary>
    public const int UnseenFieldNumber = 3;
    private bool unseen_;
    public bool Unseen {
      get { return unseen_; }
      set {
        unseen_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Item);
    }

    public bool Equals(Item other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (Count != other.Count) return false;
      if (Unseen != other.Unseen) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      if (Unseen != false) hash ^= Unseen.GetHashCode();
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
      if (Count != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Count);
      }
      if (Unseen != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unseen);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      if (Unseen != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(Item other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.Unseen != false) {
        Unseen = other.Unseen;
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
            itemId_ = (global::PokemonGoDesktop.API.Proto.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            Count = input.ReadInt32();
            break;
          }
          case 24: {
            Unseen = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
