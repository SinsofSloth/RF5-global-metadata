[ComVisibleAttribute] // RVA: 0xB07B0 Offset: 0xB08B1 VA: 0xB07B0
[Serializable]
public abstract class SerializationBinder // TypeDefIndex: 1026
{
	// Methods

	// RVA: 0x151DF90 Offset: 0x151E091 VA: 0x151DF90 Slot: 4
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0x151DFD0 Offset: 0x151E0D1 VA: 0x151DFD0
	protected void .ctor() { }
}

