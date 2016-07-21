// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/DiskEncounterResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Responses {

  /// <summary>Holder for reflection information generated from Networking/Responses/DiskEncounterResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class DiskEncounterResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/DiskEncounterResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DiskEncounterResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBOZXR3b3JraW5nL1Jlc3BvbnNlcy9EaXNrRW5jb3VudGVyUmVzcG9uc2Uu",
            "cHJvdG8SFE5ldHdvcmtpbmcuUmVzcG9uc2VzGhZEYXRhL1Bva2Vtb25EYXRh",
            "LnByb3RvGiVEYXRhL0NhcHR1cmUvQ2FwdHVyZVByb2JhYmlsaXR5LnByb3Rv",
            "IskCChVEaXNrRW5jb3VudGVyUmVzcG9uc2USQgoGcmVzdWx0GAEgASgOMjIu",
            "TmV0d29ya2luZy5SZXNwb25zZXMuRGlza0VuY291bnRlclJlc3BvbnNlLlJl",
            "c3VsdBInCgxwb2tlbW9uX2RhdGEYAiABKAsyES5EYXRhLlBva2Vtb25EYXRh",
            "Ej0KE2NhcHR1cmVfcHJvYmFiaWxpdHkYAyABKAsyIC5EYXRhLkNhcHR1cmUu",
            "Q2FwdHVyZVByb2JhYmlsaXR5IoMBCgZSZXN1bHQSCwoHVU5LTk9XThAAEgsK",
            "B1NVQ0NFU1MQARIRCg1OT1RfQVZBSUxBQkxFEAISEAoMTk9UX0lOX1JBTkdF",
            "EAMSHgoaRU5DT1VOVEVSX0FMUkVBRFlfRklOSVNIRUQQBBIaChZQT0tFTU9O",
            "X0lOVkVOVE9SWV9GVUxMEAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Data.PokemonDataReflection.Descriptor, global::Data.Capture.CaptureProbabilityReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Responses.DiskEncounterResponse), global::Networking.Responses.DiskEncounterResponse.Parser, new[]{ "Result", "PokemonData", "CaptureProbability" }, null, new[]{ typeof(global::Networking.Responses.DiskEncounterResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DiskEncounterResponse : pb::IMessage<DiskEncounterResponse> {
    private static readonly pb::MessageParser<DiskEncounterResponse> _parser = new pb::MessageParser<DiskEncounterResponse>(() => new DiskEncounterResponse());
    public static pb::MessageParser<DiskEncounterResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Responses.DiskEncounterResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DiskEncounterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DiskEncounterResponse(DiskEncounterResponse other) : this() {
      result_ = other.result_;
      PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
      CaptureProbability = other.captureProbability_ != null ? other.CaptureProbability.Clone() : null;
    }

    public DiskEncounterResponse Clone() {
      return new DiskEncounterResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Networking.Responses.DiskEncounterResponse.Types.Result result_ = 0;
    public global::Networking.Responses.DiskEncounterResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_data" field.</summary>
    public const int PokemonDataFieldNumber = 2;
    private global::Data.PokemonData pokemonData_;
    public global::Data.PokemonData PokemonData {
      get { return pokemonData_; }
      set {
        pokemonData_ = value;
      }
    }

    /// <summary>Field number for the "capture_probability" field.</summary>
    public const int CaptureProbabilityFieldNumber = 3;
    private global::Data.Capture.CaptureProbability captureProbability_;
    public global::Data.Capture.CaptureProbability CaptureProbability {
      get { return captureProbability_; }
      set {
        captureProbability_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DiskEncounterResponse);
    }

    public bool Equals(DiskEncounterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(PokemonData, other.PokemonData)) return false;
      if (!object.Equals(CaptureProbability, other.CaptureProbability)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
      if (captureProbability_ != null) hash ^= CaptureProbability.GetHashCode();
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
      if (pokemonData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PokemonData);
      }
      if (captureProbability_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CaptureProbability);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (pokemonData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
      }
      if (captureProbability_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureProbability);
      }
      return size;
    }

    public void MergeFrom(DiskEncounterResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.pokemonData_ != null) {
        if (pokemonData_ == null) {
          pokemonData_ = new global::Data.PokemonData();
        }
        PokemonData.MergeFrom(other.PokemonData);
      }
      if (other.captureProbability_ != null) {
        if (captureProbability_ == null) {
          captureProbability_ = new global::Data.Capture.CaptureProbability();
        }
        CaptureProbability.MergeFrom(other.CaptureProbability);
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
            result_ = (global::Networking.Responses.DiskEncounterResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (pokemonData_ == null) {
              pokemonData_ = new global::Data.PokemonData();
            }
            input.ReadMessage(pokemonData_);
            break;
          }
          case 26: {
            if (captureProbability_ == null) {
              captureProbability_ = new global::Data.Capture.CaptureProbability();
            }
            input.ReadMessage(captureProbability_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DiskEncounterResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("NOT_AVAILABLE")] NotAvailable = 2,
        [pbr::OriginalName("NOT_IN_RANGE")] NotInRange = 3,
        [pbr::OriginalName("ENCOUNTER_ALREADY_FINISHED")] EncounterAlreadyFinished = 4,
        [pbr::OriginalName("POKEMON_INVENTORY_FULL")] PokemonInventoryFull = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
