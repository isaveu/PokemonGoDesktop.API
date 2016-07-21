// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data/Capture/CaptureAward.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Data.Capture {

  /// <summary>Holder for reflection information generated from Data/Capture/CaptureAward.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CaptureAwardReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/Capture/CaptureAward.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CaptureAwardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9EYXRhL0NhcHR1cmUvQ2FwdHVyZUF3YXJkLnByb3RvEgxEYXRhLkNhcHR1",
            "cmUaGEVudW1zL0FjdGl2aXR5VHlwZS5wcm90byJnCgxDYXB0dXJlQXdhcmQS",
            "KgoNYWN0aXZpdHlfdHlwZRgBIAMoDjITLkVudW1zLkFjdGl2aXR5VHlwZRIK",
            "CgJ4cBgCIAMoBRINCgVjYW5keRgDIAMoBRIQCghzdGFyZHVzdBgEIAMoBWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Enums.ActivityTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.Capture.CaptureAward), global::Data.Capture.CaptureAward.Parser, new[]{ "ActivityType", "Xp", "Candy", "Stardust" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CaptureAward : pb::IMessage<CaptureAward> {
    private static readonly pb::MessageParser<CaptureAward> _parser = new pb::MessageParser<CaptureAward>(() => new CaptureAward());
    public static pb::MessageParser<CaptureAward> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.Capture.CaptureAwardReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CaptureAward() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CaptureAward(CaptureAward other) : this() {
      activityType_ = other.activityType_.Clone();
      xp_ = other.xp_.Clone();
      candy_ = other.candy_.Clone();
      stardust_ = other.stardust_.Clone();
    }

    public CaptureAward Clone() {
      return new CaptureAward(this);
    }

    /// <summary>Field number for the "activity_type" field.</summary>
    public const int ActivityTypeFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Enums.ActivityType> _repeated_activityType_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::Enums.ActivityType) x);
    private readonly pbc::RepeatedField<global::Enums.ActivityType> activityType_ = new pbc::RepeatedField<global::Enums.ActivityType>();
    public pbc::RepeatedField<global::Enums.ActivityType> ActivityType {
      get { return activityType_; }
    }

    /// <summary>Field number for the "xp" field.</summary>
    public const int XpFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_xp_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> xp_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> Xp {
      get { return xp_; }
    }

    /// <summary>Field number for the "candy" field.</summary>
    public const int CandyFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_candy_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> candy_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> Candy {
      get { return candy_; }
    }

    /// <summary>Field number for the "stardust" field.</summary>
    public const int StardustFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_stardust_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> stardust_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> Stardust {
      get { return stardust_; }
    }

    public override bool Equals(object other) {
      return Equals(other as CaptureAward);
    }

    public bool Equals(CaptureAward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!activityType_.Equals(other.activityType_)) return false;
      if(!xp_.Equals(other.xp_)) return false;
      if(!candy_.Equals(other.candy_)) return false;
      if(!stardust_.Equals(other.stardust_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= activityType_.GetHashCode();
      hash ^= xp_.GetHashCode();
      hash ^= candy_.GetHashCode();
      hash ^= stardust_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      activityType_.WriteTo(output, _repeated_activityType_codec);
      xp_.WriteTo(output, _repeated_xp_codec);
      candy_.WriteTo(output, _repeated_candy_codec);
      stardust_.WriteTo(output, _repeated_stardust_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += activityType_.CalculateSize(_repeated_activityType_codec);
      size += xp_.CalculateSize(_repeated_xp_codec);
      size += candy_.CalculateSize(_repeated_candy_codec);
      size += stardust_.CalculateSize(_repeated_stardust_codec);
      return size;
    }

    public void MergeFrom(CaptureAward other) {
      if (other == null) {
        return;
      }
      activityType_.Add(other.activityType_);
      xp_.Add(other.xp_);
      candy_.Add(other.candy_);
      stardust_.Add(other.stardust_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 8: {
            activityType_.AddEntriesFrom(input, _repeated_activityType_codec);
            break;
          }
          case 18:
          case 16: {
            xp_.AddEntriesFrom(input, _repeated_xp_codec);
            break;
          }
          case 26:
          case 24: {
            candy_.AddEntriesFrom(input, _repeated_candy_codec);
            break;
          }
          case 34:
          case 32: {
            stardust_.AddEntriesFrom(input, _repeated_stardust_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
