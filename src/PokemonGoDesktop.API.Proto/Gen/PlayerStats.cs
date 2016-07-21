// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data/Player/PlayerStats.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Data.Player {

  /// <summary>Holder for reflection information generated from Data/Player/PlayerStats.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PlayerStatsReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/Player/PlayerStats.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerStatsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1EYXRhL1BsYXllci9QbGF5ZXJTdGF0cy5wcm90bxILRGF0YS5QbGF5ZXIi",
            "7QQKC1BsYXllclN0YXRzEg0KBWxldmVsGAEgASgFEhIKCmV4cGVyaWVuY2UY",
            "AiABKAMSFQoNcHJldl9sZXZlbF94cBgDIAEoAxIVCg1uZXh0X2xldmVsX3hw",
            "GAQgASgDEhEKCWttX3dhbGtlZBgFIAEoAhIcChRwb2tlbW9uc19lbmNvdW50",
            "ZXJlZBgGIAEoBRIeChZ1bmlxdWVfcG9rZWRleF9lbnRyaWVzGAcgASgFEhkK",
            "EXBva2Vtb25zX2NhcHR1cmVkGAggASgFEhIKCmV2b2x1dGlvbnMYCSABKAUS",
            "GAoQcG9rZV9zdG9wX3Zpc2l0cxgKIAEoBRIYChBwb2tlYmFsbHNfdGhyb3du",
            "GAsgASgFEhQKDGVnZ3NfaGF0Y2hlZBgMIAEoBRIbChNiaWdfbWFnaWthcnBf",
            "Y2F1Z2h0GA0gASgFEhkKEWJhdHRsZV9hdHRhY2tfd29uGA4gASgFEhsKE2Jh",
            "dHRsZV9hdHRhY2tfdG90YWwYDyABKAUSGwoTYmF0dGxlX2RlZmVuZGVkX3dv",
            "bhgQIAEoBRIbChNiYXR0bGVfdHJhaW5pbmdfd29uGBEgASgFEh0KFWJhdHRs",
            "ZV90cmFpbmluZ190b3RhbBgSIAEoBRIdChVwcmVzdGlnZV9yYWlzZWRfdG90",
            "YWwYEyABKAUSHgoWcHJlc3RpZ2VfZHJvcHBlZF90b3RhbBgUIAEoBRIYChBw",
            "b2tlbW9uX2RlcGxveWVkGBUgASgFEh4KFnBva2Vtb25fY2F1Z2h0X2J5X3R5",
            "cGUYFiABKAwSHAoUc21hbGxfcmF0dGF0YV9jYXVnaHQYFyABKAViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.Player.PlayerStats), global::Data.Player.PlayerStats.Parser, new[]{ "Level", "Experience", "PrevLevelXp", "NextLevelXp", "KmWalked", "PokemonsEncountered", "UniquePokedexEntries", "PokemonsCaptured", "Evolutions", "PokeStopVisits", "PokeballsThrown", "EggsHatched", "BigMagikarpCaught", "BattleAttackWon", "BattleAttackTotal", "BattleDefendedWon", "BattleTrainingWon", "BattleTrainingTotal", "PrestigeRaisedTotal", "PrestigeDroppedTotal", "PokemonDeployed", "PokemonCaughtByType", "SmallRattataCaught" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PlayerStats : pb::IMessage<PlayerStats> {
    private static readonly pb::MessageParser<PlayerStats> _parser = new pb::MessageParser<PlayerStats>(() => new PlayerStats());
    public static pb::MessageParser<PlayerStats> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.Player.PlayerStatsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PlayerStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PlayerStats(PlayerStats other) : this() {
      level_ = other.level_;
      experience_ = other.experience_;
      prevLevelXp_ = other.prevLevelXp_;
      nextLevelXp_ = other.nextLevelXp_;
      kmWalked_ = other.kmWalked_;
      pokemonsEncountered_ = other.pokemonsEncountered_;
      uniquePokedexEntries_ = other.uniquePokedexEntries_;
      pokemonsCaptured_ = other.pokemonsCaptured_;
      evolutions_ = other.evolutions_;
      pokeStopVisits_ = other.pokeStopVisits_;
      pokeballsThrown_ = other.pokeballsThrown_;
      eggsHatched_ = other.eggsHatched_;
      bigMagikarpCaught_ = other.bigMagikarpCaught_;
      battleAttackWon_ = other.battleAttackWon_;
      battleAttackTotal_ = other.battleAttackTotal_;
      battleDefendedWon_ = other.battleDefendedWon_;
      battleTrainingWon_ = other.battleTrainingWon_;
      battleTrainingTotal_ = other.battleTrainingTotal_;
      prestigeRaisedTotal_ = other.prestigeRaisedTotal_;
      prestigeDroppedTotal_ = other.prestigeDroppedTotal_;
      pokemonDeployed_ = other.pokemonDeployed_;
      pokemonCaughtByType_ = other.pokemonCaughtByType_;
      smallRattataCaught_ = other.smallRattataCaught_;
    }

    public PlayerStats Clone() {
      return new PlayerStats(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private int level_;
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "experience" field.</summary>
    public const int ExperienceFieldNumber = 2;
    private long experience_;
    public long Experience {
      get { return experience_; }
      set {
        experience_ = value;
      }
    }

    /// <summary>Field number for the "prev_level_xp" field.</summary>
    public const int PrevLevelXpFieldNumber = 3;
    private long prevLevelXp_;
    public long PrevLevelXp {
      get { return prevLevelXp_; }
      set {
        prevLevelXp_ = value;
      }
    }

    /// <summary>Field number for the "next_level_xp" field.</summary>
    public const int NextLevelXpFieldNumber = 4;
    private long nextLevelXp_;
    public long NextLevelXp {
      get { return nextLevelXp_; }
      set {
        nextLevelXp_ = value;
      }
    }

    /// <summary>Field number for the "km_walked" field.</summary>
    public const int KmWalkedFieldNumber = 5;
    private float kmWalked_;
    public float KmWalked {
      get { return kmWalked_; }
      set {
        kmWalked_ = value;
      }
    }

    /// <summary>Field number for the "pokemons_encountered" field.</summary>
    public const int PokemonsEncounteredFieldNumber = 6;
    private int pokemonsEncountered_;
    public int PokemonsEncountered {
      get { return pokemonsEncountered_; }
      set {
        pokemonsEncountered_ = value;
      }
    }

    /// <summary>Field number for the "unique_pokedex_entries" field.</summary>
    public const int UniquePokedexEntriesFieldNumber = 7;
    private int uniquePokedexEntries_;
    public int UniquePokedexEntries {
      get { return uniquePokedexEntries_; }
      set {
        uniquePokedexEntries_ = value;
      }
    }

    /// <summary>Field number for the "pokemons_captured" field.</summary>
    public const int PokemonsCapturedFieldNumber = 8;
    private int pokemonsCaptured_;
    public int PokemonsCaptured {
      get { return pokemonsCaptured_; }
      set {
        pokemonsCaptured_ = value;
      }
    }

    /// <summary>Field number for the "evolutions" field.</summary>
    public const int EvolutionsFieldNumber = 9;
    private int evolutions_;
    public int Evolutions {
      get { return evolutions_; }
      set {
        evolutions_ = value;
      }
    }

    /// <summary>Field number for the "poke_stop_visits" field.</summary>
    public const int PokeStopVisitsFieldNumber = 10;
    private int pokeStopVisits_;
    public int PokeStopVisits {
      get { return pokeStopVisits_; }
      set {
        pokeStopVisits_ = value;
      }
    }

    /// <summary>Field number for the "pokeballs_thrown" field.</summary>
    public const int PokeballsThrownFieldNumber = 11;
    private int pokeballsThrown_;
    public int PokeballsThrown {
      get { return pokeballsThrown_; }
      set {
        pokeballsThrown_ = value;
      }
    }

    /// <summary>Field number for the "eggs_hatched" field.</summary>
    public const int EggsHatchedFieldNumber = 12;
    private int eggsHatched_;
    public int EggsHatched {
      get { return eggsHatched_; }
      set {
        eggsHatched_ = value;
      }
    }

    /// <summary>Field number for the "big_magikarp_caught" field.</summary>
    public const int BigMagikarpCaughtFieldNumber = 13;
    private int bigMagikarpCaught_;
    public int BigMagikarpCaught {
      get { return bigMagikarpCaught_; }
      set {
        bigMagikarpCaught_ = value;
      }
    }

    /// <summary>Field number for the "battle_attack_won" field.</summary>
    public const int BattleAttackWonFieldNumber = 14;
    private int battleAttackWon_;
    public int BattleAttackWon {
      get { return battleAttackWon_; }
      set {
        battleAttackWon_ = value;
      }
    }

    /// <summary>Field number for the "battle_attack_total" field.</summary>
    public const int BattleAttackTotalFieldNumber = 15;
    private int battleAttackTotal_;
    public int BattleAttackTotal {
      get { return battleAttackTotal_; }
      set {
        battleAttackTotal_ = value;
      }
    }

    /// <summary>Field number for the "battle_defended_won" field.</summary>
    public const int BattleDefendedWonFieldNumber = 16;
    private int battleDefendedWon_;
    public int BattleDefendedWon {
      get { return battleDefendedWon_; }
      set {
        battleDefendedWon_ = value;
      }
    }

    /// <summary>Field number for the "battle_training_won" field.</summary>
    public const int BattleTrainingWonFieldNumber = 17;
    private int battleTrainingWon_;
    public int BattleTrainingWon {
      get { return battleTrainingWon_; }
      set {
        battleTrainingWon_ = value;
      }
    }

    /// <summary>Field number for the "battle_training_total" field.</summary>
    public const int BattleTrainingTotalFieldNumber = 18;
    private int battleTrainingTotal_;
    public int BattleTrainingTotal {
      get { return battleTrainingTotal_; }
      set {
        battleTrainingTotal_ = value;
      }
    }

    /// <summary>Field number for the "prestige_raised_total" field.</summary>
    public const int PrestigeRaisedTotalFieldNumber = 19;
    private int prestigeRaisedTotal_;
    public int PrestigeRaisedTotal {
      get { return prestigeRaisedTotal_; }
      set {
        prestigeRaisedTotal_ = value;
      }
    }

    /// <summary>Field number for the "prestige_dropped_total" field.</summary>
    public const int PrestigeDroppedTotalFieldNumber = 20;
    private int prestigeDroppedTotal_;
    public int PrestigeDroppedTotal {
      get { return prestigeDroppedTotal_; }
      set {
        prestigeDroppedTotal_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_deployed" field.</summary>
    public const int PokemonDeployedFieldNumber = 21;
    private int pokemonDeployed_;
    public int PokemonDeployed {
      get { return pokemonDeployed_; }
      set {
        pokemonDeployed_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_caught_by_type" field.</summary>
    public const int PokemonCaughtByTypeFieldNumber = 22;
    private pb::ByteString pokemonCaughtByType_ = pb::ByteString.Empty;
    /// <summary>
    ///  TODO: repeated PokemonType ??
    /// </summary>
    public pb::ByteString PokemonCaughtByType {
      get { return pokemonCaughtByType_; }
      set {
        pokemonCaughtByType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "small_rattata_caught" field.</summary>
    public const int SmallRattataCaughtFieldNumber = 23;
    private int smallRattataCaught_;
    public int SmallRattataCaught {
      get { return smallRattataCaught_; }
      set {
        smallRattataCaught_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PlayerStats);
    }

    public bool Equals(PlayerStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if (Experience != other.Experience) return false;
      if (PrevLevelXp != other.PrevLevelXp) return false;
      if (NextLevelXp != other.NextLevelXp) return false;
      if (KmWalked != other.KmWalked) return false;
      if (PokemonsEncountered != other.PokemonsEncountered) return false;
      if (UniquePokedexEntries != other.UniquePokedexEntries) return false;
      if (PokemonsCaptured != other.PokemonsCaptured) return false;
      if (Evolutions != other.Evolutions) return false;
      if (PokeStopVisits != other.PokeStopVisits) return false;
      if (PokeballsThrown != other.PokeballsThrown) return false;
      if (EggsHatched != other.EggsHatched) return false;
      if (BigMagikarpCaught != other.BigMagikarpCaught) return false;
      if (BattleAttackWon != other.BattleAttackWon) return false;
      if (BattleAttackTotal != other.BattleAttackTotal) return false;
      if (BattleDefendedWon != other.BattleDefendedWon) return false;
      if (BattleTrainingWon != other.BattleTrainingWon) return false;
      if (BattleTrainingTotal != other.BattleTrainingTotal) return false;
      if (PrestigeRaisedTotal != other.PrestigeRaisedTotal) return false;
      if (PrestigeDroppedTotal != other.PrestigeDroppedTotal) return false;
      if (PokemonDeployed != other.PokemonDeployed) return false;
      if (PokemonCaughtByType != other.PokemonCaughtByType) return false;
      if (SmallRattataCaught != other.SmallRattataCaught) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Experience != 0L) hash ^= Experience.GetHashCode();
      if (PrevLevelXp != 0L) hash ^= PrevLevelXp.GetHashCode();
      if (NextLevelXp != 0L) hash ^= NextLevelXp.GetHashCode();
      if (KmWalked != 0F) hash ^= KmWalked.GetHashCode();
      if (PokemonsEncountered != 0) hash ^= PokemonsEncountered.GetHashCode();
      if (UniquePokedexEntries != 0) hash ^= UniquePokedexEntries.GetHashCode();
      if (PokemonsCaptured != 0) hash ^= PokemonsCaptured.GetHashCode();
      if (Evolutions != 0) hash ^= Evolutions.GetHashCode();
      if (PokeStopVisits != 0) hash ^= PokeStopVisits.GetHashCode();
      if (PokeballsThrown != 0) hash ^= PokeballsThrown.GetHashCode();
      if (EggsHatched != 0) hash ^= EggsHatched.GetHashCode();
      if (BigMagikarpCaught != 0) hash ^= BigMagikarpCaught.GetHashCode();
      if (BattleAttackWon != 0) hash ^= BattleAttackWon.GetHashCode();
      if (BattleAttackTotal != 0) hash ^= BattleAttackTotal.GetHashCode();
      if (BattleDefendedWon != 0) hash ^= BattleDefendedWon.GetHashCode();
      if (BattleTrainingWon != 0) hash ^= BattleTrainingWon.GetHashCode();
      if (BattleTrainingTotal != 0) hash ^= BattleTrainingTotal.GetHashCode();
      if (PrestigeRaisedTotal != 0) hash ^= PrestigeRaisedTotal.GetHashCode();
      if (PrestigeDroppedTotal != 0) hash ^= PrestigeDroppedTotal.GetHashCode();
      if (PokemonDeployed != 0) hash ^= PokemonDeployed.GetHashCode();
      if (PokemonCaughtByType.Length != 0) hash ^= PokemonCaughtByType.GetHashCode();
      if (SmallRattataCaught != 0) hash ^= SmallRattataCaught.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Level);
      }
      if (Experience != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Experience);
      }
      if (PrevLevelXp != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(PrevLevelXp);
      }
      if (NextLevelXp != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(NextLevelXp);
      }
      if (KmWalked != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(KmWalked);
      }
      if (PokemonsEncountered != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(PokemonsEncountered);
      }
      if (UniquePokedexEntries != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(UniquePokedexEntries);
      }
      if (PokemonsCaptured != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(PokemonsCaptured);
      }
      if (Evolutions != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Evolutions);
      }
      if (PokeStopVisits != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(PokeStopVisits);
      }
      if (PokeballsThrown != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(PokeballsThrown);
      }
      if (EggsHatched != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(EggsHatched);
      }
      if (BigMagikarpCaught != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(BigMagikarpCaught);
      }
      if (BattleAttackWon != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(BattleAttackWon);
      }
      if (BattleAttackTotal != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(BattleAttackTotal);
      }
      if (BattleDefendedWon != 0) {
        output.WriteRawTag(128, 1);
        output.WriteInt32(BattleDefendedWon);
      }
      if (BattleTrainingWon != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(BattleTrainingWon);
      }
      if (BattleTrainingTotal != 0) {
        output.WriteRawTag(144, 1);
        output.WriteInt32(BattleTrainingTotal);
      }
      if (PrestigeRaisedTotal != 0) {
        output.WriteRawTag(152, 1);
        output.WriteInt32(PrestigeRaisedTotal);
      }
      if (PrestigeDroppedTotal != 0) {
        output.WriteRawTag(160, 1);
        output.WriteInt32(PrestigeDroppedTotal);
      }
      if (PokemonDeployed != 0) {
        output.WriteRawTag(168, 1);
        output.WriteInt32(PokemonDeployed);
      }
      if (PokemonCaughtByType.Length != 0) {
        output.WriteRawTag(178, 1);
        output.WriteBytes(PokemonCaughtByType);
      }
      if (SmallRattataCaught != 0) {
        output.WriteRawTag(184, 1);
        output.WriteInt32(SmallRattataCaught);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (Experience != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Experience);
      }
      if (PrevLevelXp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PrevLevelXp);
      }
      if (NextLevelXp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextLevelXp);
      }
      if (KmWalked != 0F) {
        size += 1 + 4;
      }
      if (PokemonsEncountered != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonsEncountered);
      }
      if (UniquePokedexEntries != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UniquePokedexEntries);
      }
      if (PokemonsCaptured != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonsCaptured);
      }
      if (Evolutions != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Evolutions);
      }
      if (PokeStopVisits != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokeStopVisits);
      }
      if (PokeballsThrown != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokeballsThrown);
      }
      if (EggsHatched != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggsHatched);
      }
      if (BigMagikarpCaught != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BigMagikarpCaught);
      }
      if (BattleAttackWon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleAttackWon);
      }
      if (BattleAttackTotal != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleAttackTotal);
      }
      if (BattleDefendedWon != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattleDefendedWon);
      }
      if (BattleTrainingWon != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattleTrainingWon);
      }
      if (BattleTrainingTotal != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattleTrainingTotal);
      }
      if (PrestigeRaisedTotal != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(PrestigeRaisedTotal);
      }
      if (PrestigeDroppedTotal != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(PrestigeDroppedTotal);
      }
      if (PokemonDeployed != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(PokemonDeployed);
      }
      if (PokemonCaughtByType.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(PokemonCaughtByType);
      }
      if (SmallRattataCaught != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(SmallRattataCaught);
      }
      return size;
    }

    public void MergeFrom(PlayerStats other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Experience != 0L) {
        Experience = other.Experience;
      }
      if (other.PrevLevelXp != 0L) {
        PrevLevelXp = other.PrevLevelXp;
      }
      if (other.NextLevelXp != 0L) {
        NextLevelXp = other.NextLevelXp;
      }
      if (other.KmWalked != 0F) {
        KmWalked = other.KmWalked;
      }
      if (other.PokemonsEncountered != 0) {
        PokemonsEncountered = other.PokemonsEncountered;
      }
      if (other.UniquePokedexEntries != 0) {
        UniquePokedexEntries = other.UniquePokedexEntries;
      }
      if (other.PokemonsCaptured != 0) {
        PokemonsCaptured = other.PokemonsCaptured;
      }
      if (other.Evolutions != 0) {
        Evolutions = other.Evolutions;
      }
      if (other.PokeStopVisits != 0) {
        PokeStopVisits = other.PokeStopVisits;
      }
      if (other.PokeballsThrown != 0) {
        PokeballsThrown = other.PokeballsThrown;
      }
      if (other.EggsHatched != 0) {
        EggsHatched = other.EggsHatched;
      }
      if (other.BigMagikarpCaught != 0) {
        BigMagikarpCaught = other.BigMagikarpCaught;
      }
      if (other.BattleAttackWon != 0) {
        BattleAttackWon = other.BattleAttackWon;
      }
      if (other.BattleAttackTotal != 0) {
        BattleAttackTotal = other.BattleAttackTotal;
      }
      if (other.BattleDefendedWon != 0) {
        BattleDefendedWon = other.BattleDefendedWon;
      }
      if (other.BattleTrainingWon != 0) {
        BattleTrainingWon = other.BattleTrainingWon;
      }
      if (other.BattleTrainingTotal != 0) {
        BattleTrainingTotal = other.BattleTrainingTotal;
      }
      if (other.PrestigeRaisedTotal != 0) {
        PrestigeRaisedTotal = other.PrestigeRaisedTotal;
      }
      if (other.PrestigeDroppedTotal != 0) {
        PrestigeDroppedTotal = other.PrestigeDroppedTotal;
      }
      if (other.PokemonDeployed != 0) {
        PokemonDeployed = other.PokemonDeployed;
      }
      if (other.PokemonCaughtByType.Length != 0) {
        PokemonCaughtByType = other.PokemonCaughtByType;
      }
      if (other.SmallRattataCaught != 0) {
        SmallRattataCaught = other.SmallRattataCaught;
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
            Level = input.ReadInt32();
            break;
          }
          case 16: {
            Experience = input.ReadInt64();
            break;
          }
          case 24: {
            PrevLevelXp = input.ReadInt64();
            break;
          }
          case 32: {
            NextLevelXp = input.ReadInt64();
            break;
          }
          case 45: {
            KmWalked = input.ReadFloat();
            break;
          }
          case 48: {
            PokemonsEncountered = input.ReadInt32();
            break;
          }
          case 56: {
            UniquePokedexEntries = input.ReadInt32();
            break;
          }
          case 64: {
            PokemonsCaptured = input.ReadInt32();
            break;
          }
          case 72: {
            Evolutions = input.ReadInt32();
            break;
          }
          case 80: {
            PokeStopVisits = input.ReadInt32();
            break;
          }
          case 88: {
            PokeballsThrown = input.ReadInt32();
            break;
          }
          case 96: {
            EggsHatched = input.ReadInt32();
            break;
          }
          case 104: {
            BigMagikarpCaught = input.ReadInt32();
            break;
          }
          case 112: {
            BattleAttackWon = input.ReadInt32();
            break;
          }
          case 120: {
            BattleAttackTotal = input.ReadInt32();
            break;
          }
          case 128: {
            BattleDefendedWon = input.ReadInt32();
            break;
          }
          case 136: {
            BattleTrainingWon = input.ReadInt32();
            break;
          }
          case 144: {
            BattleTrainingTotal = input.ReadInt32();
            break;
          }
          case 152: {
            PrestigeRaisedTotal = input.ReadInt32();
            break;
          }
          case 160: {
            PrestigeDroppedTotal = input.ReadInt32();
            break;
          }
          case 168: {
            PokemonDeployed = input.ReadInt32();
            break;
          }
          case 178: {
            PokemonCaughtByType = input.ReadBytes();
            break;
          }
          case 184: {
            SmallRattataCaught = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
