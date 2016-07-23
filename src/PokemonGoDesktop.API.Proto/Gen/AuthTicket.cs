// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Envelopes/AuthTicket.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Envelopes/AuthTicket.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class AuthTicketReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Envelopes/AuthTicket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuthTicketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVOZXR3b3JraW5nL0VudmVsb3Blcy9BdXRoVGlja2V0LnByb3RvEhROZXR3",
            "b3JraW5nLkVudmVsb3BlcyJFCgpBdXRoVGlja2V0Eg0KBXN0YXJ0GAEgASgM",
            "EhsKE2V4cGlyZV90aW1lc3RhbXBfbXMYAiABKAQSCwoDZW5kGAMgASgMQh2q",
            "AhpQb2tlbW9uR29EZXNrdG9wLkFQSS5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.AuthTicket), global::PokemonGoDesktop.API.Proto.AuthTicket.Parser, new[]{ "Start", "ExpireTimestampMs", "End" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class AuthTicket : pb::IMessage<AuthTicket> {
    private static readonly pb::MessageParser<AuthTicket> _parser = new pb::MessageParser<AuthTicket>(() => new AuthTicket());
    public static pb::MessageParser<AuthTicket> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.AuthTicketReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public AuthTicket() {
      OnConstruction();
    }

    partial void OnConstruction();

    public AuthTicket(AuthTicket other) : this() {
      start_ = other.start_;
      expireTimestampMs_ = other.expireTimestampMs_;
      end_ = other.end_;
    }

    public AuthTicket Clone() {
      return new AuthTicket(this);
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 1;
    private pb::ByteString start_ = pb::ByteString.Empty;
    public pb::ByteString Start {
      get { return start_; }
      set {
        start_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expire_timestamp_ms" field.</summary>
    public const int ExpireTimestampMsFieldNumber = 2;
    private ulong expireTimestampMs_;
    public ulong ExpireTimestampMs {
      get { return expireTimestampMs_; }
      set {
        expireTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "end" field.</summary>
    public const int EndFieldNumber = 3;
    private pb::ByteString end_ = pb::ByteString.Empty;
    public pb::ByteString End {
      get { return end_; }
      set {
        end_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as AuthTicket);
    }

    public bool Equals(AuthTicket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Start != other.Start) return false;
      if (ExpireTimestampMs != other.ExpireTimestampMs) return false;
      if (End != other.End) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Start.Length != 0) hash ^= Start.GetHashCode();
      if (ExpireTimestampMs != 0UL) hash ^= ExpireTimestampMs.GetHashCode();
      if (End.Length != 0) hash ^= End.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Start.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Start);
      }
      if (ExpireTimestampMs != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ExpireTimestampMs);
      }
      if (End.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(End);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Start.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Start);
      }
      if (ExpireTimestampMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ExpireTimestampMs);
      }
      if (End.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(End);
      }
      return size;
    }

    public void MergeFrom(AuthTicket other) {
      if (other == null) {
        return;
      }
      if (other.Start.Length != 0) {
        Start = other.Start;
      }
      if (other.ExpireTimestampMs != 0UL) {
        ExpireTimestampMs = other.ExpireTimestampMs;
      }
      if (other.End.Length != 0) {
        End = other.End;
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
            Start = input.ReadBytes();
            break;
          }
          case 16: {
            ExpireTimestampMs = input.ReadUInt64();
            break;
          }
          case 26: {
            End = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
