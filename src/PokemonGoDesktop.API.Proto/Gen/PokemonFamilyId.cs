// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Enums/PokemonFamilyId.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Enums {

  /// <summary>Holder for reflection information generated from Enums/PokemonFamilyId.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokemonFamilyIdReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums/PokemonFamilyId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonFamilyIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtFbnVtcy9Qb2tlbW9uRmFtaWx5SWQucHJvdG8SBUVudW1zKvoMCg9Qb2tl",
            "bW9uRmFtaWx5SWQSEAoMRkFNSUxZX1VOU0VUEAASFAoQRkFNSUxZX0JVTEJB",
            "U0FVUhABEhUKEUZBTUlMWV9DSEFSTUFOREVSEAQSEwoPRkFNSUxZX1NRVUlS",
            "VExFEAcSEwoPRkFNSUxZX0NBVEVSUElFEAoSEQoNRkFNSUxZX1dFRURMRRAN",
            "EhEKDUZBTUlMWV9QSURHRVkQEBISCg5GQU1JTFlfUkFUVEFUQRATEhIKDkZB",
            "TUlMWV9TUEVBUk9XEBUSEAoMRkFNSUxZX0VLQU5TEBcSEgoORkFNSUxZX1BJ",
            "S0FDSFUQGRIUChBGQU1JTFlfU0FORFNIUkVXEBsSGQoVRkFNSUxZX05JRE9S",
            "QU5fRkVNQUxFEB0SFwoTRkFNSUxZX05JRE9SQU5fTUFMRRAgEhMKD0ZBTUlM",
            "WV9DTEVGQUlSWRAjEhEKDUZBTUlMWV9WVUxQSVgQJRIVChFGQU1JTFlfSklH",
            "R0xZUFVGRhAnEhAKDEZBTUlMWV9aVUJBVBApEhEKDUZBTUlMWV9PRERJU0gQ",
            "KxIQCgxGQU1JTFlfUEFSQVMQLhISCg5GQU1JTFlfVkVOT05BVBAwEhIKDkZB",
            "TUlMWV9ESUdMRVRUEDISEQoNRkFNSUxZX01FT1dUSBA0EhIKDkZBTUlMWV9Q",
            "U1lEVUNLEDYSEQoNRkFNSUxZX01BTktFWRA4EhQKEEZBTUlMWV9HUk9XTElU",
            "SEUQOhISCg5GQU1JTFlfUE9MSVdBRxA8Eg8KC0ZBTUlMWV9BQlJBED8SEQoN",
            "RkFNSUxZX01BQ0hPUBBCEhUKEUZBTUlMWV9CRUxMU1BST1VUEEUSFAoQRkFN",
            "SUxZX1RFTlRBQ09PTBBIEhIKDkZBTUlMWV9HRU9EVURFEEoSEQoNRkFNSUxZ",
            "X1BPTllUQRBNEhMKD0ZBTUlMWV9TTE9XUE9LRRBPEhQKEEZBTUlMWV9NQUdO",
            "RU1JVEUQURIUChBGQU1JTFlfRkFSRkVUQ0hEEFMSEAoMRkFNSUxZX0RPRFVP",
            "EFQSDwoLRkFNSUxZX1NFRUwQVhIRCg1GQU1JTFlfR1JJTUVSEFgSEwoPRkFN",
            "SUxZX1NIRUxMREVSEFoSEQoNRkFNSUxZX0dBU1RMWRBcEg8KC0ZBTUlMWV9P",
            "TklYEF8SEgoORkFNSUxZX0RST1daRUUQYBIQCgxGQU1JTFlfSFlQTk8QYRIR",
            "Cg1GQU1JTFlfS1JBQkJZEGISEgoORkFNSUxZX1ZPTFRPUkIQZBIUChBGQU1J",
            "TFlfRVhFR0dDVVRFEGYSEQoNRkFNSUxZX0NVQk9ORRBoEhQKEEZBTUlMWV9I",
            "SVRNT05MRUUQahIVChFGQU1JTFlfSElUTU9OQ0hBThBrEhQKEEZBTUlMWV9M",
            "SUNLSVRVTkcQbBISCg5GQU1JTFlfS09GRklORxBtEhIKDkZBTUlMWV9SSFlI",
            "T1JOEG8SEgoORkFNSUxZX0NIQU5TRVkQcRISCg5GQU1JTFlfVEFOR0VMQRBy",
            "EhUKEUZBTUlMWV9LQU5HQVNLSEFOEHMSEQoNRkFNSUxZX0hPUlNFQRB0EhIK",
            "DkZBTUlMWV9HT0xERUVOEHYSEQoNRkFNSUxZX1NUQVJZVRB4EhIKDkZBTUlM",
            "WV9NUl9NSU1FEHoSEgoORkFNSUxZX1NDWVRIRVIQexIPCgtGQU1JTFlfSllO",
            "WBB8EhUKEUZBTUlMWV9FTEVDVEFCVVpaEH0SEQoNRkFNSUxZX01BR01BUhB+",
            "EhEKDUZBTUlMWV9QSU5TSVIQfxISCg1GQU1JTFlfVEFVUk9TEIABEhQKD0ZB",
            "TUlMWV9NQUdJS0FSUBCBARISCg1GQU1JTFlfTEFQUkFTEIMBEhEKDEZBTUlM",
            "WV9ESVRUTxCEARIRCgxGQU1JTFlfRUVWRUUQhQESEwoORkFNSUxZX1BPUllH",
            "T04QiQESEwoORkFNSUxZX09NQU5ZVEUQigESEgoNRkFNSUxZX0tBQlVUTxCM",
            "ARIWChFGQU1JTFlfQUVST0RBQ1RZTBCOARITCg5GQU1JTFlfU05PUkxBWBCP",
            "ARIUCg9GQU1JTFlfQVJUSUNVTk8QkAESEgoNRkFNSUxZX1pBUERPUxCRARIT",
            "Cg5GQU1JTFlfTU9MVFJFUxCSARITCg5GQU1JTFlfRFJBVElOSRCTARISCg1G",
            "QU1JTFlfTUVXVFdPEJYBEg8KCkZBTUlMWV9NRVcQlwFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Enums.PokemonFamilyId), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonFamilyId {
    [pbr::OriginalName("FAMILY_UNSET")] FamilyUnset = 0,
    [pbr::OriginalName("FAMILY_BULBASAUR")] FamilyBulbasaur = 1,
    [pbr::OriginalName("FAMILY_CHARMANDER")] FamilyCharmander = 4,
    [pbr::OriginalName("FAMILY_SQUIRTLE")] FamilySquirtle = 7,
    [pbr::OriginalName("FAMILY_CATERPIE")] FamilyCaterpie = 10,
    [pbr::OriginalName("FAMILY_WEEDLE")] FamilyWeedle = 13,
    [pbr::OriginalName("FAMILY_PIDGEY")] FamilyPidgey = 16,
    [pbr::OriginalName("FAMILY_RATTATA")] FamilyRattata = 19,
    [pbr::OriginalName("FAMILY_SPEAROW")] FamilySpearow = 21,
    [pbr::OriginalName("FAMILY_EKANS")] FamilyEkans = 23,
    [pbr::OriginalName("FAMILY_PIKACHU")] FamilyPikachu = 25,
    [pbr::OriginalName("FAMILY_SANDSHREW")] FamilySandshrew = 27,
    [pbr::OriginalName("FAMILY_NIDORAN_FEMALE")] FamilyNidoranFemale = 29,
    [pbr::OriginalName("FAMILY_NIDORAN_MALE")] FamilyNidoranMale = 32,
    [pbr::OriginalName("FAMILY_CLEFAIRY")] FamilyClefairy = 35,
    [pbr::OriginalName("FAMILY_VULPIX")] FamilyVulpix = 37,
    [pbr::OriginalName("FAMILY_JIGGLYPUFF")] FamilyJigglypuff = 39,
    [pbr::OriginalName("FAMILY_ZUBAT")] FamilyZubat = 41,
    [pbr::OriginalName("FAMILY_ODDISH")] FamilyOddish = 43,
    [pbr::OriginalName("FAMILY_PARAS")] FamilyParas = 46,
    [pbr::OriginalName("FAMILY_VENONAT")] FamilyVenonat = 48,
    [pbr::OriginalName("FAMILY_DIGLETT")] FamilyDiglett = 50,
    [pbr::OriginalName("FAMILY_MEOWTH")] FamilyMeowth = 52,
    [pbr::OriginalName("FAMILY_PSYDUCK")] FamilyPsyduck = 54,
    [pbr::OriginalName("FAMILY_MANKEY")] FamilyMankey = 56,
    [pbr::OriginalName("FAMILY_GROWLITHE")] FamilyGrowlithe = 58,
    [pbr::OriginalName("FAMILY_POLIWAG")] FamilyPoliwag = 60,
    [pbr::OriginalName("FAMILY_ABRA")] FamilyAbra = 63,
    [pbr::OriginalName("FAMILY_MACHOP")] FamilyMachop = 66,
    [pbr::OriginalName("FAMILY_BELLSPROUT")] FamilyBellsprout = 69,
    [pbr::OriginalName("FAMILY_TENTACOOL")] FamilyTentacool = 72,
    [pbr::OriginalName("FAMILY_GEODUDE")] FamilyGeodude = 74,
    [pbr::OriginalName("FAMILY_PONYTA")] FamilyPonyta = 77,
    [pbr::OriginalName("FAMILY_SLOWPOKE")] FamilySlowpoke = 79,
    [pbr::OriginalName("FAMILY_MAGNEMITE")] FamilyMagnemite = 81,
    [pbr::OriginalName("FAMILY_FARFETCHD")] FamilyFarfetchd = 83,
    [pbr::OriginalName("FAMILY_DODUO")] FamilyDoduo = 84,
    [pbr::OriginalName("FAMILY_SEEL")] FamilySeel = 86,
    [pbr::OriginalName("FAMILY_GRIMER")] FamilyGrimer = 88,
    [pbr::OriginalName("FAMILY_SHELLDER")] FamilyShellder = 90,
    [pbr::OriginalName("FAMILY_GASTLY")] FamilyGastly = 92,
    [pbr::OriginalName("FAMILY_ONIX")] FamilyOnix = 95,
    [pbr::OriginalName("FAMILY_DROWZEE")] FamilyDrowzee = 96,
    [pbr::OriginalName("FAMILY_HYPNO")] FamilyHypno = 97,
    [pbr::OriginalName("FAMILY_KRABBY")] FamilyKrabby = 98,
    [pbr::OriginalName("FAMILY_VOLTORB")] FamilyVoltorb = 100,
    [pbr::OriginalName("FAMILY_EXEGGCUTE")] FamilyExeggcute = 102,
    [pbr::OriginalName("FAMILY_CUBONE")] FamilyCubone = 104,
    [pbr::OriginalName("FAMILY_HITMONLEE")] FamilyHitmonlee = 106,
    [pbr::OriginalName("FAMILY_HITMONCHAN")] FamilyHitmonchan = 107,
    [pbr::OriginalName("FAMILY_LICKITUNG")] FamilyLickitung = 108,
    [pbr::OriginalName("FAMILY_KOFFING")] FamilyKoffing = 109,
    [pbr::OriginalName("FAMILY_RHYHORN")] FamilyRhyhorn = 111,
    [pbr::OriginalName("FAMILY_CHANSEY")] FamilyChansey = 113,
    [pbr::OriginalName("FAMILY_TANGELA")] FamilyTangela = 114,
    [pbr::OriginalName("FAMILY_KANGASKHAN")] FamilyKangaskhan = 115,
    [pbr::OriginalName("FAMILY_HORSEA")] FamilyHorsea = 116,
    [pbr::OriginalName("FAMILY_GOLDEEN")] FamilyGoldeen = 118,
    [pbr::OriginalName("FAMILY_STARYU")] FamilyStaryu = 120,
    [pbr::OriginalName("FAMILY_MR_MIME")] FamilyMrMime = 122,
    [pbr::OriginalName("FAMILY_SCYTHER")] FamilyScyther = 123,
    [pbr::OriginalName("FAMILY_JYNX")] FamilyJynx = 124,
    [pbr::OriginalName("FAMILY_ELECTABUZZ")] FamilyElectabuzz = 125,
    [pbr::OriginalName("FAMILY_MAGMAR")] FamilyMagmar = 126,
    [pbr::OriginalName("FAMILY_PINSIR")] FamilyPinsir = 127,
    [pbr::OriginalName("FAMILY_TAUROS")] FamilyTauros = 128,
    [pbr::OriginalName("FAMILY_MAGIKARP")] FamilyMagikarp = 129,
    [pbr::OriginalName("FAMILY_LAPRAS")] FamilyLapras = 131,
    [pbr::OriginalName("FAMILY_DITTO")] FamilyDitto = 132,
    [pbr::OriginalName("FAMILY_EEVEE")] FamilyEevee = 133,
    [pbr::OriginalName("FAMILY_PORYGON")] FamilyPorygon = 137,
    [pbr::OriginalName("FAMILY_OMANYTE")] FamilyOmanyte = 138,
    [pbr::OriginalName("FAMILY_KABUTO")] FamilyKabuto = 140,
    [pbr::OriginalName("FAMILY_AERODACTYL")] FamilyAerodactyl = 142,
    [pbr::OriginalName("FAMILY_SNORLAX")] FamilySnorlax = 143,
    [pbr::OriginalName("FAMILY_ARTICUNO")] FamilyArticuno = 144,
    [pbr::OriginalName("FAMILY_ZAPDOS")] FamilyZapdos = 145,
    [pbr::OriginalName("FAMILY_MOLTRES")] FamilyMoltres = 146,
    [pbr::OriginalName("FAMILY_DRATINI")] FamilyDratini = 147,
    [pbr::OriginalName("FAMILY_MEWTWO")] FamilyMewtwo = 150,
    [pbr::OriginalName("FAMILY_MEW")] FamilyMew = 151,
  }

  #endregion

}

#endregion Designer generated code
