// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/FortDeployPokemonResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Responses {

  /// <summary>Holder for reflection information generated from Networking/Responses/FortDeployPokemonResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FortDeployPokemonResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/FortDeployPokemonResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortDeployPokemonResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjROZXR3b3JraW5nL1Jlc3BvbnNlcy9Gb3J0RGVwbG95UG9rZW1vblJlc3Bv",
            "bnNlLnByb3RvEhROZXR3b3JraW5nLlJlc3BvbnNlcxoWRGF0YS9Qb2tlbW9u",
            "RGF0YS5wcm90bxoXRGF0YS9HeW0vR3ltU3RhdGUucHJvdG8aLk5ldHdvcmtp",
            "bmcvUmVzcG9uc2VzL0ZvcnREZXRhaWxzUmVzcG9uc2UucHJvdG8i/AMKGUZv",
            "cnREZXBsb3lQb2tlbW9uUmVzcG9uc2USRgoGcmVzdWx0GAEgASgOMjYuTmV0",
            "d29ya2luZy5SZXNwb25zZXMuRm9ydERlcGxveVBva2Vtb25SZXNwb25zZS5S",
            "ZXN1bHQSPwoMZm9ydF9kZXRhaWxzGAIgASgLMikuTmV0d29ya2luZy5SZXNw",
            "b25zZXMuRm9ydERldGFpbHNSZXNwb25zZRInCgxwb2tlbW9uX2RhdGEYAyAB",
            "KAsyES5EYXRhLlBva2Vtb25EYXRhEiUKCWd5bV9zdGF0ZRgEIAEoCzISLkRh",
            "dGEuR3ltLkd5bVN0YXRlIoUCCgZSZXN1bHQSEQoNTk9fUkVTVUxUX1NFVBAA",
            "EgsKB1NVQ0NFU1MQARIlCiFFUlJPUl9BTFJFQURZX0hBU19QT0tFTU9OX09O",
            "X0ZPUlQQAhIhCh1FUlJPUl9PUFBPU0lOR19URUFNX09XTlNfRk9SVBADEhYK",
            "EkVSUk9SX0ZPUlRfSVNfRlVMTBAEEhYKEkVSUk9SX05PVF9JTl9SQU5HRRAF",
            "EhwKGEVSUk9SX1BMQVlFUl9IQVNfTk9fVEVBTRAGEh0KGUVSUk9SX1BPS0VN",
            "T05fTk9UX0ZVTExfSFAQBxIkCiBFUlJPUl9QTEFZRVJfQkVMT1dfTUlOSU1V",
            "TV9MRVZFTBAIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Data.PokemonDataReflection.Descriptor, global::Data.Gym.GymStateReflection.Descriptor, global::Networking.Responses.FortDetailsResponseReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Responses.FortDeployPokemonResponse), global::Networking.Responses.FortDeployPokemonResponse.Parser, new[]{ "Result", "FortDetails", "PokemonData", "GymState" }, null, new[]{ typeof(global::Networking.Responses.FortDeployPokemonResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FortDeployPokemonResponse : pb::IMessage<FortDeployPokemonResponse> {
    private static readonly pb::MessageParser<FortDeployPokemonResponse> _parser = new pb::MessageParser<FortDeployPokemonResponse>(() => new FortDeployPokemonResponse());
    public static pb::MessageParser<FortDeployPokemonResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Responses.FortDeployPokemonResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FortDeployPokemonResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FortDeployPokemonResponse(FortDeployPokemonResponse other) : this() {
      result_ = other.result_;
      FortDetails = other.fortDetails_ != null ? other.FortDetails.Clone() : null;
      PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
      GymState = other.gymState_ != null ? other.GymState.Clone() : null;
    }

    public FortDeployPokemonResponse Clone() {
      return new FortDeployPokemonResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Networking.Responses.FortDeployPokemonResponse.Types.Result result_ = 0;
    public global::Networking.Responses.FortDeployPokemonResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "fort_details" field.</summary>
    public const int FortDetailsFieldNumber = 2;
    private global::Networking.Responses.FortDetailsResponse fortDetails_;
    public global::Networking.Responses.FortDetailsResponse FortDetails {
      get { return fortDetails_; }
      set {
        fortDetails_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_data" field.</summary>
    public const int PokemonDataFieldNumber = 3;
    private global::Data.PokemonData pokemonData_;
    public global::Data.PokemonData PokemonData {
      get { return pokemonData_; }
      set {
        pokemonData_ = value;
      }
    }

    /// <summary>Field number for the "gym_state" field.</summary>
    public const int GymStateFieldNumber = 4;
    private global::Data.Gym.GymState gymState_;
    public global::Data.Gym.GymState GymState {
      get { return gymState_; }
      set {
        gymState_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FortDeployPokemonResponse);
    }

    public bool Equals(FortDeployPokemonResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(FortDetails, other.FortDetails)) return false;
      if (!object.Equals(PokemonData, other.PokemonData)) return false;
      if (!object.Equals(GymState, other.GymState)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (fortDetails_ != null) hash ^= FortDetails.GetHashCode();
      if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
      if (gymState_ != null) hash ^= GymState.GetHashCode();
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
      if (pokemonData_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PokemonData);
      }
      if (gymState_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GymState);
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
      if (pokemonData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
      }
      if (gymState_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GymState);
      }
      return size;
    }

    public void MergeFrom(FortDeployPokemonResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.fortDetails_ != null) {
        if (fortDetails_ == null) {
          fortDetails_ = new global::Networking.Responses.FortDetailsResponse();
        }
        FortDetails.MergeFrom(other.FortDetails);
      }
      if (other.pokemonData_ != null) {
        if (pokemonData_ == null) {
          pokemonData_ = new global::Data.PokemonData();
        }
        PokemonData.MergeFrom(other.PokemonData);
      }
      if (other.gymState_ != null) {
        if (gymState_ == null) {
          gymState_ = new global::Data.Gym.GymState();
        }
        GymState.MergeFrom(other.GymState);
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
            result_ = (global::Networking.Responses.FortDeployPokemonResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (fortDetails_ == null) {
              fortDetails_ = new global::Networking.Responses.FortDetailsResponse();
            }
            input.ReadMessage(fortDetails_);
            break;
          }
          case 26: {
            if (pokemonData_ == null) {
              pokemonData_ = new global::Data.PokemonData();
            }
            input.ReadMessage(pokemonData_);
            break;
          }
          case 34: {
            if (gymState_ == null) {
              gymState_ = new global::Data.Gym.GymState();
            }
            input.ReadMessage(gymState_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the FortDeployPokemonResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("NO_RESULT_SET")] NoResultSet = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_ALREADY_HAS_POKEMON_ON_FORT")] ErrorAlreadyHasPokemonOnFort = 2,
        [pbr::OriginalName("ERROR_OPPOSING_TEAM_OWNS_FORT")] ErrorOpposingTeamOwnsFort = 3,
        [pbr::OriginalName("ERROR_FORT_IS_FULL")] ErrorFortIsFull = 4,
        [pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 5,
        [pbr::OriginalName("ERROR_PLAYER_HAS_NO_TEAM")] ErrorPlayerHasNoTeam = 6,
        [pbr::OriginalName("ERROR_POKEMON_NOT_FULL_HP")] ErrorPokemonNotFullHp = 7,
        [pbr::OriginalName("ERROR_PLAYER_BELOW_MINIMUM_LEVEL")] ErrorPlayerBelowMinimumLevel = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
