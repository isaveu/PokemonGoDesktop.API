// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/InventoryUpgrades.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Inventory/InventoryUpgrades.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class InventoryUpgradesReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/InventoryUpgrades.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryUpgradesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFJbnZlbnRvcnkvSW52ZW50b3J5VXBncmFkZXMucHJvdG8SCUludmVudG9y",
            "eRogSW52ZW50b3J5L0ludmVudG9yeVVwZ3JhZGUucHJvdG8iTAoRSW52ZW50",
            "b3J5VXBncmFkZXMSNwoSaW52ZW50b3J5X3VwZ3JhZGVzGAEgAygLMhsuSW52",
            "ZW50b3J5LkludmVudG9yeVVwZ3JhZGVCHaoCGlBva2Vtb25Hb0Rlc2t0b3Au",
            "QVBJLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.InventoryUpgradeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.InventoryUpgrades), global::PokemonGoDesktop.API.Proto.InventoryUpgrades.Parser, new[]{ "InventoryUpgrades_" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class InventoryUpgrades : pb::IMessage<InventoryUpgrades> {
    private static readonly pb::MessageParser<InventoryUpgrades> _parser = new pb::MessageParser<InventoryUpgrades>(() => new InventoryUpgrades());
    public static pb::MessageParser<InventoryUpgrades> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.InventoryUpgradesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public InventoryUpgrades() {
      OnConstruction();
    }

    partial void OnConstruction();

    public InventoryUpgrades(InventoryUpgrades other) : this() {
      inventoryUpgrades_ = other.inventoryUpgrades_.Clone();
    }

    public InventoryUpgrades Clone() {
      return new InventoryUpgrades(this);
    }

    /// <summary>Field number for the "inventory_upgrades" field.</summary>
    public const int InventoryUpgrades_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::PokemonGoDesktop.API.Proto.InventoryUpgrade> _repeated_inventoryUpgrades_codec
        = pb::FieldCodec.ForMessage(10, global::PokemonGoDesktop.API.Proto.InventoryUpgrade.Parser);
    private readonly pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.InventoryUpgrade> inventoryUpgrades_ = new pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.InventoryUpgrade>();
    public pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.InventoryUpgrade> InventoryUpgrades_ {
      get { return inventoryUpgrades_; }
    }

    public override bool Equals(object other) {
      return Equals(other as InventoryUpgrades);
    }

    public bool Equals(InventoryUpgrades other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!inventoryUpgrades_.Equals(other.inventoryUpgrades_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= inventoryUpgrades_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      inventoryUpgrades_.WriteTo(output, _repeated_inventoryUpgrades_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += inventoryUpgrades_.CalculateSize(_repeated_inventoryUpgrades_codec);
      return size;
    }

    public void MergeFrom(InventoryUpgrades other) {
      if (other == null) {
        return;
      }
      inventoryUpgrades_.Add(other.inventoryUpgrades_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            inventoryUpgrades_.AddEntriesFrom(input, _repeated_inventoryUpgrades_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
