// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/InventoryUpgradeType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Inventory {

  /// <summary>Holder for reflection information generated from Inventory/InventoryUpgradeType.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class InventoryUpgradeTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/InventoryUpgradeType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryUpgradeTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRJbnZlbnRvcnkvSW52ZW50b3J5VXBncmFkZVR5cGUucHJvdG8SCUludmVu",
            "dG9yeSpiChRJbnZlbnRvcnlVcGdyYWRlVHlwZRIRCg1VUEdSQURFX1VOU0VU",
            "EAASGQoVSU5DUkVBU0VfSVRFTV9TVE9SQUdFEAESHAoYSU5DUkVBU0VfUE9L",
            "RU1PTl9TVE9SQUdFEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Inventory.InventoryUpgradeType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum InventoryUpgradeType {
    [pbr::OriginalName("UPGRADE_UNSET")] UpgradeUnset = 0,
    [pbr::OriginalName("INCREASE_ITEM_STORAGE")] IncreaseItemStorage = 1,
    [pbr::OriginalName("INCREASE_POKEMON_STORAGE")] IncreasePokemonStorage = 2,
  }

  #endregion

}

#endregion Designer generated code
