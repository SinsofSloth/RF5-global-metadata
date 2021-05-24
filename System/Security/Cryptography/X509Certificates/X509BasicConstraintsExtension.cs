public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 1841
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1712F90 Offset: 0x1713091 VA: 0x1712F90
	public void .ctor() { }

	// RVA: 0x17100B0 Offset: 0x17101B1 VA: 0x17100B0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1713300 Offset: 0x1713401 VA: 0x1713300
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x17135B0 Offset: 0x17136B1 VA: 0x17135B0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1713640 Offset: 0x1713741 VA: 0x1713640
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x17136D0 Offset: 0x17137D1 VA: 0x17136D0
	public int get_PathLengthConstraint() { }

	// RVA: 0x1713760 Offset: 0x1713861 VA: 0x1713760 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1713060 Offset: 0x1713161 VA: 0x1713060
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1713440 Offset: 0x1713541 VA: 0x1713440
	internal byte[] Encode() { }

	// RVA: 0x1713930 Offset: 0x1713A31 VA: 0x1713930 Slot: 5
	internal override string ToString(bool multiLine) { }
}

public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 1841
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1712F90 Offset: 0x1713091 VA: 0x1712F90
	public void .ctor() { }

	// RVA: 0x17100B0 Offset: 0x17101B1 VA: 0x17100B0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1713300 Offset: 0x1713401 VA: 0x1713300
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x17135B0 Offset: 0x17136B1 VA: 0x17135B0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1713640 Offset: 0x1713741 VA: 0x1713640
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x17136D0 Offset: 0x17137D1 VA: 0x17136D0
	public int get_PathLengthConstraint() { }

	// RVA: 0x1713760 Offset: 0x1713861 VA: 0x1713760 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1713060 Offset: 0x1713161 VA: 0x1713060
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1713440 Offset: 0x1713541 VA: 0x1713440
	internal byte[] Encode() { }

	// RVA: 0x1713930 Offset: 0x1713A31 VA: 0x1713930 Slot: 5
	internal override string ToString(bool multiLine) { }
}

public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 1841
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1712F90 Offset: 0x1713091 VA: 0x1712F90
	public void .ctor() { }

	// RVA: 0x17100B0 Offset: 0x17101B1 VA: 0x17100B0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1713300 Offset: 0x1713401 VA: 0x1713300
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x17135B0 Offset: 0x17136B1 VA: 0x17135B0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1713640 Offset: 0x1713741 VA: 0x1713640
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x17136D0 Offset: 0x17137D1 VA: 0x17136D0
	public int get_PathLengthConstraint() { }

	// RVA: 0x1713760 Offset: 0x1713861 VA: 0x1713760 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1713060 Offset: 0x1713161 VA: 0x1713060
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1713440 Offset: 0x1713541 VA: 0x1713440
	internal byte[] Encode() { }

	// RVA: 0x1713930 Offset: 0x1713A31 VA: 0x1713930 Slot: 5
	internal override string ToString(bool multiLine) { }
}

public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 1841
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1712F90 Offset: 0x1713091 VA: 0x1712F90
	public void .ctor() { }

	// RVA: 0x17100B0 Offset: 0x17101B1 VA: 0x17100B0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1713300 Offset: 0x1713401 VA: 0x1713300
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x17135B0 Offset: 0x17136B1 VA: 0x17135B0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1713640 Offset: 0x1713741 VA: 0x1713640
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x17136D0 Offset: 0x17137D1 VA: 0x17136D0
	public int get_PathLengthConstraint() { }

	// RVA: 0x1713760 Offset: 0x1713861 VA: 0x1713760 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1713060 Offset: 0x1713161 VA: 0x1713060
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1713440 Offset: 0x1713541 VA: 0x1713440
	internal byte[] Encode() { }

	// RVA: 0x1713930 Offset: 0x1713A31 VA: 0x1713930 Slot: 5
	internal override string ToString(bool multiLine) { }
}

public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 1841
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1712F90 Offset: 0x1713091 VA: 0x1712F90
	public void .ctor() { }

	// RVA: 0x17100B0 Offset: 0x17101B1 VA: 0x17100B0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1713300 Offset: 0x1713401 VA: 0x1713300
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x17135B0 Offset: 0x17136B1 VA: 0x17135B0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1713640 Offset: 0x1713741 VA: 0x1713640
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x17136D0 Offset: 0x17137D1 VA: 0x17136D0
	public int get_PathLengthConstraint() { }

	// RVA: 0x1713760 Offset: 0x1713861 VA: 0x1713760 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1713060 Offset: 0x1713161 VA: 0x1713060
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1713440 Offset: 0x1713541 VA: 0x1713440
	internal byte[] Encode() { }

	// RVA: 0x1713930 Offset: 0x1713A31 VA: 0x1713930 Slot: 5
	internal override string ToString(bool multiLine) { }
}

public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 1841
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1712F90 Offset: 0x1713091 VA: 0x1712F90
	public void .ctor() { }

	// RVA: 0x17100B0 Offset: 0x17101B1 VA: 0x17100B0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1713300 Offset: 0x1713401 VA: 0x1713300
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x17135B0 Offset: 0x17136B1 VA: 0x17135B0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1713640 Offset: 0x1713741 VA: 0x1713640
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x17136D0 Offset: 0x17137D1 VA: 0x17136D0
	public int get_PathLengthConstraint() { }

	// RVA: 0x1713760 Offset: 0x1713861 VA: 0x1713760 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1713060 Offset: 0x1713161 VA: 0x1713060
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1713440 Offset: 0x1713541 VA: 0x1713440
	internal byte[] Encode() { }

	// RVA: 0x1713930 Offset: 0x1713A31 VA: 0x1713930 Slot: 5
	internal override string ToString(bool multiLine) { }
}

