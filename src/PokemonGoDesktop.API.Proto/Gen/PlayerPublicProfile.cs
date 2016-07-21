// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data/Player/PlayerPublicProfile.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Data.Player {

  /// <summary>Holder for reflection information generated from Data/Player/PlayerPublicProfile.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PlayerPublicProfileReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/Player/PlayerPublicProfile.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerPublicProfileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVEYXRhL1BsYXllci9QbGF5ZXJQdWJsaWNQcm9maWxlLnByb3RvEgtEYXRh",
            "LlBsYXllchoeRGF0YS9QbGF5ZXIvUGxheWVyQXZhdGFyLnByb3RvIl0KE1Bs",
            "YXllclB1YmxpY1Byb2ZpbGUSDAoEbmFtZRgBIAEoCRINCgVsZXZlbBgCIAEo",
            "BRIpCgZhdmF0YXIYAyABKAsyGS5EYXRhLlBsYXllci5QbGF5ZXJBdmF0YXJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Data.Player.PlayerAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.Player.PlayerPublicProfile), global::Data.Player.PlayerPublicProfile.Parser, new[]{ "Name", "Level", "Avatar" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PlayerPublicProfile : pb::IMessage<PlayerPublicProfile> {
    private static readonly pb::MessageParser<PlayerPublicProfile> _parser = new pb::MessageParser<PlayerPublicProfile>(() => new PlayerPublicProfile());
    public static pb::MessageParser<PlayerPublicProfile> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.Player.PlayerPublicProfileReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PlayerPublicProfile() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PlayerPublicProfile(PlayerPublicProfile other) : this() {
      name_ = other.name_;
      level_ = other.level_;
      Avatar = other.avatar_ != null ? other.Avatar.Clone() : null;
    }

    public PlayerPublicProfile Clone() {
      return new PlayerPublicProfile(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "avatar" field.</summary>
    public const int AvatarFieldNumber = 3;
    private global::Data.Player.PlayerAvatar avatar_;
    public global::Data.Player.PlayerAvatar Avatar {
      get { return avatar_; }
      set {
        avatar_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PlayerPublicProfile);
    }

    public bool Equals(PlayerPublicProfile other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Level != other.Level) return false;
      if (!object.Equals(Avatar, other.Avatar)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (avatar_ != null) hash ^= Avatar.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Level);
      }
      if (avatar_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Avatar);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (avatar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Avatar);
      }
      return size;
    }

    public void MergeFrom(PlayerPublicProfile other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.avatar_ != null) {
        if (avatar_ == null) {
          avatar_ = new global::Data.Player.PlayerAvatar();
        }
        Avatar.MergeFrom(other.Avatar);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Level = input.ReadInt32();
            break;
          }
          case 26: {
            if (avatar_ == null) {
              avatar_ = new global::Data.Player.PlayerAvatar();
            }
            input.ReadMessage(avatar_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
