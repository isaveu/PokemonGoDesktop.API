// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/EggIncubators.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Inventory/EggIncubators.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class EggIncubatorsReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/EggIncubators.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EggIncubatorsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1JbnZlbnRvcnkvRWdnSW5jdWJhdG9ycy5wcm90bxIJSW52ZW50b3J5GhxJ",
            "bnZlbnRvcnkvRWdnSW5jdWJhdG9yLnByb3RvIj8KDUVnZ0luY3ViYXRvcnMS",
            "LgoNZWdnX2luY3ViYXRvchgBIAEoCzIXLkludmVudG9yeS5FZ2dJbmN1YmF0",
            "b3JCHaoCGlBva2Vtb25Hb0Rlc2t0b3AuQVBJLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.EggIncubatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.EggIncubators), global::PokemonGoDesktop.API.Proto.EggIncubators.Parser, new[]{ "EggIncubator" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class EggIncubators : pb::IMessage<EggIncubators> {
    private static readonly pb::MessageParser<EggIncubators> _parser = new pb::MessageParser<EggIncubators>(() => new EggIncubators());
    public static pb::MessageParser<EggIncubators> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.EggIncubatorsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public EggIncubators() {
      OnConstruction();
    }

    partial void OnConstruction();

    public EggIncubators(EggIncubators other) : this() {
      EggIncubator = other.eggIncubator_ != null ? other.EggIncubator.Clone() : null;
    }

    public EggIncubators Clone() {
      return new EggIncubators(this);
    }

    /// <summary>Field number for the "egg_incubator" field.</summary>
    public const int EggIncubatorFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.EggIncubator eggIncubator_;
    public global::PokemonGoDesktop.API.Proto.EggIncubator EggIncubator {
      get { return eggIncubator_; }
      set {
        eggIncubator_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as EggIncubators);
    }

    public bool Equals(EggIncubators other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EggIncubator, other.EggIncubator)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (eggIncubator_ != null) hash ^= EggIncubator.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (eggIncubator_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EggIncubator);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (eggIncubator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubator);
      }
      return size;
    }

    public void MergeFrom(EggIncubators other) {
      if (other == null) {
        return;
      }
      if (other.eggIncubator_ != null) {
        if (eggIncubator_ == null) {
          eggIncubator_ = new global::PokemonGoDesktop.API.Proto.EggIncubator();
        }
        EggIncubator.MergeFrom(other.EggIncubator);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (eggIncubator_ == null) {
              eggIncubator_ = new global::PokemonGoDesktop.API.Proto.EggIncubator();
            }
            input.ReadMessage(eggIncubator_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
