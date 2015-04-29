// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/unittest_import_public_lite.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UnittestImportPublicLite {

    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    #endregion
    #region Extensions
    internal static readonly object Descriptor;
    static UnittestImportPublicLite() {
      Descriptor = null;
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PublicImportMessageLite : pb::GeneratedMessageLite<PublicImportMessageLite, PublicImportMessageLite.Builder> {
    private PublicImportMessageLite() { }
    private static readonly PublicImportMessageLite defaultInstance = new PublicImportMessageLite().MakeReadOnly();
    private static readonly string[] _publicImportMessageLiteFieldNames = new string[] { "e" };
    private static readonly uint[] _publicImportMessageLiteFieldTags = new uint[] { 8 };
    public static PublicImportMessageLite DefaultInstance {
      get { return defaultInstance; }
    }

    public override PublicImportMessageLite DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override PublicImportMessageLite ThisMessage {
      get { return this; }
    }

    public const int EFieldNumber = 1;
    private bool hasE;
    private int e_;
    public bool HasE {
      get { return hasE; }
    }
    public int E {
      get { return e_; }
    }

    public override bool IsInitialized {
      get {
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _publicImportMessageLiteFieldNames;
      if (hasE) {
        output.WriteInt32(1, field_names[0], E);
      }
    }

    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }

    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;

      size = 0;
      if (hasE) {
        size += pb::CodedOutputStream.ComputeInt32Size(1, E);
      }
      memoizedSerializedSize = size;
      return size;
    }
    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasE) hash ^= e_.GetHashCode();
      return hash;
    }

    public override bool Equals(object obj) {
      PublicImportMessageLite other = obj as PublicImportMessageLite;
      if (other == null) return false;
      if (hasE != other.hasE || (hasE && !e_.Equals(other.e_))) return false;
      return true;
    }

    public override void PrintTo(global::System.IO.TextWriter writer) {
      PrintField("e", hasE, e_, writer);
    }
    #endregion

    public static PublicImportMessageLite ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static PublicImportMessageLite ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static PublicImportMessageLite ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static PublicImportMessageLite ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static PublicImportMessageLite ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static PublicImportMessageLite ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static PublicImportMessageLite ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static PublicImportMessageLite ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static PublicImportMessageLite ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static PublicImportMessageLite ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private PublicImportMessageLite MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(PublicImportMessageLite prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilderLite<PublicImportMessageLite, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(PublicImportMessageLite cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private PublicImportMessageLite result;

      private PublicImportMessageLite PrepareBuilder() {
        if (resultIsReadOnly) {
          PublicImportMessageLite original = result;
          result = new PublicImportMessageLite();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override PublicImportMessageLite MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

      public override PublicImportMessageLite DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.TestProtos.PublicImportMessageLite.DefaultInstance; }
      }

      public override PublicImportMessageLite BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessageLite other) {
        if (other is PublicImportMessageLite) {
          return MergeFrom((PublicImportMessageLite) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(PublicImportMessageLite other) {
        if (other == global::Google.ProtocolBuffers.TestProtos.PublicImportMessageLite.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasE) {
          E = other.E;
        }
        return this;
      }

      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_publicImportMessageLiteFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _publicImportMessageLiteFieldTags[field_ordinal];
            else {
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                return this;
              }
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasE = input.ReadInt32(ref result.e_);
              break;
            }
          }
        }

        return this;
      }


      public bool HasE {
        get { return result.hasE; }
      }
      public int E {
        get { return result.E; }
        set { SetE(value); }
      }
      public Builder SetE(int value) {
        PrepareBuilder();
        result.hasE = true;
        result.e_ = value;
        return this;
      }
      public Builder ClearE() {
        PrepareBuilder();
        result.hasE = false;
        result.e_ = 0;
        return this;
      }
    }
    static PublicImportMessageLite() {
      object.ReferenceEquals(global::Google.ProtocolBuffers.TestProtos.UnittestImportPublicLite.Descriptor, null);
    }
  }

  #endregion

}

#endregion Designer generated code