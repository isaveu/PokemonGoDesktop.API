// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/ItemId.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Inventory {

  /// <summary>Holder for reflection information generated from Inventory/ItemId.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ItemIdReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/ItemId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZJbnZlbnRvcnkvSXRlbUlkLnByb3RvEglJbnZlbnRvcnkqxwUKBkl0ZW1J",
            "ZBIQCgxJVEVNX1VOS05PV04QABISCg5JVEVNX1BPS0VfQkFMTBABEhMKD0lU",
            "RU1fR1JFQVRfQkFMTBACEhMKD0lURU1fVUxUUkFfQkFMTBADEhQKEElURU1f",
            "TUFTVEVSX0JBTEwQBBIPCgtJVEVNX1BPVElPThBlEhUKEUlURU1fU1VQRVJf",
            "UE9USU9OEGYSFQoRSVRFTV9IWVBFUl9QT1RJT04QZxITCg9JVEVNX01BWF9Q",
            "T1RJT04QaBIQCgtJVEVNX1JFVklWRRDJARIUCg9JVEVNX01BWF9SRVZJVkUQ",
            "ygESEwoOSVRFTV9MVUNLWV9FR0cQrQISGgoVSVRFTV9JTkNFTlNFX09SRElO",
            "QVJZEJEDEhcKEklURU1fSU5DRU5TRV9TUElDWRCSAxIWChFJVEVNX0lOQ0VO",
            "U0VfQ09PTBCTAxIYChNJVEVNX0lOQ0VOU0VfRkxPUkFMEJQDEhMKDklURU1f",
            "VFJPWV9ESVNLEPUDEhIKDUlURU1fWF9BVFRBQ0sQ2gQSEwoOSVRFTV9YX0RF",
            "RkVOU0UQ2wQSEwoOSVRFTV9YX01JUkFDTEUQ3AQSFAoPSVRFTV9SQVpaX0JF",
            "UlJZEL0FEhQKD0lURU1fQkxVS19CRVJSWRC+BRIVChBJVEVNX05BTkFCX0JF",
            "UlJZEL8FEhUKEElURU1fV0VQQVJfQkVSUlkQwAUSFQoQSVRFTV9QSU5BUF9C",
            "RVJSWRDBBRIYChNJVEVNX1NQRUNJQUxfQ0FNRVJBEKEGEiMKHklURU1fSU5D",
            "VUJBVE9SX0JBU0lDX1VOTElNSVRFRBCFBxIZChRJVEVNX0lOQ1VCQVRPUl9C",
            "QVNJQxCGBxIhChxJVEVNX1BPS0VNT05fU1RPUkFHRV9VUEdSQURFEOkHEh4K",
            "GUlURU1fSVRFTV9TVE9SQUdFX1VQR1JBREUQ6gdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Inventory.ItemId), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ItemId {
    [pbr::OriginalName("ITEM_UNKNOWN")] ItemUnknown = 0,
    [pbr::OriginalName("ITEM_POKE_BALL")] ItemPokeBall = 1,
    [pbr::OriginalName("ITEM_GREAT_BALL")] ItemGreatBall = 2,
    [pbr::OriginalName("ITEM_ULTRA_BALL")] ItemUltraBall = 3,
    [pbr::OriginalName("ITEM_MASTER_BALL")] ItemMasterBall = 4,
    [pbr::OriginalName("ITEM_POTION")] ItemPotion = 101,
    [pbr::OriginalName("ITEM_SUPER_POTION")] ItemSuperPotion = 102,
    [pbr::OriginalName("ITEM_HYPER_POTION")] ItemHyperPotion = 103,
    [pbr::OriginalName("ITEM_MAX_POTION")] ItemMaxPotion = 104,
    [pbr::OriginalName("ITEM_REVIVE")] ItemRevive = 201,
    [pbr::OriginalName("ITEM_MAX_REVIVE")] ItemMaxRevive = 202,
    [pbr::OriginalName("ITEM_LUCKY_EGG")] ItemLuckyEgg = 301,
    [pbr::OriginalName("ITEM_INCENSE_ORDINARY")] ItemIncenseOrdinary = 401,
    [pbr::OriginalName("ITEM_INCENSE_SPICY")] ItemIncenseSpicy = 402,
    [pbr::OriginalName("ITEM_INCENSE_COOL")] ItemIncenseCool = 403,
    [pbr::OriginalName("ITEM_INCENSE_FLORAL")] ItemIncenseFloral = 404,
    [pbr::OriginalName("ITEM_TROY_DISK")] ItemTroyDisk = 501,
    [pbr::OriginalName("ITEM_X_ATTACK")] ItemXAttack = 602,
    [pbr::OriginalName("ITEM_X_DEFENSE")] ItemXDefense = 603,
    [pbr::OriginalName("ITEM_X_MIRACLE")] ItemXMiracle = 604,
    [pbr::OriginalName("ITEM_RAZZ_BERRY")] ItemRazzBerry = 701,
    [pbr::OriginalName("ITEM_BLUK_BERRY")] ItemBlukBerry = 702,
    [pbr::OriginalName("ITEM_NANAB_BERRY")] ItemNanabBerry = 703,
    [pbr::OriginalName("ITEM_WEPAR_BERRY")] ItemWeparBerry = 704,
    [pbr::OriginalName("ITEM_PINAP_BERRY")] ItemPinapBerry = 705,
    [pbr::OriginalName("ITEM_SPECIAL_CAMERA")] ItemSpecialCamera = 801,
    [pbr::OriginalName("ITEM_INCUBATOR_BASIC_UNLIMITED")] ItemIncubatorBasicUnlimited = 901,
    [pbr::OriginalName("ITEM_INCUBATOR_BASIC")] ItemIncubatorBasic = 902,
    [pbr::OriginalName("ITEM_POKEMON_STORAGE_UPGRADE")] ItemPokemonStorageUpgrade = 1001,
    [pbr::OriginalName("ITEM_ITEM_STORAGE_UPGRADE")] ItemItemStorageUpgrade = 1002,
  }

  #endregion

}

#endregion Designer generated code
