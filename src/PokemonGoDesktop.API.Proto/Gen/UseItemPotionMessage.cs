// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/UseItemPotionMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/UseItemPotionMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UseItemPotionMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/UseItemPotionMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemPotionMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdOZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1VzZUl0ZW1Qb3Rpb25N",
            "ZXNzYWdlLnByb3RvEhxOZXR3b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzGhtJ",
            "bnZlbnRvcnkvSXRlbS9JdGVtSWQucHJvdG8iUwoUVXNlSXRlbVBvdGlvbk1l",
            "c3NhZ2USJwoHaXRlbV9pZBgBIAEoDjIWLkludmVudG9yeS5JdGVtLkl0ZW1J",
            "ZBISCgpwb2tlbW9uX2lkGAIgASgEQh2qAhpQb2tlbW9uR29EZXNrdG9wLkFQ",
            "SS5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.UseItemPotionMessage), global::PokemonGoDesktop.API.Proto.UseItemPotionMessage.Parser, new[]{ "ItemId", "PokemonId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UseItemPotionMessage : pb::IMessage<UseItemPotionMessage> {
    private static readonly pb::MessageParser<UseItemPotionMessage> _parser = new pb::MessageParser<UseItemPotionMessage>(() => new UseItemPotionMessage());
    public static pb::MessageParser<UseItemPotionMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.UseItemPotionMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UseItemPotionMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UseItemPotionMessage(UseItemPotionMessage other) : this() {
      itemId_ = other.itemId_;
      pokemonId_ = other.pokemonId_;
    }

    public UseItemPotionMessage Clone() {
      return new UseItemPotionMessage(this);
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

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 2;
    private ulong pokemonId_;
    public ulong PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UseItemPotionMessage);
    }

    public bool Equals(UseItemPotionMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (PokemonId != other.PokemonId) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (PokemonId != 0UL) hash ^= PokemonId.GetHashCode();
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
      if (PokemonId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(PokemonId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (PokemonId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PokemonId);
      }
      return size;
    }

    public void MergeFrom(UseItemPotionMessage other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.PokemonId != 0UL) {
        PokemonId = other.PokemonId;
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
            PokemonId = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
