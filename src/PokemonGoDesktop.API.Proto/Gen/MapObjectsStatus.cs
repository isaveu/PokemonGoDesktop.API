// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Map/MapObjectsStatus.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Map {

  /// <summary>Holder for reflection information generated from Map/MapObjectsStatus.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class MapObjectsStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for Map/MapObjectsStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapObjectsStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpNYXAvTWFwT2JqZWN0c1N0YXR1cy5wcm90bxIDTWFwKkUKEE1hcE9iamVj",
            "dHNTdGF0dXMSEAoMVU5TRVRfU1RBVFVTEAASCwoHU1VDQ0VTUxABEhIKDkxP",
            "Q0FUSU9OX1VOU0VUEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Map.MapObjectsStatus), }, null));
    }
    #endregion

  }
  #region Enums
  public enum MapObjectsStatus {
    [pbr::OriginalName("UNSET_STATUS")] UnsetStatus = 0,
    [pbr::OriginalName("SUCCESS")] Success = 1,
    [pbr::OriginalName("LOCATION_UNSET")] LocationUnset = 2,
  }

  #endregion

}

#endregion Designer generated code
