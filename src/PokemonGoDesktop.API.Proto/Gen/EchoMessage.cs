// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/EchoMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/EchoMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class EchoMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/EchoMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EchoMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0VjaG9NZXNzYWdlLnBy",
            "b3RvEhxOZXR3b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzIg0KC0VjaG9NZXNz",
            "YWdlQh2qAhpQb2tlbW9uR29EZXNrdG9wLkFQSS5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.EchoMessage), global::PokemonGoDesktop.API.Proto.EchoMessage.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  No message needed.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class EchoMessage : pb::IMessage<EchoMessage> {
    private static readonly pb::MessageParser<EchoMessage> _parser = new pb::MessageParser<EchoMessage>(() => new EchoMessage());
    public static pb::MessageParser<EchoMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.EchoMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public EchoMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public EchoMessage(EchoMessage other) : this() {
    }

    public EchoMessage Clone() {
      return new EchoMessage(this);
    }

    public override bool Equals(object other) {
      return Equals(other as EchoMessage);
    }

    public bool Equals(EchoMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(EchoMessage other) {
      if (other == null) {
        return;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
