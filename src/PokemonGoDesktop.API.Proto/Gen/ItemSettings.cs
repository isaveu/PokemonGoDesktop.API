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
            "cy5NYXN0ZXIaGEVudW1zL0l0ZW1DYXRlZ29yeS5wcm90bxoWSW52ZW50b3J5",
            "L0l0ZW1JZC5wcm90bxoYSW52ZW50b3J5L0l0ZW1UeXBlLnByb3RvGilTZXR0",
            "aW5ncy9NYXN0ZXIvSXRlbS9Gb29kQXR0cmlidXRlcy5wcm90bxorU2V0dGlu",
            "Z3MvTWFzdGVyL0l0ZW0vUG90aW9uQXR0cmlidXRlcy5wcm90bxorU2V0dGlu",
            "Z3MvTWFzdGVyL0l0ZW0vUmV2aXZlQXR0cmlidXRlcy5wcm90bxorU2V0dGlu",
            "Z3MvTWFzdGVyL0l0ZW0vQmF0dGxlQXR0cmlidXRlcy5wcm90bxosU2V0dGlu",
            "Z3MvTWFzdGVyL0l0ZW0vSW5jZW5zZUF0dHJpYnV0ZXMucHJvdG8aLVNldHRp",
            "bmdzL01hc3Rlci9JdGVtL1Bva2ViYWxsQXR0cmlidXRlcy5wcm90bxoxU2V0",
            "dGluZ3MvTWFzdGVyL0l0ZW0vRm9ydE1vZGlmaWVyQXR0cmlidXRlcy5wcm90",
            "bxoxU2V0dGluZ3MvTWFzdGVyL0l0ZW0vRWdnSW5jdWJhdG9yQXR0cmlidXRl",
            "cy5wcm90bxo0U2V0dGluZ3MvTWFzdGVyL0l0ZW0vRXhwZXJpZW5jZUJvb3N0",
            "QXR0cmlidXRlcy5wcm90bxo1U2V0dGluZ3MvTWFzdGVyL0l0ZW0vSW52ZW50",
            "b3J5VXBncmFkZUF0dHJpYnV0ZXMucHJvdG8inAYKDEl0ZW1TZXR0aW5ncxIi",
            "CgdpdGVtX2lkGAEgASgOMhEuSW52ZW50b3J5Lkl0ZW1JZBImCglpdGVtX3R5",
            "cGUYAiABKA4yEy5JbnZlbnRvcnkuSXRlbVR5cGUSJQoIY2F0ZWdvcnkYAyAB",
            "KA4yEy5FbnVtcy5JdGVtQ2F0ZWdvcnkSEQoJZHJvcF9mcmVxGAQgASgCEhoK",
            "EmRyb3BfdHJhaW5lcl9sZXZlbBgFIAEoBRI6Cghwb2tlYmFsbBgGIAEoCzIo",
            "LlNldHRpbmdzLk1hc3Rlci5JdGVtLlBva2ViYWxsQXR0cmlidXRlcxI2CgZw",
            "b3Rpb24YByABKAsyJi5TZXR0aW5ncy5NYXN0ZXIuSXRlbS5Qb3Rpb25BdHRy",
            "aWJ1dGVzEjYKBnJldml2ZRgIIAEoCzImLlNldHRpbmdzLk1hc3Rlci5JdGVt",
            "LlJldml2ZUF0dHJpYnV0ZXMSNgoGYmF0dGxlGAkgASgLMiYuU2V0dGluZ3Mu",
            "TWFzdGVyLkl0ZW0uQmF0dGxlQXR0cmlidXRlcxIyCgRmb29kGAogASgLMiQu",
            "U2V0dGluZ3MuTWFzdGVyLkl0ZW0uRm9vZEF0dHJpYnV0ZXMSSwoRaW52ZW50",
            "b3J5X3VwZ3JhZGUYCyABKAsyMC5TZXR0aW5ncy5NYXN0ZXIuSXRlbS5JbnZl",
            "bnRvcnlVcGdyYWRlQXR0cmlidXRlcxJBCgh4cF9ib29zdBgMIAEoCzIvLlNl",
            "dHRpbmdzLk1hc3Rlci5JdGVtLkV4cGVyaWVuY2VCb29zdEF0dHJpYnV0ZXMS",
            "OAoHaW5jZW5zZRgNIAEoCzInLlNldHRpbmdzLk1hc3Rlci5JdGVtLkluY2Vu",
            "c2VBdHRyaWJ1dGVzEkMKDWVnZ19pbmN1YmF0b3IYDiABKAsyLC5TZXR0aW5n",
            "cy5NYXN0ZXIuSXRlbS5FZ2dJbmN1YmF0b3JBdHRyaWJ1dGVzEkMKDWZvcnRf",
            "bW9kaWZpZXIYDyABKAsyLC5TZXR0aW5ncy5NYXN0ZXIuSXRlbS5Gb3J0TW9k",
            "aWZpZXJBdHRyaWJ1dGVzQh2qAhpQb2tlbW9uR29EZXNrdG9wLkFQSS5Qcm90",
            "b2IGcHJvdG8z"));
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
