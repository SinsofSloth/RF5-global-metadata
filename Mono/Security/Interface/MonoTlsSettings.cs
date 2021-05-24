public sealed class MonoTlsSettings // TypeDefIndex: 1586
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBAD30 Offset: 0xBAE31 VA: 0xBAD30
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBAD40 Offset: 0xBAE41 VA: 0xBAD40
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBAD50 Offset: 0xBAE51 VA: 0xBAD50
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBAD60 Offset: 0xBAE61 VA: 0xBAD60
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xBAD70 Offset: 0xBAE71 VA: 0xBAD70
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xBAD80 Offset: 0xBAE81 VA: 0xBAD80
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xBAD90 Offset: 0xBAE91 VA: 0xBAD90
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xBADA0 Offset: 0xBAEA1 VA: 0xBADA0
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0xBADB0 Offset: 0xBAEB1 VA: 0xBADB0
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x58
	private bool cloned; // 0x60
	private bool checkCertName; // 0x61
	private bool checkCertRevocationStatus; // 0x62
	private Nullable<bool> useServicePointManagerCallback; // 0x63
	private bool skipSystemValidators; // 0x65
	private bool callbackNeedsChain; // 0x66
	private ICertificateValidator certificateValidator; // 0x68
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliantAttribute] // RVA: 0xBB120 Offset: 0xBB221 VA: 0xBB120
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[ObsoleteAttribute] // RVA: 0xBB140 Offset: 0xBB241 VA: 0xBB140
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBAE20 Offset: 0xBAF21 VA: 0xBAE20
	// RVA: 0x1A6D6A0 Offset: 0x1A6D7A1 VA: 0x1A6D6A0
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAE30 Offset: 0xBAF31 VA: 0xBAE30
	// RVA: 0x1A6D6B0 Offset: 0x1A6D7B1 VA: 0x1A6D6B0
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBAE40 Offset: 0xBAF41 VA: 0xBAE40
	// RVA: 0x1A6D6C0 Offset: 0x1A6D7C1 VA: 0x1A6D6C0
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAE50 Offset: 0xBAF51 VA: 0xBAE50
	// RVA: 0x1A6D6D0 Offset: 0x1A6D7D1 VA: 0x1A6D6D0
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x1A6D6E0 Offset: 0x1A6D7E1 VA: 0x1A6D6E0
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x1A6D6F0 Offset: 0x1A6D7F1 VA: 0x1A6D6F0
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x1A6D700 Offset: 0x1A6D801 VA: 0x1A6D700
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAE60 Offset: 0xBAF61 VA: 0xBAE60
	// RVA: 0x1A6D710 Offset: 0x1A6D811 VA: 0x1A6D710
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAE70 Offset: 0xBAF71 VA: 0xBAE70
	// RVA: 0x1A6D720 Offset: 0x1A6D821 VA: 0x1A6D720
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBAE80 Offset: 0xBAF81 VA: 0xBAE80
	// RVA: 0x1A6D730 Offset: 0x1A6D831 VA: 0x1A6D730
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAE90 Offset: 0xBAF91 VA: 0xBAE90
	// RVA: 0x1A6D740 Offset: 0x1A6D841 VA: 0x1A6D740
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBAEA0 Offset: 0xBAFA1 VA: 0xBAEA0
	// RVA: 0x1A6D750 Offset: 0x1A6D851 VA: 0x1A6D750
	public object get_UserSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAEB0 Offset: 0xBAFB1 VA: 0xBAEB0
	// RVA: 0x1A6D760 Offset: 0x1A6D861 VA: 0x1A6D760
	public void set_UserSettings(object value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBAEC0 Offset: 0xBAFC1 VA: 0xBAEC0
	// RVA: 0x1A6D770 Offset: 0x1A6D871 VA: 0x1A6D770
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAED0 Offset: 0xBAFD1 VA: 0xBAED0
	// RVA: 0x1A6D780 Offset: 0x1A6D881 VA: 0x1A6D780
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBAEE0 Offset: 0xBAFE1 VA: 0xBAEE0
	// RVA: 0x1A6D790 Offset: 0x1A6D891 VA: 0x1A6D790
	internal bool get_SendCloseNotify() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAEF0 Offset: 0xBAFF1 VA: 0xBAEF0
	// RVA: 0x1A6D7A0 Offset: 0x1A6D8A1 VA: 0x1A6D7A0
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBAF00 Offset: 0xBB001 VA: 0xBAF00
	// RVA: 0x1A6D7B0 Offset: 0x1A6D8B1 VA: 0x1A6D7B0
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAF10 Offset: 0xBB011 VA: 0xBAF10
	// RVA: 0x1A6D7C0 Offset: 0x1A6D8C1 VA: 0x1A6D7C0
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBAF20 Offset: 0xBB021 VA: 0xBAF20
	// RVA: 0x1A6D7D0 Offset: 0x1A6D8D1 VA: 0x1A6D7D0
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAF30 Offset: 0xBB031 VA: 0xBAF30
	// RVA: 0x1A6D7E0 Offset: 0x1A6D8E1 VA: 0x1A6D7E0
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x1A6D7F0 Offset: 0x1A6D8F1 VA: 0x1A6D7F0
	public void .ctor() { }

	// RVA: 0x1A6D810 Offset: 0x1A6D911 VA: 0x1A6D810
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x1A6D8C0 Offset: 0x1A6D9C1 VA: 0x1A6D8C0
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x1A6DA00 Offset: 0x1A6DB01 VA: 0x1A6DA00
	public ICertificateValidator get_CertificateValidator() { }

	[ObsoleteAttribute] // RVA: 0xBAF40 Offset: 0xBB041 VA: 0xBAF40
	// RVA: 0x1A6DA10 Offset: 0x1A6DB11 VA: 0x1A6DA10
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x1A6D9A0 Offset: 0x1A6DAA1 VA: 0x1A6D9A0
	public MonoTlsSettings Clone() { }

	// RVA: 0x1A6DAC0 Offset: 0x1A6DBC1 VA: 0x1A6DAC0
	private void .ctor(MonoTlsSettings other) { }
}

