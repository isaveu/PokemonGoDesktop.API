// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/UseIncenseResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Responses {

  /// <summary>Holder for reflection information generated from Networking/Responses/UseIncenseResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UseIncenseResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/UseIncenseResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseIncenseResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1OZXR3b3JraW5nL1Jlc3BvbnNlcy9Vc2VJbmNlbnNlUmVzcG9uc2UucHJv",
            "dG8SFE5ldHdvcmtpbmcuUmVzcG9uc2VzGhtJbnZlbnRvcnkvQXBwbGllZEl0",
            "ZW0ucHJvdG8i8QEKElVzZUluY2Vuc2VSZXNwb25zZRI/CgZyZXN1bHQYASAB",
            "KA4yLy5OZXR3b3JraW5nLlJlc3BvbnNlcy5Vc2VJbmNlbnNlUmVzcG9uc2Uu",
            "UmVzdWx0Ei8KD2FwcGxpZWRfaW5jZW5zZRgCIAEoCzIWLkludmVudG9yeS5B",
            "cHBsaWVkSXRlbSJpCgZSZXN1bHQSCwoHVU5LTk9XThAAEgsKB1NVQ0NFU1MQ",
            "ARIaChZJTkNFTlNFX0FMUkVBRFlfQUNUSVZFEAISFQoRTk9ORV9JTl9JTlZF",
            "TlRPUlkQAxISCg5MT0NBVElPTl9VTlNFVBAEYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Inventory.AppliedItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Responses.UseIncenseResponse), global::Networking.Responses.UseIncenseResponse.Parser, new[]{ "Result", "AppliedIncense" }, null, new[]{ typeof(global::Networking.Responses.UseIncenseResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UseIncenseResponse : pb::IMessage<UseIncenseResponse> {
    private static readonly pb::MessageParser<UseIncenseResponse> _parser = new pb::MessageParser<UseIncenseResponse>(() => new UseIncenseResponse());
    public static pb::MessageParser<UseIncenseResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Responses.UseIncenseResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UseIncenseResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UseIncenseResponse(UseIncenseResponse other) : this() {
      result_ = other.result_;
      AppliedIncense = other.appliedIncense_ != null ? other.AppliedIncense.Clone() : null;
    }

    public UseIncenseResponse Clone() {
      return new UseIncenseResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Networking.Responses.UseIncenseResponse.Types.Result result_ = 0;
    public global::Networking.Responses.UseIncenseResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "applied_incense" field.</summary>
    public const int AppliedIncenseFieldNumber = 2;
    private global::Inventory.AppliedItem appliedIncense_;
    public global::Inventory.AppliedItem AppliedIncense {
      get { return appliedIncense_; }
      set {
        appliedIncense_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UseIncenseResponse);
    }

    public bool Equals(UseIncenseResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(AppliedIncense, other.AppliedIncense)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (appliedIncense_ != null) hash ^= AppliedIncense.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (appliedIncense_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AppliedIncense);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (appliedIncense_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppliedIncense);
      }
      return size;
    }

    public void MergeFrom(UseIncenseResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.appliedIncense_ != null) {
        if (appliedIncense_ == null) {
          appliedIncense_ = new global::Inventory.AppliedItem();
        }
        AppliedIncense.MergeFrom(other.AppliedIncense);
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
            result_ = (global::Networking.Responses.UseIncenseResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (appliedIncense_ == null) {
              appliedIncense_ = new global::Inventory.AppliedItem();
            }
            input.ReadMessage(appliedIncense_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseIncenseResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("INCENSE_ALREADY_ACTIVE")] IncenseAlreadyActive = 2,
        [pbr::OriginalName("NONE_IN_INVENTORY")] NoneInInventory = 3,
        [pbr::OriginalName("LOCATION_UNSET")] LocationUnset = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
