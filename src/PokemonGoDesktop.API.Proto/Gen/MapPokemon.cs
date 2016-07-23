// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Map/Pokemon/MapPokemon.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Map/Pokemon/MapPokemon.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class MapPokemonReflection {

    #region Descriptor
    /// <summary>File descriptor for Map/Pokemon/MapPokemon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapPokemonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxNYXAvUG9rZW1vbi9NYXBQb2tlbW9uLnByb3RvEgtNYXAuUG9rZW1vbhoV",
            "RW51bXMvUG9rZW1vbklkLnByb3RvIqYBCgpNYXBQb2tlbW9uEhYKDnNwYXdu",
            "X3BvaW50X2lkGAEgASgJEhQKDGVuY291bnRlcl9pZBgCIAEoBhIkCgpwb2tl",
            "bW9uX2lkGAMgASgOMhAuRW51bXMuUG9rZW1vbklkEh8KF2V4cGlyYXRpb25f",
            "dGltZXN0YW1wX21zGAQgASgDEhAKCGxhdGl0dWRlGAUgASgBEhEKCWxvbmdp",
            "dHVkZRgGIAEoAUIdqgIaUG9rZW1vbkdvRGVza3RvcC5BUEkuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.PokemonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.MapPokemon), global::PokemonGoDesktop.API.Proto.MapPokemon.Parser, new[]{ "SpawnPointId", "EncounterId", "PokemonId", "ExpirationTimestampMs", "Latitude", "Longitude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class MapPokemon : pb::IMessage<MapPokemon> {
    private static readonly pb::MessageParser<MapPokemon> _parser = new pb::MessageParser<MapPokemon>(() => new MapPokemon());
    public static pb::MessageParser<MapPokemon> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.MapPokemonReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public MapPokemon() {
      OnConstruction();
    }

    partial void OnConstruction();

    public MapPokemon(MapPokemon other) : this() {
      spawnPointId_ = other.spawnPointId_;
      encounterId_ = other.encounterId_;
      pokemonId_ = other.pokemonId_;
      expirationTimestampMs_ = other.expirationTimestampMs_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
    }

    public MapPokemon Clone() {
      return new MapPokemon(this);
    }

    /// <summary>Field number for the "spawn_point_id" field.</summary>
    public const int SpawnPointIdFieldNumber = 1;
    private string spawnPointId_ = "";
    public string SpawnPointId {
      get { return spawnPointId_; }
      set {
        spawnPointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 2;
    private ulong encounterId_;
    public ulong EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 3;
    private global::PokemonGoDesktop.API.Proto.PokemonId pokemonId_ = 0;
    public global::PokemonGoDesktop.API.Proto.PokemonId PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "expiration_timestamp_ms" field.</summary>
    public const int ExpirationTimestampMsFieldNumber = 4;
    private long expirationTimestampMs_;
    /// <summary>
    ///  After this timestamp, the pokemon will be gone.
    /// </summary>
    public long ExpirationTimestampMs {
      get { return expirationTimestampMs_; }
      set {
        expirationTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 5;
    private double latitude_;
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 6;
    private double longitude_;
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as MapPokemon);
    }

    public bool Equals(MapPokemon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpawnPointId != other.SpawnPointId) return false;
      if (EncounterId != other.EncounterId) return false;
      if (PokemonId != other.PokemonId) return false;
      if (ExpirationTimestampMs != other.ExpirationTimestampMs) return false;
      if (Latitude != other.Latitude) return false;
      if (Longitude != other.Longitude) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SpawnPointId.Length != 0) hash ^= SpawnPointId.GetHashCode();
      if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
      if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
      if (ExpirationTimestampMs != 0L) hash ^= ExpirationTimestampMs.GetHashCode();
      if (Latitude != 0D) hash ^= Latitude.GetHashCode();
      if (Longitude != 0D) hash ^= Longitude.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SpawnPointId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SpawnPointId);
      }
      if (EncounterId != 0UL) {
        output.WriteRawTag(17);
        output.WriteFixed64(EncounterId);
      }
      if (PokemonId != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) PokemonId);
      }
      if (ExpirationTimestampMs != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ExpirationTimestampMs);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Longitude);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SpawnPointId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointId);
      }
      if (EncounterId != 0UL) {
        size += 1 + 8;
      }
      if (PokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
      }
      if (ExpirationTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpirationTimestampMs);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(MapPokemon other) {
      if (other == null) {
        return;
      }
      if (other.SpawnPointId.Length != 0) {
        SpawnPointId = other.SpawnPointId;
      }
      if (other.EncounterId != 0UL) {
        EncounterId = other.EncounterId;
      }
      if (other.PokemonId != 0) {
        PokemonId = other.PokemonId;
      }
      if (other.ExpirationTimestampMs != 0L) {
        ExpirationTimestampMs = other.ExpirationTimestampMs;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
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
            SpawnPointId = input.ReadString();
            break;
          }
          case 17: {
            EncounterId = input.ReadFixed64();
            break;
          }
          case 24: {
            pokemonId_ = (global::PokemonGoDesktop.API.Proto.PokemonId) input.ReadEnum();
            break;
          }
          case 32: {
            ExpirationTimestampMs = input.ReadInt64();
            break;
          }
          case 41: {
            Latitude = input.ReadDouble();
            break;
          }
          case 49: {
            Longitude = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
