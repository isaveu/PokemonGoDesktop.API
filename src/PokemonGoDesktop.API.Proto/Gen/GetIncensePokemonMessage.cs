// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/GetIncensePokemonMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/GetIncensePokemonMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GetIncensePokemonMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/GetIncensePokemonMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetIncensePokemonMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtOZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0dldEluY2Vuc2VQb2tl",
            "bW9uTWVzc2FnZS5wcm90bxIcTmV0d29ya2luZy5SZXF1ZXN0cy5NZXNzYWdl",
            "cyJNChhHZXRJbmNlbnNlUG9rZW1vbk1lc3NhZ2USFwoPcGxheWVyX2xhdGl0",
            "dWRlGAEgASgBEhgKEHBsYXllcl9sb25naXR1ZGUYAiABKAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Requests.Messages.GetIncensePokemonMessage), global::Networking.Requests.Messages.GetIncensePokemonMessage.Parser, new[]{ "PlayerLatitude", "PlayerLongitude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetIncensePokemonMessage : pb::IMessage<GetIncensePokemonMessage> {
    private static readonly pb::MessageParser<GetIncensePokemonMessage> _parser = new pb::MessageParser<GetIncensePokemonMessage>(() => new GetIncensePokemonMessage());
    public static pb::MessageParser<GetIncensePokemonMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Requests.Messages.GetIncensePokemonMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetIncensePokemonMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetIncensePokemonMessage(GetIncensePokemonMessage other) : this() {
      playerLatitude_ = other.playerLatitude_;
      playerLongitude_ = other.playerLongitude_;
    }

    public GetIncensePokemonMessage Clone() {
      return new GetIncensePokemonMessage(this);
    }

    /// <summary>Field number for the "player_latitude" field.</summary>
    public const int PlayerLatitudeFieldNumber = 1;
    private double playerLatitude_;
    public double PlayerLatitude {
      get { return playerLatitude_; }
      set {
        playerLatitude_ = value;
      }
    }

    /// <summary>Field number for the "player_longitude" field.</summary>
    public const int PlayerLongitudeFieldNumber = 2;
    private double playerLongitude_;
    public double PlayerLongitude {
      get { return playerLongitude_; }
      set {
        playerLongitude_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetIncensePokemonMessage);
    }

    public bool Equals(GetIncensePokemonMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerLatitude != other.PlayerLatitude) return false;
      if (PlayerLongitude != other.PlayerLongitude) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (PlayerLatitude != 0D) hash ^= PlayerLatitude.GetHashCode();
      if (PlayerLongitude != 0D) hash ^= PlayerLongitude.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerLatitude != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(PlayerLatitude);
      }
      if (PlayerLongitude != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(PlayerLongitude);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (PlayerLatitude != 0D) {
        size += 1 + 8;
      }
      if (PlayerLongitude != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(GetIncensePokemonMessage other) {
      if (other == null) {
        return;
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
          case 9: {
            PlayerLatitude = input.ReadDouble();
            break;
          }
          case 17: {
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
