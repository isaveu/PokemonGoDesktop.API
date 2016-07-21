// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/DownloadRemoteConfigVersionResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Responses {

  /// <summary>Holder for reflection information generated from Networking/Responses/DownloadRemoteConfigVersionResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class DownloadRemoteConfigVersionResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/DownloadRemoteConfigVersionResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DownloadRemoteConfigVersionResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5OZXR3b3JraW5nL1Jlc3BvbnNlcy9Eb3dubG9hZFJlbW90ZUNvbmZpZ1Zl",
            "cnNpb25SZXNwb25zZS5wcm90bxIUTmV0d29ya2luZy5SZXNwb25zZXMi4QEK",
            "I0Rvd25sb2FkUmVtb3RlQ29uZmlnVmVyc2lvblJlc3BvbnNlElAKBnJlc3Vs",
            "dBgBIAEoDjJALk5ldHdvcmtpbmcuUmVzcG9uc2VzLkRvd25sb2FkUmVtb3Rl",
            "Q29uZmlnVmVyc2lvblJlc3BvbnNlLlJlc3VsdBIjChtpdGVtX3RlbXBsYXRl",
            "c190aW1lc3RhbXBfbXMYAiABKAQSIQoZYXNzZXRfZGlnZXN0X3RpbWVzdGFt",
            "cF9tcxgDIAEoBCIgCgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNTEAFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Responses.DownloadRemoteConfigVersionResponse), global::Networking.Responses.DownloadRemoteConfigVersionResponse.Parser, new[]{ "Result", "ItemTemplatesTimestampMs", "AssetDigestTimestampMs" }, null, new[]{ typeof(global::Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DownloadRemoteConfigVersionResponse : pb::IMessage<DownloadRemoteConfigVersionResponse> {
    private static readonly pb::MessageParser<DownloadRemoteConfigVersionResponse> _parser = new pb::MessageParser<DownloadRemoteConfigVersionResponse>(() => new DownloadRemoteConfigVersionResponse());
    public static pb::MessageParser<DownloadRemoteConfigVersionResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Responses.DownloadRemoteConfigVersionResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DownloadRemoteConfigVersionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DownloadRemoteConfigVersionResponse(DownloadRemoteConfigVersionResponse other) : this() {
      result_ = other.result_;
      itemTemplatesTimestampMs_ = other.itemTemplatesTimestampMs_;
      assetDigestTimestampMs_ = other.assetDigestTimestampMs_;
    }

    public DownloadRemoteConfigVersionResponse Clone() {
      return new DownloadRemoteConfigVersionResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result result_ = 0;
    public global::Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "item_templates_timestamp_ms" field.</summary>
    public const int ItemTemplatesTimestampMsFieldNumber = 2;
    private ulong itemTemplatesTimestampMs_;
    /// <summary>
    ///  Latest available?
    /// </summary>
    public ulong ItemTemplatesTimestampMs {
      get { return itemTemplatesTimestampMs_; }
      set {
        itemTemplatesTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "asset_digest_timestamp_ms" field.</summary>
    public const int AssetDigestTimestampMsFieldNumber = 3;
    private ulong assetDigestTimestampMs_;
    public ulong AssetDigestTimestampMs {
      get { return assetDigestTimestampMs_; }
      set {
        assetDigestTimestampMs_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DownloadRemoteConfigVersionResponse);
    }

    public bool Equals(DownloadRemoteConfigVersionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (ItemTemplatesTimestampMs != other.ItemTemplatesTimestampMs) return false;
      if (AssetDigestTimestampMs != other.AssetDigestTimestampMs) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (ItemTemplatesTimestampMs != 0UL) hash ^= ItemTemplatesTimestampMs.GetHashCode();
      if (AssetDigestTimestampMs != 0UL) hash ^= AssetDigestTimestampMs.GetHashCode();
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
      if (ItemTemplatesTimestampMs != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ItemTemplatesTimestampMs);
      }
      if (AssetDigestTimestampMs != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(AssetDigestTimestampMs);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (ItemTemplatesTimestampMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ItemTemplatesTimestampMs);
      }
      if (AssetDigestTimestampMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AssetDigestTimestampMs);
      }
      return size;
    }

    public void MergeFrom(DownloadRemoteConfigVersionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.ItemTemplatesTimestampMs != 0UL) {
        ItemTemplatesTimestampMs = other.ItemTemplatesTimestampMs;
      }
      if (other.AssetDigestTimestampMs != 0UL) {
        AssetDigestTimestampMs = other.AssetDigestTimestampMs;
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
            result_ = (global::Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            ItemTemplatesTimestampMs = input.ReadUInt64();
            break;
          }
          case 24: {
            AssetDigestTimestampMs = input.ReadUInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DownloadRemoteConfigVersionResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
