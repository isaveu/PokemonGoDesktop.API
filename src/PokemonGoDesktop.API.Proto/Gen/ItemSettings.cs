// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Master/ItemSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Settings/Master/ItemSettings.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ItemSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Master/ItemSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJTZXR0aW5ncy9NYXN0ZXIvSXRlbVNldHRpbmdzLnByb3RvEg9TZXR0aW5n",
            "cy5NYXN0ZXIaGEVudW1zL0l0ZW1DYXRlZ29yeS5wcm90bxobSW52ZW50b3J5",
            "L0l0ZW0vSXRlbUlkLnByb3RvGh1JbnZlbnRvcnkvSXRlbS9JdGVtVHlwZS5w",
            "cm90bxopU2V0dGluZ3MvTWFzdGVyL0l0ZW0vRm9vZEF0dHJpYnV0ZXMucHJv",
            "dG8aK1NldHRpbmdzL01hc3Rlci9JdGVtL1BvdGlvbkF0dHJpYnV0ZXMucHJv",
            "dG8aK1NldHRpbmdzL01hc3Rlci9JdGVtL1Jldml2ZUF0dHJpYnV0ZXMucHJv",
            "dG8aK1NldHRpbmdzL01hc3Rlci9JdGVtL0JhdHRsZUF0dHJpYnV0ZXMucHJv",
            "dG8aLFNldHRpbmdzL01hc3Rlci9JdGVtL0luY2Vuc2VBdHRyaWJ1dGVzLnBy",
            "b3RvGi1TZXR0aW5ncy9NYXN0ZXIvSXRlbS9Qb2tlYmFsbEF0dHJpYnV0ZXMu",
            "cHJvdG8aMVNldHRpbmdzL01hc3Rlci9JdGVtL0ZvcnRNb2RpZmllckF0dHJp",
            "YnV0ZXMucHJvdG8aMVNldHRpbmdzL01hc3Rlci9JdGVtL0VnZ0luY3ViYXRv",
            "ckF0dHJpYnV0ZXMucHJvdG8aNFNldHRpbmdzL01hc3Rlci9JdGVtL0V4cGVy",
            "aWVuY2VCb29zdEF0dHJpYnV0ZXMucHJvdG8aNVNldHRpbmdzL01hc3Rlci9J",
            "dGVtL0ludmVudG9yeVVwZ3JhZGVBdHRyaWJ1dGVzLnByb3RvIqYGCgxJdGVt",
            "U2V0dGluZ3MSJwoHaXRlbV9pZBgBIAEoDjIWLkludmVudG9yeS5JdGVtLkl0",
            "ZW1JZBIrCglpdGVtX3R5cGUYAiABKA4yGC5JbnZlbnRvcnkuSXRlbS5JdGVt",
            "VHlwZRIlCghjYXRlZ29yeRgDIAEoDjITLkVudW1zLkl0ZW1DYXRlZ29yeRIR",
            "Cglkcm9wX2ZyZXEYBCABKAISGgoSZHJvcF90cmFpbmVyX2xldmVsGAUgASgF",
            "EjoKCHBva2ViYWxsGAYgASgLMiguU2V0dGluZ3MuTWFzdGVyLkl0ZW0uUG9r",
            "ZWJhbGxBdHRyaWJ1dGVzEjYKBnBvdGlvbhgHIAEoCzImLlNldHRpbmdzLk1h",
            "c3Rlci5JdGVtLlBvdGlvbkF0dHJpYnV0ZXMSNgoGcmV2aXZlGAggASgLMiYu",
            "U2V0dGluZ3MuTWFzdGVyLkl0ZW0uUmV2aXZlQXR0cmlidXRlcxI2CgZiYXR0",
            "bGUYCSABKAsyJi5TZXR0aW5ncy5NYXN0ZXIuSXRlbS5CYXR0bGVBdHRyaWJ1",
            "dGVzEjIKBGZvb2QYCiABKAsyJC5TZXR0aW5ncy5NYXN0ZXIuSXRlbS5Gb29k",
            "QXR0cmlidXRlcxJLChFpbnZlbnRvcnlfdXBncmFkZRgLIAEoCzIwLlNldHRp",
            "bmdzLk1hc3Rlci5JdGVtLkludmVudG9yeVVwZ3JhZGVBdHRyaWJ1dGVzEkEK",
            "CHhwX2Jvb3N0GAwgASgLMi8uU2V0dGluZ3MuTWFzdGVyLkl0ZW0uRXhwZXJp",
            "ZW5jZUJvb3N0QXR0cmlidXRlcxI4CgdpbmNlbnNlGA0gASgLMicuU2V0dGlu",
            "Z3MuTWFzdGVyLkl0ZW0uSW5jZW5zZUF0dHJpYnV0ZXMSQwoNZWdnX2luY3Vi",
            "YXRvchgOIAEoCzIsLlNldHRpbmdzLk1hc3Rlci5JdGVtLkVnZ0luY3ViYXRv",
            "ckF0dHJpYnV0ZXMSQwoNZm9ydF9tb2RpZmllchgPIAEoCzIsLlNldHRpbmdz",
            "Lk1hc3Rlci5JdGVtLkZvcnRNb2RpZmllckF0dHJpYnV0ZXNCHaoCGlBva2Vt",
            "b25Hb0Rlc2t0b3AuQVBJLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.ItemCategoryReflection.Descriptor, global::PokemonGoDesktop.API.Proto.ItemIdReflection.Descriptor, global::PokemonGoDesktop.API.Proto.ItemTypeReflection.Descriptor, global::PokemonGoDesktop.API.Proto.FoodAttributesReflection.Descriptor, global::PokemonGoDesktop.API.Proto.PotionAttributesReflection.Descriptor, global::PokemonGoDesktop.API.Proto.ReviveAttributesReflection.Descriptor, global::PokemonGoDesktop.API.Proto.BattleAttributesReflection.Descriptor, global::PokemonGoDesktop.API.Proto.IncenseAttributesReflection.Descriptor, global::PokemonGoDesktop.API.Proto.PokeballAttributesReflection.Descriptor, global::PokemonGoDesktop.API.Proto.FortModifierAttributesReflection.Descriptor, global::PokemonGoDesktop.API.Proto.EggIncubatorAttributesReflection.Descriptor, global::PokemonGoDesktop.API.Proto.ExperienceBoostAttributesReflection.Descriptor, global::PokemonGoDesktop.API.Proto.InventoryUpgradeAttributesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.ItemSettings), global::PokemonGoDesktop.API.Proto.ItemSettings.Parser, new[]{ "ItemId", "ItemType", "Category", "DropFreq", "DropTrainerLevel", "Pokeball", "Potion", "Revive", "Battle", "Food", "InventoryUpgrade", "XpBoost", "Incense", "EggIncubator", "FortModifier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ItemSettings : pb::IMessage<ItemSettings> {
    private static readonly pb::MessageParser<ItemSettings> _parser = new pb::MessageParser<ItemSettings>(() => new ItemSettings());
    public static pb::MessageParser<ItemSettings> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.ItemSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ItemSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ItemSettings(ItemSettings other) : this() {
      itemId_ = other.itemId_;
      itemType_ = other.itemType_;
      category_ = other.category_;
      dropFreq_ = other.dropFreq_;
      dropTrainerLevel_ = other.dropTrainerLevel_;
      Pokeball = other.pokeball_ != null ? other.Pokeball.Clone() : null;
      Potion = other.potion_ != null ? other.Potion.Clone() : null;
      Revive = other.revive_ != null ? other.Revive.Clone() : null;
      Battle = other.battle_ != null ? other.Battle.Clone() : null;
      Food = other.food_ != null ? other.Food.Clone() : null;
      InventoryUpgrade = other.inventoryUpgrade_ != null ? other.InventoryUpgrade.Clone() : null;
      XpBoost = other.xpBoost_ != null ? other.XpBoost.Clone() : null;
      Incense = other.incense_ != null ? other.Incense.Clone() : null;
      EggIncubator = other.eggIncubator_ != null ? other.EggIncubator.Clone() : null;
      FortModifier = other.fortModifier_ != null ? other.FortModifier.Clone() : null;
    }

    public ItemSettings Clone() {
      return new ItemSettings(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.ItemId itemId_ = 0;
    public global::PokemonGoDesktop.API.Proto.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "item_type" field.</summary>
    public const int ItemTypeFieldNumber = 2;
    private global::PokemonGoDesktop.API.Proto.ItemType itemType_ = 0;
    public global::PokemonGoDesktop.API.Proto.ItemType ItemType {
      get { return itemType_; }
      set {
        itemType_ = value;
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 3;
    private global::PokemonGoDesktop.API.Proto.ItemCategory category_ = 0;
    public global::PokemonGoDesktop.API.Proto.ItemCategory Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "drop_freq" field.</summary>
    public const int DropFreqFieldNumber = 4;
    private float dropFreq_;
    public float DropFreq {
      get { return dropFreq_; }
      set {
        dropFreq_ = value;
      }
    }

    /// <summary>Field number for the "drop_trainer_level" field.</summary>
    public const int DropTrainerLevelFieldNumber = 5;
    private int dropTrainerLevel_;
    public int DropTrainerLevel {
      get { return dropTrainerLevel_; }
      set {
        dropTrainerLevel_ = value;
      }
    }

    /// <summary>Field number for the "pokeball" field.</summary>
    public const int PokeballFieldNumber = 6;
    private global::PokemonGoDesktop.API.Proto.PokeballAttributes pokeball_;
    public global::PokemonGoDesktop.API.Proto.PokeballAttributes Pokeball {
      get { return pokeball_; }
      set {
        pokeball_ = value;
      }
    }

    /// <summary>Field number for the "potion" field.</summary>
    public const int PotionFieldNumber = 7;
    private global::PokemonGoDesktop.API.Proto.PotionAttributes potion_;
    public global::PokemonGoDesktop.API.Proto.PotionAttributes Potion {
      get { return potion_; }
      set {
        potion_ = value;
      }
    }

    /// <summary>Field number for the "revive" field.</summary>
    public const int ReviveFieldNumber = 8;
    private global::PokemonGoDesktop.API.Proto.ReviveAttributes revive_;
    public global::PokemonGoDesktop.API.Proto.ReviveAttributes Revive {
      get { return revive_; }
      set {
        revive_ = value;
      }
    }

    /// <summary>Field number for the "battle" field.</summary>
    public const int BattleFieldNumber = 9;
    private global::PokemonGoDesktop.API.Proto.BattleAttributes battle_;
    public global::PokemonGoDesktop.API.Proto.BattleAttributes Battle {
      get { return battle_; }
      set {
        battle_ = value;
      }
    }

    /// <summary>Field number for the "food" field.</summary>
    public const int FoodFieldNumber = 10;
    private global::PokemonGoDesktop.API.Proto.FoodAttributes food_;
    public global::PokemonGoDesktop.API.Proto.FoodAttributes Food {
      get { return food_; }
      set {
        food_ = value;
      }
    }

    /// <summary>Field number for the "inventory_upgrade" field.</summary>
    public const int InventoryUpgradeFieldNumber = 11;
    private global::PokemonGoDesktop.API.Proto.InventoryUpgradeAttributes inventoryUpgrade_;
    public global::PokemonGoDesktop.API.Proto.InventoryUpgradeAttributes InventoryUpgrade {
      get { return inventoryUpgrade_; }
      set {
        inventoryUpgrade_ = value;
      }
    }

    /// <summary>Field number for the "xp_boost" field.</summary>
    public const int XpBoostFieldNumber = 12;
    private global::PokemonGoDesktop.API.Proto.ExperienceBoostAttributes xpBoost_;
    public global::PokemonGoDesktop.API.Proto.ExperienceBoostAttributes XpBoost {
      get { return xpBoost_; }
      set {
        xpBoost_ = value;
      }
    }

    /// <summary>Field number for the "incense" field.</summary>
    public const int IncenseFieldNumber = 13;
    private global::PokemonGoDesktop.API.Proto.IncenseAttributes incense_;
    public global::PokemonGoDesktop.API.Proto.IncenseAttributes Incense {
      get { return incense_; }
      set {
        incense_ = value;
      }
    }

    /// <summary>Field number for the "egg_incubator" field.</summary>
    public const int EggIncubatorFieldNumber = 14;
    private global::PokemonGoDesktop.API.Proto.EggIncubatorAttributes eggIncubator_;
    public global::PokemonGoDesktop.API.Proto.EggIncubatorAttributes EggIncubator {
      get { return eggIncubator_; }
      set {
        eggIncubator_ = value;
      }
    }

    /// <summary>Field number for the "fort_modifier" field.</summary>
    public const int FortModifierFieldNumber = 15;
    private global::PokemonGoDesktop.API.Proto.FortModifierAttributes fortModifier_;
    public global::PokemonGoDesktop.API.Proto.FortModifierAttributes FortModifier {
      get { return fortModifier_; }
      set {
        fortModifier_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ItemSettings);
    }

    public bool Equals(ItemSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (ItemType != other.ItemType) return false;
      if (Category != other.Category) return false;
      if (DropFreq != other.DropFreq) return false;
      if (DropTrainerLevel != other.DropTrainerLevel) return false;
      if (!object.Equals(Pokeball, other.Pokeball)) return false;
      if (!object.Equals(Potion, other.Potion)) return false;
      if (!object.Equals(Revive, other.Revive)) return false;
      if (!object.Equals(Battle, other.Battle)) return false;
      if (!object.Equals(Food, other.Food)) return false;
      if (!object.Equals(InventoryUpgrade, other.InventoryUpgrade)) return false;
      if (!object.Equals(XpBoost, other.XpBoost)) return false;
      if (!object.Equals(Incense, other.Incense)) return false;
      if (!object.Equals(EggIncubator, other.EggIncubator)) return false;
      if (!object.Equals(FortModifier, other.FortModifier)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (ItemType != 0) hash ^= ItemType.GetHashCode();
      if (Category != 0) hash ^= Category.GetHashCode();
      if (DropFreq != 0F) hash ^= DropFreq.GetHashCode();
      if (DropTrainerLevel != 0) hash ^= DropTrainerLevel.GetHashCode();
      if (pokeball_ != null) hash ^= Pokeball.GetHashCode();
      if (potion_ != null) hash ^= Potion.GetHashCode();
      if (revive_ != null) hash ^= Revive.GetHashCode();
      if (battle_ != null) hash ^= Battle.GetHashCode();
      if (food_ != null) hash ^= Food.GetHashCode();
      if (inventoryUpgrade_ != null) hash ^= InventoryUpgrade.GetHashCode();
      if (xpBoost_ != null) hash ^= XpBoost.GetHashCode();
      if (incense_ != null) hash ^= Incense.GetHashCode();
      if (eggIncubator_ != null) hash ^= EggIncubator.GetHashCode();
      if (fortModifier_ != null) hash ^= FortModifier.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (ItemType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ItemType);
      }
      if (Category != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Category);
      }
      if (DropFreq != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(DropFreq);
      }
      if (DropTrainerLevel != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(DropTrainerLevel);
      }
      if (pokeball_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Pokeball);
      }
      if (potion_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Potion);
      }
      if (revive_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Revive);
      }
      if (battle_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Battle);
      }
      if (food_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Food);
      }
      if (inventoryUpgrade_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(InventoryUpgrade);
      }
      if (xpBoost_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(XpBoost);
      }
      if (incense_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Incense);
      }
      if (eggIncubator_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(EggIncubator);
      }
      if (fortModifier_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(FortModifier);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (ItemType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemType);
      }
      if (Category != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
      }
      if (DropFreq != 0F) {
        size += 1 + 4;
      }
      if (DropTrainerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DropTrainerLevel);
      }
      if (pokeball_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pokeball);
      }
      if (potion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Potion);
      }
      if (revive_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Revive);
      }
      if (battle_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Battle);
      }
      if (food_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Food);
      }
      if (inventoryUpgrade_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryUpgrade);
      }
      if (xpBoost_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(XpBoost);
      }
      if (incense_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Incense);
      }
      if (eggIncubator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubator);
      }
      if (fortModifier_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortModifier);
      }
      return size;
    }

    public void MergeFrom(ItemSettings other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.ItemType != 0) {
        ItemType = other.ItemType;
      }
      if (other.Category != 0) {
        Category = other.Category;
      }
      if (other.DropFreq != 0F) {
        DropFreq = other.DropFreq;
      }
      if (other.DropTrainerLevel != 0) {
        DropTrainerLevel = other.DropTrainerLevel;
      }
      if (other.pokeball_ != null) {
        if (pokeball_ == null) {
          pokeball_ = new global::PokemonGoDesktop.API.Proto.PokeballAttributes();
        }
        Pokeball.MergeFrom(other.Pokeball);
      }
      if (other.potion_ != null) {
        if (potion_ == null) {
          potion_ = new global::PokemonGoDesktop.API.Proto.PotionAttributes();
        }
        Potion.MergeFrom(other.Potion);
      }
      if (other.revive_ != null) {
        if (revive_ == null) {
          revive_ = new global::PokemonGoDesktop.API.Proto.ReviveAttributes();
        }
        Revive.MergeFrom(other.Revive);
      }
      if (other.battle_ != null) {
        if (battle_ == null) {
          battle_ = new global::PokemonGoDesktop.API.Proto.BattleAttributes();
        }
        Battle.MergeFrom(other.Battle);
      }
      if (other.food_ != null) {
        if (food_ == null) {
          food_ = new global::PokemonGoDesktop.API.Proto.FoodAttributes();
        }
        Food.MergeFrom(other.Food);
      }
      if (other.inventoryUpgrade_ != null) {
        if (inventoryUpgrade_ == null) {
          inventoryUpgrade_ = new global::PokemonGoDesktop.API.Proto.InventoryUpgradeAttributes();
        }
        InventoryUpgrade.MergeFrom(other.InventoryUpgrade);
      }
      if (other.xpBoost_ != null) {
        if (xpBoost_ == null) {
          xpBoost_ = new global::PokemonGoDesktop.API.Proto.ExperienceBoostAttributes();
        }
        XpBoost.MergeFrom(other.XpBoost);
      }
      if (other.incense_ != null) {
        if (incense_ == null) {
          incense_ = new global::PokemonGoDesktop.API.Proto.IncenseAttributes();
        }
        Incense.MergeFrom(other.Incense);
      }
      if (other.eggIncubator_ != null) {
        if (eggIncubator_ == null) {
          eggIncubator_ = new global::PokemonGoDesktop.API.Proto.EggIncubatorAttributes();
        }
        EggIncubator.MergeFrom(other.EggIncubator);
      }
      if (other.fortModifier_ != null) {
        if (fortModifier_ == null) {
          fortModifier_ = new global::PokemonGoDesktop.API.Proto.FortModifierAttributes();
        }
        FortModifier.MergeFrom(other.FortModifier);
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
            itemId_ = (global::PokemonGoDesktop.API.Proto.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            itemType_ = (global::PokemonGoDesktop.API.Proto.ItemType) input.ReadEnum();
            break;
          }
          case 24: {
            category_ = (global::PokemonGoDesktop.API.Proto.ItemCategory) input.ReadEnum();
            break;
          }
          case 37: {
            DropFreq = input.ReadFloat();
            break;
          }
          case 40: {
            DropTrainerLevel = input.ReadInt32();
            break;
          }
          case 50: {
            if (pokeball_ == null) {
              pokeball_ = new global::PokemonGoDesktop.API.Proto.PokeballAttributes();
            }
            input.ReadMessage(pokeball_);
            break;
          }
          case 58: {
            if (potion_ == null) {
              potion_ = new global::PokemonGoDesktop.API.Proto.PotionAttributes();
            }
            input.ReadMessage(potion_);
            break;
          }
          case 66: {
            if (revive_ == null) {
              revive_ = new global::PokemonGoDesktop.API.Proto.ReviveAttributes();
            }
            input.ReadMessage(revive_);
            break;
          }
          case 74: {
            if (battle_ == null) {
              battle_ = new global::PokemonGoDesktop.API.Proto.BattleAttributes();
            }
            input.ReadMessage(battle_);
            break;
          }
          case 82: {
            if (food_ == null) {
              food_ = new global::PokemonGoDesktop.API.Proto.FoodAttributes();
            }
            input.ReadMessage(food_);
            break;
          }
          case 90: {
            if (inventoryUpgrade_ == null) {
              inventoryUpgrade_ = new global::PokemonGoDesktop.API.Proto.InventoryUpgradeAttributes();
            }
            input.ReadMessage(inventoryUpgrade_);
            break;
          }
          case 98: {
            if (xpBoost_ == null) {
              xpBoost_ = new global::PokemonGoDesktop.API.Proto.ExperienceBoostAttributes();
            }
            input.ReadMessage(xpBoost_);
            break;
          }
          case 106: {
            if (incense_ == null) {
              incense_ = new global::PokemonGoDesktop.API.Proto.IncenseAttributes();
            }
            input.ReadMessage(incense_);
            break;
          }
          case 114: {
            if (eggIncubator_ == null) {
              eggIncubator_ = new global::PokemonGoDesktop.API.Proto.EggIncubatorAttributes();
            }
            input.ReadMessage(eggIncubator_);
            break;
          }
          case 122: {
            if (fortModifier_ == null) {
              fortModifier_ = new global::PokemonGoDesktop.API.Proto.FortModifierAttributes();
            }
            input.ReadMessage(fortModifier_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
