// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/UseItemGymMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/UseItemGymMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UseItemGymMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/UseItemGymMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemGymMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjROZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1VzZUl0ZW1HeW1NZXNz",
            "YWdlLnByb3RvEhxOZXR3b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzGhZJbnZl",
            "bnRvcnkvSXRlbUlkLnByb3RvInoKEVVzZUl0ZW1HeW1NZXNzYWdlEiIKB2l0",
            "ZW1faWQYASABKA4yES5JbnZlbnRvcnkuSXRlbUlkEg4KBmd5bV9pZBgCIAEo",
            "CRIXCg9wbGF5ZXJfbGF0aXR1ZGUYAyABKAESGAoQcGxheWVyX2xvbmdpdHVk",
            "ZRgEIAEoAUIdqgIaUG9rZW1vbkdvRGVza3RvcC5BUEkuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.UseItemGymMessage), global::PokemonGoDesktop.API.Proto.UseItemGymMessage.Parser, new[]{ "ItemId", "GymId", "PlayerLatitude", "PlayerLongitude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UseItemGymMessage : pb::IMessage<UseItemGymMessage> {
    private static readonly pb::MessageParser<UseItemGymMessage> _parser = new pb::MessageParser<UseItemGymMessage>(() => new UseItemGymMessage());
    public static pb::MessageParser<UseItemGymMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.UseItemGymMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UseItemGymMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UseItemGymMessage(UseItemGymMessage other) : this() {
      itemId_ = other.itemId_;
      gymId_ = other.gymId_;
      playerLatitude_ = other.playerLatitude_;
      playerLongitude_ = other.playerLongitude_;
    }

    public UseItemGymMessage Clone() {
      return new UseItemGymMessage(this);
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

    /// <summary>Field number for the "gym_id" field.</summary>
    public const int GymIdFieldNumber = 2;
    private string gymId_ = "";
    public string GymId {
      get { return gymId_; }
      set {
        gymId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "player_latitude" field.</summary>
    public const int PlayerLatitudeFieldNumber = 3;
    private double playerLatitude_;
    public double PlayerLatitude {
      get { return playerLatitude_; }
      set {
        playerLatitude_ = value;
      }
    }

    /// <summary>Field number for the "player_longitude" field.</summary>
    public const int PlayerLongitudeFieldNumber = 4;
    private double playerLongitude_;
    public double PlayerLongitude {
      get { return playerLongitude_; }
      set {
        playerLongitude_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UseItemGymMessage);
    }

    public bool Equals(UseItemGymMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (GymId != other.GymId) return false;
      if (PlayerLatitude != other.PlayerLatitude) return false;
      if (PlayerLongitude != other.PlayerLongitude) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (GymId.Length != 0) hash ^= GymId.GetHashCode();
      if (PlayerLatitude != 0D) hash ^= PlayerLatitude.GetHashCode();
      if (PlayerLongitude != 0D) hash ^= PlayerLongitude.GetHashCode();
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
      if (GymId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GymId);
      }
      if (PlayerLatitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(PlayerLatitude);
      }
      if (PlayerLongitude != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(PlayerLongitude);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (GymId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GymId);
      }
      if (PlayerLatitude != 0D) {
        size += 1 + 8;
      }
      if (PlayerLongitude != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(UseItemGymMessage other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.GymId.Length != 0) {
        GymId = other.GymId;
      }
      if (other.PlayerLatitude != 0D) {
        PlayerLatitude = other.PlayerLatitude;
      }
      if (other.PlayerLongitude != 0D) {
        PlayerLongitude = other.PlayerLongitude;
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
          case 18: {
            GymId = input.ReadString();
            break;
          }
          case 25: {
            PlayerLatitude = input.ReadDouble();
            break;
          }
          case 33: {
            PlayerLongitude = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
