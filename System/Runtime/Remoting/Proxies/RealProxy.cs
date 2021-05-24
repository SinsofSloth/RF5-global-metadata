[ComVisibleAttribute] // RVA: 0xB0C20 Offset: 0xB0D21 VA: 0xB0C20
public abstract class RealProxy // TypeDefIndex: 1134
{
	// Fields
	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	// Properties
	internal Identity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x15F0180 Offset: 0x15F0281 VA: 0x15F0180
	protected void .ctor() { }

	// RVA: 0x15F0190 Offset: 0x15F0291 VA: 0x15F0190
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x15F0310 Offset: 0x15F0411 VA: 0x15F0310
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x15F01F0 Offset: 0x15F02F1 VA: 0x15F01F0
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x15F0380 Offset: 0x15F0481 VA: 0x15F0380
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x15F0390 Offset: 0x15F0491 VA: 0x15F0390
	public Type GetProxiedType() { }

	// RVA: 0x15F0450 Offset: 0x15F0551 VA: 0x15F0450 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15F0610 Offset: 0x15F0711 VA: 0x15F0610
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x15F0620 Offset: 0x15F0721 VA: 0x15F0620
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg) { }

	// RVA: 0x15F0630 Offset: 0x15F0731 VA: 0x15F0630
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x15F1780 Offset: 0x15F1881 VA: 0x15F1780 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x15F1790 Offset: 0x15F1891 VA: 0x15F1790 Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x15F1930 Offset: 0x15F1A31 VA: 0x15F1930
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x15F1940 Offset: 0x15F1A41 VA: 0x15F1940
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x15F1950 Offset: 0x15F1A51 VA: 0x15F1950
	internal object GetAppDomainTarget() { }

	// RVA: 0x15F1080 Offset: 0x15F1181 VA: 0x15F1080
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }
}

