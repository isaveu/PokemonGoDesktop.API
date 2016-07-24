// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data/Capture/CaptureProbability.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Data/Capture/CaptureProbability.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CaptureProbabilityReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/Capture/CaptureProbability.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CaptureProbabilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVEYXRhL0NhcHR1cmUvQ2FwdHVyZVByb2JhYmlsaXR5LnByb3RvEgxEYXRh",
            "LkNhcHR1cmUaG0ludmVudG9yeS9JdGVtL0l0ZW1JZC5wcm90byKCAQoSQ2Fw",
            "dHVyZVByb2JhYmlsaXR5Ei0KDXBva2ViYWxsX3R5cGUYASADKA4yFi5JbnZl",
            "bnRvcnkuSXRlbS5JdGVtSWQSGwoTY2FwdHVyZV9wcm9iYWJpbGl0eRgCIAMo",
            "AhIgChhyZXRpY2xlX2RpZmZpY3VsdHlfc2NhbGUYDCABKAFCHaoCGlBva2Vt",
            "b25Hb0Rlc2t0b3AuQVBJLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.CaptureProbability), global::PokemonGoDesktop.API.Proto.CaptureProbability.Parser, new[]{ "PokeballType", "CaptureProbability_", "ReticleDifficultyScale" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CaptureProbability : pb::IMessage<CaptureProbability> {
    private static readonly pb::MessageParser<CaptureProbability> _parser = new pb::MessageParser<CaptureProbability>(() => new CaptureProbability());
    public static pb::MessageParser<CaptureProbability> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.CaptureProbabilityReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CaptureProbability() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CaptureProbability(CaptureProbability other) : this() {
      pokeballType_ = other.pokeballType_.Clone();
      captureProbability_ = other.captureProbability_.Clone();
      reticleDifficultyScale_ = other.reticleDifficultyScale_;
    }

    public CaptureProbability Clone() {
      return new CaptureProbability(this);
    }

    /// <summary>Field number for the "pokeball_type" field.</summary>
    public const int PokeballTypeFieldNumber = 1;
    private static readonly pb::FieldCodec<global::PokemonGoDesktop.API.Proto.ItemId> _repeated_pokeballType_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::PokemonGoDesktop.API.Proto.ItemId) x);
    private readonly pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.ItemId> pokeballType_ = new pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.ItemId>();
    public pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.ItemId> PokeballType {
      get { return pokeballType_; }
    }

    /// <summary>Field number for the "capture_probability" field.</summary>
    public const int CaptureProbability_FieldNumber = 2;
    private static readonly pb::FieldCodec<float> _repeated_captureProbability_codec
        = pb::FieldCodec.ForFloat(18);
    private readonly pbc::RepeatedField<float> captureProbability_ = new pbc::RepeatedField<float>();
    public pbc::RepeatedField<float> CaptureProbability_ {
      get { return captureProbability_; }
    }

    /// <summary>Field number for the "reticle_difficulty_scale" field.</summary>
    public const int ReticleDifficultyScaleFieldNumber = 12;
    private double reticleDifficultyScale_;
    public double ReticleDifficultyScale {
      get { return reticleDifficultyScale_; }
      set {
        reticleDifficultyScale_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CaptureProbability);
    }

    public bool Equals(CaptureProbability other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!pokeballType_.Equals(other.pokeballType_)) return false;
      if(!captureProbability_.Equals(other.captureProbability_)) return false;
      if (ReticleDifficultyScale != other.ReticleDifficultyScale) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= pokeballType_.GetHashCode();
      hash ^= captureProbability_.GetHashCode();
      if (ReticleDifficultyScale != 0D) hash ^= ReticleDifficultyScale.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      pokeballType_.WriteTo(output, _repeated_pokeballType_codec);
      captureProbability_.WriteTo(output, _repeated_captureProbability_codec);
      if (ReticleDifficultyScale != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(ReticleDifficultyScale);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += pokeballType_.CalculateSize(_repeated_pokeballType_codec);
      size += captureProbability_.CalculateSize(_repeated_captureProbability_codec);
      if (ReticleDifficultyScale != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(CaptureProbability other) {
      if (other == null) {
        return;
      }
      pokeballType_.Add(other.pokeballType_);
      captureProbability_.Add(other.captureProbability_);
      if (other.ReticleDifficultyScale != 0D) {
        ReticleDifficultyScale = other.ReticleDifficultyScale;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 8: {
            pokeballType_.AddEntriesFrom(input, _repeated_pokeballType_codec);
            break;
          }
          case 18:
          case 21: {
            captureProbability_.AddEntriesFrom(input, _repeated_captureProbability_codec);
            break;
          }
          case 97: {
            ReticleDifficultyScale = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
