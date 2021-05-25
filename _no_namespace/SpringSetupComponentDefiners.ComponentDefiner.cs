public class SpringSetupComponentDefiners.ComponentDefiner // TypeDefIndex: 9165
{
	// Fields
	protected Type componentType; // 0x10

	// Methods

	// RVA: 0x23A2FA0 Offset: 0x23A30A1 VA: 0x23A2FA0
	public void .ctor(Type newType) { }

	// RVA: 0x239C8B0 Offset: 0x239C9B1 VA: 0x239C8B0
	public bool TryToAppendDefinition(StringBuilder builder, GameObject rootObject) { }

	// RVA: 0x23A2FF0 Offset: 0x23A30F1 VA: 0x23A2FF0
	public void AppendDefinition(StringBuilder builder, Component component) { }

	// RVA: 0x239F540 Offset: 0x239F641 VA: 0x239F540
	public Component BuildFromDefinition(GameObject owner, Queue<string> definitionItems) { }

	// RVA: 0x23A3080 Offset: 0x23A3181 VA: 0x23A3080 Slot: 4
	protected virtual string GetTypeToken() { }

	// RVA: 0x23A30A0 Offset: 0x23A31A1 VA: 0x23A30A0 Slot: 5
	protected virtual void AppendProperties(StringBuilder builder, Component component) { }

	// RVA: -1 Offset: -1
	protected static void AppendRecordItem<T>(StringBuilder builder, T item, char separator = '\x2c') { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E24A0 Offset: 0x23E25A1 VA: 0x23E24A0
	|-SpringSetupComponentDefiners.ComponentDefiner.AppendRecordItem<object>
	|-SpringSetupComponentDefiners.ComponentDefiner.AppendRecordItem<string>
	*/

	// RVA: 0x23A3230 Offset: 0x23A3331 VA: 0x23A3230
	protected static string GetComponentName(Component component) { }

	// RVA: 0x23A32D0 Offset: 0x23A33D1 VA: 0x23A32D0 Slot: 6
	protected virtual Component InternalBuildFromDefinition(GameObject owner, Queue<string> definitionItems) { }
}

