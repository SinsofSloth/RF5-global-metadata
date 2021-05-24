[MonoTODOAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[ComVisibleAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[Serializable]
public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 991
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x263B3C0 Offset: 0x263B4C1 VA: 0x263B3C0
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x263B430 Offset: 0x263B531 VA: 0x263B430
	public void .ctor(byte[] data) { }

	// RVA: 0x263B480 Offset: 0x263B581 VA: 0x263B480
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x263B670 Offset: 0x263B771 VA: 0x263B670
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x263B870 Offset: 0x263B971 VA: 0x263B870
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x263B8B0 Offset: 0x263B9B1 VA: 0x263B8B0
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x263B9A0 Offset: 0x263BAA1 VA: 0x263B9A0
	internal bool get_IsValid() { }

	// RVA: 0x263B9E0 Offset: 0x263BAE1 VA: 0x263B9E0 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x263BB00 Offset: 0x263BC01 VA: 0x263BB00 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x263BCD0 Offset: 0x263BDD1 VA: 0x263BCD0 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x263BE10 Offset: 0x263BF11 VA: 0x263BE10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x263BE70 Offset: 0x263BF71 VA: 0x263BE70 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x263BF00 Offset: 0x263C001 VA: 0x263BF00 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x263BF90 Offset: 0x263C091 VA: 0x263BF90 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x263C000 Offset: 0x263C101 VA: 0x263C000 Slot: 3
	public override string ToString() { }

	// RVA: 0x263C010 Offset: 0x263C111 VA: 0x263C010 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x263C080 Offset: 0x263C181 VA: 0x263C080
	public void .ctor() { }

	// RVA: 0x263C090 Offset: 0x263C191 VA: 0x263C090
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C190 Offset: 0x263C291 VA: 0x263C190
	public string get_Issuer() { }

	// RVA: 0x263C260 Offset: 0x263C361 VA: 0x263C260
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0xB9290 Offset: 0xB9391 VA: 0xB9290
	// RVA: 0x263C330 Offset: 0x263C431 VA: 0x263C330 Slot: 0
	public override bool Equals(object obj) { }

	[MonoTODOAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	[ComVisibleAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	// RVA: 0x263C3E0 Offset: 0x263C4E1 VA: 0x263C3E0 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x263C580 Offset: 0x263C681 VA: 0x263C580 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x263C590 Offset: 0x263C691 VA: 0x263C590 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C660 Offset: 0x263C761 VA: 0x263C660 Slot: 6
	public void Dispose() { }

	// RVA: 0x263C680 Offset: 0x263C781 VA: 0x263C680 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0xB9300 Offset: 0xB9401 VA: 0xB9300
	// RVA: 0x263C6A0 Offset: 0x263C7A1 VA: 0x263C6A0 Slot: 16
	public virtual void Reset() { }
}

[MonoTODOAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[ComVisibleAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[Serializable]
public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 991
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x263B3C0 Offset: 0x263B4C1 VA: 0x263B3C0
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x263B430 Offset: 0x263B531 VA: 0x263B430
	public void .ctor(byte[] data) { }

	// RVA: 0x263B480 Offset: 0x263B581 VA: 0x263B480
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x263B670 Offset: 0x263B771 VA: 0x263B670
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x263B870 Offset: 0x263B971 VA: 0x263B870
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x263B8B0 Offset: 0x263B9B1 VA: 0x263B8B0
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x263B9A0 Offset: 0x263BAA1 VA: 0x263B9A0
	internal bool get_IsValid() { }

	// RVA: 0x263B9E0 Offset: 0x263BAE1 VA: 0x263B9E0 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x263BB00 Offset: 0x263BC01 VA: 0x263BB00 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x263BCD0 Offset: 0x263BDD1 VA: 0x263BCD0 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x263BE10 Offset: 0x263BF11 VA: 0x263BE10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x263BE70 Offset: 0x263BF71 VA: 0x263BE70 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x263BF00 Offset: 0x263C001 VA: 0x263BF00 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x263BF90 Offset: 0x263C091 VA: 0x263BF90 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x263C000 Offset: 0x263C101 VA: 0x263C000 Slot: 3
	public override string ToString() { }

	// RVA: 0x263C010 Offset: 0x263C111 VA: 0x263C010 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x263C080 Offset: 0x263C181 VA: 0x263C080
	public void .ctor() { }

	// RVA: 0x263C090 Offset: 0x263C191 VA: 0x263C090
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C190 Offset: 0x263C291 VA: 0x263C190
	public string get_Issuer() { }

	// RVA: 0x263C260 Offset: 0x263C361 VA: 0x263C260
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0xB9290 Offset: 0xB9391 VA: 0xB9290
	// RVA: 0x263C330 Offset: 0x263C431 VA: 0x263C330 Slot: 0
	public override bool Equals(object obj) { }

	[MonoTODOAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	[ComVisibleAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	// RVA: 0x263C3E0 Offset: 0x263C4E1 VA: 0x263C3E0 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x263C580 Offset: 0x263C681 VA: 0x263C580 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x263C590 Offset: 0x263C691 VA: 0x263C590 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C660 Offset: 0x263C761 VA: 0x263C660 Slot: 6
	public void Dispose() { }

	// RVA: 0x263C680 Offset: 0x263C781 VA: 0x263C680 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0xB9300 Offset: 0xB9401 VA: 0xB9300
	// RVA: 0x263C6A0 Offset: 0x263C7A1 VA: 0x263C6A0 Slot: 16
	public virtual void Reset() { }
}

[MonoTODOAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[ComVisibleAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[Serializable]
public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 991
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x263B3C0 Offset: 0x263B4C1 VA: 0x263B3C0
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x263B430 Offset: 0x263B531 VA: 0x263B430
	public void .ctor(byte[] data) { }

	// RVA: 0x263B480 Offset: 0x263B581 VA: 0x263B480
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x263B670 Offset: 0x263B771 VA: 0x263B670
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x263B870 Offset: 0x263B971 VA: 0x263B870
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x263B8B0 Offset: 0x263B9B1 VA: 0x263B8B0
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x263B9A0 Offset: 0x263BAA1 VA: 0x263B9A0
	internal bool get_IsValid() { }

	// RVA: 0x263B9E0 Offset: 0x263BAE1 VA: 0x263B9E0 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x263BB00 Offset: 0x263BC01 VA: 0x263BB00 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x263BCD0 Offset: 0x263BDD1 VA: 0x263BCD0 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x263BE10 Offset: 0x263BF11 VA: 0x263BE10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x263BE70 Offset: 0x263BF71 VA: 0x263BE70 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x263BF00 Offset: 0x263C001 VA: 0x263BF00 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x263BF90 Offset: 0x263C091 VA: 0x263BF90 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x263C000 Offset: 0x263C101 VA: 0x263C000 Slot: 3
	public override string ToString() { }

	// RVA: 0x263C010 Offset: 0x263C111 VA: 0x263C010 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x263C080 Offset: 0x263C181 VA: 0x263C080
	public void .ctor() { }

	// RVA: 0x263C090 Offset: 0x263C191 VA: 0x263C090
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C190 Offset: 0x263C291 VA: 0x263C190
	public string get_Issuer() { }

	// RVA: 0x263C260 Offset: 0x263C361 VA: 0x263C260
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0xB9290 Offset: 0xB9391 VA: 0xB9290
	// RVA: 0x263C330 Offset: 0x263C431 VA: 0x263C330 Slot: 0
	public override bool Equals(object obj) { }

	[MonoTODOAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	[ComVisibleAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	// RVA: 0x263C3E0 Offset: 0x263C4E1 VA: 0x263C3E0 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x263C580 Offset: 0x263C681 VA: 0x263C580 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x263C590 Offset: 0x263C691 VA: 0x263C590 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C660 Offset: 0x263C761 VA: 0x263C660 Slot: 6
	public void Dispose() { }

	// RVA: 0x263C680 Offset: 0x263C781 VA: 0x263C680 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0xB9300 Offset: 0xB9401 VA: 0xB9300
	// RVA: 0x263C6A0 Offset: 0x263C7A1 VA: 0x263C6A0 Slot: 16
	public virtual void Reset() { }
}

[MonoTODOAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[ComVisibleAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[Serializable]
public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 991
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x263B3C0 Offset: 0x263B4C1 VA: 0x263B3C0
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x263B430 Offset: 0x263B531 VA: 0x263B430
	public void .ctor(byte[] data) { }

	// RVA: 0x263B480 Offset: 0x263B581 VA: 0x263B480
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x263B670 Offset: 0x263B771 VA: 0x263B670
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x263B870 Offset: 0x263B971 VA: 0x263B870
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x263B8B0 Offset: 0x263B9B1 VA: 0x263B8B0
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x263B9A0 Offset: 0x263BAA1 VA: 0x263B9A0
	internal bool get_IsValid() { }

	// RVA: 0x263B9E0 Offset: 0x263BAE1 VA: 0x263B9E0 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x263BB00 Offset: 0x263BC01 VA: 0x263BB00 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x263BCD0 Offset: 0x263BDD1 VA: 0x263BCD0 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x263BE10 Offset: 0x263BF11 VA: 0x263BE10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x263BE70 Offset: 0x263BF71 VA: 0x263BE70 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x263BF00 Offset: 0x263C001 VA: 0x263BF00 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x263BF90 Offset: 0x263C091 VA: 0x263BF90 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x263C000 Offset: 0x263C101 VA: 0x263C000 Slot: 3
	public override string ToString() { }

	// RVA: 0x263C010 Offset: 0x263C111 VA: 0x263C010 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x263C080 Offset: 0x263C181 VA: 0x263C080
	public void .ctor() { }

	// RVA: 0x263C090 Offset: 0x263C191 VA: 0x263C090
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C190 Offset: 0x263C291 VA: 0x263C190
	public string get_Issuer() { }

	// RVA: 0x263C260 Offset: 0x263C361 VA: 0x263C260
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0xB9290 Offset: 0xB9391 VA: 0xB9290
	// RVA: 0x263C330 Offset: 0x263C431 VA: 0x263C330 Slot: 0
	public override bool Equals(object obj) { }

	[MonoTODOAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	[ComVisibleAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	// RVA: 0x263C3E0 Offset: 0x263C4E1 VA: 0x263C3E0 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x263C580 Offset: 0x263C681 VA: 0x263C580 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x263C590 Offset: 0x263C691 VA: 0x263C590 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C660 Offset: 0x263C761 VA: 0x263C660 Slot: 6
	public void Dispose() { }

	// RVA: 0x263C680 Offset: 0x263C781 VA: 0x263C680 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0xB9300 Offset: 0xB9401 VA: 0xB9300
	// RVA: 0x263C6A0 Offset: 0x263C7A1 VA: 0x263C6A0 Slot: 16
	public virtual void Reset() { }
}

[MonoTODOAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[ComVisibleAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[Serializable]
public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 991
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x263B3C0 Offset: 0x263B4C1 VA: 0x263B3C0
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x263B430 Offset: 0x263B531 VA: 0x263B430
	public void .ctor(byte[] data) { }

	// RVA: 0x263B480 Offset: 0x263B581 VA: 0x263B480
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x263B670 Offset: 0x263B771 VA: 0x263B670
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x263B870 Offset: 0x263B971 VA: 0x263B870
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x263B8B0 Offset: 0x263B9B1 VA: 0x263B8B0
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x263B9A0 Offset: 0x263BAA1 VA: 0x263B9A0
	internal bool get_IsValid() { }

	// RVA: 0x263B9E0 Offset: 0x263BAE1 VA: 0x263B9E0 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x263BB00 Offset: 0x263BC01 VA: 0x263BB00 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x263BCD0 Offset: 0x263BDD1 VA: 0x263BCD0 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x263BE10 Offset: 0x263BF11 VA: 0x263BE10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x263BE70 Offset: 0x263BF71 VA: 0x263BE70 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x263BF00 Offset: 0x263C001 VA: 0x263BF00 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x263BF90 Offset: 0x263C091 VA: 0x263BF90 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x263C000 Offset: 0x263C101 VA: 0x263C000 Slot: 3
	public override string ToString() { }

	// RVA: 0x263C010 Offset: 0x263C111 VA: 0x263C010 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x263C080 Offset: 0x263C181 VA: 0x263C080
	public void .ctor() { }

	// RVA: 0x263C090 Offset: 0x263C191 VA: 0x263C090
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C190 Offset: 0x263C291 VA: 0x263C190
	public string get_Issuer() { }

	// RVA: 0x263C260 Offset: 0x263C361 VA: 0x263C260
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0xB9290 Offset: 0xB9391 VA: 0xB9290
	// RVA: 0x263C330 Offset: 0x263C431 VA: 0x263C330 Slot: 0
	public override bool Equals(object obj) { }

	[MonoTODOAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	[ComVisibleAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	// RVA: 0x263C3E0 Offset: 0x263C4E1 VA: 0x263C3E0 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x263C580 Offset: 0x263C681 VA: 0x263C580 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x263C590 Offset: 0x263C691 VA: 0x263C590 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C660 Offset: 0x263C761 VA: 0x263C660 Slot: 6
	public void Dispose() { }

	// RVA: 0x263C680 Offset: 0x263C781 VA: 0x263C680 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0xB9300 Offset: 0xB9401 VA: 0xB9300
	// RVA: 0x263C6A0 Offset: 0x263C7A1 VA: 0x263C6A0 Slot: 16
	public virtual void Reset() { }
}

[MonoTODOAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[ComVisibleAttribute] // RVA: 0xB0460 Offset: 0xB0561 VA: 0xB0460
[Serializable]
public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 991
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x263B3C0 Offset: 0x263B4C1 VA: 0x263B3C0
	internal void .ctor(byte[] data, bool dates) { }

	// RVA: 0x263B430 Offset: 0x263B531 VA: 0x263B430
	public void .ctor(byte[] data) { }

	// RVA: 0x263B480 Offset: 0x263B581 VA: 0x263B480
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x263B670 Offset: 0x263B771 VA: 0x263B670
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x263B870 Offset: 0x263B971 VA: 0x263B870
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x263B8B0 Offset: 0x263B9B1 VA: 0x263B8B0
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x263B9A0 Offset: 0x263BAA1 VA: 0x263B9A0
	internal bool get_IsValid() { }

	// RVA: 0x263B9E0 Offset: 0x263BAE1 VA: 0x263B9E0 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x263BB00 Offset: 0x263BC01 VA: 0x263BB00 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x263BCD0 Offset: 0x263BDD1 VA: 0x263BCD0 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x263BE10 Offset: 0x263BF11 VA: 0x263BE10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x263BE70 Offset: 0x263BF71 VA: 0x263BE70 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x263BF00 Offset: 0x263C001 VA: 0x263BF00 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x263BF90 Offset: 0x263C091 VA: 0x263BF90 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x263C000 Offset: 0x263C101 VA: 0x263C000 Slot: 3
	public override string ToString() { }

	// RVA: 0x263C010 Offset: 0x263C111 VA: 0x263C010 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x263C080 Offset: 0x263C181 VA: 0x263C080
	public void .ctor() { }

	// RVA: 0x263C090 Offset: 0x263C191 VA: 0x263C090
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C190 Offset: 0x263C291 VA: 0x263C190
	public string get_Issuer() { }

	// RVA: 0x263C260 Offset: 0x263C361 VA: 0x263C260
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0xB9290 Offset: 0xB9391 VA: 0xB9290
	// RVA: 0x263C330 Offset: 0x263C431 VA: 0x263C330 Slot: 0
	public override bool Equals(object obj) { }

	[MonoTODOAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	[ComVisibleAttribute] // RVA: 0xB92B0 Offset: 0xB93B1 VA: 0xB92B0
	// RVA: 0x263C3E0 Offset: 0x263C4E1 VA: 0x263C3E0 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x263C580 Offset: 0x263C681 VA: 0x263C580 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x263C590 Offset: 0x263C691 VA: 0x263C590 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x263C660 Offset: 0x263C761 VA: 0x263C660 Slot: 6
	public void Dispose() { }

	// RVA: 0x263C680 Offset: 0x263C781 VA: 0x263C680 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0xB9300 Offset: 0xB9401 VA: 0xB9300
	// RVA: 0x263C6A0 Offset: 0x263C7A1 VA: 0x263C6A0 Slot: 16
	public virtual void Reset() { }
}

