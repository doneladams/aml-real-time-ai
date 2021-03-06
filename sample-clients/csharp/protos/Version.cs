// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: version.proto
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aml.Fpga {

  /// <summary>Holder for reflection information generated from version.proto</summary>
  public static partial class VersionReflection {

    #region Descriptor
    /// <summary>File descriptor for version.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VersionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg12ZXJzaW9uLnByb3RvEghhbWwuZnBnYSIQCg5WZXJzaW9uUmVxdWVzdCJX",
            "Cg9WZXJzaW9uUmVzcG9uc2USDwoHb3NfbmFtZRgBIAEoCRISCgpmcGdhX21v",
            "ZGVsGAIgASgJEgsKA2FwaRgDIAEoCRISCgpvc192ZXJzaW9uGAQgASgJMlAK",
            "DlZlcnNpb25TZXJ2aWNlEj4KB1ZlcnNpb24SGC5hbWwuZnBnYS5WZXJzaW9u",
            "UmVxdWVzdBoZLmFtbC5mcGdhLlZlcnNpb25SZXNwb25zZUID+AEBYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aml.Fpga.VersionRequest), global::Aml.Fpga.VersionRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Aml.Fpga.VersionResponse), global::Aml.Fpga.VersionResponse.Parser, new[]{ "OsName", "FpgaModel", "Api", "OsVersion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VersionRequest : pb::IMessage<VersionRequest> {
    private static readonly pb::MessageParser<VersionRequest> _parser = new pb::MessageParser<VersionRequest>(() => new VersionRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VersionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aml.Fpga.VersionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionRequest(VersionRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionRequest Clone() {
      return new VersionRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VersionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VersionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VersionRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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

  public sealed partial class VersionResponse : pb::IMessage<VersionResponse> {
    private static readonly pb::MessageParser<VersionResponse> _parser = new pb::MessageParser<VersionResponse>(() => new VersionResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VersionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aml.Fpga.VersionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionResponse(VersionResponse other) : this() {
      osName_ = other.osName_;
      fpgaModel_ = other.fpgaModel_;
      api_ = other.api_;
      osVersion_ = other.osVersion_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionResponse Clone() {
      return new VersionResponse(this);
    }

    /// <summary>Field number for the "os_name" field.</summary>
    public const int OsNameFieldNumber = 1;
    private string osName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OsName {
      get { return osName_; }
      set {
        osName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fpga_model" field.</summary>
    public const int FpgaModelFieldNumber = 2;
    private string fpgaModel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FpgaModel {
      get { return fpgaModel_; }
      set {
        fpgaModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "api" field.</summary>
    public const int ApiFieldNumber = 3;
    private string api_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Api {
      get { return api_; }
      set {
        api_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "os_version" field.</summary>
    public const int OsVersionFieldNumber = 4;
    private string osVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OsVersion {
      get { return osVersion_; }
      set {
        osVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VersionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VersionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OsName != other.OsName) return false;
      if (FpgaModel != other.FpgaModel) return false;
      if (Api != other.Api) return false;
      if (OsVersion != other.OsVersion) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OsName.Length != 0) hash ^= OsName.GetHashCode();
      if (FpgaModel.Length != 0) hash ^= FpgaModel.GetHashCode();
      if (Api.Length != 0) hash ^= Api.GetHashCode();
      if (OsVersion.Length != 0) hash ^= OsVersion.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (OsName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OsName);
      }
      if (FpgaModel.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FpgaModel);
      }
      if (Api.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Api);
      }
      if (OsVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OsVersion);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OsName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OsName);
      }
      if (FpgaModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FpgaModel);
      }
      if (Api.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Api);
      }
      if (OsVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OsVersion);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VersionResponse other) {
      if (other == null) {
        return;
      }
      if (other.OsName.Length != 0) {
        OsName = other.OsName;
      }
      if (other.FpgaModel.Length != 0) {
        FpgaModel = other.FpgaModel;
      }
      if (other.Api.Length != 0) {
        Api = other.Api;
      }
      if (other.OsVersion.Length != 0) {
        OsVersion = other.OsVersion;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            OsName = input.ReadString();
            break;
          }
          case 18: {
            FpgaModel = input.ReadString();
            break;
          }
          case 26: {
            Api = input.ReadString();
            break;
          }
          case 34: {
            OsVersion = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
