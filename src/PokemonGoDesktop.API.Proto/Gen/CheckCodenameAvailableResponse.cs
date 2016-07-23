// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/CheckCodenameAvailableResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Responses/CheckCodenameAvailableResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CheckCodenameAvailableResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/CheckCodenameAvailableResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckCodenameAvailableResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjlOZXR3b3JraW5nL1Jlc3BvbnNlcy9DaGVja0NvZGVuYW1lQXZhaWxhYmxl",
            "UmVzcG9uc2UucHJvdG8SFE5ldHdvcmtpbmcuUmVzcG9uc2VzIrcCCh5DaGVj",
            "a0NvZGVuYW1lQXZhaWxhYmxlUmVzcG9uc2USEAoIY29kZW5hbWUYASABKAkS",
            "FAoMdXNlcl9tZXNzYWdlGAIgASgJEhUKDWlzX2Fzc2lnbmFibGUYAyABKAgS",
            "SwoGc3RhdHVzGAQgASgOMjsuTmV0d29ya2luZy5SZXNwb25zZXMuQ2hlY2tD",
            "b2RlbmFtZUF2YWlsYWJsZVJlc3BvbnNlLlN0YXR1cyKIAQoGU3RhdHVzEgkK",
            "BVVOU0VUEAASCwoHU1VDQ0VTUxABEhoKFkNPREVOQU1FX05PVF9BVkFJTEFC",
            "TEUQAhIWChJDT0RFTkFNRV9OT1RfVkFMSUQQAxIRCg1DVVJSRU5UX09XTkVS",
            "EAQSHwobQ09ERU5BTUVfQ0hBTkdFX05PVF9BTExPV0VEEAVCHaoCGlBva2Vt",
            "b25Hb0Rlc2t0b3AuQVBJLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.CheckCodenameAvailableResponse), global::PokemonGoDesktop.API.Proto.CheckCodenameAvailableResponse.Parser, new[]{ "Codename", "UserMessage", "IsAssignable", "Status" }, null, new[]{ typeof(global::PokemonGoDesktop.API.Proto.CheckCodenameAvailableResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  TODO: Might be incorrect, please test.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CheckCodenameAvailableResponse : pb::IMessage<CheckCodenameAvailableResponse> {
    private static readonly pb::MessageParser<CheckCodenameAvailableResponse> _parser = new pb::MessageParser<CheckCodenameAvailableResponse>(() => new CheckCodenameAvailableResponse());
    public static pb::MessageParser<CheckCodenameAvailableResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.CheckCodenameAvailableResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CheckCodenameAvailableResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CheckCodenameAvailableResponse(CheckCodenameAvailableResponse other) : this() {
      codename_ = other.codename_;
      userMessage_ = other.userMessage_;
      isAssignable_ = other.isAssignable_;
      status_ = other.status_;
    }

    public CheckCodenameAvailableResponse Clone() {
      return new CheckCodenameAvailableResponse(this);
    }

    /// <summary>Field number for the "codename" field.</summary>
    public const int CodenameFieldNumber = 1;
    private string codename_ = "";
    public string Codename {
      get { return codename_; }
      set {
        codename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_message" field.</summary>
    public const int UserMessageFieldNumber = 2;
    private string userMessage_ = "";
    public string UserMessage {
      get { return userMessage_; }
      set {
        userMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_assignable" field.</summary>
    public const int IsAssignableFieldNumber = 3;
    private bool isAssignable_;
    public bool IsAssignable {
      get { return isAssignable_; }
      set {
        isAssignable_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::PokemonGoDesktop.API.Proto.CheckCodenameAvailableResponse.Types.Status status_ = 0;
    public global::PokemonGoDesktop.API.Proto.CheckCodenameAvailableResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CheckCodenameAvailableResponse);
    }

    public bool Equals(CheckCodenameAvailableResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Codename != other.Codename) return false;
      if (UserMessage != other.UserMessage) return false;
      if (IsAssignable != other.IsAssignable) return false;
      if (Status != other.Status) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Codename.Length != 0) hash ^= Codename.GetHashCode();
      if (UserMessage.Length != 0) hash ^= UserMessage.GetHashCode();
      if (IsAssignable != false) hash ^= IsAssignable.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Codename.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Codename);
      }
      if (UserMessage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserMessage);
      }
      if (IsAssignable != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsAssignable);
      }
      if (Status != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Codename.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Codename);
      }
      if (UserMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserMessage);
      }
      if (IsAssignable != false) {
        size += 1 + 1;
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      return size;
    }

    public void MergeFrom(CheckCodenameAvailableResponse other) {
      if (other == null) {
        return;
      }
      if (other.Codename.Length != 0) {
        Codename = other.Codename;
      }
      if (other.UserMessage.Length != 0) {
        UserMessage = other.UserMessage;
      }
      if (other.IsAssignable != false) {
        IsAssignable = other.IsAssignable;
      }
      if (other.Status != 0) {
        Status = other.Status;
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
            Codename = input.ReadString();
            break;
          }
          case 18: {
            UserMessage = input.ReadString();
            break;
          }
          case 24: {
            IsAssignable = input.ReadBool();
            break;
          }
          case 32: {
            status_ = (global::PokemonGoDesktop.API.Proto.CheckCodenameAvailableResponse.Types.Status) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CheckCodenameAvailableResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("CODENAME_NOT_AVAILABLE")] CodenameNotAvailable = 2,
        [pbr::OriginalName("CODENAME_NOT_VALID")] CodenameNotValid = 3,
        [pbr::OriginalName("CURRENT_OWNER")] CurrentOwner = 4,
        [pbr::OriginalName("CODENAME_CHANGE_NOT_ALLOWED")] CodenameChangeNotAllowed = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
