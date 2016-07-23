// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Master/Item/FoodAttributes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Settings/Master/Item/FoodAttributes.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FoodAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Master/Item/FoodAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoodAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilTZXR0aW5ncy9NYXN0ZXIvSXRlbS9Gb29kQXR0cmlidXRlcy5wcm90bxIU",
            "U2V0dGluZ3MuTWFzdGVyLkl0ZW0aFkVudW1zL0l0ZW1FZmZlY3QucHJvdG8i",
            "bQoORm9vZEF0dHJpYnV0ZXMSJgoLaXRlbV9lZmZlY3QYASADKA4yES5FbnVt",
            "cy5JdGVtRWZmZWN0EhsKE2l0ZW1fZWZmZWN0X3BlcmNlbnQYAiADKAISFgoO",
            "Z3Jvd3RoX3BlcmNlbnQYAyABKAJCHaoCGlBva2Vtb25Hb0Rlc2t0b3AuQVBJ",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.ItemEffectReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.FoodAttributes), global::PokemonGoDesktop.API.Proto.FoodAttributes.Parser, new[]{ "ItemEffect", "ItemEffectPercent", "GrowthPercent" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FoodAttributes : pb::IMessage<FoodAttributes> {
    private static readonly pb::MessageParser<FoodAttributes> _parser = new pb::MessageParser<FoodAttributes>(() => new FoodAttributes());
    public static pb::MessageParser<FoodAttributes> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.FoodAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FoodAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FoodAttributes(FoodAttributes other) : this() {
      itemEffect_ = other.itemEffect_.Clone();
      itemEffectPercent_ = other.itemEffectPercent_.Clone();
      growthPercent_ = other.growthPercent_;
    }

    public FoodAttributes Clone() {
      return new FoodAttributes(this);
    }

    /// <summary>Field number for the "item_effect" field.</summary>
    public const int ItemEffectFieldNumber = 1;
    private static readonly pb::FieldCodec<global::PokemonGoDesktop.API.Proto.ItemEffect> _repeated_itemEffect_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::PokemonGoDesktop.API.Proto.ItemEffect) x);
    private readonly pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.ItemEffect> itemEffect_ = new pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.ItemEffect>();
    public pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.ItemEffect> ItemEffect {
      get { return itemEffect_; }
    }

    /// <summary>Field number for the "item_effect_percent" field.</summary>
    public const int ItemEffectPercentFieldNumber = 2;
    private static readonly pb::FieldCodec<float> _repeated_itemEffectPercent_codec
        = pb::FieldCodec.ForFloat(18);
    private readonly pbc::RepeatedField<float> itemEffectPercent_ = new pbc::RepeatedField<float>();
    public pbc::RepeatedField<float> ItemEffectPercent {
      get { return itemEffectPercent_; }
    }

    /// <summary>Field number for the "growth_percent" field.</summary>
    public const int GrowthPercentFieldNumber = 3;
    private float growthPercent_;
    public float GrowthPercent {
      get { return growthPercent_; }
      set {
        growthPercent_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FoodAttributes);
    }

    public bool Equals(FoodAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!itemEffect_.Equals(other.itemEffect_)) return false;
      if(!itemEffectPercent_.Equals(other.itemEffectPercent_)) return false;
      if (GrowthPercent != other.GrowthPercent) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= itemEffect_.GetHashCode();
      hash ^= itemEffectPercent_.GetHashCode();
      if (GrowthPercent != 0F) hash ^= GrowthPercent.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      itemEffect_.WriteTo(output, _repeated_itemEffect_codec);
      itemEffectPercent_.WriteTo(output, _repeated_itemEffectPercent_codec);
      if (GrowthPercent != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(GrowthPercent);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += itemEffect_.CalculateSize(_repeated_itemEffect_codec);
      size += itemEffectPercent_.CalculateSize(_repeated_itemEffectPercent_codec);
      if (GrowthPercent != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    public void MergeFrom(FoodAttributes other) {
      if (other == null) {
        return;
      }
      itemEffect_.Add(other.itemEffect_);
      itemEffectPercent_.Add(other.itemEffectPercent_);
      if (other.GrowthPercent != 0F) {
        GrowthPercent = other.GrowthPercent;
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
            itemEffect_.AddEntriesFrom(input, _repeated_itemEffect_codec);
            break;
          }
          case 18:
          case 21: {
            itemEffectPercent_.AddEntriesFrom(input, _repeated_itemEffectPercent_codec);
            break;
          }
          case 29: {
            GrowthPercent = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
