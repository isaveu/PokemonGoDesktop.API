// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/UseItemGymResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Responses {

  /// <summary>Holder for reflection information generated from Networking/Responses/UseItemGymResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UseItemGymResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/UseItemGymResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemGymResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1OZXR3b3JraW5nL1Jlc3BvbnNlcy9Vc2VJdGVtR3ltUmVzcG9uc2UucHJv",
            "dG8SFE5ldHdvcmtpbmcuUmVzcG9uc2VzIrkBChJVc2VJdGVtR3ltUmVzcG9u",
            "c2USPwoGcmVzdWx0GAEgASgOMi8uTmV0d29ya2luZy5SZXNwb25zZXMuVXNl",
            "SXRlbUd5bVJlc3BvbnNlLlJlc3VsdBISCgp1cGRhdGVkX2dwGAIgASgDIk4K",
            "BlJlc3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIUChBFUlJPUl9DQU5O",
            "T1RfVVNFEAISFgoSRVJST1JfTk9UX0lOX1JBTkdFEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Responses.UseItemGymResponse), global::Networking.Responses.UseItemGymResponse.Parser, new[]{ "Result", "UpdatedGp" }, null, new[]{ typeof(global::Networking.Responses.UseItemGymResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UseItemGymResponse : pb::IMessage<UseItemGymResponse> {
    private static readonly pb::MessageParser<UseItemGymResponse> _parser = new pb::MessageParser<UseItemGymResponse>(() => new UseItemGymResponse());
    public static pb::MessageParser<UseItemGymResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Responses.UseItemGymResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UseItemGymResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UseItemGymResponse(UseItemGymResponse other) : this() {
      result_ = other.result_;
      updatedGp_ = other.updatedGp_;
    }

    public UseItemGymResponse Clone() {
      return new UseItemGymResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Networking.Responses.UseItemGymResponse.Types.Result result_ = 0;
    public global::Networking.Responses.UseItemGymResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "updated_gp" field.</summary>
    public const int UpdatedGpFieldNumber = 2;
    private long updatedGp_;
    /// <summary>
    ///  Gym Points (?)
    /// </summary>
    public long UpdatedGp {
      get { return updatedGp_; }
      set {
        updatedGp_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UseItemGymResponse);
    }

    public bool Equals(UseItemGymResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (UpdatedGp != other.UpdatedGp) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (UpdatedGp != 0L) hash ^= UpdatedGp.GetHashCode();
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
      if (UpdatedGp != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(UpdatedGp);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (UpdatedGp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UpdatedGp);
      }
      return size;
    }

    public void MergeFrom(UseItemGymResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.UpdatedGp != 0L) {
        UpdatedGp = other.UpdatedGp;
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
            result_ = (global::Networking.Responses.UseItemGymResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            UpdatedGp = input.ReadInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseItemGymResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_CANNOT_USE")] ErrorCannotUse = 2,
        [pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
