// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BattleActionType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Battle {

  /// <summary>Holder for reflection information generated from BattleActionType.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class BattleActionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for BattleActionType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleActionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZCYXR0bGVBY3Rpb25UeXBlLnByb3RvEhZQT0dPUHJvdG9zLkRhdGEuQmF0",
            "dGxlKvwBChBCYXR0bGVBY3Rpb25UeXBlEhAKDEFDVElPTl9VTlNFVBAAEhEK",
            "DUFDVElPTl9BVFRBQ0sQARIQCgxBQ1RJT05fRE9ER0UQAhIZChVBQ1RJT05f",
            "U1BFQ0lBTF9BVFRBQ0sQAxIXChNBQ1RJT05fU1dBUF9QT0tFTU9OEAQSEAoM",
            "QUNUSU9OX0ZBSU5UEAUSFgoSQUNUSU9OX1BMQVlFUl9KT0lOEAYSFgoSQUNU",
            "SU9OX1BMQVlFUl9RVUlUEAcSEgoOQUNUSU9OX1ZJQ1RPUlkQCBIRCg1BQ1RJ",
            "T05fREVGRUFUEAkSFAoQQUNUSU9OX1RJTUVEX09VVBAKYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Data.Battle.BattleActionType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum BattleActionType {
    [pbr::OriginalName("ACTION_UNSET")] ActionUnset = 0,
    [pbr::OriginalName("ACTION_ATTACK")] ActionAttack = 1,
    [pbr::OriginalName("ACTION_DODGE")] ActionDodge = 2,
    [pbr::OriginalName("ACTION_SPECIAL_ATTACK")] ActionSpecialAttack = 3,
    [pbr::OriginalName("ACTION_SWAP_POKEMON")] ActionSwapPokemon = 4,
    [pbr::OriginalName("ACTION_FAINT")] ActionFaint = 5,
    [pbr::OriginalName("ACTION_PLAYER_JOIN")] ActionPlayerJoin = 6,
    [pbr::OriginalName("ACTION_PLAYER_QUIT")] ActionPlayerQuit = 7,
    [pbr::OriginalName("ACTION_VICTORY")] ActionVictory = 8,
    [pbr::OriginalName("ACTION_DEFEAT")] ActionDefeat = 9,
    [pbr::OriginalName("ACTION_TIMED_OUT")] ActionTimedOut = 10,
  }

  #endregion

}

#endregion Designer generated code