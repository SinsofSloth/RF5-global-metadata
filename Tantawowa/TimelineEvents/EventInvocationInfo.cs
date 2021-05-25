public class EventInvocationInfo // TypeDefIndex: 10429
{
	// Fields
	public Behaviour TargetBehaviour; // 0x10
	public MethodInfo MethodInfo; // 0x18
	public static Type[] SupportedTypes; // 0x0
	public string Key; // 0x20

	// Methods

	// RVA: 0x1C75A40 Offset: 0x1C75B41 VA: 0x1C75A40
	public void .ctor(string key, Behaviour targetBehaviour, MethodInfo methodInfo) { }

	// RVA: 0x1C75AB0 Offset: 0x1C75BB1 VA: 0x1C75AB0
	public void Invoke(object value) { }

	// RVA: 0x1C75BA0 Offset: 0x1C75CA1 VA: 0x1C75BA0
	public void InvokEnum(int value) { }

	// RVA: 0x1C75D00 Offset: 0x1C75E01 VA: 0x1C75D00
	public void InvokeNoArgs() { }

	// RVA: 0x1C75D60 Offset: 0x1C75E61 VA: 0x1C75D60
	public void Invoke(bool isSingleArg, string value) { }

	// RVA: 0x1C76A00 Offset: 0x1C76B01 VA: 0x1C76A00
	private static void .cctor() { }
}

