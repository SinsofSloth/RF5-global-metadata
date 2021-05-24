[FlagsAttribute] // RVA: 0xBC050 Offset: 0xBC151 VA: 0xBC050
public enum X509ChainStatusFlags // TypeDefIndex: 1832
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags Revoked = 4;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotValidForUsage = 16;
	public const X509ChainStatusFlags UntrustedRoot = 32;
	public const X509ChainStatusFlags RevocationStatusUnknown = 64;
	public const X509ChainStatusFlags Cyclic = 128;
	public const X509ChainStatusFlags InvalidExtension = 256;
	public const X509ChainStatusFlags InvalidPolicyConstraints = 512;
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags InvalidNameConstraints = 2048;
	public const X509ChainStatusFlags HasNotSupportedNameConstraint = 4096;
	public const X509ChainStatusFlags HasNotDefinedNameConstraint = 8192;
	public const X509ChainStatusFlags HasNotPermittedNameConstraint = 16384;
	public const X509ChainStatusFlags HasExcludedNameConstraint = 32768;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags CtlNotTimeValid = 131072;
	public const X509ChainStatusFlags CtlNotSignatureValid = 262144;
	public const X509ChainStatusFlags CtlNotValidForUsage = 524288;
	public const X509ChainStatusFlags OfflineRevocation = 16777216;
	public const X509ChainStatusFlags NoIssuanceChainPolicy = 33554432;
	public const X509ChainStatusFlags ExplicitDistrust = 67108864;
	public const X509ChainStatusFlags HasNotSupportedCriticalExtension = 134217728;
	public const X509ChainStatusFlags HasWeakSignature = 1048576;
}

