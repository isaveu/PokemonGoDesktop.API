// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/UseItemReviveMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/UseItemReviveMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UseItemReviveMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/UseItemReviveMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemReviveMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdOZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1VzZUl0ZW1SZXZpdmVN",
            "ZXNzYWdlLnByb3RvEhxOZXR3b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzGhZJ",
            "bnZlbnRvcnkvSXRlbUlkLnByb3RvIk4KFFVzZUl0ZW1SZXZpdmVNZXNzYWdl",
            "EiIKB2l0ZW1faWQYASABKA4yES5JbnZlbnRvcnkuSXRlbUlkEhIKCnBva2Vt",
            "b25faWQYAiABKARCHaoCGlBva2Vtb25Hb0Rlc2t0b3AuQVBJLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.UseItemReviveMessage), global::PokemonGoDesktop.API.Proto.UseItemReviveMessage.Parser, new[]{ "ItemId", "PokemonId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UseItemReviveMessage : pb::IMessage<UseItemReviveMessage> {
    private static readonly pb::MessageParser<UseItemReviveMessage> _parser = new pb::MessageParser<UseItemReviveMessage>(() => new UseItemReviveMessage());
    public static pb::MessageParser<UseItemReviveMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.UseItemReviveMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UseItemReviveMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UseItemReviveMessage(UseItemReviveMessage other) : this() {
      itemId_ = other.itemId_;
      pokemonId_ = other.pokemonId_;
    }

    public UseItemReviveMessage Clone() {
      return new UseItemReviveMessage(this);
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
      return Equals(other as UseItemReviveMessage);
    }

    public bool Equals(UseItemReviveMessage other) {
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

    public void MergeFrom(UseItemReviveMessage other) {
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
