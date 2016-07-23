// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/FortRecallPokemonResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Responses/FortRecallPokemonResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FortRecallPokemonResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/FortRecallPokemonResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortRecallPokemonResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjROZXR3b3JraW5nL1Jlc3BvbnNlcy9Gb3J0UmVjYWxsUG9rZW1vblJlc3Bv",
            "bnNlLnByb3RvEhROZXR3b3JraW5nLlJlc3BvbnNlcxouTmV0d29ya2luZy9S",
            "ZXNwb25zZXMvRm9ydERldGFpbHNSZXNwb25zZS5wcm90byKaAgoZRm9ydFJl",
            "Y2FsbFBva2Vtb25SZXNwb25zZRJGCgZyZXN1bHQYASABKA4yNi5OZXR3b3Jr",
            "aW5nLlJlc3BvbnNlcy5Gb3J0UmVjYWxsUG9rZW1vblJlc3BvbnNlLlJlc3Vs",
            "dBI/Cgxmb3J0X2RldGFpbHMYAiABKAsyKS5OZXR3b3JraW5nLlJlc3BvbnNl",
            "cy5Gb3J0RGV0YWlsc1Jlc3BvbnNlInQKBlJlc3VsdBIRCg1OT19SRVNVTFRf",
            "U0VUEAASCwoHU1VDQ0VTUxABEhYKEkVSUk9SX05PVF9JTl9SQU5HRRACEh0K",
            "GUVSUk9SX1BPS0VNT05fTk9UX09OX0ZPUlQQAxITCg9FUlJPUl9OT19QTEFZ",
            "RVIQBEIdqgIaUG9rZW1vbkdvRGVza3RvcC5BUEkuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.FortDetailsResponseReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.FortRecallPokemonResponse), global::PokemonGoDesktop.API.Proto.FortRecallPokemonResponse.Parser, new[]{ "Result", "FortDetails" }, null, new[]{ typeof(global::PokemonGoDesktop.API.Proto.FortRecallPokemonResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FortRecallPokemonResponse : pb::IMessage<FortRecallPokemonResponse> {
    private static readonly pb::MessageParser<FortRecallPokemonResponse> _parser = new pb::MessageParser<FortRecallPokemonResponse>(() => new FortRecallPokemonResponse());
    public static pb::MessageParser<FortRecallPokemonResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.FortRecallPokemonResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FortRecallPokemonResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FortRecallPokemonResponse(FortRecallPokemonResponse other) : this() {
      result_ = other.result_;
      FortDetails = other.fortDetails_ != null ? other.FortDetails.Clone() : null;
    }

    public FortRecallPokemonResponse Clone() {
      return new FortRecallPokemonResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.FortRecallPokemonResponse.Types.Result result_ = 0;
    public global::PokemonGoDesktop.API.Proto.FortRecallPokemonResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "fort_details" field.</summary>
    public const int FortDetailsFieldNumber = 2;
    private global::PokemonGoDesktop.API.Proto.FortDetailsResponse fortDetails_;
    public global::PokemonGoDesktop.API.Proto.FortDetailsResponse FortDetails {
      get { return fortDetails_; }
      set {
        fortDetails_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FortRecallPokemonResponse);
    }

    public bool Equals(FortRecallPokemonResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(FortDetails, other.FortDetails)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (fortDetails_ != null) hash ^= FortDetails.GetHashCode();
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
      if (fortDetails_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(FortDetails);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (fortDetails_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortDetails);
      }
      return size;
    }

    public void MergeFrom(FortRecallPokemonResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.fortDetails_ != null) {
        if (fortDetails_ == null) {
          fortDetails_ = new global::PokemonGoDesktop.API.Proto.FortDetailsResponse();
        }
        FortDetails.MergeFrom(other.FortDetails);
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
            result_ = (global::PokemonGoDesktop.API.Proto.FortRecallPokemonResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (fortDetails_ == null) {
              fortDetails_ = new global::PokemonGoDesktop.API.Proto.FortDetailsResponse();
            }
            input.ReadMessage(fortDetails_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the FortRecallPokemonResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("NO_RESULT_SET")] NoResultSet = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 2,
        [pbr::OriginalName("ERROR_POKEMON_NOT_ON_FORT")] ErrorPokemonNotOnFort = 3,
        [pbr::OriginalName("ERROR_NO_PLAYER")] ErrorNoPlayer = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
