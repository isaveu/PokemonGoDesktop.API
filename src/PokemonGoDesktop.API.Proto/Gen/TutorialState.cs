// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Enums/TutorialState.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Enums {

  /// <summary>Holder for reflection information generated from Enums/TutorialState.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class TutorialStateReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums/TutorialState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TutorialStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlFbnVtcy9UdXRvcmlhbFN0YXRlLnByb3RvEgVFbnVtcyrkAQoNVHV0b3Jp",
            "YWxTdGF0ZRIQCgxMRUdBTF9TQ1JFRU4QABIUChBBVkFUQVJfU0VMRUNUSU9O",
            "EAESFAoQQUNDT1VOVF9DUkVBVElPThACEhMKD1BPS0VNT05fQ0FQVFVSRRAD",
            "EhIKDk5BTUVfU0VMRUNUSU9OEAQSEQoNUE9LRU1PTl9CRVJSWRAFEgwKCFVT",
            "RV9JVEVNEAYSIgoeRklSU1RfVElNRV9FWFBFUklFTkNFX0NPTVBMRVRFEAcS",
            "FQoRUE9LRVNUT1BfVFVUT1JJQUwQCBIQCgxHWU1fVFVUT1JJQUwQCWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Enums.TutorialState), }, null));
    }
    #endregion

  }
  #region Enums
  public enum TutorialState {
    [pbr::OriginalName("LEGAL_SCREEN")] LegalScreen = 0,
    [pbr::OriginalName("AVATAR_SELECTION")] AvatarSelection = 1,
    [pbr::OriginalName("ACCOUNT_CREATION")] AccountCreation = 2,
    [pbr::OriginalName("POKEMON_CAPTURE")] PokemonCapture = 3,
    [pbr::OriginalName("NAME_SELECTION")] NameSelection = 4,
    [pbr::OriginalName("POKEMON_BERRY")] PokemonBerry = 5,
    [pbr::OriginalName("USE_ITEM")] UseItem = 6,
    [pbr::OriginalName("FIRST_TIME_EXPERIENCE_COMPLETE")] FirstTimeExperienceComplete = 7,
    [pbr::OriginalName("POKESTOP_TUTORIAL")] PokestopTutorial = 8,
    [pbr::OriginalName("GYM_TUTORIAL")] GymTutorial = 9,
  }

  #endregion

}

#endregion Designer generated code
