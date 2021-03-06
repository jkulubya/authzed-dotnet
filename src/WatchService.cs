// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: authzed/api/v1/watch_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Authzed.Api.V1 {

  /// <summary>Holder for reflection information generated from authzed/api/v1/watch_service.proto</summary>
  public static partial class WatchServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for authzed/api/v1/watch_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WatchServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJhdXRoemVkL2FwaS92MS93YXRjaF9zZXJ2aWNlLnByb3RvEg5hdXRoemVk",
            "LmFwaS52MRoXdmFsaWRhdGUvdmFsaWRhdGUucHJvdG8aGWF1dGh6ZWQvYXBp",
            "L3YxL2NvcmUucHJvdG8i0AEKDFdhdGNoUmVxdWVzdBJyCgxvYmplY3RfdHlw",
            "ZXMYASADKAlCT/pCTJIBSQgBIkVyQyiAATI+XihbYS16XVthLXowLTlfXXsy",
            "LDYyfVthLXowLTldLyk/W2Etel1bYS16MC05X117Miw2Mn1bYS16MC05XSRS",
            "C29iamVjdFR5cGVzEkwKFW9wdGlvbmFsX3N0YXJ0X2N1cnNvchgCIAEoCzIY",
            "LmF1dGh6ZWQuYXBpLnYxLlplZFRva2VuUhNvcHRpb25hbFN0YXJ0Q3Vyc29y",
            "IpABCg1XYXRjaFJlc3BvbnNlEjwKB3VwZGF0ZXMYASADKAsyIi5hdXRoemVk",
            "LmFwaS52MS5SZWxhdGlvbnNoaXBVcGRhdGVSB3VwZGF0ZXMSQQoPY2hhbmdl",
            "c190aHJvdWdoGAIgASgLMhguYXV0aHplZC5hcGkudjEuWmVkVG9rZW5SDmNo",
            "YW5nZXNUaHJvdWdoMlgKDFdhdGNoU2VydmljZRJICgVXYXRjaBIcLmF1dGh6",
            "ZWQuYXBpLnYxLldhdGNoUmVxdWVzdBodLmF1dGh6ZWQuYXBpLnYxLldhdGNo",
            "UmVzcG9uc2UiADABQkgKEmNvbS5hdXRoemVkLmFwaS52MVoyZ2l0aHViLmNv",
            "bS9hdXRoemVkL2F1dGh6ZWQtZ28vcHJvdG8vYXV0aHplZC9hcGkvdjFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Validate.ValidateReflection.Descriptor, global::Authzed.Api.V1.CoreReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V1.WatchRequest), global::Authzed.Api.V1.WatchRequest.Parser, new[]{ "ObjectTypes", "OptionalStartCursor" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V1.WatchResponse), global::Authzed.Api.V1.WatchResponse.Parser, new[]{ "Updates", "ChangesThrough" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// WatchRequest specifies the object definitions for which we want to start
  /// watching mutations, and an optional start snapshot for when to start
  /// watching.
  /// </summary>
  public sealed partial class WatchRequest : pb::IMessage<WatchRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WatchRequest> _parser = new pb::MessageParser<WatchRequest>(() => new WatchRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WatchRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V1.WatchServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WatchRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WatchRequest(WatchRequest other) : this() {
      objectTypes_ = other.objectTypes_.Clone();
      optionalStartCursor_ = other.optionalStartCursor_ != null ? other.optionalStartCursor_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WatchRequest Clone() {
      return new WatchRequest(this);
    }

    /// <summary>Field number for the "object_types" field.</summary>
    public const int ObjectTypesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_objectTypes_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> objectTypes_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ObjectTypes {
      get { return objectTypes_; }
    }

    /// <summary>Field number for the "optional_start_cursor" field.</summary>
    public const int OptionalStartCursorFieldNumber = 2;
    private global::Authzed.Api.V1.ZedToken optionalStartCursor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Authzed.Api.V1.ZedToken OptionalStartCursor {
      get { return optionalStartCursor_; }
      set {
        optionalStartCursor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WatchRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WatchRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!objectTypes_.Equals(other.objectTypes_)) return false;
      if (!object.Equals(OptionalStartCursor, other.OptionalStartCursor)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= objectTypes_.GetHashCode();
      if (optionalStartCursor_ != null) hash ^= OptionalStartCursor.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      objectTypes_.WriteTo(output, _repeated_objectTypes_codec);
      if (optionalStartCursor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OptionalStartCursor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      objectTypes_.WriteTo(ref output, _repeated_objectTypes_codec);
      if (optionalStartCursor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OptionalStartCursor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += objectTypes_.CalculateSize(_repeated_objectTypes_codec);
      if (optionalStartCursor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OptionalStartCursor);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WatchRequest other) {
      if (other == null) {
        return;
      }
      objectTypes_.Add(other.objectTypes_);
      if (other.optionalStartCursor_ != null) {
        if (optionalStartCursor_ == null) {
          OptionalStartCursor = new global::Authzed.Api.V1.ZedToken();
        }
        OptionalStartCursor.MergeFrom(other.OptionalStartCursor);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            objectTypes_.AddEntriesFrom(input, _repeated_objectTypes_codec);
            break;
          }
          case 18: {
            if (optionalStartCursor_ == null) {
              OptionalStartCursor = new global::Authzed.Api.V1.ZedToken();
            }
            input.ReadMessage(OptionalStartCursor);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            objectTypes_.AddEntriesFrom(ref input, _repeated_objectTypes_codec);
            break;
          }
          case 18: {
            if (optionalStartCursor_ == null) {
              OptionalStartCursor = new global::Authzed.Api.V1.ZedToken();
            }
            input.ReadMessage(OptionalStartCursor);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// WatchResponse contains all tuple modification events in ascending
  /// timestamp order, from the requested start snapshot to a snapshot
  /// encoded in the watch response. The client can use the snapshot to resume
  /// watching where the previous watch response left off.
  /// </summary>
  public sealed partial class WatchResponse : pb::IMessage<WatchResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WatchResponse> _parser = new pb::MessageParser<WatchResponse>(() => new WatchResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WatchResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V1.WatchServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WatchResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WatchResponse(WatchResponse other) : this() {
      updates_ = other.updates_.Clone();
      changesThrough_ = other.changesThrough_ != null ? other.changesThrough_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WatchResponse Clone() {
      return new WatchResponse(this);
    }

    /// <summary>Field number for the "updates" field.</summary>
    public const int UpdatesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Authzed.Api.V1.RelationshipUpdate> _repeated_updates_codec
        = pb::FieldCodec.ForMessage(10, global::Authzed.Api.V1.RelationshipUpdate.Parser);
    private readonly pbc::RepeatedField<global::Authzed.Api.V1.RelationshipUpdate> updates_ = new pbc::RepeatedField<global::Authzed.Api.V1.RelationshipUpdate>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Authzed.Api.V1.RelationshipUpdate> Updates {
      get { return updates_; }
    }

    /// <summary>Field number for the "changes_through" field.</summary>
    public const int ChangesThroughFieldNumber = 2;
    private global::Authzed.Api.V1.ZedToken changesThrough_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Authzed.Api.V1.ZedToken ChangesThrough {
      get { return changesThrough_; }
      set {
        changesThrough_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WatchResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WatchResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!updates_.Equals(other.updates_)) return false;
      if (!object.Equals(ChangesThrough, other.ChangesThrough)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= updates_.GetHashCode();
      if (changesThrough_ != null) hash ^= ChangesThrough.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      updates_.WriteTo(output, _repeated_updates_codec);
      if (changesThrough_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ChangesThrough);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      updates_.WriteTo(ref output, _repeated_updates_codec);
      if (changesThrough_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ChangesThrough);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += updates_.CalculateSize(_repeated_updates_codec);
      if (changesThrough_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChangesThrough);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WatchResponse other) {
      if (other == null) {
        return;
      }
      updates_.Add(other.updates_);
      if (other.changesThrough_ != null) {
        if (changesThrough_ == null) {
          ChangesThrough = new global::Authzed.Api.V1.ZedToken();
        }
        ChangesThrough.MergeFrom(other.ChangesThrough);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            updates_.AddEntriesFrom(input, _repeated_updates_codec);
            break;
          }
          case 18: {
            if (changesThrough_ == null) {
              ChangesThrough = new global::Authzed.Api.V1.ZedToken();
            }
            input.ReadMessage(ChangesThrough);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            updates_.AddEntriesFrom(ref input, _repeated_updates_codec);
            break;
          }
          case 18: {
            if (changesThrough_ == null) {
              ChangesThrough = new global::Authzed.Api.V1.ZedToken();
            }
            input.ReadMessage(ChangesThrough);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
