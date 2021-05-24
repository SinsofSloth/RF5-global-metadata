internal class ActivationServices // TypeDefIndex: 1175
{
	// Fields
	private static IActivator _constructionActivator; // 0x0

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0x1805C10 Offset: 0x1805D11 VA: 0x1805C10
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0x1805CC0 Offset: 0x1805DC1 VA: 0x1805CC0
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0x1805F10 Offset: 0x1806011 VA: 0x1805F10
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0x1806120 Offset: 0x1806221 VA: 0x1806120
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x1806CE0 Offset: 0x1806DE1 VA: 0x1806CE0
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0x1807100 Offset: 0x1807201 VA: 0x1807100
	public static object CreateProxyForType(Type type) { }

	// RVA: 0x18070F0 Offset: 0x18071F1 VA: 0x18070F0
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0x18072A0 Offset: 0x18073A1 VA: 0x18072A0
	public static void EnableProxyActivation(Type type, bool enable) { }
}

