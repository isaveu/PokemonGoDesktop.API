// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/SetFavoritePokemonMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/SetFavoritePokemonMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class SetFavoritePokemonMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/SetFavoritePokemonMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetFavoritePokemonMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxOZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1NldEZhdm9yaXRlUG9r",
            "ZW1vbk1lc3NhZ2UucHJvdG8SHE5ldHdvcmtpbmcuUmVxdWVzdHMuTWVzc2Fn",
            "ZXMiRAoZU2V0RmF2b3JpdGVQb2tlbW9uTWVzc2FnZRISCgpwb2tlbW9uX2lk",
            "GAEgASgEEhMKC2lzX2Zhdm9yaXRlGAIgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Requests.Messages.SetFavoritePokemonMessage), global::Networking.Requests.Messages.SetFavoritePokemonMessage.Parser, new[]{ "PokemonId", "IsFavorite" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SetFavoritePokemonMessage : pb::IMessage<SetFavoritePokemonMessage> {
    private static readonly pb::MessageParser<SetFavoritePokemonMessage> _parser = new pb::MessageParser<SetFavoritePokemonMessage>(() => new SetFavoritePokemonMessage());
    public static pb::MessageParser<SetFavoritePokemonMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Requests.Messages.SetFavoritePokemonMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SetFavoritePokemonMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SetFavoritePokemonMessage(SetFavoritePokemonMessage other) : this() {
      pokemonId_ = other.pokemonId_;
      isFavorite_ = other.isFavorite_;
    }

    public SetFavoritePokemonMessage Clone() {
      return new SetFavoritePokemonMessage(this);
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 1;
    private ulong pokemonId_;
    public ulong PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "is_favorite" field.</summary>
    public const int IsFavoriteFieldNumber = 2;
    private bool isFavorite_;
    public bool IsFavorite {
      get { return isFavorite_; }
      set {
        isFavorite_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SetFavoritePokemonMessage);
    }

    public bool Equals(SetFavoritePokemonMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonId != other.PokemonId) return false;
      if (IsFavorite != other.IsFavorite) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (PokemonId != 0UL) hash ^= PokemonId.GetHashCode();
      if (IsFavorite != false) hash ^= IsFavorite.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PokemonId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(PokemonId);
      }
      if (IsFavorite != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsFavorite);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (PokemonId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PokemonId);
      }
      if (IsFavorite != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(SetFavoritePokemonMessage other) {
      if (other == null) {
        return;
      }
      if (other.PokemonId != 0UL) {
        PokemonId = other.PokemonId;
      }
      if (other.IsFavorite != false) {
        IsFavorite = other.IsFavorite;
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
            PokemonId = input.ReadUInt64();
            break;
          }
          case 16: {
            IsFavorite = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
