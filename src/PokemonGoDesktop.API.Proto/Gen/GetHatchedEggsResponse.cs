// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/GetHatchedEggsResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Responses {

  /// <summary>Holder for reflection information generated from Networking/Responses/GetHatchedEggsResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GetHatchedEggsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/GetHatchedEggsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetHatchedEggsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFOZXR3b3JraW5nL1Jlc3BvbnNlcy9HZXRIYXRjaGVkRWdnc1Jlc3BvbnNl",
            "LnByb3RvEhROZXR3b3JraW5nLlJlc3BvbnNlcyKOAQoWR2V0SGF0Y2hlZEVn",
            "Z3NSZXNwb25zZRIPCgdzdWNjZXNzGAEgASgIEhYKCnBva2Vtb25faWQYAiAD",
            "KARCAhABEhoKEmV4cGVyaWVuY2VfYXdhcmRlZBgDIAMoBRIVCg1jYW5keV9h",
            "d2FyZGVkGAQgAygFEhgKEHN0YXJkdXN0X2F3YXJkZWQYBSADKAViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Responses.GetHatchedEggsResponse), global::Networking.Responses.GetHatchedEggsResponse.Parser, new[]{ "Success", "PokemonId", "ExperienceAwarded", "CandyAwarded", "StardustAwarded" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetHatchedEggsResponse : pb::IMessage<GetHatchedEggsResponse> {
    private static readonly pb::MessageParser<GetHatchedEggsResponse> _parser = new pb::MessageParser<GetHatchedEggsResponse>(() => new GetHatchedEggsResponse());
    public static pb::MessageParser<GetHatchedEggsResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Responses.GetHatchedEggsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetHatchedEggsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetHatchedEggsResponse(GetHatchedEggsResponse other) : this() {
      success_ = other.success_;
      pokemonId_ = other.pokemonId_.Clone();
      experienceAwarded_ = other.experienceAwarded_.Clone();
      candyAwarded_ = other.candyAwarded_.Clone();
      stardustAwarded_ = other.stardustAwarded_.Clone();
    }

    public GetHatchedEggsResponse Clone() {
      return new GetHatchedEggsResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 2;
    private static readonly pb::FieldCodec<ulong> _repeated_pokemonId_codec
        = pb::FieldCodec.ForUInt64(18);
    private readonly pbc::RepeatedField<ulong> pokemonId_ = new pbc::RepeatedField<ulong>();
    public pbc::RepeatedField<ulong> PokemonId {
      get { return pokemonId_; }
    }

    /// <summary>Field number for the "experience_awarded" field.</summary>
    public const int ExperienceAwardedFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_experienceAwarded_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> experienceAwarded_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> ExperienceAwarded {
      get { return experienceAwarded_; }
    }

    /// <summary>Field number for the "candy_awarded" field.</summary>
    public const int CandyAwardedFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_candyAwarded_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> candyAwarded_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> CandyAwarded {
      get { return candyAwarded_; }
    }

    /// <summary>Field number for the "stardust_awarded" field.</summary>
    public const int StardustAwardedFieldNumber = 5;
    private static readonly pb::FieldCodec<int> _repeated_stardustAwarded_codec
        = pb::FieldCodec.ForInt32(42);
    private readonly pbc::RepeatedField<int> stardustAwarded_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> StardustAwarded {
      get { return stardustAwarded_; }
    }

    public override bool Equals(object other) {
      return Equals(other as GetHatchedEggsResponse);
    }

    public bool Equals(GetHatchedEggsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if(!pokemonId_.Equals(other.pokemonId_)) return false;
      if(!experienceAwarded_.Equals(other.experienceAwarded_)) return false;
      if(!candyAwarded_.Equals(other.candyAwarded_)) return false;
      if(!stardustAwarded_.Equals(other.stardustAwarded_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      hash ^= pokemonId_.GetHashCode();
      hash ^= experienceAwarded_.GetHashCode();
      hash ^= candyAwarded_.GetHashCode();
      hash ^= stardustAwarded_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      pokemonId_.WriteTo(output, _repeated_pokemonId_codec);
      experienceAwarded_.WriteTo(output, _repeated_experienceAwarded_codec);
      candyAwarded_.WriteTo(output, _repeated_candyAwarded_codec);
      stardustAwarded_.WriteTo(output, _repeated_stardustAwarded_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      size += pokemonId_.CalculateSize(_repeated_pokemonId_codec);
      size += experienceAwarded_.CalculateSize(_repeated_experienceAwarded_codec);
      size += candyAwarded_.CalculateSize(_repeated_candyAwarded_codec);
      size += stardustAwarded_.CalculateSize(_repeated_stardustAwarded_codec);
      return size;
    }

    public void MergeFrom(GetHatchedEggsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      pokemonId_.Add(other.pokemonId_);
      experienceAwarded_.Add(other.experienceAwarded_);
      candyAwarded_.Add(other.candyAwarded_);
      stardustAwarded_.Add(other.stardustAwarded_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
          case 18:
          case 16: {
            pokemonId_.AddEntriesFrom(input, _repeated_pokemonId_codec);
            break;
          }
          case 26:
          case 24: {
            experienceAwarded_.AddEntriesFrom(input, _repeated_experienceAwarded_codec);
            break;
          }
          case 34:
          case 32: {
            candyAwarded_.AddEntriesFrom(input, _repeated_candyAwarded_codec);
            break;
          }
          case 42:
          case 40: {
            stardustAwarded_.AddEntriesFrom(input, _repeated_stardustAwarded_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
