// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Envelopes/RequestEnvelope.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Envelopes/RequestEnvelope.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class RequestEnvelopeReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Envelopes/RequestEnvelope.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestEnvelopeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipOZXR3b3JraW5nL0VudmVsb3Blcy9SZXF1ZXN0RW52ZWxvcGUucHJvdG8S",
            "FE5ldHdvcmtpbmcuRW52ZWxvcGVzGiFOZXR3b3JraW5nL1JlcXVlc3RzL1Jl",
            "cXVlc3QucHJvdG8aJU5ldHdvcmtpbmcvRW52ZWxvcGVzL0F1dGhUaWNrZXQu",
            "cHJvdG8aI05ldHdvcmtpbmcvRW52ZWxvcGVzL1Vua25vd242LnByb3RvIu0D",
            "Cg9SZXF1ZXN0RW52ZWxvcGUSEwoLc3RhdHVzX2NvZGUYASABKAUSEgoKcmVx",
            "dWVzdF9pZBgDIAEoBBIuCghyZXF1ZXN0cxgEIAMoCzIcLk5ldHdvcmtpbmcu",
            "UmVxdWVzdHMuUmVxdWVzdBIwCgh1bmtub3duNhgGIAEoCzIeLk5ldHdvcmtp",
            "bmcuRW52ZWxvcGVzLlVua25vd242EhAKCGxhdGl0dWRlGAcgASgBEhEKCWxv",
            "bmdpdHVkZRgIIAEoARIQCghhbHRpdHVkZRgJIAEoARJBCglhdXRoX2luZm8Y",
            "CiABKAsyLi5OZXR3b3JraW5nLkVudmVsb3Blcy5SZXF1ZXN0RW52ZWxvcGUu",
            "QXV0aEluZm8SNQoLYXV0aF90aWNrZXQYCyABKAsyIC5OZXR3b3JraW5nLkVu",
            "dmVsb3Blcy5BdXRoVGlja2V0EhEKCXVua25vd24xMhgMIAEoAxqKAQoIQXV0",
            "aEluZm8SEAoIcHJvdmlkZXIYASABKAkSQQoFdG9rZW4YAiABKAsyMi5OZXR3",
            "b3JraW5nLkVudmVsb3Blcy5SZXF1ZXN0RW52ZWxvcGUuQXV0aEluZm8uSldU",
            "GikKA0pXVBIQCghjb250ZW50cxgBIAEoCRIQCgh1bmtub3duMhgCIAEoBUId",
            "qgIaUG9rZW1vbkdvRGVza3RvcC5BUEkuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.RequestReflection.Descriptor, global::PokemonGoDesktop.API.Proto.AuthTicketReflection.Descriptor, global::PokemonGoDesktop.API.Proto.Unknown6Reflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.RequestEnvelope), global::PokemonGoDesktop.API.Proto.RequestEnvelope.Parser, new[]{ "StatusCode", "RequestId", "Requests", "Unknown6", "Latitude", "Longitude", "Altitude", "AuthInfo", "AuthTicket", "Unknown12" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo), global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo.Parser, new[]{ "Provider", "Token" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo.Types.JWT), global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo.Types.JWT.Parser, new[]{ "Contents", "Unknown2" }, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class RequestEnvelope : pb::IMessage<RequestEnvelope> {
    private static readonly pb::MessageParser<RequestEnvelope> _parser = new pb::MessageParser<RequestEnvelope>(() => new RequestEnvelope());
    public static pb::MessageParser<RequestEnvelope> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.RequestEnvelopeReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public RequestEnvelope() {
      OnConstruction();
    }

    partial void OnConstruction();

    public RequestEnvelope(RequestEnvelope other) : this() {
      statusCode_ = other.statusCode_;
      requestId_ = other.requestId_;
      requests_ = other.requests_.Clone();
      Unknown6 = other.unknown6_ != null ? other.Unknown6.Clone() : null;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
      altitude_ = other.altitude_;
      AuthInfo = other.authInfo_ != null ? other.AuthInfo.Clone() : null;
      AuthTicket = other.authTicket_ != null ? other.AuthTicket.Clone() : null;
      unknown12_ = other.unknown12_;
    }

    public RequestEnvelope Clone() {
      return new RequestEnvelope(this);
    }

    /// <summary>Field number for the "status_code" field.</summary>
    public const int StatusCodeFieldNumber = 1;
    private int statusCode_;
    public int StatusCode {
      get { return statusCode_; }
      set {
        statusCode_ = value;
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 3;
    private ulong requestId_;
    public ulong RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    /// <summary>Field number for the "requests" field.</summary>
    public const int RequestsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::PokemonGoDesktop.API.Proto.Request> _repeated_requests_codec
        = pb::FieldCodec.ForMessage(34, global::PokemonGoDesktop.API.Proto.Request.Parser);
    private readonly pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.Request> requests_ = new pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.Request>();
    public pbc::RepeatedField<global::PokemonGoDesktop.API.Proto.Request> Requests {
      get { return requests_; }
    }

    /// <summary>Field number for the "unknown6" field.</summary>
    public const int Unknown6FieldNumber = 6;
    private global::PokemonGoDesktop.API.Proto.Unknown6 unknown6_;
    public global::PokemonGoDesktop.API.Proto.Unknown6 Unknown6 {
      get { return unknown6_; }
      set {
        unknown6_ = value;
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 7;
    private double latitude_;
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 8;
    private double longitude_;
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    /// <summary>Field number for the "altitude" field.</summary>
    public const int AltitudeFieldNumber = 9;
    private double altitude_;
    public double Altitude {
      get { return altitude_; }
      set {
        altitude_ = value;
      }
    }

    /// <summary>Field number for the "auth_info" field.</summary>
    public const int AuthInfoFieldNumber = 10;
    private global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo authInfo_;
    public global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo AuthInfo {
      get { return authInfo_; }
      set {
        authInfo_ = value;
      }
    }

    /// <summary>Field number for the "auth_ticket" field.</summary>
    public const int AuthTicketFieldNumber = 11;
    private global::PokemonGoDesktop.API.Proto.AuthTicket authTicket_;
    public global::PokemonGoDesktop.API.Proto.AuthTicket AuthTicket {
      get { return authTicket_; }
      set {
        authTicket_ = value;
      }
    }

    /// <summary>Field number for the "unknown12" field.</summary>
    public const int Unknown12FieldNumber = 12;
    private long unknown12_;
    public long Unknown12 {
      get { return unknown12_; }
      set {
        unknown12_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as RequestEnvelope);
    }

    public bool Equals(RequestEnvelope other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StatusCode != other.StatusCode) return false;
      if (RequestId != other.RequestId) return false;
      if(!requests_.Equals(other.requests_)) return false;
      if (!object.Equals(Unknown6, other.Unknown6)) return false;
      if (Latitude != other.Latitude) return false;
      if (Longitude != other.Longitude) return false;
      if (Altitude != other.Altitude) return false;
      if (!object.Equals(AuthInfo, other.AuthInfo)) return false;
      if (!object.Equals(AuthTicket, other.AuthTicket)) return false;
      if (Unknown12 != other.Unknown12) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (StatusCode != 0) hash ^= StatusCode.GetHashCode();
      if (RequestId != 0UL) hash ^= RequestId.GetHashCode();
      hash ^= requests_.GetHashCode();
      if (unknown6_ != null) hash ^= Unknown6.GetHashCode();
      if (Latitude != 0D) hash ^= Latitude.GetHashCode();
      if (Longitude != 0D) hash ^= Longitude.GetHashCode();
      if (Altitude != 0D) hash ^= Altitude.GetHashCode();
      if (authInfo_ != null) hash ^= AuthInfo.GetHashCode();
      if (authTicket_ != null) hash ^= AuthTicket.GetHashCode();
      if (Unknown12 != 0L) hash ^= Unknown12.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (StatusCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StatusCode);
      }
      if (RequestId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(RequestId);
      }
      requests_.WriteTo(output, _repeated_requests_codec);
      if (unknown6_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Unknown6);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(Longitude);
      }
      if (Altitude != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Altitude);
      }
      if (authInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(AuthInfo);
      }
      if (authTicket_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(AuthTicket);
      }
      if (Unknown12 != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(Unknown12);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (StatusCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StatusCode);
      }
      if (RequestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestId);
      }
      size += requests_.CalculateSize(_repeated_requests_codec);
      if (unknown6_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unknown6);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      if (Altitude != 0D) {
        size += 1 + 8;
      }
      if (authInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AuthInfo);
      }
      if (authTicket_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AuthTicket);
      }
      if (Unknown12 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Unknown12);
      }
      return size;
    }

    public void MergeFrom(RequestEnvelope other) {
      if (other == null) {
        return;
      }
      if (other.StatusCode != 0) {
        StatusCode = other.StatusCode;
      }
      if (other.RequestId != 0UL) {
        RequestId = other.RequestId;
      }
      requests_.Add(other.requests_);
      if (other.unknown6_ != null) {
        if (unknown6_ == null) {
          unknown6_ = new global::PokemonGoDesktop.API.Proto.Unknown6();
        }
        Unknown6.MergeFrom(other.Unknown6);
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
      if (other.Altitude != 0D) {
        Altitude = other.Altitude;
      }
      if (other.authInfo_ != null) {
        if (authInfo_ == null) {
          authInfo_ = new global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo();
        }
        AuthInfo.MergeFrom(other.AuthInfo);
      }
      if (other.authTicket_ != null) {
        if (authTicket_ == null) {
          authTicket_ = new global::PokemonGoDesktop.API.Proto.AuthTicket();
        }
        AuthTicket.MergeFrom(other.AuthTicket);
      }
      if (other.Unknown12 != 0L) {
        Unknown12 = other.Unknown12;
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
            StatusCode = input.ReadInt32();
            break;
          }
          case 24: {
            RequestId = input.ReadUInt64();
            break;
          }
          case 34: {
            requests_.AddEntriesFrom(input, _repeated_requests_codec);
            break;
          }
          case 50: {
            if (unknown6_ == null) {
              unknown6_ = new global::PokemonGoDesktop.API.Proto.Unknown6();
            }
            input.ReadMessage(unknown6_);
            break;
          }
          case 57: {
            Latitude = input.ReadDouble();
            break;
          }
          case 65: {
            Longitude = input.ReadDouble();
            break;
          }
          case 73: {
            Altitude = input.ReadDouble();
            break;
          }
          case 82: {
            if (authInfo_ == null) {
              authInfo_ = new global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo();
            }
            input.ReadMessage(authInfo_);
            break;
          }
          case 90: {
            if (authTicket_ == null) {
              authTicket_ = new global::PokemonGoDesktop.API.Proto.AuthTicket();
            }
            input.ReadMessage(authTicket_);
            break;
          }
          case 96: {
            Unknown12 = input.ReadInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RequestEnvelope message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class AuthInfo : pb::IMessage<AuthInfo> {
        private static readonly pb::MessageParser<AuthInfo> _parser = new pb::MessageParser<AuthInfo>(() => new AuthInfo());
        public static pb::MessageParser<AuthInfo> Parser { get { return _parser; } }

        public static pbr::MessageDescriptor Descriptor {
          get { return global::PokemonGoDesktop.API.Proto.RequestEnvelope.Descriptor.NestedTypes[0]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        public AuthInfo() {
          OnConstruction();
        }

        partial void OnConstruction();

        public AuthInfo(AuthInfo other) : this() {
          provider_ = other.provider_;
          Token = other.token_ != null ? other.Token.Clone() : null;
        }

        public AuthInfo Clone() {
          return new AuthInfo(this);
        }

        /// <summary>Field number for the "provider" field.</summary>
        public const int ProviderFieldNumber = 1;
        private string provider_ = "";
        public string Provider {
          get { return provider_; }
          set {
            provider_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "token" field.</summary>
        public const int TokenFieldNumber = 2;
        private global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo.Types.JWT token_;
        public global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo.Types.JWT Token {
          get { return token_; }
          set {
            token_ = value;
          }
        }

        public override bool Equals(object other) {
          return Equals(other as AuthInfo);
        }

        public bool Equals(AuthInfo other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Provider != other.Provider) return false;
          if (!object.Equals(Token, other.Token)) return false;
          return true;
        }

        public override int GetHashCode() {
          int hash = 1;
          if (Provider.Length != 0) hash ^= Provider.GetHashCode();
          if (token_ != null) hash ^= Token.GetHashCode();
          return hash;
        }

        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Provider.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Provider);
          }
          if (token_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(Token);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Provider.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Provider);
          }
          if (token_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Token);
          }
          return size;
        }

        public void MergeFrom(AuthInfo other) {
          if (other == null) {
            return;
          }
          if (other.Provider.Length != 0) {
            Provider = other.Provider;
          }
          if (other.token_ != null) {
            if (token_ == null) {
              token_ = new global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo.Types.JWT();
            }
            Token.MergeFrom(other.Token);
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
                Provider = input.ReadString();
                break;
              }
              case 18: {
                if (token_ == null) {
                  token_ = new global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo.Types.JWT();
                }
                input.ReadMessage(token_);
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the AuthInfo message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static partial class Types {
          [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
          public sealed partial class JWT : pb::IMessage<JWT> {
            private static readonly pb::MessageParser<JWT> _parser = new pb::MessageParser<JWT>(() => new JWT());
            public static pb::MessageParser<JWT> Parser { get { return _parser; } }

            public static pbr::MessageDescriptor Descriptor {
              get { return global::PokemonGoDesktop.API.Proto.RequestEnvelope.Types.AuthInfo.Descriptor.NestedTypes[0]; }
            }

            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            public JWT() {
              OnConstruction();
            }

            partial void OnConstruction();

            public JWT(JWT other) : this() {
              contents_ = other.contents_;
              unknown2_ = other.unknown2_;
            }

            public JWT Clone() {
              return new JWT(this);
            }

            /// <summary>Field number for the "contents" field.</summary>
            public const int ContentsFieldNumber = 1;
            private string contents_ = "";
            public string Contents {
              get { return contents_; }
              set {
                contents_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
              }
            }

            /// <summary>Field number for the "unknown2" field.</summary>
            public const int Unknown2FieldNumber = 2;
            private int unknown2_;
            public int Unknown2 {
              get { return unknown2_; }
              set {
                unknown2_ = value;
              }
            }

            public override bool Equals(object other) {
              return Equals(other as JWT);
            }

            public bool Equals(JWT other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (Contents != other.Contents) return false;
              if (Unknown2 != other.Unknown2) return false;
              return true;
            }

            public override int GetHashCode() {
              int hash = 1;
              if (Contents.Length != 0) hash ^= Contents.GetHashCode();
              if (Unknown2 != 0) hash ^= Unknown2.GetHashCode();
              return hash;
            }

            public override string ToString() {
              return pb::JsonFormatter.ToDiagnosticString(this);
            }

            public void WriteTo(pb::CodedOutputStream output) {
              if (Contents.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(Contents);
              }
              if (Unknown2 != 0) {
                output.WriteRawTag(16);
                output.WriteInt32(Unknown2);
              }
            }

            public int CalculateSize() {
              int size = 0;
              if (Contents.Length != 0) {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Contents);
              }
              if (Unknown2 != 0) {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown2);
              }
              return size;
            }

            public void MergeFrom(JWT other) {
              if (other == null) {
                return;
              }
              if (other.Contents.Length != 0) {
                Contents = other.Contents;
              }
              if (other.Unknown2 != 0) {
                Unknown2 = other.Unknown2;
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
                    Contents = input.ReadString();
                    break;
                  }
                  case 16: {
                    Unknown2 = input.ReadInt32();
                    break;
                  }
                }
              }
            }

          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
